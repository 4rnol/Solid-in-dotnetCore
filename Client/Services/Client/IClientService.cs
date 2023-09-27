using Epsa.Shared.Entities;
using Epsa.Shared.Models;

namespace Epsa.Client.Services.Client
{
    public interface IClientService
    {
        Task<List<FcCliente>> Search(string keyword);
        Task<List<CobranzaDataViewModel>> PendingPayments(int _clientId);
    }
}
