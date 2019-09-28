using Gym.Models.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gym.Models.DataAccess
{
    class CompraSuscripcionDao
    {

        public List<CompraSuscripcionModel> Consultar()
        {
            List<CompraSuscripcionModel> resultado = new List<CompraSuscripcionModel>();

            using (var contexto = new GymEntities())
            {
                var resultadoconsulta = (from d in contexto.CompraSuscripcion select d).ToList();
                foreach (var item in resultadoconsulta)
                {
                    CompraSuscripcionModel x = new CompraSuscripcionModel();

                    x.Id = item.Id;
                    x.Cliente = item.Cliente;
                    x.Suscripcion = item.Suscripcion;
                    x.Fecha = item.Fecha;
                    x.NumeroRutinas = item.NumeroRutinas;

                    resultado.Add(x);
                }
            }
            return resultado;
        }
        public int Crear(CompraSuscripcionModel u)
        {
            using (var contexto = new GymEntities())
            {
                CompraSuscripcion us = new CompraSuscripcion();

                us.Cliente = u.Cliente;
                us.Suscripcion = u.Suscripcion;
                us.Fecha = u.Fecha;
                us.NumeroRutinas = u.NumeroRutinas;
                contexto.CompraSuscripcion.Add(us);
                contexto.SaveChanges();

                return us.Id;
                
            }
            
        }
        public CompraSuscripcionModel ConsultarCompraSuscripcion(int id)
        {
            CompraSuscripcionModel model = new CompraSuscripcionModel();
            using (var contexto = new GymEntities())
            {
                var registro = (from d in contexto.CompraSuscripcion select d).Where(x => x.Id.Equals(id)).FirstOrDefault();
                model.Cliente = registro.Cliente;
                model.Suscripcion = registro.Suscripcion;
                model.Fecha = registro.Fecha;
                model.NumeroRutinas = registro.NumeroRutinas;
            }
            return model;

        }

        //select sum(NumeroRutinas) from CompraSuscripcion where Cliente = 1 and fecha BETWEEN '2019-08-16' AND '2020-01-01'
        public int ConsultarNumeroRuticas(int id)
        {
            int p;
            using (var contexto = new GymEntities())
            {
                DateTime fin = new DateTime();
                DateTime inicio = DateTime.Now;

                try
                {
                    var fechafin = (from d in contexto.CompraSuscripcion select d).Where(x => x.Cliente.Equals(id)).Max(x => x.Fecha);
                    fin = fechafin;
                }
                catch (Exception)
                {
                    return -1;

                }
               
                var personaje = (from d in contexto.CompraSuscripcion select d).Where((x => x.Cliente.Equals(id) && (x.Fecha >= inicio && x.Fecha<=fin))).Sum(x => x.NumeroRutinas);
                 p = Convert.ToInt32(personaje);
                //select sum(NumeroRutinas) from CompraSuscripcion where Cliente = 1 and fecha BETWEEN '2019-08-16' AND '2020-01-01'
                //select MAX(fecha) from CompraSuscripcion where Cliente = 1
            }
            return p;
        }
        

        public List<CompraSuscripcionModel> ConteoCompraSuscripciones(String inicial, string final)
        {

            List<CompraSuscripcionModel> resultado = new List<CompraSuscripcionModel>();
            using (var contexto = new GymEntities())
            {
                
                DateTime dateValueInicial, dateValueFinal;
                //string dateString = "2010-07-24";
                //string dateString2 = "2020-09-1";
                //dateValueInicial = DateTime.Parse(dateString);
                //dateValueFinal = DateTime.Parse(dateString2);
                var ConteoCompraSuscripcion = from s in contexto.Suscripcion
                                              join c in contexto.CompraSuscripcion
                                              on s.Id equals c.Suscripcion

                                              
                                              group new { s, c } by new { s.Id, c.Suscripcion } into qubit
                                              select new
                                              {
                                                  IdSuscripcion = qubit.Key.Id,
                                                  PostCount = qubit.Count()

                                              };

                if (inicial!="" )
                {
                    dateValueInicial = DateTime.Parse(inicial);
                    dateValueFinal = DateTime.Parse(final);
                    ConteoCompraSuscripcion = from s in contexto.Suscripcion
                                              join c in contexto.CompraSuscripcion
                                              on s.Id equals c.Suscripcion
                                              where c.Fecha >= dateValueInicial && c.Fecha<= dateValueFinal


                                              group new { s, c } by new { s.Id, c.Suscripcion } into qubit
                                              select new
                                              {
                                                  IdSuscripcion = qubit.Key.Id,
                                                  PostCount = qubit.Count()

                                              };
                    //id suscripciones que se encuentran presentes en la tabla comprasuscripcion.

                    //la misma consulta anterior pero en sql normal.

                    /*select s.id, count(c.Suscripcion)  as NoTotalDeCompras
                    from Suscripcion s 
                    LEFT JOIN  CompraSuscripcion c on c.Suscripcion= s.Id
                    group by s.Id  order by count(2)")*/
                }




                //consultar todas las id de las suscripciones
                var Suscripciones = from s in contexto.Suscripcion
                                  select new
                                  {
                                      IdSuscripcion = s.Id,
                                 };

               //comparar que suscripciones no se encuentran en la tabla CompraSuscripcion
                foreach (var item in Suscripciones)
                {
                    Boolean a = true;
                    foreach (var relacion in ConteoCompraSuscripcion)
                    {
                        if (item.IdSuscripcion == relacion.IdSuscripcion)
                        {
                            a = false;
                        }
                        
                    }
                    if (a.Equals(true))
                    {
                        CompraSuscripcionModel model = new CompraSuscripcionModel();
                        model.Id = item.IdSuscripcion;
                        var f = (from d in contexto.Suscripcion select d).Where(x => x.Id.Equals(item.IdSuscripcion)).FirstOrDefault();

                        model.NombreSuscripcion = f.Nombre;
                        model.NumeroTotalDeCompras = 0;

                        resultado.Add(model);
                    }
                }


                //añadir a la lista "resultado" todos las suscripciones las que estan y las que no en la tabla CompraSuscripcion,
                //asi como su respectivo conteo
                foreach (var item in ConteoCompraSuscripcion)
                {
                    CompraSuscripcionModel model = new CompraSuscripcionModel();


                    model.Id = item.IdSuscripcion;

                    var f = (from d in contexto.Suscripcion select d).Where(x => x.Id.Equals(item.IdSuscripcion)).FirstOrDefault();

                    model.NombreSuscripcion = f.Nombre;
                    model.NumeroTotalDeCompras = item.PostCount;
                    //model.Suscripcion = item.Suscripcion;

                    resultado.Add(model);
                }

            }

           //ordenar de mayor a menor la lista resultado para posteriomente retornarla.
            resultado = resultado.OrderByDescending(p => p.NumeroTotalDeCompras).ToList();
            return resultado;
        }
    }
}
