using Epsa.Server.Authorization;
using Epsa.Server.Context;
using Epsa.Server.Helpers;
using Epsa.Shared.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


namespace Epsa.Server.Repository.User
{
    public class UserRepository:IUserRepository
    {
        private readonly EpsaDbContext _context;
        private IJwtUtils _jwtUtils;
        public UserRepository(EpsaDbContext context, IJwtUtils jwtUtils) 
        {
            _context=context;
            _jwtUtils = jwtUtils;
        }

        public AuthenticateResponse Authenticate(AuthenticateRequest request)
        {
            var _user = _context.SiUsuarios.SingleOrDefault(u => u.UsLogin == request.Username);

            // validate
            if (_user == null || _user.UsPassword != request.Password)
                throw new AppException("Username or password is incorrect");

            // authentication successful
            AuthenticateResponse response = new AuthenticateResponse();
            response.UsId = _user.UsId;            
            response.UsNombre = _user.UsNombre;
            response.UsDepto = _user.UsDepto;
            response.SiToken = _jwtUtils.GenerateToken(_user);
            return response;
        }
        public async Task<SiUsuario> AddUser(SiUsuario usr)
        { 
            var res=await _context.SiUsuarios.AddAsync(usr);
            await _context.SaveChangesAsync();
            return res.Entity;
        }

        public async Task<List<SiUsuario>> GetUsers()
        {            
            List<SiUsuario> Users = await _context.SiUsuarios.ToListAsync();            
            return Users;
        }
    }
}
