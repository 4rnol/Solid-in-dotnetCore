using Epsa.Server.Repository.Client;
using Epsa.Shared.Entities;
using Epsa.Shared.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Epsa.Server.Controllers
{

    [Authorize]
    [ApiController]
    [Route("api/[controller]")]
    public class ClientController : Controller
    {
        private readonly IClientRepository _clientRepository;

        public ClientController(IClientRepository clientRepository)
        {
            _clientRepository = clientRepository;
        }

        [HttpPost("Search")]
        public ActionResult Search(ClientsViewModel client) 
        { 
            return Ok(_clientRepository.Search(client.search));
        }

        [HttpPost("GetPendingPayments")]
        public ActionResult GetPendingPayments(ClientsViewModel client)
        {
            int idNoNull = (int)client.clId;
            return Ok(_clientRepository.GetPendingPayments(idNoNull));
        }

        [HttpPost]
        public ActionResult MakeBilling(FcPaymentsViewModel fcPayment)
        { 
            return Ok();

        }
    }
}
