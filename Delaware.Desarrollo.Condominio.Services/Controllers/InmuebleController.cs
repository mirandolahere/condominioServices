using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Delaware.Desarrollo.Condominio.Dominio.Base;
using Delaware.Desarrollo.Condominio.Dominio.Inmueble;
using Delaware.Desarrollo.Condominio.Contrato;
using Delaware.Desarrollo.Condominio.Services;
using Microsoft.AspNetCore.Mvc;
using Delaware.Desarrollo.Condominio.Implementacion;
using Delaware.Desarrollo.Condominio.Dominio;
using Delaware.Desarrollo.Condominio.Dominio.TipoDocumento;

namespace Delaware.Desarrollo.Condominio.Services.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class InmuebleController : Controller, IInmuebleServicio
    {
        IInmuebleServicio _IInmuebleServicio ;

        #region constructor

        public InmuebleController(IInmuebleServicio _IInmuebleServicio)
        {
            this._IInmuebleServicio = _IInmuebleServicio;
        }

        #endregion constructor

        [HttpPost]
        public ResultadoBE<IEnumerable<InmueblesBE>> ListarPorProyecto(InmueblesFiltroBE parametro)
        {
            return _IInmuebleServicio.ListarPorProyecto(parametro);
        }

        [HttpPost]
        public ResultadoBE<IEnumerable<InmuebleInformacionLayout>> InmuebleLayout(InmueblesBE parametro)
        {
            return _IInmuebleServicio.InmuebleLayout(parametro);

        }

        [HttpPost]
        public ResultadoBE<IEnumerable<Documento>> ListarDocumentosInmuebles(InmueblesBE parametro)
        {
            return _IInmuebleServicio.ListarDocumentosInmuebles(parametro);
        }
    }
}