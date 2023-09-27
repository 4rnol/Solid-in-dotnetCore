using Epsa.Server.Authorization;
using Epsa.Shared.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Epsa.Server.Repository.User
{
    public interface IUserRepository
    {
        AuthenticateResponse Authenticate(AuthenticateRequest request);
        Task<SiUsuario> AddUser(SiUsuario usr);
        Task<List<SiUsuario>> GetUsers();
    }
}
