using Gym.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gym.Interfaz.Asistencia
{
    public partial class ListaUsuarios : Form
    {
        public ListaUsuarios()
        {
            InitializeComponent();
        }

        

        private void BtnNuevoUsuario_Click(object sender, EventArgs e)
        {
            Identificacion i = new Identificacion();
            int id = Convert.ToInt32(tablaUsuariosRegistrados.CurrentRow.Cells["id"].Value.ToString());
            i.ConsultarUsuario(id);
            AbrirPanel(i);
        }

        private void ListaUsuarios_Load(object sender, EventArgs e)
        {
            
            MostrarUsuarios();
        }
        public void MostrarUsuarios()
        {
            UsuarioModel model = new UsuarioModel();


            foreach (var item in model.ObtenerUsuarios())
            {
                TablaUsuarios.Rows.Clear();
            }

            foreach (var item in model.ObtenerUsuarios())
            {

                tablaUsuariosRegistrados.Rows.Add(
                               Convert.ToString(item.Id),
                               Convert.ToString(item.Di),
                               Convert.ToString(item.Nombre),
                               Convert.ToString(item.Apellido),
                               Convert.ToString(item.Id)
                               );
            }
        }
        private void AbrirPanel(object FormHijo)
        {
            Form form = FormHijo as Form;
            AddOwnedForm(form);
            form.ShowDialog();

        }
    }
}
