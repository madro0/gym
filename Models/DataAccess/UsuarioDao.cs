using Gym.Models.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gym.Models.DataAccess
{
    class UsuarioDao
    {
        public List<UsuarioModel> Consultar()
        {
            List<UsuarioModel> resultado = new List<UsuarioModel>();

            using (var contexto = new GymEntities())
            {
                var resultadoconsulta = (from d in contexto.Usuario select d).ToList();
                foreach (var item in resultadoconsulta)
                {
                    UsuarioModel x = new UsuarioModel();

                    x.Id = item.Id;
                    x.Di = item.Di;
                    x.Nombre = item.Nombre;
                    x.Apellido = item.Apellido;
                    x.Genero = item.Genero1.Nombre;
                    x.Telefono = item.Telefono;
                    x.Correo= item.Correo;

                    resultado.Add(x);
                }
            }


            return resultado;
        }
        public List<UsuarioModel> listaGeneros()
        {
            List<UsuarioModel> resultado = new List<UsuarioModel>();

            using (var contexto = new GymEntities())
            {
                var resultadoconsulta = (from d in contexto.Genero select d).ToList();
                foreach (var item in resultadoconsulta)
                {
                    UsuarioModel x = new UsuarioModel();

                    x.IdGenero = item.Id;
                    x.NombreGenero = item.Nombre;



                    resultado.Add(x);
                }
            }


            return resultado;
        }
        public void Crear (UsuarioModel u)
        {
            using (var contexto = new GymEntities())
            {
                Usuario us = new Usuario();
                us.Di = u.Di;
                us.Nombre = u.Nombre;
                us.Apellido = u.Apellido;
                us.Genero = u.Genero;
                us.Telefono = u.Telefono;
                us.Correo = u.Correo;
                contexto.Usuario.Add(us);
                contexto.SaveChanges();
            }
        }
        public void EliminarRegistro(int id)
        {
            using (var contexto = new GymEntities())
            {
                var miregistro = (from d in contexto.Usuario select d).Where(x => x.Id.Equals(id)).FirstOrDefault();
                contexto.Usuario.Remove(miregistro);
                contexto.SaveChanges();
            }
        }
        public UsuarioModel ConsultarUsuario(int id)
        {
            UsuarioModel model = new UsuarioModel();
            using (var contexto = new GymEntities())
            {
                var personaje = (from d in contexto.Usuario select d).Where(x => x.Id.Equals(id)).FirstOrDefault();
                model.Di = personaje.Di;
                model.Nombre = personaje.Nombre;
                model.Apellido = personaje.Apellido;
                model.Genero = personaje.Genero;
                model.Telefono = personaje.Telefono;
                model.Correo = personaje.Correo;

            }
            return model;
        }
        public void ActualizarUsuario(UsuarioModel um)
        {
            using (var contexto = new GymEntities())
            {
                var datos = (from d in contexto.Usuario select d).Where(x => x.Id.Equals(um.Id)).FirstOrDefault();

                datos.Di = um.Di;
                datos.Nombre = um.Nombre;
                datos.Apellido = um.Apellido;
                datos.Genero = um.Genero;
                datos.Telefono = um.Telefono;
                datos.Correo = um.Correo;
              

                contexto.SaveChanges();
            }
        }

    }
}
