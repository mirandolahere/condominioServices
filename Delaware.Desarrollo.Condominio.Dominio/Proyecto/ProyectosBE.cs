using System;
using System.Collections.Generic;
using System.Text;

namespace Delaware.Desarrollo.Condominio.Dominio.Proyecto
{
    public class ProyectosBE
    {
        public int idProyecto { get; set; }
        public string nombreProyecto { get; set; }
        public string direccion { get; set; }
        public int? idDistrito { get; set; }
        public int? estado { get; set; }
        public int? idEmpresa { get; set; }

        public string razonSocial { get; set; }


        // entidades adquiridas por SP

        public string nombreDistrito { get; set; }


        public byte[] archivoLogo { get; set; }

        public byte[] archivoPerfil { get; set; }

}
}
