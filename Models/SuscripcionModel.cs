using Gym.Models.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gym.Models
{
    class SuscripcionModel
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int NumeroRutinas { get; set; }
        public int DuracionRutina { get; set; }
        public decimal Valor { get; set; }
        public double Plazo { get; set; }
        public int NumeroIntegrantes { get; set; }
        public List<SuscripcionModel> Lista { get; set; }

        public List<SuscripcionModel> ObtenerSuscripcion()
        {
            SuscripcionDao dao = new SuscripcionDao();
            return dao.Consultar();
        }
        public void GuardarSuscripcion()
        {
            SuscripcionDao dao = new SuscripcionDao();
            dao.Crear(this);
        }
        public SuscripcionModel ConsultarSuscripcion(int id)
        {
            SuscripcionDao dao = new SuscripcionDao();
            return dao.ConsultarSuscripcion(id);
        }
    }
}
