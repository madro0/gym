using Gym.Models.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gym.Models
{
    class SuscripcionUsuarioModel
    {
        public int id { get; set; }
        public int CompraSuscripcion { get; set; }
        public int Clientes { get; set; }
        public int NumeroRutinas { get; set; }
        public DateTime FechaVencimiento { get; set; }
        public List<int> ListaClientes { get; set; }
        public void GuardarSuscripcionUsuario()
        {
            SuscripcionUsuarioDao dao = new SuscripcionUsuarioDao();
            foreach(var item in ListaClientes)
            {
                Clientes = item;
                dao.Crear(this);
            }
            
        }
        public SuscripcionUsuarioModel ConsultarSuscripcionUsuario(int id)
        {
            SuscripcionUsuarioDao dao = new SuscripcionUsuarioDao();
            return dao.ConsultarSuscripcionUsuario(id);
        }
        public int ConsultarNumeroRutinas(int id)
        {
            SuscripcionUsuarioDao dao = new SuscripcionUsuarioDao();
            return dao.ConsultarNumeroRutinas(id);
        }
        public List<SuscripcionUsuarioModel> RestarNumeroRutinas(int id)
        {
            SuscripcionUsuarioDao dao = new SuscripcionUsuarioDao();
            return dao.RestarNumeroRutinas(id);
        }

    }
}
