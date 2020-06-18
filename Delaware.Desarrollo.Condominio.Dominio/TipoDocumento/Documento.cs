using Delaware.Desarrollo.Condominio.Dominio.Proyecto;
using System;
using System.Collections.Generic;
using System.Text;

namespace Delaware.Desarrollo.Condominio.Dominio.TipoDocumento
{
    public class Documento
    {
        public Documento()
        {
            this.ListaDocumento = new List<ListarDocumentos>();
        }
        public int idTipoDocumento { get; set; }
        public string tipoDocumento { get; set; }

        public List<ListarDocumentos> ListaDocumento { get; set; }

    }
}
