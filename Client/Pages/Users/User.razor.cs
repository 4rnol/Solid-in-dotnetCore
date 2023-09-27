
namespace Epsa.Client.Pages.Users
{
    using Epsa.Client.Services.Users;
    using Epsa.Shared.Entities;
    using Epsa.Shared.Models;
    using Microsoft.AspNetCore.Components;
    using System.Net.Http.Json;

    public partial class User
    {
        [Inject]
        public UserViewModel viewModel { get; set; } = new UserViewModel();

        [Inject]
        public HttpClient client { get; set; } = new HttpClient();

        [Inject]
        protected IUserService _userService { get; set; }

        

        protected override async Task OnInitializedAsync()
        {
            viewModel.SiUsuario = new SiUsuario();
            var Data = await _userService.GetUsers();
            if (Data != null)
            {
                viewModel.SiUsuarios = Data;
            }

        }
    }
}
