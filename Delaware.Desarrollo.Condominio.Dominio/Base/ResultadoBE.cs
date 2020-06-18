using System;
using System.Collections.Generic;
using System.Text;

namespace Delaware.Desarrollo.Condominio.Dominio.Base
{
    public class ResultadoBE<T>
    {
        public T Data { get; set; }
        public string Mensaje { get; set; }
        public int IdError { get; set; }

        

    }
}
