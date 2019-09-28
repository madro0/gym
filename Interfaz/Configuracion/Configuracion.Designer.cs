namespace Gym.Interfaz.Configuracion
{
    partial class Configuracion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Configuracion));
            this.label4 = new System.Windows.Forms.Label();
            this.panelFondo = new System.Windows.Forms.Panel();
            this.btnNuevaSuscripcion = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnListaSuscripciones = new Bunifu.Framework.UI.BunifuFlatButton();
            this.tablaPrueba = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelFondo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaPrueba)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(64, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "Suscripciones";
            // 
            // panelFondo
            // 
            this.panelFondo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelFondo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelFondo.BackgroundImage")));
            this.panelFondo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelFondo.Controls.Add(this.label4);
            this.panelFondo.Controls.Add(this.btnNuevaSuscripcion);
            this.panelFondo.Controls.Add(this.btnListaSuscripciones);
            this.panelFondo.Location = new System.Drawing.Point(32, 12);
            this.panelFondo.Name = "panelFondo";
            this.panelFondo.Size = new System.Drawing.Size(734, 114);
            this.panelFondo.TabIndex = 17;
            // 
            // btnNuevaSuscripcion
            // 
            this.btnNuevaSuscripcion.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(115)))), ((int)(((byte)(69)))));
            this.btnNuevaSuscripcion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNuevaSuscripcion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(115)))), ((int)(((byte)(69)))));
            this.btnNuevaSuscripcion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNuevaSuscripcion.BorderRadius = 7;
            this.btnNuevaSuscripcion.ButtonText = "Nueva Suscripcion";
            this.btnNuevaSuscripcion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevaSuscripcion.DisabledColor = System.Drawing.Color.Gray;
            this.btnNuevaSuscripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevaSuscripcion.Iconcolor = System.Drawing.Color.Transparent;
            this.btnNuevaSuscripcion.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnNuevaSuscripcion.Iconimage")));
            this.btnNuevaSuscripcion.Iconimage_right = null;
            this.btnNuevaSuscripcion.Iconimage_right_Selected = null;
            this.btnNuevaSuscripcion.Iconimage_Selected = null;
            this.btnNuevaSuscripcion.IconMarginLeft = 0;
            this.btnNuevaSuscripcion.IconMarginRight = 0;
            this.btnNuevaSuscripcion.IconRightVisible = true;
            this.btnNuevaSuscripcion.IconRightZoom = 0D;
            this.btnNuevaSuscripcion.IconVisible = true;
            this.btnNuevaSuscripcion.IconZoom = 60D;
            this.btnNuevaSuscripcion.IsTab = false;
            this.btnNuevaSuscripcion.Location = new System.Drawing.Point(324, 56);
            this.btnNuevaSuscripcion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnNuevaSuscripcion.Name = "btnNuevaSuscripcion";
            this.btnNuevaSuscripcion.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(115)))), ((int)(((byte)(69)))));
            this.btnNuevaSuscripcion.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(115)))), ((int)(((byte)(69)))));
            this.btnNuevaSuscripcion.OnHoverTextColor = System.Drawing.Color.White;
            this.btnNuevaSuscripcion.selected = false;
            this.btnNuevaSuscripcion.Size = new System.Drawing.Size(189, 37);
            this.btnNuevaSuscripcion.TabIndex = 14;
            this.btnNuevaSuscripcion.Text = "Nueva Suscripcion";
            this.btnNuevaSuscripcion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevaSuscripcion.Textcolor = System.Drawing.Color.White;
            this.btnNuevaSuscripcion.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevaSuscripcion.Click += new System.EventHandler(this.BtnNuevaSuscripcion_Click);
            // 
            // btnListaSuscripciones
            // 
            this.btnListaSuscripciones.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(104)))), ((int)(((byte)(185)))));
            this.btnListaSuscripciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnListaSuscripciones.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnListaSuscripciones.BorderRadius = 7;
            this.btnListaSuscripciones.ButtonText = "Suscripciones";
            this.btnListaSuscripciones.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnListaSuscripciones.DisabledColor = System.Drawing.Color.Gray;
            this.btnListaSuscripciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListaSuscripciones.Iconcolor = System.Drawing.Color.Transparent;
            this.btnListaSuscripciones.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnListaSuscripciones.Iconimage")));
            this.btnListaSuscripciones.Iconimage_right = null;
            this.btnListaSuscripciones.Iconimage_right_Selected = null;
            this.btnListaSuscripciones.Iconimage_Selected = null;
            this.btnListaSuscripciones.IconMarginLeft = 0;
            this.btnListaSuscripciones.IconMarginRight = 0;
            this.btnListaSuscripciones.IconRightVisible = true;
            this.btnListaSuscripciones.IconRightZoom = 0D;
            this.btnListaSuscripciones.IconVisible = true;
            this.btnListaSuscripciones.IconZoom = 30D;
            this.btnListaSuscripciones.IsTab = false;
            this.btnListaSuscripciones.Location = new System.Drawing.Point(68, 56);
            this.btnListaSuscripciones.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnListaSuscripciones.Name = "btnListaSuscripciones";
            this.btnListaSuscripciones.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnListaSuscripciones.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnListaSuscripciones.OnHoverTextColor = System.Drawing.Color.White;
            this.btnListaSuscripciones.selected = false;
            this.btnListaSuscripciones.Size = new System.Drawing.Size(151, 37);
            this.btnListaSuscripciones.TabIndex = 13;
            this.btnListaSuscripciones.Text = "Suscripciones";
            this.btnListaSuscripciones.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnListaSuscripciones.Textcolor = System.Drawing.Color.White;
            this.btnListaSuscripciones.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListaSuscripciones.Click += new System.EventHandler(this.BtnListaSuscripciones_Click);
            // 
            // tablaPrueba
            // 
            this.tablaPrueba.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaPrueba.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.nombre,
            this.numero});
            this.tablaPrueba.Location = new System.Drawing.Point(415, 200);
            this.tablaPrueba.Name = "tablaPrueba";
            this.tablaPrueba.Size = new System.Drawing.Size(240, 150);
            this.tablaPrueba.TabIndex = 18;
            this.tablaPrueba.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tablaPrueba_CellContentClick);
            // 
            // id
            // 
            this.id.HeaderText = "Column1";
            this.id.Name = "id";
            // 
            // nombre
            // 
            this.nombre.HeaderText = "Column1";
            this.nombre.Name = "nombre";
            // 
            // numero
            // 
            this.numero.HeaderText = "Column1";
            this.numero.Name = "numero";
            // 
            // Configuracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tablaPrueba);
            this.Controls.Add(this.panelFondo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Configuracion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configuracion";
            this.Load += new System.EventHandler(this.Configuracion_Load);
            this.panelFondo.ResumeLayout(false);
            this.panelFondo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaPrueba)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panelFondo;
        private Bunifu.Framework.UI.BunifuFlatButton btnNuevaSuscripcion;
        private Bunifu.Framework.UI.BunifuFlatButton btnListaSuscripciones;
        private System.Windows.Forms.DataGridView tablaPrueba;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn numero;
    }
}