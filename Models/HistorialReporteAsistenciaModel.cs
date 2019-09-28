using Gym.Models.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gym.Models
{
    class HistorialReporteAsistenciaModel
    {
        public int Id { get; set; }
        public int IdSuscripcionUsuario { get; set; }
        public DateTime Fecha { get; set; }
        public int NumeroDeRutina { get; set; }
        public void GuardarReporteAsistencia()
        {
            HistorialReporteAsistenciaDao dao = new HistorialReporteAsistenciaDao();
            dao.crear(this);
        }
        public List<HistorialReporteAsistenciaModel> ConteoHistorialReporteAsistencia()
        {
            HistorialReporteAsistenciaDao dao = new HistorialReporteAsistenciaDao();
            return dao.ConteoHistorialReporteAsistencia();
        } 
    }
}
