using Epsa.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epsa.Shared.Models
{
    public class ClientsViewModel
    {
        public FcCliente? FcCliente { get; set; }
        public string? search { get; set; }
        public int? clId { get; set; }
        public List<FcCliente>? FcClienteList { get; set;}
    }
}
