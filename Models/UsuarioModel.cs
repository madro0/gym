using Gym.Models.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gym.Models
{
    class UsuarioModel
    {
        public int Id { get; set; }
        public int Di { get; set; }
        public string Genero { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Telefono { get; set; }
        public string  Correo { get; set; }
        public string IdGenero { get; set; }
        public string NombreGenero { get; set; }
        public List<UsuarioModel> Lista { get; set; }


        public List<UsuarioModel> ObtenerUsuarios()
        {
            UsuarioDao dao = new UsuarioDao();
            return dao.Consultar();
        }
        public void GuardarUsuario()
        {
            UsuarioDao dao = new UsuarioDao(); 
            dao.Crear(this);
        }
        public List<UsuarioModel> listaGeneros()
        {
            UsuarioDao dao = new UsuarioDao();
            dao.listaGeneros();
            return dao.listaGeneros();
        }
        public void EliminarRegistro(int id)
        {
            UsuarioDao dao = new UsuarioDao();
            dao.EliminarRegistro(id);
        }
        public UsuarioModel ConsultarUsuario(int id)
        {
            UsuarioDao dao = new UsuarioDao();

            return dao.ConsultarUsuario(id);
        }
        public void ActualizarUsuarios(UsuarioModel um)
        {
            UsuarioDao dao = new UsuarioDao();
            dao.ActualizarUsuario(um);
        }
    }
}
