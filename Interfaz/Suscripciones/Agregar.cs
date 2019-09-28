using Gym.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gym.Interfaz.Suscripciones
{
    public partial class Agregar : Form
    {
        public Agregar()
        {
            InitializeComponent();
        }
        private int datoIdUsuario = 0;
        private int datoIdSuscripcion = 0;
        private  DateTime fechaFinal;
        
        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
       
        private void Agregar_Load(object sender, EventArgs e)
        {
            llenarComboBox();
        }
        private void TextValorIngresado_KeyUp(object sender, KeyEventArgs e)
        {
            Operacion();
        }
        public void LlenarCampos(int id)
        {
            UsuarioModel model = new UsuarioModel();
            model = model.ConsultarUsuario(id);
            datoIdUsuario = id;
            LabelNombre.Text = model.Nombre + " "+ model.Apellido;
            labelDI.Text = Convert.ToString (model.Di);
        }
        public string MonthName(int month)
        {
            DateTimeFormatInfo dtinfo = new CultureInfo("es-ES", false).DateTimeFormat;
            return dtinfo.GetMonthName(month);
        }
        private void ComboSuscripcion_SelectionChangeCommitted(object sender, EventArgs e)
        {
            llenarCamposSuscripcion();
        }
        public void llenarCamposSuscripcion()
        {
            SuscripcionModel model = new SuscripcionModel();
            int id = Convert.ToInt32(comboSuscripcion.SelectedValue.ToString());
            datoIdSuscripcion = id;
            model = model.ConsultarSuscripcion(id);
            //datoIdSuscripcion = model.Id;
            textValor.Text = model.Valor.ToString();
            textDias.Text = model.NumeroRutinas.ToString();
            DateTime fechaActual = DateTime.Now;
            labeFechaInicio.Text = fechaActual.ToString("dd") + " de " + MonthName(fechaActual.Month) + " del " + fechaActual.Year;
            fechaFinal = fechaActual.AddMonths(Convert.ToInt32(model.Plazo));
            if (model.NumeroRutinas==0)
            {

            }


            labeFechaFinal.Text = fechaFinal.ToString("dd") + " de " + MonthName(fechaFinal.Month) + " del " + fechaFinal.Year;
            textValorIngresado.Enabled = true;

            Operacion();
        }
        private void Operacion()
        {
            if (textValorIngresado.Text != "")
                textValorSobrante.Text = Convert.ToString(Convert.ToDouble(textValorIngresado.Text) - Convert.ToDouble(textValor.Text));
            else
                textValorSobrante.Text = "-" + textValor.Text;
        }
        private void llenarComboBox()
        {
            SuscripcionModel model = new SuscripcionModel();
            comboSuscripcion.ValueMember = "Id";
            comboSuscripcion.DisplayMember = "Nombre";
            comboSuscripcion.DataSource = model.ObtenerSuscripcion();

            comboSuscripcion.SelectedIndex = -1;
            comboSuscripcion.Text = "Seleccion una suscripcion...";
        }
        private void pagar()
        {
            System.DateTime date3 = new System.DateTime(2019, 10, 15, 0, 0, 0);
            CompraSuscripcionModel model = new CompraSuscripcionModel();
            model.Cliente = datoIdUsuario;
            model.Suscripcion = datoIdSuscripcion;
            model.Fecha = fechaFinal;
            model.NumeroRutinas = Convert.ToInt32(textDias.Text);
            model.GuardarCompraSuscripcion();
            this.Close();
            MessageBox.Show("Compra finalizada satisfactoriamente.");
        }

        private void BtnPagar_Click(object sender, EventArgs e)
        {
            if (Convert.ToDouble(textValorSobrante.Text) < 0 | comboSuscripcion.SelectedIndex == -1)
                MessageBox.Show("Erro el valor ingresado es menor al saldo de la suscripción");
            else
            pagar();
        }
        private void AbrirPanel(object FormHijo)
        {
            Form form = FormHijo as Form;
            AddOwnedForm(form);
            form.ShowDialog();

        }
        private void BtnIntegrantes_Click(object sender, EventArgs e)
        {
            ListaFamiliares a = new ListaFamiliares();
            AbrirPanel(a);
           
        }
    }
}
