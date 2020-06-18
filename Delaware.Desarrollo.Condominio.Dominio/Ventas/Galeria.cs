using System;
using System.Collections.Generic;
using System.Text;

namespace Delaware.Desarrollo.Condominio.Dominio.Ventas
{
    public class Galeria
    {
		public int idCatalogo { get; set; }
		public int idArchivo { get; set; }
		public int orden { get; set; }
		public string titulo { get; set; }
		public int idTipoGaleria { get; set; }
		public string nombreOriginal { get; set; }
		public string nombreGuardado { get; set; }
		public string ruta { get; set; }
		public int idArchivoTipo { get; set; }
		public string codigo { get; set; }
		public string tipoMime { get; set; }
		public string image { get; set; }
	}
}
