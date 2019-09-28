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

namespace Gym.Interfaz.Asistencia
{
    public partial class Identificacion : Form
    {
        public Identificacion()
        {
            InitializeComponent();
        }
        private int IdCliente;

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void HoraFechaPanel_Tick(object sender, EventArgs e)
        {
            Time();
        }

        private string MonthName(int month)
        {
            DateTimeFormatInfo dtinfo = new CultureInfo("es-ES", false).DateTimeFormat;
            return dtinfo.GetMonthName(month);
        }
        private void Time()
        {
            DateTime fechaActual = DateTime.Now;

            labelHora.Text = fechaActual.ToString("h:mm") + " " + DateTime.Now.AddHours(12).ToString("tt", CultureInfo.InvariantCulture);
            labelFecha.Text = fechaActual.ToString("dd") + " de " + MonthName(fechaActual.Month) + " del " + fechaActual.Year;
        }
        public void ConsultarUsuario(int id)
        {
            IdCliente = id;
            UsuarioModel model = new UsuarioModel();
            model = model.ConsultarUsuario(id);
            LabelNombre.Text = model.Nombre + " "+ model.Apellido;
            labelDI.Text = model.Di.ToString();
        }

        private void Identificacion_Load(object sender, EventArgs e)
        {
            TieneONoNumeroRutinas();
        }
        private void TieneONoNumeroRutinas()
        {
            SuscripcionUsuarioModel CNR = new SuscripcionUsuarioModel();
            int NumeroDiasDisponibles = Convert.ToInt32(CNR.ConsultarNumeroRutinas(IdCliente));
            if (NumeroDiasDisponibles > 0)
            {
                panelAdvertencia.BackColor = Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(194)))), ((int)(((byte)(89)))));
                textDiasDisponibles.Text = NumeroDiasDisponibles.ToString();
                btnConfirmar.Visible = true;
                labelConfirmar.Visible = true;
            }
            else
            {
                panelAdvertencia.BackColor = Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(135)))), ((int)(((byte)(125)))));
                textDiasDisponibles.Text = ""+0;
                btnConfirmar.Visible = false;
                labelConfirmar.Visible = false;
            }

        }
        private void ConfirmarAsistencia()
        {
            llenarReporteHistorial();


            TieneONoNumeroRutinas();
        }
        private void llenarReporteHistorial()
        {
            SuscripcionUsuarioModel model = new SuscripcionUsuarioModel();
            
            foreach (var item in model.RestarNumeroRutinas(IdCliente))
            {
                model.id = item.id;
                model.NumeroRutinas = item.NumeroRutinas;
            }
            HistorialReporteAsistenciaModel hram = new HistorialReporteAsistenciaModel();
            DateTime fecha = DateTime.Now;
            hram.IdSuscripcionUsuario = model.id;
            hram.Fecha = fecha;
            hram.NumeroDeRutina = model.NumeroRutinas+1;
            hram.GuardarReporteAsistencia();

        }

        private void BtnConfirmar_Click(object sender, EventArgs e)
        {
            ConfirmarAsistencia();
        }
    }
}
