using Delaware.Desarrollo.Condominio.Contrato;
using Delaware.Desarrollo.Condominio.Dominio;
using Delaware.Desarrollo.Condominio.Dominio.Base;
using Delaware.Desarrollo.Condominio.Dominio.Empresa;
using Delaware.Desarrollo.Condominio.Dominio.Proyecto;
using Delaware.Desarrollo.Condominio.Negocio;
using System;
using System.Collections.Generic;
using System.Text;

namespace Delaware.Desarrollo.Condominio.Implementacion
{
    public class EmpresaServicio : IEmpresaServicio
    {
        private EmpresaNegocio _ProyectoNegocio = new EmpresaNegocio();
        public ResultadoBE<IEnumerable<EmpresasBE>> ListarEmpresaPorUsuario(UsuariosBE parametro)
        {
            return _ProyectoNegocio.ListarEmpresaPorUsuario(parametro);
        }
    }
}
