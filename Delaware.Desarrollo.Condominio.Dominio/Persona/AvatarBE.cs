using System;
using System.Collections.Generic;
using System.Text;

namespace Delaware.Desarrollo.Condominio.Dominio.Persona
{
	public class AvatarBE
	{
		public string nombre { get; set; }
		public string apellidoPaterno { get; set; }
		public string apellidoMaterno { get; set; }
		public string correo { get; set; }
		public string telefono { get; set; }
		public string redSocial { get; set; }
		public byte[] archivo { get; set; }
		public string extensionArchivo { get; set; }


	}
}
