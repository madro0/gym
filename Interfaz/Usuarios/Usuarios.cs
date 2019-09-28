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

namespace Gym.Interfaz.Usuarios
{
    public partial class Usuarios : Form
    {
        public Usuarios()
        {
            InitializeComponent();
            
        }
       

        private void TextBuscar_Enter(object sender, EventArgs e)
        {
            if (textBuscar.Text == "Buscar")
            {
                textBuscar.Text = "";

                textBuscar.ForeColor = Color.Black;
            }
        }
        private void TextBuscar_Leave(object sender, EventArgs e)
        {
            if (textBuscar.Text == "")
            {
                textBuscar.Text = "Buscar";

                textBuscar.ForeColor = Color.DimGray;
            }
        }
        private void AbrirPanel(object FormHijo)
        {
            Form form = FormHijo as Form;
            AddOwnedForm(form);
            form.ShowDialog();

        }

        private void BtnNuevoUsuario_Click(object sender, EventArgs e)
        {
            AbrirPanel(new DatosUsuario());
        }
        private void HeadersTablaUsuarios()
        {
            
            //TablaUsuarios.Columns.Add("id", "Id");
            //TablaUsuarios.Columns.Add("di", "Di");
            //TablaUsuarios.Columns.Add("nombre", "Nombre");
            //TablaUsuarios.Columns.Add("apellido", "Apellido");
            //TablaUsuarios.Columns.Add("genero", "Genero");
            TablaUsuarios.Columns[0].Width = 50;
            TablaUsuarios.ColumnHeadersHeight = 50;
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

                TablaUsuarios.Rows.Add(
                               Convert.ToString(item.Id),
                               Convert.ToString(item.Di),
                               Convert.ToString(item.Nombre),
                               Convert.ToString(item.Apellido),
                               Convert.ToString(item.Genero)
                               );
            }
        }

        public void Usuarios2_Load(object sender, EventArgs e)
        {
            HeadersTablaUsuarios();
            MostrarUsuarios();
        }

        private void BunifuFlatButton2_Click(object sender, EventArgs e)
        {
            try
            {

                UsuarioModel Model = new UsuarioModel();
                int id = Convert.ToInt32(TablaUsuarios.CurrentRow.Cells["id"].Value.ToString());
                Model.EliminarRegistro(id);
                MostrarUsuarios();
                TablaUsuarios.ClearSelection();
            }
            catch (Exception ex)
            {
                    MessageBox.Show("Error "+ ex.Message );
            }
        }

        private void TablaUsuarios_Leave(object sender, EventArgs e)
        {
            TablaUsuarios.ClearSelection();
        }

       
        private void PanelBotonesUsu_MouseClick(object sender, MouseEventArgs e)
        {
            TablaUsuarios.ClearSelection();
        }

        private void BtnEditarUsuario_Click(object sender, EventArgs e)
        {
            try
            {
                DatosUsuario datos = new DatosUsuario();
                int id = Convert.ToInt32(TablaUsuarios.CurrentRow.Cells["id"].Value.ToString());
                datos.Editar(id);
               
                AbrirPanel(datos);

            }
            catch (Exception Ex)
            {
                MessageBox.Show("Error "+ Ex);   
            }
            
        }

        private void TablaUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
