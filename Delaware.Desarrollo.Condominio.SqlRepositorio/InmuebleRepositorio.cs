using Dapper;
using Delaware.Desarrollo.Condominio.ContractoRepositorio;
using Delaware.Desarrollo.Condominio.Dominio;
using Delaware.Desarrollo.Condominio.Dominio.Base;
using Delaware.Desarrollo.Condominio.Dominio.Inmueble;
using Delaware.Desarrollo.Condominio.Dominio.Proyecto;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Delaware.Desarrollo.Condominio.SqlRepositorio
{
    public class InmuebleRepositorio : IInmuebleRepositorio
    {
        public IEnumerable<InmueblesBE> ListarPorProyecto(InmueblesFiltroBE parametro)
        {
            using (IDbConnection conexion = new SqlConnection("data source=SRV_APP_001\\MSSQLSERVER01;initial catalog=condominio;integrated security=false;user id=sa;password=R@bb1t20131992"))
            //using (IDbConnection conexion = new SqlConnection("data source=GDPORLIM162\\PRUEBA;initial catalog=condominio;integrated security=false;user id=sa;password=pass"))
            {
                conexion.Open();
                var parametros = new DynamicParameters();
                parametros.Add("@p_idProyecto", parametro.idProyecto);
                parametros.Add("@p_idPersona", parametro.idPersona);
                var coleccion = conexion.Query<InmueblesBE>("dbo.Inmuebles_ListarPorProyecto_pa", param: parametros, commandType: CommandType.StoredProcedure);
                return coleccion;
            }
        }
        public IEnumerable<InmuebleInformacionLayout> InmuebleLayout(InmueblesBE parametro)
        {
            using (IDbConnection conexion = new SqlConnection("data source=SRV_APP_001\\MSSQLSERVER01;initial catalog=condominio;integrated security=false;user id=sa;password=R@bb1t20131992"))
            //using (IDbConnection conexion = new SqlConnection("data source=GDPORLIM162\\PRUEBA;initial catalog=condominio;integrated security=false;user id=sa;password=pass"))
            {
                conexion.Open();
                var parametros = new DynamicParameters();
                parametros.Add("@idInmueble", parametro.idInmueble);
                var coleccion = conexion.Query<InmuebleInformacionLayout>("dbo.Inmueble_informacionLayout_pa", param: parametros, commandType: CommandType.StoredProcedure);
                return coleccion;
            }
        }

        public IEnumerable<ListarDocumentos> ListarDocumentosInmueble(InmueblesBE parametro)
        {
            //using (IDbConnection conexion = new SqlConnection("data source=GDPORLIM162\\PRUEBA;initial catalog=condominio;integrated security=false;user id=sa;password=pass"))

            using (IDbConnection conexion = new SqlConnection("data source=SRV_APP_001\\MSSQLSERVER01;initial catalog=condominio;integrated security=false;user id=sa;password=R@bb1t20131992"))
            {
                conexion.Open();
                var parametros = new DynamicParameters();
                parametros.Add("@p_idInmueble", parametro.idInmueble);
                var coleccion = conexion.Query<ListarDocumentos>("dbo.Inmueble_ListarDocumentos_pa", param: parametros, commandType: CommandType.StoredProcedure);
                return coleccion;
            }
        }
    }
}
