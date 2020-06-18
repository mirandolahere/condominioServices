using Delaware.Desarrollo.Condominio.Dominio.Base;
using Delaware.Desarrollo.Condominio.Dominio.Filtro;
using Delaware.Desarrollo.Condominio.Dominio.Ventas;
using System;
using System.Collections.Generic;
using System.Text;

namespace Delaware.Desarrollo.Condominio.Contrato
{
    public interface IVentaServicio
    {
        ResultadoBE<IEnumerable<Venta>> ProyectList(Filtro parametro);

        ResultadoBE<IEnumerable<Presentacion>> PresentacionProyecto(Venta parametro);

        ResultadoBE<IEnumerable<ListaLugares>> LugaresProyecto(Venta parametro);

        ResultadoBE<IEnumerable<Galeria>> GaleriaProyecto(Galeria galeria);

        ResultadoBE<IEnumerable<Plano>> PlanoPorTipo(Plano parametro);

        ResultadoBE<IEnumerable<PlanoPorId>> PlanoPorInmueble(PlanoPorId parametro);
        ResultadoBE<IEnumerable<Contacto>> ContactoProyecto(Venta parametro);


        ResultadoBE<IEnumerable<Provincia>> ProvinciaList(Departamento departamento);

        ResultadoBE<IEnumerable<Departamento>> DepartamentoList();
    }
}
