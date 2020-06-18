using Delaware.Desarrollo.Condominio.Contrato;
using Delaware.Desarrollo.Condominio.Dominio;
using Delaware.Desarrollo.Condominio.Dominio.Base;
using Delaware.Desarrollo.Condominio.Dominio.Inmueble;
using Delaware.Desarrollo.Condominio.Dominio.TipoDocumento;
using Delaware.Desarrollo.Condominio.Negocio;
using System;
using System.Collections.Generic;
using System.Text;

namespace Delaware.Desarrollo.Condominio.Implementacion
{
    public class InmuebleServicio : IInmuebleServicio
    {
        private InmuebleNegocio _objInmuebleNegocio = new InmuebleNegocio();

        public ResultadoBE<IEnumerable<InmueblesBE>> ListarPorProyecto(InmueblesFiltroBE parametro)
        {
            return _objInmuebleNegocio.ListarPorProyecto(parametro);
        }

        public ResultadoBE<IEnumerable<InmuebleInformacionLayout>> InmuebleLayout(InmueblesBE parametro)
        {
            return _objInmuebleNegocio.InmuebleLayout(parametro);
        }

        public ResultadoBE<IEnumerable<Documento>> ListarDocumentosInmuebles(InmueblesBE parametro)
        {
            return _objInmuebleNegocio.ListarDocumentosInmuebles(parametro);
        }
    }
}
