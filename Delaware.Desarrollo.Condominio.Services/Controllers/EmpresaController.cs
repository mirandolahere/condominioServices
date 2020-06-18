using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Delaware.Desarrollo.Condominio.Contrato;
using Delaware.Desarrollo.Condominio.Dominio;
using Delaware.Desarrollo.Condominio.Dominio.Base;
using Delaware.Desarrollo.Condominio.Dominio.Empresa;
using Delaware.Desarrollo.Condominio.Dominio.Proyecto;
using Microsoft.AspNetCore.Mvc;

namespace Delaware.Desarrollo.Condominio.Services.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class EmpresaController : Controller , IEmpresaServicio
    {
        IEmpresaServicio _IProyectoServicio;

        public EmpresaController(IEmpresaServicio _IProyectoServicio)
        {
            this._IProyectoServicio = _IProyectoServicio;
        }

        [HttpPost]
        public ResultadoBE<IEnumerable<EmpresasBE>> ListarEmpresaPorUsuario(UsuariosBE parametro)
        {
            return _IProyectoServicio.ListarEmpresaPorUsuario(parametro);
        }
    }
}