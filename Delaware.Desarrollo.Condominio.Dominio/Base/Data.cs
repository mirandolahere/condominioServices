using Delaware.Desarrollo.Condominio.Dominio.Ventas;
using System;
using System.Collections.Generic;
using System.Text;

namespace Delaware.Desarrollo.Condominio.Dominio.Ventas

{
    public class Data
    {
        public Data()
        {
            this.ListaDeLugares = new List<ListaLugares>();
            this.Presentacion = new List<Presentacion>();

        }
        public List<ListaLugares> ListaDeLugares { get; set; }

        public List<Presentacion> Presentacion { get; set; }


    }
}
