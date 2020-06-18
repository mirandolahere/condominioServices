using System;
using System.Collections.Generic;
using System.Text;

namespace Delaware.Desarrollo.Condominio.Dominio.TipoDocumento
{
    public class ListaDocumento
    {
        public string nombre { get; set; }
        public byte[] archivo { get; set; }
        public int idArchivoBinario { get; set; }

    }
} 