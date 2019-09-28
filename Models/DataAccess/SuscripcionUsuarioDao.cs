using Gym.Models.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gym.Models.DataAccess
{
    class SuscripcionUsuarioDao
    {
        
        public SuscripcionUsuarioModel ConsultarSuscripcionUsuario(int id)
        {
            SuscripcionUsuarioModel model = new SuscripcionUsuarioModel();
            using (var contexto = new GymEntities())
            {
                var registro = (from d in contexto.SuscripcionUsuario select d).Where(x => x.Id.Equals(id)).FirstOrDefault();
                model.CompraSuscripcion = registro.CompraSuscripcion;
                model.Clientes = registro.Clientes;
                model.NumeroRutinas = registro.NumeroRutinas;
                model.FechaVencimiento = registro.FechaDeVencimiento;
               
            }
            return model;

        }
        public void Crear(SuscripcionUsuarioModel u)
        {
            using (var contexto = new GymEntities())
            {
                SuscripcionUsuario us = new SuscripcionUsuario();
                us.CompraSuscripcion = u.CompraSuscripcion;
                us.Clientes = u.Clientes;
                us.NumeroRutinas = u.NumeroRutinas;
                us.FechaDeVencimiento = u.FechaVencimiento;
                us.NumeroRutinas = u.NumeroRutinas;
                contexto.SuscripcionUsuario.Add(us);
                contexto.SaveChanges();
            }

        }
        public int ConsultarNumeroRutinas(int id)
        {
            int p;
            using (var contexto = new GymEntities())
            {
                DateTime fin = new DateTime();
                DateTime inicio = DateTime.Now;

                try
                {
                    var fechafin = (from d in contexto.SuscripcionUsuario select d).Where(x => x.Clientes.Equals(id)).Max(x => x.FechaDeVencimiento);
                    fin = fechafin;
                }
                catch (Exception)
                {
                    return -1;

                }

                var personaje = (from d in contexto.SuscripcionUsuario select d).Where((x => x.Clientes.Equals(id) && (x.FechaDeVencimiento >= inicio && x.FechaDeVencimiento <= fin))).Sum(x => x.NumeroRutinas);
                p = Convert.ToInt32(personaje);
                //select sum(NumeroRutinas) from CompraSuscripcion where Cliente = 1 and fecha BETWEEN '2019-08-16' AND '2020-01-01'
                //select MAX(fecha) from CompraSuscripcion where Cliente = 1
            }
            return p;
        }
        public List<SuscripcionUsuarioModel> RestarNumeroRutinas(int id)
        {
            int p;
            using (var contexto = new GymEntities())
            {
                DateTime fin = new DateTime();
                DateTime inicio = DateTime.Now;
                int tupla=-1;
                List<SuscripcionUsuarioModel> resultado = new List<SuscripcionUsuarioModel>();
                SuscripcionUsuarioModel model = new SuscripcionUsuarioModel();
                try
                {

                    var fechafin = (from d in contexto.SuscripcionUsuario select d).Where(x => x.Clientes.Equals(id)).Max(x => x.FechaDeVencimiento);
                    fin = fechafin;
                }
                catch (Exception)
                {

                    
                }
                try
                {
                    //select * from SuscripcionUsuario where Clientes = 1 and FechaVencimiento BETWEEN '2019-08-14' AND '2019-08-26' and NumeroRutinas>0
                    var TuplaArestar = (from d in contexto.SuscripcionUsuario select d).Where((x => x.Clientes.Equals(id) && (x.FechaDeVencimiento >= inicio && x.FechaDeVencimiento <= fin) && (x.NumeroRutinas > 0))).Min(x => x.Id);
                    tupla = TuplaArestar;
                    model.id = tupla;

                }
                catch (Exception)
                {

                    

                }
                try
                {
                    var datos = (from d in contexto.SuscripcionUsuario select d).Where(x => x.Id.Equals(tupla)).FirstOrDefault();
                    datos.NumeroRutinas = datos.NumeroRutinas - 1;
                    model.NumeroRutinas = datos.NumeroRutinas;
                    contexto.SaveChanges();
                    
                }
                catch (Exception)
                {

                   
                }
                resultado.Add(model);
                return resultado;


            }
               
            }

    }
}
