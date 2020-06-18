using Delaware.Desarrollo.Condominio.ContractoRepositorio;
using Delaware.Desarrollo.Condominio.Dominio;
using Delaware.Desarrollo.Condominio.Dominio.Base;
using Delaware.Desarrollo.Condominio.Dominio.Empresa;
using Delaware.Desarrollo.Condominio.Dominio.Proyecto;
using Delaware.Desarrollo.Condominio.SqlRepositorio;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Delaware.Desarrollo.Condominio.Dominio.TipoDocumento;

namespace Delaware.Desarrollo.Condominio.Negocio
{
    public class ProyectoNegocio
    {
        IProyectoRepositorio _IProyectoRepositorio = new ProyectoRepositorio();
        IEmpresaRepositorio _IEmpresaRepositorio = new EmpresaRepositorio();
        ITipoDocumentoRepositorio _ITipoDocumentoRepositorio = new TipoDocumentoRepositorio();


        public ResultadoBE<IEnumerable<ProyectosBE>> ListarProyectoPorEmpresa(UsuariosBE parametro)
        {
            ResultadoBE<IEnumerable<ProyectosBE>> resultado = new ResultadoBE<IEnumerable<ProyectosBE>>();
            resultado.Data = _IProyectoRepositorio.ListarProyectoPorEmpresa(parametro);
            return resultado;
        }

        public ResultadoBE<IEnumerable<ProyectoEmpresa>> ProyectoPorEmpresa(UsuariosBE parametro)
        {
            ResultadoBE<IEnumerable<ProyectoEmpresa>> resultado = new ResultadoBE<IEnumerable<ProyectoEmpresa>>();

            List<ProyectoEmpresa> resultadoProyectoEmpresa = new List<ProyectoEmpresa>();
            IEnumerable<ProyectosBE> resultadoproyecto = _IProyectoRepositorio.ListarProyectoPorEmpresa(parametro);
            IEnumerable<EmpresasBE> resultadoempresa = _IEmpresaRepositorio.ListarEmpresaPorUsuario(parametro);
            //change

            foreach (var empresa in resultadoempresa)
            {
                ProyectoEmpresa entidadProyecto = new ProyectoEmpresa();
                entidadProyecto.logoEmpresa = empresa.logoArchivo;
                entidadProyecto.nombre = empresa.razonSocial;
                foreach (var proyecto in resultadoproyecto)
                {
                    if (proyecto.idEmpresa == empresa.idEmpresa)
                    {

                        entidadProyecto.listaProyecto.Add(proyecto);
                    }

                }
                resultadoProyectoEmpresa.Add(entidadProyecto);
            }
            resultado.Data = resultadoProyectoEmpresa;
            return resultado;
        }

       public ResultadoBE<IEnumerable<ListarDocumentos>> DocumentoProyecto(ProyectosBE parametro)
        {
            ResultadoBE<IEnumerable<ListarDocumentos>> resultado = new ResultadoBE<IEnumerable<ListarDocumentos>>();
            resultado.Data = _IProyectoRepositorio.DocumentoProyecto(parametro);
            return resultado;

        }


        public ResultadoBE<IEnumerable<Documento>> ListarDocumentosProyecto(ProyectosBE parametro)
        {
            ResultadoBE<IEnumerable<Documento>> resultado = new ResultadoBE<IEnumerable<Documento>>();
            List<Documento> resultadoDocumento = new List<Documento>();

            //resultado.Data IEnumerable<ListarDocumentos> = _IProyectoRepositorio.ListarDocumentosProyecto(parametro);
            IEnumerable<ListarDocumentos> resultados= _IProyectoRepositorio.DocumentoProyecto(parametro);
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
