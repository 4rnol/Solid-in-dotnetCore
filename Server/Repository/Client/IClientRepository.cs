using Epsa.Shared.Entities;
using Epsa.Shared.Models;

namespace Epsa.Server.Repository.Client
{
    public interface IClientRepository
    {
        List<FcCliente> Search(string keyword);
        List<CobranzaDataViewModel> GetPendingPayments(int _clientId);

    }
}
