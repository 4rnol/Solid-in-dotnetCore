using Epsa.Client.Pages;
using Epsa.Client.Shared;
using Epsa.Shared.Entities;

namespace Epsa.Client.Services.Users
{
    public interface IUserService
    {
        SiUsuario SiUsuario { get; }
        Task<List<SiUsuario>> GetUsers();
        Task<SiUsuario> Login(Login model);
    }
}
