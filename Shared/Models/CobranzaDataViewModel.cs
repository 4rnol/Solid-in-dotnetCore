using Epsa.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epsa.Shared.Models
{
    public class CobranzaDataViewModel
    {
        public decimal FcImporteTotal { get; set; }

        public string? FcArea { get; set; }

        public DateTime? FcFecl { get; set; }

        public byte? FcMes { get; set; }

        public short? FcAño { get; set; }

        public string? FcCli { get; set; }

        public DateTime? FcFecf { get; set; }

        public decimal? FcApcf { get; set; }

        public decimal? FcApcv { get; set; }

        public decimal? FcAlc { get; set; }

        public decimal? FcRc { get; set; }

        public string? FcEstf { get; set; }

        public int FcClid { get; set; }

        public string? LeCli { get; set; }

        public int? FcNum { get; set; }

        public decimal? LeMonto { get; set; }

        public bool Checked { get; set; } = false;
        

    }
}
