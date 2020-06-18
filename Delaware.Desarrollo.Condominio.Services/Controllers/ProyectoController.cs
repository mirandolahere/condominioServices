using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Delaware.Desarrollo.Condominio.Contrato;
using Delaware.Desarrollo.Condominio.Dominio;
using Delaware.Desarrollo.Condominio.Dominio.Base;
using Delaware.Desarrollo.Condominio.Dominio.Proyecto;
using Delaware.Desarrollo.Condominio.Dominio.TipoDocumento;
using Microsoft.AspNetCore.Mvc;

namespace Delaware.Desarrollo.Condominio.Services.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class ProyectoController : Controller , IProyectoServicio
    {
        IProyectoServicio _IProyectoServicio;
        public  ProyectoController(IProyectoServicio _IProyectoServicio)
        {
            this._IProyectoServicio = _IProyectoServicio;
        }

        [HttpPost]
        public ResultadoBE<IEnumerable<ProyectosBE>> ListarProyectoPorEmpresa(UsuariosBE parametro)
        {
            return _IProyectoServicio.ListarProyectoPorEmpresa(parametro);
        }

        [HttpPost]
        public ResultadoBE<IEnumerable<ProyectoEmpresa>> ProyectoPorEmpresa(UsuariosBE parametro)
        {
            return _IProyectoServicio.ProyectoPorEmpresa(parametro);
        }

        public ResultadoBE<IEnumerable<Documento>> ListarDocumentosProyecto(ProyectosBE parametro)
        {
            return _IProyectoServicio.ListarDocumentosProyecto(parametro);
        }
    }
}