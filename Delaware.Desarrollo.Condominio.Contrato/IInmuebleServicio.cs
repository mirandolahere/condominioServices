using Delaware.Desarrollo.Condominio.Dominio;
using Delaware.Desarrollo.Condominio.Dominio.Base;
using Delaware.Desarrollo.Condominio.Dominio.Inmueble;
using Delaware.Desarrollo.Condominio.Dominio.TipoDocumento;
using System;
using System.Collections.Generic;
using System.Text;

namespace Delaware.Desarrollo.Condominio.Contrato
{
  public  interface IInmuebleServicio
    {
        ResultadoBE<IEnumerable<InmueblesBE>> ListarPorProyecto(InmueblesFiltroBE parametro);

        ResultadoBE<IEnumerable<InmuebleInformacionLayout>> InmuebleLayout(InmueblesBE parametro);

        ResultadoBE<IEnumerable<Documento>> ListarDocumentosInmuebles(InmueblesBE parametro);
    }
}
