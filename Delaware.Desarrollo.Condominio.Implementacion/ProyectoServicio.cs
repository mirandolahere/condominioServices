using Delaware.Desarrollo.Condominio.Contrato;
using Delaware.Desarrollo.Condominio.Dominio;
using Delaware.Desarrollo.Condominio.Dominio.Base;
using Delaware.Desarrollo.Condominio.Dominio.Proyecto;
using Delaware.Desarrollo.Condominio.Dominio.TipoDocumento;
using Delaware.Desarrollo.Condominio.Negocio;
using System;
using System.Collections.Generic;
using System.Text;

namespace Delaware.Desarrollo.Condominio.Implementacion
{
    public class ProyectoServicio : IProyectoServicio
    {
        private ProyectoNegocio _ProyectoNegocio = new ProyectoNegocio();

        public ResultadoBE<IEnumerable<ProyectosBE>> ListarProyectoPorEmpresa(UsuariosBE parametro)
        {
            return _ProyectoNegocio.ListarProyectoPorEmpresa(parametro);
        }

        public ResultadoBE<IEnumerable<ProyectoEmpresa>> ProyectoPorEmpresa(UsuariosBE parametro)
        {
            return _ProyectoNegocio.ProyectoPorEmpresa(parametro);
        }

        public ResultadoBE<IEnumerable<Documento>> ListarDocumentosProyecto(ProyectosBE parametro)
        {
            return _ProyectoNegocio.ListarDocumentosProyecto(parametro);
        }
    }
}
