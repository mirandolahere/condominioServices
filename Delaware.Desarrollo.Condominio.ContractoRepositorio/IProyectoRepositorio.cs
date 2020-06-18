using Delaware.Desarrollo.Condominio.Dominio;
using Delaware.Desarrollo.Condominio.Dominio.Proyecto;
using System;
using System.Collections.Generic;
using System.Text;

namespace Delaware.Desarrollo.Condominio.ContractoRepositorio
{
     public interface IProyectoRepositorio
    {
        IEnumerable<ProyectosBE> ListarProyectoPorEmpresa(UsuariosBE parametro);

      //  IEnumerable<ListarDocumentos> ListarDocumentosProyecto(ProyectosBE parametro);

        IEnumerable<ListarDocumentos> DocumentoProyecto(ProyectosBE parametro);

    }
}
