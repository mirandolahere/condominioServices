using Delaware.Desarrollo.Condominio.Dominio;
using Delaware.Desarrollo.Condominio.Dominio.Empresa;
using Delaware.Desarrollo.Condominio.Dominio.Proyecto;
using System;
using System.Collections.Generic;
using System.Text;

namespace Delaware.Desarrollo.Condominio.ContractoRepositorio
{
    public interface IEmpresaRepositorio
    {
        IEnumerable<EmpresasBE> ListarEmpresaPorUsuario(UsuariosBE parametro);
    }
}
