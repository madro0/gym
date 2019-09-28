using Gym.Models;
using Gym.Models.DataModel;
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
    public partial class DatosUsuario : Form
    {
        public DatosUsuario()
        {
            InitializeComponent();
            
        }
        private int datoId=-1;
        //placeholders de los campos de texto.
        private void PlaceholderNombre_Enter(object sender, EventArgs e)
        {
            if (textNombre.Text== "Juan Pepito")
            {
                textNombre.Text = "";
                textNombre.ForeColor = Color.Black;
            }
        }
        private void PlaceholderNombre_Leave(object sender, EventArgs e)
        {
            if (textNombre.Text == "")
            {
                textNombre.Text = "Juan Pepito";
                textNombre.ForeColor = Color.DimGray;
            }
        }


        private void TextCedula_Enter(object sender, EventArgs e)
        {
            if (textCedula.Text == "123344556")
            {
                textCedula.Text = "";
                textCedula.ForeColor = Color.Black;
            }
        }

        private void TextCedula_Leave(object sender, EventArgs e)
        {
            if (textCedula.Text == "")
            {
                textCedula.Text = "123344556";
                textCedula.ForeColor = Color.DimGray;
            }
        }

        private void TextApellidos_Enter(object sender, EventArgs e)
        {
            if (textApellidos.Text == "Perez")
            {
                textApellidos.Text = "";
                textApellidos.ForeColor = Color.Black;
            }
        }

        private void TextApellidos_Leave(object sender, EventArgs e)
        {
            if (textApellidos.Text == "")
            {
                textApellidos.Text = "Perez";
                textApellidos.ForeColor = Color.DimGray;
            }
        }

        private void TextTelefono_Enter(object sender, EventArgs e)
        {
            if (textTelefono.Text == "3160003332")
            {
                textTelefono.Text = "";
                textTelefono.ForeColor = Color.Black;
            }
        }

        private void TextTelefono_Leave(object sender, EventArgs e)
        {
            if (textTelefono.Text == "")
            {
                textTelefono.Text = "3160003332";
                textTelefono.ForeColor = Color.DimGray;
            }
        }

        private void TextCorreo_Enter(object sender, EventArgs e)
        {
            if (textCorreo.Text == "ejemplo@gmail.com")
            {
                textCorreo.Text = "";
                textCorreo.ForeColor = Color.Black;
            }
        }

        private void TextCorreo_Leave(object sender, EventArgs e)
        {
            if (textCorreo.Text == "")
            {
                textCorreo.Text = "ejemplo@gmail.com";
                textCorreo.ForeColor = Color.DimGray;
            }
        }
        //evento cerrar ventana Datos Usuario
        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //evento Validar solo numeros en la cedula 
        private void TextCedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.SoloNumeros(e);
        }
        //evento click Erear//Editar
        private void BtnDatosUsuario_Click(object sender, EventArgs e)
        {

            if (datoId == -1)
            {
                PresionarCrear();
            }
            else
            {
                PresionarEditar();
            }
        }




        //Metodos Creados 
        //Validar que los campos No esten vacios
        private Boolean ValidarVacios()
        {
            if (textNombre.Text == "Juan Pepito" | textApellidos.Text == "Perez" | textCedula.Text == "123344556"
                | textTelefono.Text == "3160003332" | textCorreo.Text == "ejemplo@gmail.com" | GeneroCrear() == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //Metodos Para genero
        private string GeneroCrear()
        {
            if (radio0.Checked)
                return "M";
            if (radio1.Checked)
                return "F";
            if (radio2.Checked)
                return "O";
            else
                return null;
        }
        private void GeneroEditar(string G)
        {
            if (G == "M")
                radio0.Checked = true;
            if (G == "F")
                radio1.Checked = true;
            if (G == "O")
                radio2.Checked = true;

        }
        //metodos para crear Nuevo Usuario
        private void PresionarCrear()
        {
            if (ValidarVacios() == true)
            {
                MessageBox.Show("Error, campos incompletos");
            }
            else
            {
                UsuarioModel model = new UsuarioModel();
                model.Di = Convert.ToInt32(textCedula.Text);
                model.Nombre = textNombre.Text;
                model.Apellido = textApellidos.Text;
                //model.Genero = comboGenero.SelectedValue.ToString();
                model.Genero = GeneroCrear();
                model.Telefono = textTelefono.Text;
                model.Correo = textCorreo.Text;
                model.GuardarUsuario();

                Usuarios U = Owner as Usuarios;
                U.MostrarUsuarios();

                this.Close();
            }
        }
        //metodos para Editar un Usuario
        //metodo para traer datos de Usuario A Editar
        public void Editar(int id)
        {
            StyleBtnEditar();
            UsuarioModel model = new UsuarioModel();
            model = model.ConsultarUsuario(id);
            datoId = id;

            textCedula.Text = Convert.ToString(model.Di);
            textCedula.ForeColor = Color.Black;
            textNombre.Text = model.Nombre;
            textNombre.ForeColor = Color.Black;
            textApellidos.Text = model.Apellido;
            textApellidos.ForeColor = Color.Black;
            textTelefono.Text = model.Telefono;
            textTelefono.ForeColor = Color.Black;
            textCorreo.Text = model.Correo;
            textCorreo.ForeColor = Color.Black;
            GeneroEditar(model.Genero);
        }
        private void PresionarEditar()
        {
            if (ValidarVacios() == true)
            {
                MessageBox.Show("Error, campos incompletos");
            }
            else
            {
                UsuarioModel model = new UsuarioModel();
                model.Id = datoId;
                model.Di = Convert.ToInt32(textCedula.Text);
                model.Nombre = textNombre.Text;
                model.Apellido = textApellidos.Text;
                model.Genero = GeneroCrear();
                model.Telefono = textTelefono.Text;
                model.Correo = textCorreo.Text;
                model.ActualizarUsuarios(model);

                Usuarios U = Owner as Usuarios;
                U.MostrarUsuarios();
                this.Close();

            }
        }
        //Cambiar estilo de boton cuando se va editar el voton cambia sus propiedades
        private void StyleBtnEditar()
        {
            this.btnDatosUsuario.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(104)))), ((int)(((byte)(185)))));
            this.btnDatosUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(104)))), ((int)(((byte)(185)))));
            this.btnDatosUsuario.ButtonText = "      Editar";
            this.btnDatosUsuario.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(104)))), ((int)(((byte)(185)))));
            this.btnDatosUsuario.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(104)))), ((int)(((byte)(185)))));
            this.btnDatosUsuario.Text = "      Editar";
        }
        
    }
}
