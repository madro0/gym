using Gym.Models.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gym.Models
{
    class CompraSuscripcionModel
    {
        public int Id { get; set; }
        public int Cliente { get; set; }
        public int Suscripcion { get; set; }
        public DateTime Fecha { get; set; }
        public int NumeroRutinas { get; set; }
        public string NombreSuscripcion { get; set; }
        public int NumeroTotalDeCompras { get; set; }
        
        
        public List<CompraSuscripcionModel> ObtenerCompraSuscripcion()
        {
            CompraSuscripcionDao dao = new CompraSuscripcionDao();
            return dao.Consultar();
        }
        public int GuardarCompraSuscripcion()
        {
            CompraSuscripcionDao dao = new CompraSuscripcionDao();
            return dao.Crear(this);
        }
        public CompraSuscripcionModel ConsultarCompraSuscripcion(int id)
        {
            CompraSuscripcionDao dao = new CompraSuscripcionDao();
            return dao.ConsultarCompraSuscripcion(id);
        }
        public int ConsultarNumeroRuticas(int id)
        {
            CompraSuscripcionDao dao = new CompraSuscripcionDao();
            return dao.ConsultarNumeroRuticas(id);
        }
        public List<CompraSuscripcionModel> ConteoCompraSuscripciones(string inicial, string final)
        {
            CompraSuscripcionDao dao = new CompraSuscripcionDao();
            return dao.ConteoCompraSuscripciones(inicial, final);
        }
    }
}
