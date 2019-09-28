namespace Gym
{
    partial class Index
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Bunifu.Framework.UI.BunifuGradientPanel menuInterno;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Index));
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            BunifuAnimatorNS.Animation animation2 = new BunifuAnimatorNS.Animation();
            this.btnConfiguraciones = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnEstadisticas = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnSuscripciones = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnAsistencia = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnUsuarios = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton6 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lineaUsuario = new Bunifu.Framework.UI.BunifuSeparator();
            this.lineaTitulo = new Bunifu.Framework.UI.BunifuSeparator();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panelTop = new System.Windows.Forms.Panel();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.btnRestaurar = new System.Windows.Forms.PictureBox();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.btnMaximizar = new System.Windows.Forms.PictureBox();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panelPrincipal = new System.Windows.Forms.Panel();
            this.animacionIda = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.buelta = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.moverFormIndex = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            menuInterno = new Bunifu.Framework.UI.BunifuGradientPanel();
            menuInterno.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panelMenu.SuspendLayout();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRestaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).BeginInit();
            this.SuspendLayout();
            // 
            // menuInterno
            // 
            menuInterno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(32)))), ((int)(((byte)(34)))));
            menuInterno.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("menuInterno.BackgroundImage")));
            menuInterno.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            menuInterno.Controls.Add(this.btnConfiguraciones);
            menuInterno.Controls.Add(this.btnEstadisticas);
            menuInterno.Controls.Add(this.btnSuscripciones);
            menuInterno.Controls.Add(this.btnAsistencia);
            menuInterno.Controls.Add(this.btnUsuarios);
            menuInterno.Controls.Add(this.bunifuFlatButton6);
            menuInterno.Controls.Add(this.label2);
            menuInterno.Controls.Add(this.pictureBox2);
            menuInterno.Controls.Add(this.lineaUsuario);
            menuInterno.Controls.Add(this.lineaTitulo);
            this.buelta.SetDecoration(menuInterno, BunifuAnimatorNS.DecorationType.None);
            this.animacionIda.SetDecoration(menuInterno, BunifuAnimatorNS.DecorationType.None);
            menuInterno.Dock = System.Windows.Forms.DockStyle.Left;
            menuInterno.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(32)))), ((int)(((byte)(34)))));
            menuInterno.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(32)))), ((int)(((byte)(34)))));
            menuInterno.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(32)))), ((int)(((byte)(34)))));
            menuInterno.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(32)))), ((int)(((byte)(34)))));
            menuInterno.Location = new System.Drawing.Point(0, 0);
            menuInterno.Name = "menuInterno";
            menuInterno.Quality = 10;
            menuInterno.Size = new System.Drawing.Size(300, 610);
            menuInterno.TabIndex = 0;
            // 
            // btnConfiguraciones
            // 
            this.btnConfiguraciones.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.btnConfiguraciones.BackColor = System.Drawing.Color.Transparent;
            this.btnConfiguraciones.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnConfiguraciones.BorderRadius = 0;
            this.btnConfiguraciones.ButtonText = "      Configuración";
            this.btnConfiguraciones.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animacionIda.SetDecoration(this.btnConfiguraciones, BunifuAnimatorNS.DecorationType.None);
            this.buelta.SetDecoration(this.btnConfiguraciones, BunifuAnimatorNS.DecorationType.None);
            this.btnConfiguraciones.DisabledColor = System.Drawing.Color.Gray;
            this.btnConfiguraciones.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfiguraciones.Iconcolor = System.Drawing.Color.Transparent;
            this.btnConfiguraciones.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnConfiguraciones.Iconimage")));
            this.btnConfiguraciones.Iconimage_right = null;
            this.btnConfiguraciones.Iconimage_right_Selected = null;
            this.btnConfiguraciones.Iconimage_Selected = null;
            this.btnConfiguraciones.IconMarginLeft = 0;
            this.btnConfiguraciones.IconMarginRight = 0;
            this.btnConfiguraciones.IconRightVisible = true;
            this.btnConfiguraciones.IconRightZoom = 0D;
            this.btnConfiguraciones.IconVisible = true;
            this.btnConfiguraciones.IconZoom = 90D;
            this.btnConfiguraciones.IsTab = true;
            this.btnConfiguraciones.Location = new System.Drawing.Point(13, 478);
            this.btnConfiguraciones.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnConfiguraciones.Name = "btnConfiguraciones";
            this.btnConfiguraciones.Normalcolor = System.Drawing.Color.Transparent;
            this.btnConfiguraciones.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.btnConfiguraciones.OnHoverTextColor = System.Drawing.Color.White;
            this.btnConfiguraciones.selected = false;
            this.btnConfiguraciones.Size = new System.Drawing.Size(270, 46);
            this.btnConfiguraciones.TabIndex = 19;
            this.btnConfiguraciones.Text = "      Configuración";
            this.btnConfiguraciones.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfiguraciones.Textcolor = System.Drawing.Color.White;
            this.btnConfiguraciones.TextFont = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfiguraciones.Click += new System.EventHandler(this.BtnConfiguraciones_Click);
            // 
            // btnEstadisticas
            // 
            this.btnEstadisticas.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.btnEstadisticas.BackColor = System.Drawing.Color.Transparent;
            this.btnEstadisticas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEstadisticas.BorderRadius = 0;
            this.btnEstadisticas.ButtonText = "      Estadisticas";
            this.btnEstadisticas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animacionIda.SetDecoration(this.btnEstadisticas, BunifuAnimatorNS.DecorationType.None);
            this.buelta.SetDecoration(this.btnEstadisticas, BunifuAnimatorNS.DecorationType.None);
            this.btnEstadisticas.DisabledColor = System.Drawing.Color.Gray;
            this.btnEstadisticas.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEstadisticas.Iconcolor = System.Drawing.Color.Transparent;
            this.btnEstadisticas.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnEstadisticas.Iconimage")));
            this.btnEstadisticas.Iconimage_right = null;
            this.btnEstadisticas.Iconimage_right_Selected = null;
            this.btnEstadisticas.Iconimage_Selected = null;
            this.btnEstadisticas.IconMarginLeft = 0;
            this.btnEstadisticas.IconMarginRight = 0;
            this.btnEstadisticas.IconRightVisible = true;
            this.btnEstadisticas.IconRightZoom = 0D;
            this.btnEstadisticas.IconVisible = true;
            this.btnEstadisticas.IconZoom = 90D;
            this.btnEstadisticas.IsTab = true;
            this.btnEstadisticas.Location = new System.Drawing.Point(13, 421);
            this.btnEstadisticas.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEstadisticas.Name = "btnEstadisticas";
            this.btnEstadisticas.Normalcolor = System.Drawing.Color.Transparent;
            this.btnEstadisticas.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.btnEstadisticas.OnHoverTextColor = System.Drawing.Color.White;
            this.btnEstadisticas.selected = false;
            this.btnEstadisticas.Size = new System.Drawing.Size(270, 46);
            this.btnEstadisticas.TabIndex = 18;
            this.btnEstadisticas.Text = "      Estadisticas";
            this.btnEstadisticas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEstadisticas.Textcolor = System.Drawing.Color.White;
            this.btnEstadisticas.TextFont = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEstadisticas.Click += new System.EventHandler(this.BtnEstadisticas_Click);
            // 
            // btnSuscripciones
            // 
            this.btnSuscripciones.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.btnSuscripciones.BackColor = System.Drawing.Color.Transparent;
            this.btnSuscripciones.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSuscripciones.BorderRadius = 0;
            this.btnSuscripciones.ButtonText = "      Suscripciones";
            this.btnSuscripciones.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animacionIda.SetDecoration(this.btnSuscripciones, BunifuAnimatorNS.DecorationType.None);
            this.buelta.SetDecoration(this.btnSuscripciones, BunifuAnimatorNS.DecorationType.None);
            this.btnSuscripciones.DisabledColor = System.Drawing.Color.Gray;
            this.btnSuscripciones.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuscripciones.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSuscripciones.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnSuscripciones.Iconimage")));
            this.btnSuscripciones.Iconimage_right = null;
            this.btnSuscripciones.Iconimage_right_Selected = null;
            this.btnSuscripciones.Iconimage_Selected = null;
            this.btnSuscripciones.IconMarginLeft = 0;
            this.btnSuscripciones.IconMarginRight = 0;
            this.btnSuscripciones.IconRightVisible = true;
            this.btnSuscripciones.IconRightZoom = 0D;
            this.btnSuscripciones.IconVisible = true;
            this.btnSuscripciones.IconZoom = 90D;
            this.btnSuscripciones.IsTab = true;
            this.btnSuscripciones.Location = new System.Drawing.Point(13, 364);
            this.btnSuscripciones.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSuscripciones.Name = "btnSuscripciones";
            this.btnSuscripciones.Normalcolor = System.Drawing.Color.Transparent;
            this.btnSuscripciones.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.btnSuscripciones.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSuscripciones.selected = false;
            this.btnSuscripciones.Size = new System.Drawing.Size(270, 46);
            this.btnSuscripciones.TabIndex = 17;
            this.btnSuscripciones.Text = "      Suscripciones";
            this.btnSuscripciones.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSuscripciones.Textcolor = System.Drawing.Color.White;
            this.btnSuscripciones.TextFont = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuscripciones.Click += new System.EventHandler(this.BtnSuscripciones_Click);
            // 
            // btnAsistencia
            // 
            this.btnAsistencia.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.btnAsistencia.BackColor = System.Drawing.Color.Transparent;
            this.btnAsistencia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAsistencia.BorderRadius = 0;
            this.btnAsistencia.ButtonText = "      Asistencia";
            this.btnAsistencia.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animacionIda.SetDecoration(this.btnAsistencia, BunifuAnimatorNS.DecorationType.None);
            this.buelta.SetDecoration(this.btnAsistencia, BunifuAnimatorNS.DecorationType.None);
            this.btnAsistencia.DisabledColor = System.Drawing.Color.Gray;
            this.btnAsistencia.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAsistencia.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAsistencia.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnAsistencia.Iconimage")));
            this.btnAsistencia.Iconimage_right = null;
            this.btnAsistencia.Iconimage_right_Selected = null;
            this.btnAsistencia.Iconimage_Selected = null;
            this.btnAsistencia.IconMarginLeft = 0;
            this.btnAsistencia.IconMarginRight = 0;
            this.btnAsistencia.IconRightVisible = true;
            this.btnAsistencia.IconRightZoom = 0D;
            this.btnAsistencia.IconVisible = true;
            this.btnAsistencia.IconZoom = 90D;
            this.btnAsistencia.IsTab = true;
            this.btnAsistencia.Location = new System.Drawing.Point(13, 307);
            this.btnAsistencia.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAsistencia.Name = "btnAsistencia";
            this.btnAsistencia.Normalcolor = System.Drawing.Color.Transparent;
            this.btnAsistencia.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.btnAsistencia.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAsistencia.selected = false;
            this.btnAsistencia.Size = new System.Drawing.Size(270, 46);
            this.btnAsistencia.TabIndex = 16;
            this.btnAsistencia.Text = "      Asistencia";
            this.btnAsistencia.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAsistencia.Textcolor = System.Drawing.Color.White;
            this.btnAsistencia.TextFont = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAsistencia.Click += new System.EventHandler(this.BtnAsistencia_Click);
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.btnUsuarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.btnUsuarios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUsuarios.BorderRadius = 0;
            this.btnUsuarios.ButtonText = "      Usuarios";
            this.btnUsuarios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animacionIda.SetDecoration(this.btnUsuarios, BunifuAnimatorNS.DecorationType.None);
            this.buelta.SetDecoration(this.btnUsuarios, BunifuAnimatorNS.DecorationType.None);
            this.btnUsuarios.DisabledColor = System.Drawing.Color.Gray;
            this.btnUsuarios.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsuarios.Iconcolor = System.Drawing.Color.Transparent;
            this.btnUsuarios.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnUsuarios.Iconimage")));
            this.btnUsuarios.Iconimage_right = null;
            this.btnUsuarios.Iconimage_right_Selected = null;
            this.btnUsuarios.Iconimage_Selected = null;
            this.btnUsuarios.IconMarginLeft = 0;
            this.btnUsuarios.IconMarginRight = 0;
            this.btnUsuarios.IconRightVisible = true;
            this.btnUsuarios.IconRightZoom = 0D;
            this.btnUsuarios.IconVisible = true;
            this.btnUsuarios.IconZoom = 90D;
            this.btnUsuarios.IsTab = true;
            this.btnUsuarios.Location = new System.Drawing.Point(13, 250);
            this.btnUsuarios.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Normalcolor = System.Drawing.Color.Transparent;
            this.btnUsuarios.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.btnUsuarios.OnHoverTextColor = System.Drawing.Color.White;
            this.btnUsuarios.selected = true;
            this.btnUsuarios.Size = new System.Drawing.Size(270, 46);
            this.btnUsuarios.TabIndex = 15;
            this.btnUsuarios.Text = "      Usuarios";
            this.btnUsuarios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsuarios.Textcolor = System.Drawing.Color.White;
            this.btnUsuarios.TextFont = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsuarios.Click += new System.EventHandler(this.BtnUsuarios_Click);
            // 
            // bunifuFlatButton6
            // 
            this.bunifuFlatButton6.Activecolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton6.BackColor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton6.BorderRadius = 0;
            this.bunifuFlatButton6.ButtonText = "          GYM";
            this.bunifuFlatButton6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animacionIda.SetDecoration(this.bunifuFlatButton6, BunifuAnimatorNS.DecorationType.None);
            this.buelta.SetDecoration(this.bunifuFlatButton6, BunifuAnimatorNS.DecorationType.None);
            this.bunifuFlatButton6.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton6.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton6.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton6.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton6.Iconimage")));
            this.bunifuFlatButton6.Iconimage_right = null;
            this.bunifuFlatButton6.Iconimage_right_Selected = null;
            this.bunifuFlatButton6.Iconimage_Selected = null;
            this.bunifuFlatButton6.IconMarginLeft = 1;
            this.bunifuFlatButton6.IconMarginRight = 0;
            this.bunifuFlatButton6.IconRightVisible = true;
            this.bunifuFlatButton6.IconRightZoom = 0D;
            this.bunifuFlatButton6.IconVisible = true;
            this.bunifuFlatButton6.IconZoom = 90D;
            this.bunifuFlatButton6.IsTab = true;
            this.bunifuFlatButton6.Location = new System.Drawing.Point(16, 16);
            this.bunifuFlatButton6.Margin = new System.Windows.Forms.Padding(7);
            this.bunifuFlatButton6.Name = "bunifuFlatButton6";
            this.bunifuFlatButton6.Normalcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton6.OnHovercolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton6.OnHoverTextColor = System.Drawing.SystemColors.Window;
            this.bunifuFlatButton6.selected = false;
            this.bunifuFlatButton6.Size = new System.Drawing.Size(240, 42);
            this.bunifuFlatButton6.TabIndex = 14;
            this.bunifuFlatButton6.Text = "          GYM";
            this.bunifuFlatButton6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton6.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton6.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton6.Click += new System.EventHandler(this.BunifuFlatButton6_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.animacionIda.SetDecoration(this.label2, BunifuAnimatorNS.DecorationType.None);
            this.buelta.SetDecoration(this.label2, BunifuAnimatorNS.DecorationType.None);
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(116, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Madro";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.animacionIda.SetDecoration(this.pictureBox2, BunifuAnimatorNS.DecorationType.None);
            this.buelta.SetDecoration(this.pictureBox2, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(104, 81);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(80, 80);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // lineaUsuario
            // 
            this.lineaUsuario.BackColor = System.Drawing.Color.Transparent;
            this.buelta.SetDecoration(this.lineaUsuario, BunifuAnimatorNS.DecorationType.None);
            this.animacionIda.SetDecoration(this.lineaUsuario, BunifuAnimatorNS.DecorationType.None);
            this.lineaUsuario.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.lineaUsuario.LineThickness = 1;
            this.lineaUsuario.Location = new System.Drawing.Point(12, 193);
            this.lineaUsuario.Name = "lineaUsuario";
            this.lineaUsuario.Size = new System.Drawing.Size(270, 35);
            this.lineaUsuario.TabIndex = 5;
            this.lineaUsuario.Transparency = 255;
            this.lineaUsuario.Vertical = false;
            // 
            // lineaTitulo
            // 
            this.lineaTitulo.BackColor = System.Drawing.Color.Transparent;
            this.buelta.SetDecoration(this.lineaTitulo, BunifuAnimatorNS.DecorationType.None);
            this.animacionIda.SetDecoration(this.lineaTitulo, BunifuAnimatorNS.DecorationType.None);
            this.lineaTitulo.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.lineaTitulo.LineThickness = 1;
            this.lineaTitulo.Location = new System.Drawing.Point(12, 46);
            this.lineaTitulo.Name = "lineaTitulo";
            this.lineaTitulo.Size = new System.Drawing.Size(270, 35);
            this.lineaTitulo.TabIndex = 0;
            this.lineaTitulo.Transparency = 255;
            this.lineaTitulo.Vertical = false;
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.White;
            this.panelMenu.Controls.Add(menuInterno);
            this.buelta.SetDecoration(this.panelMenu, BunifuAnimatorNS.DecorationType.None);
            this.animacionIda.SetDecoration(this.panelMenu, BunifuAnimatorNS.DecorationType.None);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(300, 610);
            this.panelMenu.TabIndex = 1;
            this.panelMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelMenu_Paint);
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.panelTop.Controls.Add(this.btnCerrar);
            this.panelTop.Controls.Add(this.btnRestaurar);
            this.panelTop.Controls.Add(this.btnMinimizar);
            this.panelTop.Controls.Add(this.btnMaximizar);
            this.buelta.SetDecoration(this.panelTop, BunifuAnimatorNS.DecorationType.None);
            this.animacionIda.SetDecoration(this.panelTop, BunifuAnimatorNS.DecorationType.None);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelTop.ForeColor = System.Drawing.Color.White;
            this.panelTop.Location = new System.Drawing.Point(300, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(780, 46);
            this.panelTop.TabIndex = 2;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animacionIda.SetDecoration(this.btnCerrar, BunifuAnimatorNS.DecorationType.None);
            this.buelta.SetDecoration(this.btnCerrar, BunifuAnimatorNS.DecorationType.None);
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.Location = new System.Drawing.Point(738, 10);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(30, 30);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnCerrar.TabIndex = 4;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // btnRestaurar
            // 
            this.btnRestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRestaurar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animacionIda.SetDecoration(this.btnRestaurar, BunifuAnimatorNS.DecorationType.None);
            this.buelta.SetDecoration(this.btnRestaurar, BunifuAnimatorNS.DecorationType.None);
            this.btnRestaurar.Image = ((System.Drawing.Image)(resources.GetObject("btnRestaurar.Image")));
            this.btnRestaurar.Location = new System.Drawing.Point(705, 10);
            this.btnRestaurar.Name = "btnRestaurar";
            this.btnRestaurar.Size = new System.Drawing.Size(30, 30);
            this.btnRestaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnRestaurar.TabIndex = 3;
            this.btnRestaurar.TabStop = false;
            this.btnRestaurar.Visible = false;
            this.btnRestaurar.Click += new System.EventHandler(this.BtnRestaurar_Click);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animacionIda.SetDecoration(this.btnMinimizar, BunifuAnimatorNS.DecorationType.None);
            this.buelta.SetDecoration(this.btnMinimizar, BunifuAnimatorNS.DecorationType.None);
            this.btnMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimizar.Image")));
            this.btnMinimizar.Location = new System.Drawing.Point(672, 10);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(30, 30);
            this.btnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnMinimizar.TabIndex = 2;
            this.btnMinimizar.TabStop = false;
            this.btnMinimizar.Click += new System.EventHandler(this.BtnMinimizar_Click);
            // 
            // btnMaximizar
            // 
            this.btnMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animacionIda.SetDecoration(this.btnMaximizar, BunifuAnimatorNS.DecorationType.None);
            this.buelta.SetDecoration(this.btnMaximizar, BunifuAnimatorNS.DecorationType.None);
            this.btnMaximizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMaximizar.Image")));
            this.btnMaximizar.Location = new System.Drawing.Point(705, 10);
            this.btnMaximizar.Name = "btnMaximizar";
            this.btnMaximizar.Size = new System.Drawing.Size(30, 30);
            this.btnMaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnMaximizar.TabIndex = 1;
            this.btnMaximizar.TabStop = false;
            this.btnMaximizar.Click += new System.EventHandler(this.BtnMaximizar_Click);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 7;
            this.bunifuElipse1.TargetControl = this;
            // 
            // panelPrincipal
            // 
            this.panelPrincipal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(236)))), ((int)(((byte)(234)))));
            this.buelta.SetDecoration(this.panelPrincipal, BunifuAnimatorNS.DecorationType.None);
            this.animacionIda.SetDecoration(this.panelPrincipal, BunifuAnimatorNS.DecorationType.None);
            this.panelPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPrincipal.Location = new System.Drawing.Point(300, 46);
            this.panelPrincipal.Name = "panelPrincipal";
            this.panelPrincipal.Size = new System.Drawing.Size(780, 564);
            this.panelPrincipal.TabIndex = 3;
            // 
            // animacionIda
            // 
            this.animacionIda.AnimationType = BunifuAnimatorNS.AnimationType.HorizSlide;
            this.animacionIda.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.animacionIda.DefaultAnimation = animation1;
            // 
            // buelta
            // 
            this.buelta.AnimationType = BunifuAnimatorNS.AnimationType.Transparent;
            this.buelta.Cursor = null;
            animation2.AnimateOnlyDifferences = true;
            animation2.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.BlindCoeff")));
            animation2.LeafCoeff = 0F;
            animation2.MaxTime = 1F;
            animation2.MinTime = 0F;
            animation2.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicCoeff")));
            animation2.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicShift")));
            animation2.MosaicSize = 0;
            animation2.Padding = new System.Windows.Forms.Padding(0);
            animation2.RotateCoeff = 0F;
            animation2.RotateLimit = 0F;
            animation2.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.ScaleCoeff")));
            animation2.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.SlideCoeff")));
            animation2.TimeCoeff = 0F;
            animation2.TransparencyCoeff = 1F;
            this.buelta.DefaultAnimation = animation2;
            // 
            // moverFormIndex
            // 
            this.moverFormIndex.Fixed = true;
            this.moverFormIndex.Horizontal = true;
            this.moverFormIndex.TargetControl = this.panelTop;
            this.moverFormIndex.Vertical = true;
            // 
            // Index
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 610);
            this.Controls.Add(this.panelPrincipal);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.panelMenu);
            this.buelta.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.animacionIda.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Index";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Index_Load);
            menuInterno.ResumeLayout(false);
            menuInterno.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panelMenu.ResumeLayout(false);
            this.panelTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRestaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.PictureBox btnMaximizar;
        private System.Windows.Forms.PictureBox btnMinimizar;
        private System.Windows.Forms.PictureBox btnRestaurar;
        private System.Windows.Forms.PictureBox btnCerrar;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Bunifu.Framework.UI.BunifuSeparator lineaUsuario;
        private Bunifu.Framework.UI.BunifuSeparator lineaTitulo;
        private BunifuAnimatorNS.BunifuTransition animacionIda;
        private BunifuAnimatorNS.BunifuTransition buelta;
        private Bunifu.Framework.UI.BunifuFlatButton btnUsuarios;
        private Bunifu.Framework.UI.BunifuFlatButton btnConfiguraciones;
        private Bunifu.Framework.UI.BunifuFlatButton btnEstadisticas;
        private Bunifu.Framework.UI.BunifuFlatButton btnSuscripciones;
        private Bunifu.Framework.UI.BunifuFlatButton btnAsistencia;
        private Bunifu.Framework.UI.BunifuDragControl moverFormIndex;
        public System.Windows.Forms.Panel panelPrincipal;
    }
}

