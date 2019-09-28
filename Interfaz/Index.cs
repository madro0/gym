using Gym.Interfaz.Asistencia;
using Gym.Interfaz.Configuracion;
using Gym.Interfaz.Estadisticas;
using Gym.Interfaz.Suscripciones;
using Gym.Interfaz.Usuarios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gym
{
    public partial class Index : Form
    {
        public Index()
        {
            InitializeComponent();
            nombre = btnUsuarios;
        }
        private Bunifu.Framework.UI.BunifuFlatButton nombre;


        private void BtnMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
            
        }

        private void BtnMaximizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            btnMaximizar.Visible = false;
            btnRestaurar.Visible = true;

        }

        private void BtnRestaurar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
            btnRestaurar.Visible = false;
            btnMaximizar.Visible = true;
            nombre.selected = true;

        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void BunifuFlatButton6_Click_1(object sender, EventArgs e)
        {
           
            if (panelMenu.Width == 300)
            {
                panelMenu.Visible = false;
                panelMenu.Width = 80;
                //lineaUsuario.Visible = false;
                lineaTitulo.Width = 57;
                lineaUsuario.Width = 57;

               

                buelta.Show(panelMenu);
                
                
            }
            else
            {
                panelMenu.Visible = false;
                panelMenu.Width = 300;
                lineaUsuario.Visible = true;
                lineaTitulo.Width = 270;
                lineaUsuario.Width = 270;
                
                animacionIda.Show(panelMenu);
            }

            
        }
        public void AbrirPanel(object FormHijo)
        {
            if (this.panelPrincipal.Controls.Count > 0)
                this.panelPrincipal.Controls.RemoveAt(0);
            Form form = FormHijo as Form;
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            this.panelPrincipal.Controls.Add(form);
            this.panelPrincipal.Tag = form;
            form.Show();
        }
        public void BtnUsuarios_Click(object sender, EventArgs e)
        {
            AbrirPanel(new Usuarios());

            nombre = btnUsuarios;
        }

        private void BtnAsistencia_Click(object sender, EventArgs e)
        {
            AbrirPanel(new ListaUsuarios());
            nombre = btnAsistencia;
        }

       

        public void Index_Load(object sender, EventArgs e)
        {
            AbrirPanel(new Usuarios());
            
        }

        private void BtnSuscripciones_Click(object sender, EventArgs e)
        {
            //AbrirPanel(new NuevaSuscripcion());
            AbrirPanel(new CompraSuscripcion());
            nombre = btnSuscripciones;
        }

        private void BtnConfiguraciones_Click(object sender, EventArgs e)
        {
            AbrirPanel(new Configuracion());
            nombre = btnConfiguraciones;
        }

        private void PanelMenu_Paint(object sender, PaintEventArgs e)
        {
            nombre.selected = true;
        }

        private void BtnEstadisticas_Click(object sender, EventArgs e)
        {
            AbrirPanel(new Grafica());
            nombre = btnEstadisticas;
        }
    }
}
