using Gym.Models.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gym.Models.DataAccess
{
    class HistorialReporteAsistenciaDao
    {
        public void crear(HistorialReporteAsistenciaModel hram)
        {
            using (var contexto= new GymEntities())
            {
                HistorialReporteAsistencia hra = new HistorialReporteAsistencia();
                hra.IdSuscripcionUsuario = hram.IdSuscripcionUsuario;
                hra.Fecha = hram.Fecha;
                hra.NumeroDeRutina = hram.NumeroDeRutina;
                contexto.HistorialReporteAsistencia.Add(hra);
                contexto.SaveChanges();
            }
        }
        public List<HistorialReporteAsistenciaModel> ConteoHistorialReporteAsistencia()
        {
            List<HistorialReporteAsistenciaModel> resultado = new List<HistorialReporteAsistenciaModel>();
            using (var contexto = new GymEntities())
            {
                var ConteoHistorialReporteAsistencia = from s in contexto.Suscripcion
                                                       join c in contexto.CompraSuscripcion
                                                       on s.Id equals c.Suscripcion
                                                       join su in contexto.SuscripcionUsuario
                                                       on c.Id equals su.CompraSuscripcion
                                                       join h in contexto.HistorialReporteAsistencia
                                                       on su.Id equals h.IdSuscripcionUsuario
                                                       
                                                       group new { s } by new { s.Id } into qubit
                                                       select new
                                                       {
                                                           Id = qubit.Key.Id,
                                                           postcount = qubit.Count()
                                                       } 

                                                       

                                                      ;
                foreach (var item in ConteoHistorialReporteAsistencia)
                {
                    HistorialReporteAsistenciaModel x = new HistorialReporteAsistenciaModel();
                    x.Id = item.Id;
                    x.NumeroDeRutina = item.postcount;

                    resultado.Add(x);
                }
                
            }

            
                    return resultado;
                
                                                       
                                                       

                                                       
            }
        }
    }

