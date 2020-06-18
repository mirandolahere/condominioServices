using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Delaware.Desarrollo.Condominio.Contrato;
using Delaware.Desarrollo.Condominio.Dominio.Base;
using Delaware.Desarrollo.Condominio.Dominio.Filtro;
using Delaware.Desarrollo.Condominio.Dominio.Ventas;
using Microsoft.AspNetCore.Mvc;

namespace Delaware.Desarrollo.Condominio.Services.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class VentaController : Controller, IVentaServicio
    {
        IVentaServicio _IVentaServicio;

        public VentaController(IVentaServicio _IVentaServicio)
        {
            this._IVentaServicio = _IVentaServicio;
        }

        public ResultadoBE<IEnumerable<Contacto>> ContactoProyecto(Venta parametro)
        {
            return _IVentaServicio.ContactoProyecto(parametro);
        }

        public ResultadoBE<IEnumerable<Departamento>> DepartamentoList()
        {
            return _IVentaServicio.DepartamentoList();
        }

        public ResultadoBE<IEnumerable<Galeria>> GaleriaProyecto(Galeria galeria)
        {
            return _IVentaServicio.GaleriaProyecto(galeria);
        }

        public ResultadoBE<IEnumerable<ListaLugares>> LugaresProyecto(Venta parametro)
        {
            return _IVentaServicio.LugaresProyecto(parametro);
        }

        public ResultadoBE<IEnumerable<PlanoPorId>> PlanoPorInmueble(PlanoPorId parametro)
        {
            return _IVentaServicio.PlanoPorInmueble(parametro);
        }

        public ResultadoBE<IEnumerable<Plano>> PlanoPorTipo(Plano parametro)
        {
            return _IVentaServicio.PlanoPorTipo(parametro);
        }

        public ResultadoBE<IEnumerable<Presentacion>> PresentacionProyecto(Venta parametro)
        {
            return _IVentaServicio.PresentacionProyecto(parametro);

        }

        public ResultadoBE<IEnumerable<Provincia>> ProvinciaList(Departamento departamento)
        {
            return _IVentaServicio.ProvinciaList(departamento);
        }

        public ResultadoBE<IEnumerable<Venta>> ProyectList(Filtro parametro)
        {
            return _IVentaServicio.ProyectList(parametro);
        }
    }
}