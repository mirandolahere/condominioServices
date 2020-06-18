using System;
using System.Collections.Generic;
using System.Text;

namespace Delaware.Desarrollo.Condominio.Dominio.Proyecto
{
    public class ListarDocumentos
    {
        public  int idTipoDocumento { get; set; }

        public string tipoDocumento { get; set; }

        public string nombre        { get; set; }

        public byte[] archivo       { get; set; }

        public int idArchivoBinario { get; set; }

    }
}
