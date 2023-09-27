using Epsa.Client.Services.Users;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;

namespace Epsa.Client.Pages.Users
{
    public partial class Login
    {
        [Inject]
        public IUserService UserService { get; set; }

        [Inject]
        public NavigationManager NavigationManager { get; set; }
        [Inject]
        public AuthenticationStateProvider authenticationStateProvider { get; set; }

        private Epsa.Client.Shared.Login loginModel = new Epsa.Client.Shared.Login();
        private bool loading;
        public async void OnValidSubmit()
        {
            loading = true;
            try {
                var user=await UserService.Login(loginModel);
                if (user != null)
                {
                    loading = false;
                    await authenticationStateProvider.GetAuthenticationStateAsync();
                    NavigationManager.NavigateTo("/cobranzas");
                }
                else {
                    NavigationManager.NavigateTo("/login");
                }

            }
            catch (Exception ex) 
            { 
                Console.WriteLine(ex.ToString());
                loading=false;
                StateHasChanged();
            }
        
        }


    }
}
