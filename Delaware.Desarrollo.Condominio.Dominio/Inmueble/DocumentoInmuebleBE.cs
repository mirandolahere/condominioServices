using System;
using System.Collections.Generic;
using System.Text;

namespace Delaware.Desarrollo.Condominio.Dominio.Inmueble
{
    public class DocumentoInmuebleBE
    {
        public int idTipoDocumento { get; set; }

        public string tipoDocumento { get; set; }

        public string nombre { get; set; }

        public int idArchivoBinario { get; set; }

        public byte[] archivo { get; set; }
    }
}
