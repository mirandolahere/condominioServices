using Delaware.Desarrollo.Condominio.ContractoRepositorio;
using Delaware.Desarrollo.Condominio.Dominio;
using Delaware.Desarrollo.Condominio.Dominio.Base;
using Delaware.Desarrollo.Condominio.Dominio.Empresa;
using Delaware.Desarrollo.Condominio.Dominio.Proyecto;
using Delaware.Desarrollo.Condominio.SqlRepositorio;
using System;
using System.Collections.Generic;
using System.Text;

namespace Delaware.Desarrollo.Condominio.Negocio
{
    public class EmpresaNegocio
    {
        IEmpresaRepositorio _IProyectoRepositorio = new EmpresaRepositorio();


        public ResultadoBE<IEnumerable<EmpresasBE>> ListarEmpresaPorUsuario(UsuariosBE parametro)
        {
            ResultadoBE<IEnumerable<EmpresasBE>> resultado = new ResultadoBE<IEnumerable<EmpresasBE>>();
            resultado.Data = _IProyectoRepositorio.ListarEmpresaPorUsuario(parametro);
            return resultado;

        }

    }
}
