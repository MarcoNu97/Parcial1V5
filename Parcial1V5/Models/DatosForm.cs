using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Parcial1V5.Models
{
    public class DatosForm
    {
        public string? CondicionIVA { get; set; }

        public int Cuit { get; set; }
        public string? RazonSocial { get; set; }
        public string? Domicilio { get; set; }
        public string? Email { get; set; }

        public string? Condicionventa { get; set; }

    }
}
