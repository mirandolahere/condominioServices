using System;
using System.Collections.Generic;
using System.Text;

namespace Delaware.Desarrollo.Condominio.Dominio.Proyecto
{
    public class ProyectoEmpresa
    {
        public ProyectoEmpresa()
        {
            this.listaProyecto = new List<ProyectosBE>();
        }
        public string nombre { get; set; }

        public byte[] logoEmpresa { get; set; }

        public List<ProyectosBE> listaProyecto { get; set; }


    }
}
