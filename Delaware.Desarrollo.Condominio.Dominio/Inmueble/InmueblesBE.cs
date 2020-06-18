using System;
using System.Collections.Generic;
using System.Text;

namespace Delaware.Desarrollo.Condominio.Dominio.Inmueble
{
    public class InmueblesBE
    {
        public int idProyecto { get; set; }
        public int idInmueble { get; set; }
        public string codigoInmueble { get; set; }
        public int? idTipoInmueble { get; set; }
        public int? estado { get; set; }
    }
}
