using System;
using System.Collections.Generic;
using System.Text;

namespace Delaware.Desarrollo.Condominio.Dominio.Ventas
{
    public class ListaLugares
    {
        public ListaLugares()
        {
            this.ListaDeLugares = new List<Lugares>();
        }
        public int idCatalogo { get; set; }
        public string coordX { get; set; }
        public string coordY { get; set; }
        public string introduccion { get; set; }
        public int idTipoLugar { get; set; }
        public string nombreTipo { get; set; } 
        public List<Lugares> ListaDeLugares { get; set; }


    }
}
