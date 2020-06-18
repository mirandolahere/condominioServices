using System;
using System.Collections.Generic;
using System.Text;

namespace Delaware.Desarrollo.Condominio.Dominio.Inmueble
{
    public class InmuebleInformacionLayout
    {
        public byte[]  logoArchivo { get; set; }
		
		public string colorHexadecimal { get; set; }

		public byte[] archivo { get; set; }

		public int idProyecto { get; set; }

		public int idInmueble { get; set; }
		
    }
}
