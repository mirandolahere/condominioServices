using Delaware.Desarrollo.Condominio.Dominio;
using Delaware.Desarrollo.Condominio.Dominio.Base;
using Delaware.Desarrollo.Condominio.Dominio.Inmueble;
using Delaware.Desarrollo.Condominio.Dominio.Proyecto;
using System;
using System.Collections.Generic;
using System.Text;

namespace Delaware.Desarrollo.Condominio.ContractoRepositorio
{
    public interface IInmuebleRepositorio
    {
        IEnumerable<InmueblesBE> ListarPorProyecto(InmueblesFiltroBE parametro);

        IEnumerable<InmuebleInformacionLayout> InmuebleLayout(InmueblesBE parametro);

        IEnumerable<ListarDocumentos> ListarDocumentosInmueble(InmueblesBE parametro);

    }
}
