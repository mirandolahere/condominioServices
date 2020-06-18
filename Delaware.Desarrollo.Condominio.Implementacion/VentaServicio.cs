using Delaware.Desarrollo.Condominio.Contrato;
using Delaware.Desarrollo.Condominio.Dominio.Base;
using Delaware.Desarrollo.Condominio.Dominio.Filtro;
using Delaware.Desarrollo.Condominio.Dominio.Ventas;
using Delaware.Desarrollo.Condominio.Negocio;
using System;
using System.Collections.Generic;
using System.Text;

namespace Delaware.Desarrollo.Condominio.Implementacion
{
    public class VentaServicio : IVentaServicio
    {
        private VentaNegocio _VentaNegocio = new VentaNegocio();

        public ResultadoBE<IEnumerable<Contacto>> ContactoProyecto(Venta parametro)
        {
            return _VentaNegocio.ContactoProyecto(parametro);
        }

        public ResultadoBE<IEnumerable<Departamento>> DepartamentoList()
        {
            return _VentaNegocio.DepartamentoList();
        }

        public ResultadoBE<IEnumerable<Galeria>> GaleriaProyecto(Galeria galeria)
        {
            return _VentaNegocio.GaleriaProyecto(galeria);
        }

        public ResultadoBE<IEnumerable<ListaLugares>> LugaresProyecto(Venta parametro)
        {
            return _VentaNegocio.LugaresProyecto(parametro);
        }

        public ResultadoBE<IEnumerable<PlanoPorId>> PlanoPorInmueble(PlanoPorId parametro)
        {
            return _VentaNegocio.PlanoPorInmueble(parametro);
        }

        public ResultadoBE<IEnumerable<Plano>> PlanoPorTipo(Plano parametro)
        {
            return _VentaNegocio.PlanoPorTipo(parametro);
        }

        public ResultadoBE<IEnumerable<Presentacion>> PresentacionProyecto(Venta parametro)
        {
            return _VentaNegocio.PresentacionProyecto(parametro);
        }

        public ResultadoBE<IEnumerable<Provincia>> ProvinciaList(Departamento departamento)
        {
            return _VentaNegocio.ProvinciaList(departamento);
        }

        public ResultadoBE<IEnumerable<Venta>> ProyectList(Filtro parametro)
        {
            return _VentaNegocio.ProyectList(parametro);
        }

    }
}
