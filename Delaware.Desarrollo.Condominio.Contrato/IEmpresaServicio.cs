using Delaware.Desarrollo.Condominio.Dominio;
using Delaware.Desarrollo.Condominio.Dominio.Base;
using Delaware.Desarrollo.Condominio.Dominio.Empresa;
using Delaware.Desarrollo.Condominio.Dominio.Proyecto;
using System;
using System.Collections.Generic;
using System.Text;

namespace Delaware.Desarrollo.Condominio.Contrato
{
     public interface IEmpresaServicio
    {
        ResultadoBE<IEnumerable<EmpresasBE>> ListarEmpresaPorUsuario(UsuariosBE parametro);

    }

}
