using Dapper;
using Delaware.Desarrollo.Condominio.ContractoRepositorio;
using Delaware.Desarrollo.Condominio.Dominio.Filtro;
using Delaware.Desarrollo.Condominio.Dominio.Ventas;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Delaware.Desarrollo.Condominio.SqlRepositorio
{
    public class VentaRepositorio : IVentaRepositorio
    {
        public IEnumerable<Contacto> ContactoProyecto(Venta parametro)
        {
            using (IDbConnection conexion = new SqlConnection("data source=SRV_APP_001\\MSSQLSERVER01;initial catalog=condominio;integrated security=false;user id=sa;password=R@bb1t20131992"))

            //using (IDbConnection conexion = new SqlConnection("data source=GDPORLIM162\\PRUEBA;initial catalog=condominio;integrated security=false;user id=sa;password=pass"))
            {
                conexion.Open();
                var parametros = new DynamicParameters();
                parametros.Add("@p_idCatalogo", parametro.idCatalogo);
                var coleccion = conexion.Query<Contacto>("dbo.Venta_Contacto_pa", param: parametros, commandType: CommandType.StoredProcedure);
                return coleccion;
            }
        }

        

        public IEnumerable<Galeria> GaleriaProyecto(Galeria parametro)
        {
            using (IDbConnection conexion = new SqlConnection("data source=SRV_APP_001\\MSSQLSERVER01;initial catalog=condominio;integrated security=false;user id=sa;password=R@bb1t20131992"))

            //using (IDbConnection conexion = new SqlConnection("data source=GDPORLIM162\\PRUEBA;initial catalog=condominio;integrated security=false;user id=sa;password=pass"))
            {
                conexion.Open();
                var parametros = new DynamicParameters();
                parametros.Add("@p_idCatalogo", parametro.idCatalogo);
                parametros.Add("@p_idTipoGaleria", parametro.idTipoGaleria);
                var coleccion = conexion.Query<Galeria>("dbo.Venta_GaleriaProyecto_pa", param: parametros, commandType: CommandType.StoredProcedure);
                return coleccion;
            }
        }

        public IEnumerable<Lugares_todo> Lugarea_todo(Venta parametro)
        {
            using (IDbConnection conexion = new SqlConnection("data source=SRV_APP_001\\MSSQLSERVER01;initial catalog=condominio;integrated security=false;user id=sa;password=R@bb1t20131992"))

            //using (IDbConnection conexion = new SqlConnection("data source=GDPORLIM162\\PRUEBA;initial catalog=condominio;integrated security=false;user id=sa;password=pass"))
            {
                conexion.Open();
                var parametros = new DynamicParameters();
                var coleccion = conexion.Query<Lugares_todo>("dbo.LUGARES_OBTENER", param: parametros, commandType: CommandType.StoredProcedure);
                return coleccion;
            }
        }

        public IEnumerable<Lugares> LugaresProyecto(Venta parametro)
        {
            using (IDbConnection conexion = new SqlConnection("data source=SRV_APP_001\\MSSQLSERVER01;initial catalog=condominio;integrated security=false;user id=sa;password=R@bb1t20131992"))

            //using (IDbConnection conexion = new SqlConnection("data source=GDPORLIM162\\PRUEBA;initial catalog=condominio;integrated security=false;user id=sa;password=pass"))
            {
                conexion.Open();
                var parametros = new DynamicParameters();
                parametros.Add("@p_idCatalogo", parametro.idCatalogo);
                var coleccion = conexion.Query<Lugares>("dbo.Venta_Ubicacion_pa", param: parametros, commandType: CommandType.StoredProcedure);
                return coleccion;
            }
        }

        public IEnumerable<PlanoPorId> PlanoPorInmueble(PlanoPorId parametro)
        {
            using (IDbConnection conexion = new SqlConnection("data source=SRV_APP_001\\MSSQLSERVER01;initial catalog=condominio;integrated security=false;user id=sa;password=R@bb1t20131992"))

            //using (IDbConnection conexion = new SqlConnection("data source=GDPORLIM162\\PRUEBA;initial catalog=condominio;integrated security=false;user id=sa;password=pass"))
            {
                conexion.Open();
                var parametros = new DynamicParameters();
                parametros.Add("@p_idInmueble", parametro.idInmueble);
                var coleccion = conexion.Query<PlanoPorId>("dbo.Venta_InformacionPorPlano_pa", param: parametros, commandType: CommandType.StoredProcedure);
                return coleccion;
            }
        }

        public IEnumerable<Plano> PlanoPorTipo(Plano parametro)
        {
            using (IDbConnection conexion = new SqlConnection("data source=SRV_APP_001\\MSSQLSERVER01;initial catalog=condominio;integrated security=false;user id=sa;password=R@bb1t20131992"))

            //using (IDbConnection conexion = new SqlConnection("data source=GDPORLIM162\\PRUEBA;initial catalog=condominio;integrated security=false;user id=sa;password=pass"))
            {
                conexion.Open();
                var parametros = new DynamicParameters();
                parametros.Add("@p_idCatalogo", parametro.idCatalogo);
                parametros.Add("@p_idTipoInmueble", parametro.idTipoInmueble);
                var coleccion = conexion.Query<Plano>("dbo.Venta_Planos_pa", param: parametros, commandType: CommandType.StoredProcedure);
                return coleccion;
            }
        }

        public IEnumerable<Presentacion> PresentacionProyecto(Venta parametro)
        {
            using (IDbConnection conexion = new SqlConnection("data source=SRV_APP_001\\MSSQLSERVER01;initial catalog=condominio;integrated security=false;user id=sa;password=R@bb1t20131992"))

            //using (IDbConnection conexion = new SqlConnection("data source=GDPORLIM162\\PRUEBA;initial catalog=condominio;integrated security=false;user id=sa;password=pass"))
            {
                conexion.Open();
                var parametros = new DynamicParameters();
                parametros.Add("@p_idCatalogo", parametro.idCatalogo);
                var coleccion = conexion.Query<Presentacion>("dbo.Venta_DescripcionProyecto_pa", param: parametros, commandType: CommandType.StoredProcedure);
                return coleccion;
            }
        }

        public IEnumerable<Provincia> ProvinciaList(Departamento departamento)
        {
            using (IDbConnection conexion = new SqlConnection("data source=SRV_APP_001\\MSSQLSERVER01;initial catalog=condominio;integrated security=false;user id=sa;password=R@bb1t20131992"))

            //using (IDbConnection conexion = new SqlConnection("data source=GDPORLIM162\\PRUEBA;initial catalog=condominio;integrated security=false;user id=sa;password=pass"))
            {
                conexion.Open();
                var parametros = new DynamicParameters();
                parametros.Add("@p_idDepartamento", departamento.id);
                var coleccion = conexion.Query<Provincia>("dbo.Proyecto_AyudaLista_Provincia", param: parametros, commandType: CommandType.StoredProcedure);
                return coleccion;
            }
        }

        public IEnumerable<Departamento> DepartamentoList()
        {
            using (IDbConnection conexion = new SqlConnection("data source=SRV_APP_001\\MSSQLSERVER01;initial catalog=condominio;integrated security=false;user id=sa;password=R@bb1t20131992"))

            //using (IDbConnection conexion = new SqlConnection("data source=GDPORLIM162\\PRUEBA;initial catalog=condominio;integrated security=false;user id=sa;password=pass"))
            {
                conexion.Open();
                var parametros = new DynamicParameters();
                var coleccion = conexion.Query<Departamento>("dbo.Proyecto_AyudaLista_Departamento", param: parametros, commandType: CommandType.StoredProcedure);
                return coleccion;
            }
        }

        public IEnumerable<Venta> ProyectList(Filtro parametro)
        {
            using (IDbConnection conexion = new SqlConnection("data source=SRV_APP_001\\MSSQLSERVER01;initial catalog=condominio;integrated security=false;user id=sa;password=R@bb1t20131992"))

            // using (IDbConnection conexion = new SqlConnection("data source=GDPORLIM162\\PRUEBA;initial catalog=condominio;integrated security=false;user id=sa;password=pass"))
            {
                conexion.Open();
                var parametros = new DynamicParameters();
                parametros.Add("@p_provincia", parametro.provincia);
                parametros.Add("@p_departamento", parametro.departamento);

                var coleccion = conexion.Query<Venta>("dbo.Venta_ListarProyecto_pa", param: parametros, commandType: CommandType.StoredProcedure);
                return coleccion;
            }
        }
    }
}
