using System;
using System.Collections.Generic;
using System.Text;

namespace Delaware.Desarrollo.Condominio.Dominio.Ventas
{
    public class PlanoPorId
    {
        public int idCatalogo { get; set; }
		public int idInmueble { get; set; }
		public float areaTechada { get; set; }
		public float areaLibreVendible { get; set; }
		public string nombre { get; set; }
		public float precioEstacionamiento { get; set; }
		public float precioDeposito { get; set; }
		public float precioTotal { get; set; }
		public string nombreGuardado { get; set; }
		public string nombreOriginal { get; set; }
		public string ruta { get; set; }
		public string image { get; set; }

	}
}
