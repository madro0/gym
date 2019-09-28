using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gym.Models;

namespace Gym.Interfaz.Suscripciones
{
    public partial class NuevaSuscripcion : Form
    {
        public NuevaSuscripcion()
        {
            InitializeComponent();
        }
        private void AbrirPanel(object FormHijo)
        {
            Form form = FormHijo as Form;
            AddOwnedForm(form);
            form.ShowDialog();

        }

        private void BunifuFlatButton1_Click(object sender, EventArgs e)
        {
            try
            {
                Agregar datos = new Agregar();
                int id = Convert.ToInt32(TablaUsuariosRegistrados.CurrentRow.Cells["id"].Value.ToString());
                datos.LlenarCampos(id);

                AbrirPanel(datos);

            }
            catch (Exception Ex)
            {
                MessageBox.Show("Error " + Ex);
            }
        }
        //Mostrar Usuarios
        public void MostrarUsuarios()
        {
            UsuarioModel model = new UsuarioModel();


            foreach (var item in model.ObtenerUsuarios())
            {
                TablaUsuariosRegistrados.Rows.Clear();
            }

            foreach (var item in model.ObtenerUsuarios())
            {

                TablaUsuariosRegistrados.Rows.Add(
                               Convert.ToString(item.Id),
                               Convert.ToString(item.Di),
                               Convert.ToString(item.Nombre),
                               Convert.ToString(item.Apellido)
                               );
            }
        }

        private void NuevaSuscripcion_Load(object sender, EventArgs e)
        {
            MostrarUsuarios();
        }
    }
}
