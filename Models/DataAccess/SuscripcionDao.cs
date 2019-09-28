using Gym.Models.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gym.Models.DataAccess
{
    class SuscripcionDao
    {
        public List<SuscripcionModel> Consultar()
        {
            List<SuscripcionModel> resultado = new List<SuscripcionModel>();

            using (var contexto = new GymEntities())
            {
                var resultadoconsulta = (from d in contexto.Suscripcion select d).ToList();
                foreach (var item in resultadoconsulta)
                {
                    SuscripcionModel x = new SuscripcionModel();

                    x.Id = item.Id;
                    x.Nombre = item.Nombre;
                    x.NumeroRutinas = item.NumeroRutinas;
                    x.DuracionRutina = item.DuracionRutina;
                    x.Valor = item.Valor;
                    x.Plazo = item.Plazo;

                    resultado.Add(x);
                }
            }
            return resultado;
        }
        public void Crear(SuscripcionModel u)
        {
            using (var contexto = new GymEntities())
            {
                Suscripcion us = new Suscripcion();

                us.Nombre = u.Nombre;
                us.NumeroRutinas = u.NumeroRutinas;
                us.DuracionRutina = u.DuracionRutina;
                us.NumeroIntegrantes = u.NumeroIntegrantes;
                us.Valor = u.Valor;
                us.Plazo = u.Plazo;
                contexto.Suscripcion.Add(us);
                contexto.SaveChanges();
            }
        }
        public SuscripcionModel ConsultarSuscripcion(int id)
        {
            SuscripcionModel model = new SuscripcionModel();
            using (var contexto = new GymEntities())
            {
                var registro = (from d in contexto.Suscripcion select d).Where(x => x.Id.Equals(id)).FirstOrDefault();
                model.Nombre = registro.Nombre;
                model.Valor = registro.Valor;
                model.Plazo = registro.Plazo;
                model.NumeroRutinas = registro.NumeroRutinas;
                model.NumeroIntegrantes =Convert.ToInt32(registro.NumeroIntegrantes);
            }
            return model;
        }
    }
}
