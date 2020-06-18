using System;
using System.Collections.Generic;
using System.Text;

namespace Delaware.Desarrollo.Condominio.Dominio.Empresa
{
    public class EmpresasBE
    {
        public int idEmpresa { get; set; }
        public string razonSocial { get; set; }
        public string ruc { get; set; }
        public string direccion { get; set; }
        public int? estado { get; set; }
        public byte[] logoArchivo { get; set; }
        public int? idTipoArchivo { get; set; }
        public string colorHexadecimal { get; set; }
        public string extension { get; set; }

       

    }
}
