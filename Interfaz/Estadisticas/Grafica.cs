using Gym.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gym.Interfaz.Estadisticas
{
    public partial class Grafica : Form
    {
        public Grafica()
        {
            InitializeComponent();
        }

        private void Grafica_Load(object sender, EventArgs e)
        {
            UsarFechas(false);


            //para usar despues
            DateTime s = DateTime.Today;
            DateTime dateValue;
            string dateString = "";
            //dateValue = DateTime.Parse(dateString);
            //
            //EstadisticaCompras("","");
            EstadisticasAsistencia();

        }

        
        private void PickerFechaInicial_onValueChanged(object sender, EventArgs e)
        {
           
            string dateString = pickerFechaInicial.Value.ToString("yyyy-MM-dd");
            string dateStringFinal = pickerFechaFinal.Value.ToString("yyyy-MM-dd");

            EstadisticaCompras(dateString, dateStringFinal);
        }
        private void PickerFechaFinal_onValueChanged(object sender, EventArgs e)
        {
            string dateStringInicial = pickerFechaInicial.Value.ToString("yyyy-MM-dd");

            string dateStringFinal = pickerFechaFinal.Value.ToString("yyyy-MM-dd");
            EstadisticaCompras(dateStringInicial, dateStringFinal);

        }



        private void BunifuSwitch1_Click(object sender, EventArgs e)
        {
            if (bunifuSwitch1.Value == false)
            {

                UsarFechas(false);
                EstadisticaCompras("","");
            }
            else
            {

                UsarFechas(true);
                DateTime s = DateTime.Today;
                EstadisticaCompras(s.ToString(), s.ToString());
            }
        }
        private void UsarFechas(Boolean variable)
        {
            pickerFechaInicial.Visible = variable;
            pickerFechaFinal.Visible = variable;
            labelDesde.Visible = variable;
            labelHasta.Visible = variable;
        }
        private void EstadisticaCompras(string inicial, string final)
        {
            CompraSuscripcionModel model = new CompraSuscripcionModel();
            
            ArrayList IdSuscripcion = new ArrayList();
            ArrayList NompreSuscripcion = new ArrayList();
            ArrayList NumeroTotalDeCompras = new ArrayList();
            
            foreach (var item in model.ConteoCompraSuscripciones(inicial, final))
            {
                IdSuscripcion.Add(item.Id);
                NompreSuscripcion.Add(item.NombreSuscripcion);
                NumeroTotalDeCompras.Add(item.NumeroTotalDeCompras);
                //chartProductoMasVendido.Series[0].Points.AddXY(item.NombreSuscripcion, item.NumeroTotalDeCompras);
            }
            chartProductoMasVendido.Series[0].Points.DataBindXY(NompreSuscripcion, NumeroTotalDeCompras);
        }
        private void EstadisticasAsistencia()
        {
            HistorialReporteAsistenciaModel model = new HistorialReporteAsistenciaModel();

            ArrayList NombreMes = new ArrayList();
            ArrayList Conteo = new ArrayList();
            foreach (var item in model.ConteoAsistenciaPorMesAño())
            {
                NombreMes.Add(item.NombreMes);
                Conteo.Add(item.Conteo);
            }
            chartProductoMasVendido.Series[0].Points.DataBindXY(NombreMes, Conteo);
        }

        
    }
}
