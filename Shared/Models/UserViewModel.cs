using Epsa.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epsa.Shared.Models
{
    public class UserViewModel
    {
        public SiUsuario SiUsuario { get; set; }
        public List<SiUsuario> SiUsuarios { get; set; }
    }
}
