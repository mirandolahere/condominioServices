using Delaware.Desarrollo.Condominio.ContractoRepositorio;
using Delaware.Desarrollo.Condominio.Dominio;
using Delaware.Desarrollo.Condominio.Dominio.Base;
using Delaware.Desarrollo.Condominio.Dominio.Inmueble;
using Delaware.Desarrollo.Condominio.Dominio.Proyecto;
using Delaware.Desarrollo.Condominio.Dominio.TipoDocumento;
using Delaware.Desarrollo.Condominio.SqlRepositorio;
using System;
using System.Collections.Generic;
using System.Text;

namespace Delaware.Desarrollo.Condominio.Negocio
{
    public class InmuebleNegocio
    {
        private IInmuebleRepositorio _IInmuebleRepositorio = new InmuebleRepositorio();
        ITipoDocumentoRepositorio _ITipoDocumentoRepositorio = new TipoDocumentoRepositorio();

        public ResultadoBE<IEnumerable<InmueblesBE>> ListarPorProyecto(InmueblesFiltroBE parametro)
        {
            ResultadoBE<IEnumerable<InmueblesBE>> resultado = new ResultadoBE<IEnumerable<InmueblesBE>>();
            resultado.Data = _IInmuebleRepositorio.ListarPorProyecto(parametro);
            return resultado;
        }

        public ResultadoBE<IEnumerable<InmuebleInformacionLayout>> InmuebleLayout(InmueblesBE parametro)
        {
            ResultadoBE<IEnumerable<InmuebleInformacionLayout>> resultado = new ResultadoBE<IEnumerable<InmuebleInformacionLayout>>();
            resultado.Data = _IInmuebleRepositorio.InmuebleLayout(parametro);
            return resultado;
        }

        public ResultadoBE<IEnumerable<ListarDocumentos>> ListarDocumentosInmueble(InmueblesBE parametro)
        {
            ResultadoBE<IEnumerable<ListarDocumentos>> resultado = new ResultadoBE<IEnumerable<ListarDocumentos>>();
            resultado.Data = _IInmuebleRepositorio.ListarDocumentosInmueble(parametro);
            return resultado;
        }

        public ResultadoBE<IEnumerable<Documento>> ListarDocumentosInmuebles(InmueblesBE parametro)
        {
            ResultadoBE<IEnumerable<Documento>> resultado = new ResultadoBE<IEnumerable<Documento>>();
            List<Documento> resultadoDocumento = new List<Documento>();

            //resultado.Data IEnumerable<ListarDocumentos> = _IProyectoRepositorio.ListarDocumentosProyecto(parametro);
            IEnumerable<ListarDocumentos> resultados = _IInmuebleRepositorio.ListarDocumentosInmueble(parametro);
            IEnumerable<TipoDocumentoBE> tipoDocumento = _ITipoDocumentoRepositorio.ListarTipoDocumento();

            foreach (var tipo in tipoDocumento)
            {
                Documento entidadDocumento = new Documento();
                entidadDocumento.idTipoDocumento = tipo.idTipoDocumento;
                entidadDocumento.tipoDocumento = tipo.nombre;
                foreach (var i in resultados)
                {
                    if (tipo.idTipoDocumento == i.idTipoDocumento)
                    {

                        entidadDocumento.ListaDocumento.Add(i);
                    }

                }
                resultadoDocumento.Add(entidadDocumento);
            }
            resultado.Data = resultadoDocumento;
            return resultado;

        }
    }
}
