using Delaware.Desarrollo.Condominio.Dominio.Filtro;
using Delaware.Desarrollo.Condominio.Dominio.Ventas;
using System;
using System.Collections.Generic;
using System.Text;

namespace Delaware.Desarrollo.Condominio.ContractoRepositorio
{
    public interface IVentaRepositorio
    {
        IEnumerable<Departamento> DepartamentoList();
        IEnumerable<Provincia> ProvinciaList(Departamento id);

        IEnumerable<Venta> ProyectList(Filtro parametro);

        IEnumerable<Presentacion> PresentacionProyecto(Venta parametro);

        IEnumerable<Lugares> LugaresProyecto(Venta parametro);

        IEnumerable<Lugares_todo> Lugarea_todo(Venta parametro);

        IEnumerable<Galeria> GaleriaProyecto(Galeria galeria);

        IEnumerable<Plano> PlanoPorTipo(Plano galeria);

        IEnumerable<PlanoPorId> PlanoPorInmueble(PlanoPorId parametro);

        IEnumerable<Contacto> ContactoProyecto(Venta parametro);



    }
}
