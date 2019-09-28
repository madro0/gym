namespace Gym.Interfaz.Asistencia
{
    partial class ListaUsuarios
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListaUsuarios));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelFondo = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tablaUsuariosRegistrados = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.di = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TablaUsuarios = new System.Windows.Forms.DataGridView();
            this.panelTop = new System.Windows.Forms.Panel();
            this.btnNuevoUsuario = new Bunifu.Framework.UI.BunifuFlatButton();
            this.textBuscar = new System.Windows.Forms.TextBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.tarjetaAlerta1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.ElipseTarjeta1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.tarjetaAlerta2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bunifuSeparator2 = new Bunifu.Framework.UI.BunifuSeparator();
            this.tarjetaAlerta3 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.bunifuSeparator3 = new Bunifu.Framework.UI.BunifuSeparator();
            this.ElipseTarjeta2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.ElipseTarjeta3 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panelFondo.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaUsuariosRegistrados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TablaUsuarios)).BeginInit();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.tarjetaAlerta1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tarjetaAlerta2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tarjetaAlerta3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // panelFondo
            // 
            this.panelFondo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelFondo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelFondo.BackgroundImage")));
            this.panelFondo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelFondo.Controls.Add(this.panel1);
            this.panelFondo.Location = new System.Drawing.Point(177, 31);
            this.panelFondo.Name = "panelFondo";
            this.panelFondo.Size = new System.Drawing.Size(566, 374);
            this.panelFondo.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.tablaUsuariosRegistrados);
            this.panel1.Controls.Add(this.TablaUsuarios);
            this.panel1.Controls.Add(this.panelTop);
            this.panel1.Location = new System.Drawing.Point(3, 20);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(543, 338);
            this.panel1.TabIndex = 0;
            // 
            // tablaUsuariosRegistrados
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tablaUsuariosRegistrados.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.tablaUsuariosRegistrados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tablaUsuariosRegistrados.BackgroundColor = System.Drawing.Color.White;
            this.tablaUsuariosRegistrados.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tablaUsuariosRegistrados.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.tablaUsuariosRegistrados.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tablaUsuariosRegistrados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.tablaUsuariosRegistrados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaUsuariosRegistrados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.di,
            this.nombre,
            this.apellido,
            this.genero});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tablaUsuariosRegistrados.DefaultCellStyle = dataGridViewCellStyle3;
            this.tablaUsuariosRegistrados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablaUsuariosRegistrados.DoubleBuffered = true;
            this.tablaUsuariosRegistrados.EnableHeadersVisualStyles = false;
            this.tablaUsuariosRegistrados.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.tablaUsuariosRegistrados.HeaderBgColor = System.Drawing.Color.LightGray;
            this.tablaUsuariosRegistrados.HeaderForeColor = System.Drawing.Color.Black;
            this.tablaUsuariosRegistrados.Location = new System.Drawing.Point(0, 101);
            this.tablaUsuariosRegistrados.Name = "tablaUsuariosRegistrados";
            this.tablaUsuariosRegistrados.ReadOnly = true;
            this.tablaUsuariosRegistrados.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tablaUsuariosRegistrados.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.tablaUsuariosRegistrados.RowHeadersVisible = false;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tablaUsuariosRegistrados.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.tablaUsuariosRegistrados.RowTemplate.DividerHeight = 1;
            this.tablaUsuariosRegistrados.RowTemplate.Height = 50;
            this.tablaUsuariosRegistrados.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.tablaUsuariosRegistrados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tablaUsuariosRegistrados.Size = new System.Drawing.Size(543, 237);
            this.tablaUsuariosRegistrados.TabIndex = 5;
            // 
            // id
            // 
            this.id.HeaderText = "Id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // di
            // 
            this.di.HeaderText = "Di";
            this.di.Name = "di";
            this.di.ReadOnly = true;
            // 
            // nombre
            // 
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            // 
            // apellido
            // 
            this.apellido.HeaderText = "Apellido";
            this.apellido.Name = "apellido";
            this.apellido.ReadOnly = true;
            // 
            // genero
            // 
            this.genero.HeaderText = "Genero";
            this.genero.Name = "genero";
            this.genero.ReadOnly = true;
            // 
            // TablaUsuarios
            // 
            this.TablaUsuarios.BackgroundColor = System.Drawing.Color.White;
            this.TablaUsuarios.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TablaUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TablaUsuarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TablaUsuarios.Location = new System.Drawing.Point(0, 101);
            this.TablaUsuarios.Name = "TablaUsuarios";
            this.TablaUsuarios.Size = new System.Drawing.Size(543, 237);
            this.TablaUsuarios.TabIndex = 4;
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.btnNuevoUsuario);
            this.panelTop.Controls.Add(this.textBuscar);
            this.panelTop.Controls.Add(this.pictureBox4);
            this.panelTop.Controls.Add(this.pictureBox5);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(543, 101);
            this.panelTop.TabIndex = 3;
            // 
            // btnNuevoUsuario
            // 
            this.btnNuevoUsuario.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(50)))));
            this.btnNuevoUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNuevoUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(50)))));
            this.btnNuevoUsuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNuevoUsuario.BorderRadius = 7;
            this.btnNuevoUsuario.ButtonText = "Identifica";
            this.btnNuevoUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevoUsuario.DisabledColor = System.Drawing.Color.Gray;
            this.btnNuevoUsuario.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoUsuario.Iconcolor = System.Drawing.Color.Transparent;
            this.btnNuevoUsuario.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnNuevoUsuario.Iconimage")));
            this.btnNuevoUsuario.Iconimage_right = null;
            this.btnNuevoUsuario.Iconimage_right_Selected = null;
            this.btnNuevoUsuario.Iconimage_Selected = null;
            this.btnNuevoUsuario.IconMarginLeft = 0;
            this.btnNuevoUsuario.IconMarginRight = 0;
            this.btnNuevoUsuario.IconRightVisible = true;
            this.btnNuevoUsuario.IconRightZoom = 0D;
            this.btnNuevoUsuario.IconVisible = true;
            this.btnNuevoUsuario.IconZoom = 70D;
            this.btnNuevoUsuario.IsTab = false;
            this.btnNuevoUsuario.Location = new System.Drawing.Point(374, 35);
            this.btnNuevoUsuario.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNuevoUsuario.Name = "btnNuevoUsuario";
            this.btnNuevoUsuario.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(50)))));
            this.btnNuevoUsuario.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(50)))));
            this.btnNuevoUsuario.OnHoverTextColor = System.Drawing.Color.White;
            this.btnNuevoUsuario.selected = false;
            this.btnNuevoUsuario.Size = new System.Drawing.Size(126, 36);
            this.btnNuevoUsuario.TabIndex = 10;
            this.btnNuevoUsuario.Text = "Identifica";
            this.btnNuevoUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevoUsuario.Textcolor = System.Drawing.Color.White;
            this.btnNuevoUsuario.TextFont = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoUsuario.Click += new System.EventHandler(this.BtnNuevoUsuario_Click);
            // 
            // textBuscar
            // 
            this.textBuscar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBuscar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBuscar.ForeColor = System.Drawing.Color.DimGray;
            this.textBuscar.Location = new System.Drawing.Point(89, 45);
            this.textBuscar.Name = "textBuscar";
            this.textBuscar.Size = new System.Drawing.Size(185, 20);
            this.textBuscar.TabIndex = 9;
            this.textBuscar.Text = "Buscar";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(47, 43);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(25, 25);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 8;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(35, 39);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(249, 33);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 0;
            this.pictureBox5.TabStop = false;
            // 
            // tarjetaAlerta1
            // 
            this.tarjetaAlerta1.BackColor = System.Drawing.Color.White;
            this.tarjetaAlerta1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tarjetaAlerta1.BackgroundImage")));
            this.tarjetaAlerta1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tarjetaAlerta1.Controls.Add(this.pictureBox2);
            this.tarjetaAlerta1.Controls.Add(this.label5);
            this.tarjetaAlerta1.Controls.Add(this.label4);
            this.tarjetaAlerta1.Controls.Add(this.bunifuSeparator1);
            this.tarjetaAlerta1.Location = new System.Drawing.Point(21, 31);
            this.tarjetaAlerta1.Name = "tarjetaAlerta1";
            this.tarjetaAlerta1.Size = new System.Drawing.Size(137, 100);
            this.tarjetaAlerta1.TabIndex = 1;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(11, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(60, 60);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(76, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 36);
            this.label5.TabIndex = 2;
            this.label5.Text = "50";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "Usuarios Totales";
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(11, 60);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(114, 20);
            this.bunifuSeparator1.TabIndex = 0;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // ElipseTarjeta1
            // 
            this.ElipseTarjeta1.ElipseRadius = 10;
            this.ElipseTarjeta1.TargetControl = this.tarjetaAlerta1;
            // 
            // tarjetaAlerta2
            // 
            this.tarjetaAlerta2.BackColor = System.Drawing.Color.White;
            this.tarjetaAlerta2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tarjetaAlerta2.BackgroundImage")));
            this.tarjetaAlerta2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tarjetaAlerta2.Controls.Add(this.pictureBox1);
            this.tarjetaAlerta2.Controls.Add(this.label1);
            this.tarjetaAlerta2.Controls.Add(this.label2);
            this.tarjetaAlerta2.Controls.Add(this.bunifuSeparator2);
            this.tarjetaAlerta2.Location = new System.Drawing.Point(21, 155);
            this.tarjetaAlerta2.Name = "tarjetaAlerta2";
            this.tarjetaAlerta2.Size = new System.Drawing.Size(137, 100);
            this.tarjetaAlerta2.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(11, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(76, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 36);
            this.label1.TabIndex = 2;
            this.label1.Text = "50";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Usuarios Totales";
            // 
            // bunifuSeparator2
            // 
            this.bunifuSeparator2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator2.LineThickness = 1;
            this.bunifuSeparator2.Location = new System.Drawing.Point(11, 60);
            this.bunifuSeparator2.Name = "bunifuSeparator2";
            this.bunifuSeparator2.Size = new System.Drawing.Size(114, 20);
            this.bunifuSeparator2.TabIndex = 0;
            this.bunifuSeparator2.Transparency = 255;
            this.bunifuSeparator2.Vertical = false;
            // 
            // tarjetaAlerta3
            // 
            this.tarjetaAlerta3.BackColor = System.Drawing.Color.White;
            this.tarjetaAlerta3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tarjetaAlerta3.BackgroundImage")));
            this.tarjetaAlerta3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tarjetaAlerta3.Controls.Add(this.pictureBox3);
            this.tarjetaAlerta3.Controls.Add(this.label3);
            this.tarjetaAlerta3.Controls.Add(this.label6);
            this.tarjetaAlerta3.Controls.Add(this.bunifuSeparator3);
            this.tarjetaAlerta3.Location = new System.Drawing.Point(21, 279);
            this.tarjetaAlerta3.Name = "tarjetaAlerta3";
            this.tarjetaAlerta3.Size = new System.Drawing.Size(137, 100);
            this.tarjetaAlerta3.TabIndex = 9;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(11, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(60, 60);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 7;
            this.pictureBox3.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(76, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 36);
            this.label3.TabIndex = 2;
            this.label3.Text = "50";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(18, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 16);
            this.label6.TabIndex = 1;
            this.label6.Text = "Usuarios Totales";
            // 
            // bunifuSeparator3
            // 
            this.bunifuSeparator3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator3.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator3.LineThickness = 1;
            this.bunifuSeparator3.Location = new System.Drawing.Point(11, 60);
            this.bunifuSeparator3.Name = "bunifuSeparator3";
            this.bunifuSeparator3.Size = new System.Drawing.Size(114, 20);
            this.bunifuSeparator3.TabIndex = 0;
            this.bunifuSeparator3.Transparency = 255;
            this.bunifuSeparator3.Vertical = false;
            // 
            // ElipseTarjeta2
            // 
            this.ElipseTarjeta2.ElipseRadius = 10;
            this.ElipseTarjeta2.TargetControl = this.tarjetaAlerta2;
            // 
            // ElipseTarjeta3
            // 
            this.ElipseTarjeta3.ElipseRadius = 10;
            this.ElipseTarjeta3.TargetControl = this.tarjetaAlerta3;
            // 
            // ListaUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tarjetaAlerta3);
            this.Controls.Add(this.tarjetaAlerta2);
            this.Controls.Add(this.tarjetaAlerta1);
            this.Controls.Add(this.panelFondo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ListaUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ListaUsuarios";
            this.Load += new System.EventHandler(this.ListaUsuarios_Load);
            this.panelFondo.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tablaUsuariosRegistrados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TablaUsuarios)).EndInit();
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.tarjetaAlerta1.ResumeLayout(false);
            this.tarjetaAlerta1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.tarjetaAlerta2.ResumeLayout(false);
            this.tarjetaAlerta2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tarjetaAlerta3.ResumeLayout(false);
            this.tarjetaAlerta3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelFondo;
        private System.Windows.Forms.Panel tarjetaAlerta1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView TablaUsuarios;
        private System.Windows.Forms.Panel panelTop;
        private Bunifu.Framework.UI.BunifuFlatButton btnNuevoUsuario;
        private System.Windows.Forms.TextBox textBuscar;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private Bunifu.Framework.UI.BunifuElipse ElipseTarjeta1;
        private System.Windows.Forms.Panel tarjetaAlerta2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator2;
        private System.Windows.Forms.Panel tarjetaAlerta3;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator3;
        private Bunifu.Framework.UI.BunifuElipse ElipseTarjeta2;
        private Bunifu.Framework.UI.BunifuElipse ElipseTarjeta3;
        public Bunifu.Framework.UI.BunifuCustomDataGrid tablaUsuariosRegistrados;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn di;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn genero;
    }
}