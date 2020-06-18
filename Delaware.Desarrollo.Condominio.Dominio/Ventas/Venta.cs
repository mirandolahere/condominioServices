using System;
using System.Collections.Generic;
using System.Text;

namespace Delaware.Desarrollo.Condominio.Dominio.Ventas
{
    public class Venta
    {
        public int idCatalogo { get; set; }

        public string estadoObra { get; set; }

        public int idEmpresa { get; set; }

        public string razonSocial { get; set; }

        public string colorHexadecimal { get; set; }

        public byte[] logoEmpresa { get; set; }

        public int idProyecto { get; set; }

        public string nombreProyecto { get; set; }

        public string direccion { get; set; }

        public string nombreDistrito { get; set; }

        public string nombrePerfil { get; set; }

        public byte[] perfilProyecto { get; set; }

        public string nombreLogo { get; set; }

        public byte[] logoProyecto { get; set; }

    }
}
