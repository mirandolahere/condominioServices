using Dapper;
using Delaware.Desarrollo.Condominio.ContractoRepositorio;
using Delaware.Desarrollo.Condominio.Dominio;
using Delaware.Desarrollo.Condominio.Dominio.Proyecto;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Delaware.Desarrollo.Condominio.SqlRepositorio
{
    public class ProyectoRepositorio : IProyectoRepositorio
    {


        public IEnumerable<ProyectosBE> ListarProyectoPorEmpresa(UsuariosBE parametro)
        {
            using (IDbConnection conexion = new SqlConnection("data source=SRV_APP_001\\MSSQLSERVER01;initial catalog=condominio;integrated security=false;user id=sa;password=R@bb1t20131992"))
            //using (IDbConnection conexion = new SqlConnection("data source=GDPORLIM162\\PRUEBA;initial catalog=condominio;integrated security=false;user id=sa;password=pass"))
            {
                conexion.Open();
                var parametros = new DynamicParameters();
                parametros.Add("@p_idPersona", parametro.idPersona);
                var coleccion = conexion.Query<ProyectosBE>("dbo.Proyecto_ListarPorPersona_pa", param: parametros, commandType: CommandType.StoredProcedure);
                return coleccion;
            }
        }

        
        public IEnumerable<ListarDocumentos> DocumentoProyecto(ProyectosBE parametro)
        {
            using (IDbConnection conexion = new SqlConnection("data source=SRV_APP_001\\MSSQLSERVER01;initial catalog=condominio;integrated security=false;user id=sa;password=R@bb1t20131992"))
            //using (IDbConnection conexion = new SqlConnection("data source=GDPORLIM162\\PRUEBA;initial catalog=condominio;integrated security=false;user id=sa;password=pass"))
            {
                conexion.Open();
                var parametros = new DynamicParameters();
                parametros.Add("@p_idProyecto", parametro.idProyecto);
                var coleccion = conexion.Query<ListarDocumentos>("dbo.Proyecto_ListarDocumentos_pa", param: parametros, commandType: CommandType.StoredProcedure);
                return coleccion;
            }
        }
    }
}
