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

namespace Gym.Interfaz.Configuracion
{
    public partial class AgregarSuscripcion : Form
    {
        public AgregarSuscripcion()
        {
            InitializeComponent();
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //Placeholders
        private void TextPazoDias_Enter(object sender, EventArgs e)
        {
            if (textPazoDias.Text=="dias")
            {
                textPazoDias.Text = "";
                textPazoDias.ForeColor = Color.Black;
            }
        }

        private void TextPlazoMeses_Enter(object sender, EventArgs e)
        {
            if (textPlazoMeses.Text == "meses")
            {
                textPlazoMeses.Text = "";
                textPlazoMeses.ForeColor = Color.Black;
            }
        }

        private void TextPlazoAños_Enter(object sender, EventArgs e)
        {
            if (textPlazoAños.Text == "años")
            {
                textPlazoAños.Text = "";
                textPlazoAños.ForeColor = Color.Black;
            }
        }

        private void TextPazoDias_Leave(object sender, EventArgs e)
        {
            if (textPazoDias.Text == "")
            {
                textPazoDias.Text = "dias";
                textPazoDias.ForeColor = Color.Gray;
            }
        }

        private void TextPlazoMeses_Leave(object sender, EventArgs e)
        {
            if (textPlazoMeses.Text == "")
            {
                textPlazoMeses.Text = "meses";
                textPlazoMeses.ForeColor = Color.Gray;
            }
        }

        private void TextPlazoAños_Leave(object sender, EventArgs e)
        {
            if (textPlazoAños.Text == "")
            {
                textPlazoAños.Text = "años";
                textPlazoAños.ForeColor = Color.Gray;
            }
        }
        //validar campos vacios
        public Boolean ValidarVacios()
        {
            if (textNombreSuscripcion.Text == "" | textDias.Text == "" | textPlazoMeses.Text == "meses" | textTiempoRutina.Text == "" | textValor.Text == ""| textNumeroDeIntegrantes.Text == "")
                return true;
            else
                return false;
        }
        //Presionar Crear
        private void PresionarCrear()
        {
            if (ValidarVacios() == true)
            {
                MessageBox.Show("Error, campos incompletos");
            }
            else
            {
                SuscripcionModel model = new SuscripcionModel();
                

                model.Nombre = textNombreSuscripcion.Text;
                model.NumeroRutinas = Convert.ToInt32(textDias.Text);
                model.DuracionRutina = Convert.ToInt32(textTiempoRutina.Text);
                model.Valor = Convert.ToDecimal(textValor.Text);
                model.Plazo = Convert.ToDouble(textPlazoMeses.Text);
                model.NumeroIntegrantes = Convert.ToInt32(textNumeroDeIntegrantes.Text);
                
                //model.Genero = comboGenero.SelectedValue.ToString();
                
                model.GuardarSuscripcion();

                //Usuarios U = Owner as Usuarios;
                //U.MostrarUsuarios();
                this.Close();
            }
        }

        private void BtnCrearSuscripcion_Click(object sender, EventArgs e)
        {
            PresionarCrear();
        }
    }
}
