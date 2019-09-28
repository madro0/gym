using Gym.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gym.Interfaz.Suscripciones
{
    public partial class CompraSuscripcion : Form
    {
        private int datoIdUsuario = 0;
        private int datoIdSuscripcion = 0;
        private DateTime fechaFinal;
        private int NumeroIntegrantes = 0;

       
        public CompraSuscripcion()
        {
            InitializeComponent();
            
        }

        


        //Metodos creados a mano
        public void LlenarLista(int id, int di, string nombre, string apellido)
        {
            Boolean question = false;

            for (int i = 0; i < TablaUsuariosBeneficiarios.Rows.Count - 1; i++)
            {
                if (id == Convert.ToInt32(TablaUsuariosBeneficiarios.Rows[i].Cells["id"].Value.ToString()))
                {
                    question = true;
                }
            }

            if (question == true)
            {
                MessageBox.Show("Error, este usuario ya esta en lista");
            }
            else
            {
                    TablaUsuariosBeneficiarios.Rows.Add(
                    Convert.ToString(id),
                    Convert.ToString(di),
                    nombre,
                    apellido
                  );
            }
        }


        public string MonthName(int month)
        {
            DateTimeFormatInfo dtinfo = new CultureInfo("es-ES", false).DateTimeFormat;
            return dtinfo.GetMonthName(month);
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
            if (datoIdUsuario!=0)
            {
                //System.DateTime date3 = new System.DateTime(2019, 10, 15, 0, 0, 0);
                CompraSuscripcionModel model = new CompraSuscripcionModel();
                model.Cliente = datoIdUsuario;
                model.Suscripcion = datoIdSuscripcion;
                //model.Fecha = fechaFinal;
                model.Fecha = DateTime.Now;
                model.NumeroRutinas = 0; //Convert.ToInt32(textDias.Text);

                SuscripcionUsuarioModel modelSU = new SuscripcionUsuarioModel();
               
                //modelSU.Clientes = datoIdUsuario;
                modelSU.ListaClientes = AgregarListaUsuario();
                modelSU.NumeroRutinas = Convert.ToInt32(textDias.Text);
                modelSU.FechaVencimiento = fechaFinal;
                modelSU.CompraSuscripcion = model.GuardarCompraSuscripcion();

                modelSU.GuardarSuscripcionUsuario();


                MessageBox.Show("Compra finalizada satisfactoriamente.");

                limpiarCampos();
            }
            else
            {
                MessageBox.Show("Error, es necesario que selccione un comprador.");
            }
            
        }
        private List<int> AgregarListaUsuario()
        {
            List<int> a = new List<int>();
            for (int i = 0; i < TablaUsuariosBeneficiarios.Rows.Count - 1; i++)
            {
                a.Add(Convert.ToInt32(TablaUsuariosBeneficiarios.Rows[i].Cells["id"].Value.ToString()));
                
            }
            return a;
        }
        private void limpiarCampos()
        {
            comboSuscripcion.SelectedIndex = -1;
            comboSuscripcion.Text = "Seleccion una suscripcion...";

            for (int i = 0; i < TablaUsuariosBeneficiarios.Rows.Count - 1; i++)
            {
                TablaUsuariosBeneficiarios.Rows.Clear();
            }

            textDias.Text="";
            labeFechaInicio.Text = "";
            labeFechaFinal.Text = "";
            LabelNombreComprador.Text = "";
            textValor.Text = "";
            textValorIngresado.Text = "";
            textValorSobrante.Text = "";

            datoIdUsuario = 0;
            datoIdSuscripcion = 0;
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
            NumeroIntegrantes = model.NumeroIntegrantes;

            ActivarBtnMas();
           


            labeFechaFinal.Text = fechaFinal.ToString("dd") + " de " + MonthName(fechaFinal.Month) + " del " + fechaFinal.Year;
            textValorIngresado.Enabled = true;

            Operacion();
        }
        private void AbrirPanel(object FormHijo)
        {
            Form form = FormHijo as Form;
            AddOwnedForm(form);
            form.ShowDialog();

        }
        public void LlenarCamposComprador(int id, string nombre)
        {
            LabelNombreComprador.Text = nombre;
            datoIdUsuario = id;

        }
       
        //eventos Creados
        private void BunifuFlatButton1_Click(object sender, EventArgs e)
        {
            ListaFamiliares l = new ListaFamiliares();
            l.pregunta1();
            AbrirPanel(l);
        }
        private void ActivarBtnMas()
        {
            if (NumeroIntegrantes > TablaUsuariosBeneficiarios.Rows.Count - 1)
            {
                btnMasIntegrantes.Visible = true;
                btnDelete.Visible = true;
            }
            else
            {
                btnMasIntegrantes.Visible = false;
                
            }
            if (TablaUsuariosBeneficiarios.Rows.Count - 1 == 0)
            {
                btnDelete.Visible = false;
            }
            else
            {
                btnDelete.Visible = true;
            }


        }
        private void BtnIntegrantes_Click(object sender, EventArgs e)
        {
            ListaFamiliares l = new ListaFamiliares();
            l.pregunta2();
            AbrirPanel(l);
            ActivarBtnMas();
            
        }

        private void BtnPagar_Click(object sender, EventArgs e)
        {
            
            if (comboSuscripcion.SelectedIndex == -1 )
            {
                MessageBox.Show("No hay ningun valor seleccionado");
            }
            else
            {
                if (Convert.ToDouble(textValorSobrante.Text) < 0)
                    MessageBox.Show("Erro el valor ingresado es menor al saldo de la suscripción");
                else
                    pagar();
            }
           
            foreach (var item in AgregarListaUsuario())
            {
                MessageBox.Show("" + item);
                
            }

        }
        private void ComboSuscripcion_SelectionChangeCommitted(object sender, EventArgs e)
        {
            for (int i = 0; i < TablaUsuariosBeneficiarios.Rows.Count - 1; i++)
            {
                TablaUsuariosBeneficiarios.Rows.Clear();
            }

            llenarCamposSuscripcion();
            
        }

        private void TextValorIngresado_KeyUp(object sender, KeyEventArgs e)
        {
            Operacion();
        }
        private void CompraSuscripcion_Load(object sender, EventArgs e)
        {
            llenarComboBox();
        }



        private void BtnMasIntegrantes_MouseEnter(object sender, EventArgs e)
        {
            btnMasIntegrantes.BackColor = Color.Gainsboro;
        }

        private void BtnMasIntegrantes_MouseLeave(object sender, EventArgs e)
        {
            btnMasIntegrantes.BackColor = Color.Transparent;
        }

        private void BtnDelete_MouseEnter(object sender, EventArgs e)
        {
            btnDelete.BackColor = Color.Gainsboro;
        }

        private void BtnDelete_MouseLeave(object sender, EventArgs e)
        {
            btnDelete.BackColor = Color.Transparent;
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                TablaUsuariosBeneficiarios.Rows.Remove(TablaUsuariosBeneficiarios.CurrentRow);
                ActivarBtnMas();
            }
            catch (Exception)
            {
                MessageBox.Show("Seleccione un afila.");
            }
            
        }
    }
}
