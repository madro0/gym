using Gym.Interfaz.Usuarios;
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

namespace Gym.Interfaz.Suscripciones
{
    public partial class ListaFamiliares : Form
    {
        public int ListaOTitular=-1;
        public int datoIdSeleccionado;
        public ListaFamiliares()
        {
            InitializeComponent();
        }
        

        private void ListaFamiliares_Load(object sender, EventArgs e)
        {
            UsuarioModel model = new UsuarioModel();


           foreach (var item in model.ObtenerUsuarios())
            {

                TablaUsuarios.Rows.Add(
                               Convert.ToString(item.Id),
                               Convert.ToString(item.Di),
                               Convert.ToString(item.Nombre),
                               Convert.ToString(item.Apellido),
                               (true)
                               );
               
            }
            //TablaUsuarios.AutoSizeRowsMode = DataGridViewAutoSizeColumnMode.Fill;
            TablaUsuarios.AllowUserToAddRows = true;
        }

        

        private void BtnCerrar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TablaUsuarios_DoubleClick(object sender, EventArgs e)
        {
            if (ListaOTitular==1)
            {
                LenarCampoComprador();
            }
            else {

                if (ListaOTitular == 2)
                    {
                        llenarListaIntegrantes();
                    }
            }
            this.Close();

        }
        //Eventos creados a mano
        
        public void llenarListaIntegrantes()
        {
            try
            {

                int id = Convert.ToInt32(TablaUsuarios.CurrentRow.Cells["id"].Value.ToString());
                int di = Convert.ToInt32(TablaUsuarios.CurrentRow.Cells["di"].Value.ToString());
                string nombre = TablaUsuarios.CurrentRow.Cells["nombre"].Value.ToString();
                string apellido = TablaUsuarios.CurrentRow.Cells["apellido"].Value.ToString();

                CompraSuscripcion Compra = Owner as CompraSuscripcion;

                Compra.LlenarLista(id, di, nombre, apellido);
                this.Close();

            }
            catch (Exception Ex)
            {
                MessageBox.Show("Error " + Ex);
            }
        }
        public void LenarCampoComprador()
        {
            int id = Convert.ToInt32(TablaUsuarios.CurrentRow.Cells["id"].Value.ToString());
            string nombre = TablaUsuarios.CurrentRow.Cells["nombre"].Value.ToString() +" "+ TablaUsuarios.CurrentRow.Cells["apellido"].Value.ToString(); ;
             
            CompraSuscripcion Compra = Owner as CompraSuscripcion;
            Compra.LlenarCamposComprador(id, nombre);
            
        }
        public void pregunta1()
        {
            ListaOTitular = 1;
            
        }
        public void pregunta2()
        {
            ListaOTitular = 2;
        }
    }
}
