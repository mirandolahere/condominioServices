using Delaware.Desarrollo.Condominio.ContractoRepositorio;
using Delaware.Desarrollo.Condominio.Dominio.Base;
using Delaware.Desarrollo.Condominio.Dominio.Ventas;
using Delaware.Desarrollo.Condominio.SqlRepositorio;
using System;
using System.Collections.Generic;
using System.IO;
using System.Drawing;
using static System.Net.Mime.MediaTypeNames;
using Delaware.Desarrollo.Condominio.Dominio.Filtro;

namespace Delaware.Desarrollo.Condominio.Negocio
{
    public class VentaNegocio
    {
        private IVentaRepositorio _IVentaRepositorio = new VentaRepositorio();

        public ResultadoBE<IEnumerable<Contacto>> ContactoProyecto(Venta parametro)
        {
            ResultadoBE<IEnumerable<Contacto>> resultado = new ResultadoBE<IEnumerable<Contacto>>();
            resultado.Data = _IVentaRepositorio.ContactoProyecto(parametro);
            return resultado;
        }

        public ResultadoBE<IEnumerable<Plano>> PlanoPorTipo(Plano parametro)
        {

            ResultadoBE<IEnumerable<Plano>> resultado = new ResultadoBE<IEnumerable<Plano>>();
            resultado.Data = _IVentaRepositorio.PlanoPorTipo(parametro);
            return resultado;
        }

        public ResultadoBE<IEnumerable<PlanoPorId>> PlanoPorInmueble(PlanoPorId parametro)
        {
            ResultadoBE<IEnumerable<PlanoPorId>> resultado = new ResultadoBE<IEnumerable<PlanoPorId>>();
            List<PlanoPorId> resultadoProyecto = new List<PlanoPorId>();
            IEnumerable<PlanoPorId> plano = _IVentaRepositorio.PlanoPorInmueble(parametro);
            foreach (var foto in plano)
            {
                PlanoPorId plans = new PlanoPorId();
                string imgBase64String = GetBase64StringForImage(foto.ruta + "\\" + foto.nombreGuardado + ".jpg");
                plans = foto;
                plans.image = imgBase64String;
                resultadoProyecto.Add(plans);
            }
            resultado.Data = resultadoProyecto;
            return resultado;
        }

        public ResultadoBE<IEnumerable<Galeria>> GaleriaProyecto(Galeria parametro)
        {
            ResultadoBE<IEnumerable<Galeria>> resultado = new ResultadoBE<IEnumerable<Galeria>>();
            List<Galeria> resultadoProyecto = new List<Galeria>();
            IEnumerable<Galeria> galeria = _IVentaRepositorio.GaleriaProyecto(parametro);
            foreach (var foto in galeria)
            {
                Galeria galery = new Galeria();
                string imgBase64String = GetBase64StringForImage(foto.ruta+"\\"+foto.nombreGuardado+".jpg");
                galery = foto;
                galery.image = imgBase64String;
                resultadoProyecto.Add(galery);
            }
            resultado.Data = resultadoProyecto;
            return resultado;
        }

        private string GetBase64StringForImage(string imagePath)
        {
            byte[] imageBytes = System.IO.File.ReadAllBytes(imagePath);
            string base64String = Convert.ToBase64String(imageBytes);
            return base64String;
        }

        public ResultadoBE<IEnumerable<Venta>> ProyectList(Filtro parametro)
       {
            ResultadoBE<IEnumerable<Venta>> resultado = new ResultadoBE<IEnumerable<Venta>>();
            resultado.Data = _IVentaRepositorio.ProyectList(parametro);
            return resultado;
       }
        public ResultadoBE<IEnumerable<Provincia>> ProvinciaList(Departamento departamento)
        {
            ResultadoBE<IEnumerable<Provincia>> resultado = new ResultadoBE<IEnumerable<Provincia>>();
            resultado.Data = _IVentaRepositorio.ProvinciaList(departamento);
            return resultado;
        }
        public ResultadoBE<IEnumerable<Departamento>> DepartamentoList()
        {
            ResultadoBE<IEnumerable<Departamento>> resultado = new ResultadoBE<IEnumerable<Departamento>>();
            resultado.Data = _IVentaRepositorio.DepartamentoList();
            return resultado;
        }

        public ResultadoBE<IEnumerable<Presentacion>> PresentacionProyecto(Venta parametro)
        {
            ResultadoBE<IEnumerable<Presentacion>> resultado = new ResultadoBE<IEnumerable<Presentacion>>();
            resultado.Data = _IVentaRepositorio.PresentacionProyecto(parametro);
            return resultado;
        }
        
        public ResultadoBE<IEnumerable<ListaLugares>> LugaresProyecto(Venta parametro)
        {
            ResultadoBE<IEnumerable<ListaLugares>> resultado = new ResultadoBE<IEnumerable<ListaLugares>>();
           Data juntar = new Data();

            List<ListaLugares> resultadoProyectoEmpresa = new List<ListaLugares>();
            IEnumerable<Lugares> lugares = _IVentaRepositorio.LugaresProyecto(parametro);
            IEnumerable<Lugares_todo> lugares_all = _IVentaRepositorio.Lugarea_todo(parametro);

            //presentacion
            IEnumerable<Presentacion> presentacion = _IVentaRepositorio.PresentacionProyecto(parametro);


            foreach (var all in lugares_all)
            {
                ListaLugares entidadLista = new ListaLugares();
              

                foreach(var lugar in lugares)
                {
                    entidadLista.idCatalogo = lugar.idCatalogo;
                    entidadLista.coordX = lugar.coordX;
                    entidadLista.coordY = lugar.coordY;
                    entidadLista.introduccion = lugar.introduccion;
                   
                    if(lugar.idTipoLugar == all.idLista)
                    {
                        entidadLista.idTipoLugar = lugar.idTipoLugar;
                        entidadLista.nombreTipo = lugar.nombreTipo;
                        entidadLista.ListaDeLugares.Add(lugar);
                    }

                }

                resultadoProyectoEmpresa.Add(entidadLista);
                
            }
           

            resultado.Data = resultadoProyectoEmpresa;
            return resultado;

        }



    }
}
