using Epsa.Client.Shared.Services;
using Epsa.Shared.Entities;
using Microsoft.AspNetCore.Components.Authorization;
using System.Security.Claims;

namespace Epsa.Client
{
    public class CustomAuthenticationStateProvider : AuthenticationStateProvider
    {
        private readonly ILocalStorageService _localStorageService;
        public CustomAuthenticationStateProvider(ILocalStorageService storageService)
        {
            _localStorageService = storageService;
        }
        public override async Task<AuthenticationState> GetAuthenticationStateAsync()
        {
            var usr = await _localStorageService.GetItem<SiUsuario>("user");
            if (usr != null)                
            {
                var claims = new[]
                {
                    new Claim("UsId", usr.UsId.ToString())
                };
                var identity = new ClaimsIdentity(claims, "BearerToken");
                var user = new ClaimsPrincipal(identity);
                var state = new AuthenticationState(user);

                NotifyAuthenticationStateChanged(Task.FromResult(state));

                return state;
            }
            return new AuthenticationState(new ClaimsPrincipal());
        }
    }
}
