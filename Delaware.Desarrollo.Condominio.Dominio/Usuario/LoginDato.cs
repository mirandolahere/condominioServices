using System;
using System.Collections.Generic;
using System.Text;

namespace Delaware.Desarrollo.Condominio.Dominio.Usuario
{
    public class LoginDato
    {
        public int idPersona { get; set; }
		public string correo { get; set; }
		public string nombre { get; set; }
		public string apellidoPaterno { get; set; }
		public string apellidoMaterno { get; set; }
		public string telefono { get; set; }
		public int idRol { get; set; }
		public string nombreRol { get; set; }
		public int idOpcionRol{ get; set; }
		public string nombreOpcion { get; set; }
		public string nombreTipoOpcion { get; set; }
		

	}
}
