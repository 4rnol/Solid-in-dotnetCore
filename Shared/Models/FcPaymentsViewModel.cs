using Epsa.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epsa.Shared.Models
{
    public class FcPaymentsViewModel
    {
        public FcAlta? FcAlta { get; set; }        
        public List<FcAlta>? FcAltaList { get; set; }
    }
}
