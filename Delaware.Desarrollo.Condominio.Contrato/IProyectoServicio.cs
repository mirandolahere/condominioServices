using Delaware.Desarrollo.Condominio.Dominio;
using Delaware.Desarrollo.Condominio.Dominio.Base;
using Delaware.Desarrollo.Condominio.Dominio.Proyecto;
using Delaware.Desarrollo.Condominio.Dominio.TipoDocumento;
using System;
using System.Collections.Generic;
using System.Text;

namespace Delaware.Desarrollo.Condominio.Contrato
{
    public interface IProyectoServicio
    {
        ResultadoBE<IEnumerable<ProyectosBE>> ListarProyectoPorEmpresa(UsuariosBE parametro);

        ResultadoBE<IEnumerable<ProyectoEmpresa>> ProyectoPorEmpresa(UsuariosBE parametro);
        ResultadoBE<IEnumerable<Documento>> ListarDocumentosProyecto(ProyectosBE parametro);


    }
}
