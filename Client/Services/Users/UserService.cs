using Epsa.Client.Pages;
using Epsa.Client.Pages.Users;
using Epsa.Client.Shared;
using Epsa.Client.Shared.Services;
using Epsa.Shared.Entities;
using Microsoft.AspNetCore.Components;

namespace Epsa.Client.Services.Users
{
    public class UserService : IUserService
    {
        private IHttpService _httpService;
        private ILocalStorageService _localStorageService;
        private NavigationManager _navigationManager;
        private string _userKey = "user";
        public SiUsuario SiUsuario { get; set; }

        public UserService(IHttpService httpService, ILocalStorageService LocalStorageService, NavigationManager navigationManager) 
        { 
            _httpService = httpService;
            _localStorageService = LocalStorageService;
            _navigationManager = navigationManager;
        }

        public async Task<List<SiUsuario>> GetUsers()
        {
            return await _httpService.Get<List<SiUsuario>>("api/User");
        }

        public async Task<SiUsuario> Login(Shared.Login model)
        {
            SiUsuario = await _httpService.Post<SiUsuario>("api/User/authenticate", model);
            await _localStorageService.SetItem(_userKey, SiUsuario);
            return SiUsuario;
        }
    }
}
