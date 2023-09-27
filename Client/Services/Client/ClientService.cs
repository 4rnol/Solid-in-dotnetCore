using Epsa.Client.Shared.Services;
using Epsa.Shared.Entities;
using Epsa.Shared.Models;
using Microsoft.AspNetCore.Components;

namespace Epsa.Client.Services.Client
{
    public class ClientService:IClientService
    {
        private IHttpService _httpService;
        private ILocalStorageService _localStorageService;
        private NavigationManager _navigationManager;        

        public ClientService(IHttpService httpService, ILocalStorageService localStorageService, NavigationManager navigationManager)
        {
            _httpService = httpService;
            _localStorageService = localStorageService;
            _navigationManager = navigationManager;            
        }

        public async Task<List<FcCliente>> Search(string keyword)
        { 
            ClientsViewModel client = new ClientsViewModel();
            client.search = keyword;
            return await _httpService.Post<List<FcCliente>>("api/Client/Search", client);
        }

        public async Task<List<CobranzaDataViewModel>> PendingPayments(int _clientId)
        {
            ClientsViewModel client = new ClientsViewModel();
            client.clId = _clientId;
            return await _httpService.Post<List<CobranzaDataViewModel>>("api/Client/GetPendingPayments" , client);
        }
    }
}
