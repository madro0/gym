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

namespace Gym.Interfaz.Configuracion
{
    public partial class Configuracion : Form
    {
        public Configuracion()
        {
            InitializeComponent();
        }

        private void Configuracion_Load(object sender, EventArgs e)
        {
            CompraSuscripcionModel model = new CompraSuscripcionModel();
            DateTime s = DateTime.Today;
            /*foreach (var item in model.ConteoCompraSuscripciones())
            {
                tablaPrueba.Rows.Add(
                    Convert.ToString( item.Id),
                    Convert.ToString(item.NombreSuscripcion),
                    Convert.ToString (item.NumeroTotalDeCompras)
                    );
                

            }*/
            //tablaPrueba.DataSource= model.ConteoCompraSuscripciones();
            pruebota();
        }

        private void BtnListaSuscripciones_Click(object sender, EventArgs e)
        {
            ListaSuscripciones s = new ListaSuscripciones();
            s.ShowDialog();
        }

        private void BtnNuevaSuscripcion_Click(object sender, EventArgs e)
        {
            AgregarSuscripcion s = new AgregarSuscripcion();
            s.ShowDialog();
        }

        private void tablaPrueba_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void pruebota()
        {
            HistorialReporteAsistenciaModel model = new HistorialReporteAsistenciaModel();
            foreach (var item in model.ConteoHistorialReporteAsistencia())
            {
                tablaPrueba.Rows.Add(
                    Convert.ToString( item.Id),
                    Convert.ToString (item.NumeroDeRutina)
                  );
                

            }
        }
    }
}
