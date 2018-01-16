namespace UI
{
    partial class VentanaPrincipal
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
            System.Windows.Forms.MenuStrip menuStrip1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentanaPrincipal));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.sesionToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.iniciarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.altaDeReservaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alojamientoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarServicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.listarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serviciosConsumidosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.movimientoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manualDeUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administracionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serviciosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tarifasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_Buscar = new System.Windows.Forms.Button();
            this.dtp_fechaHasta = new System.Windows.Forms.DateTimePicker();
            this.dtp_fechaDesde = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dGV_Alojamientos = new System.Windows.Forms.DataGridView();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_DNI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_Legajo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btn_VerDetalle = new System.Windows.Forms.Button();
            this.modificarAltaDeClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            menuStrip1 = new System.Windows.Forms.MenuStrip();
            menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Alojamientos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            menuStrip1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sesionToolStripMenuItem1,
            this.archivoToolStripMenuItem,
            this.alojamientoToolStripMenuItem,
            this.clienteToolStripMenuItem,
            this.buscarToolStripMenuItem,
            this.listarToolStripMenuItem,
            this.movimientoToolStripMenuItem,
            this.ayudaToolStripMenuItem,
            this.administracionToolStripMenuItem});
            menuStrip1.Location = new System.Drawing.Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.ShowItemToolTips = true;
            menuStrip1.Size = new System.Drawing.Size(1110, 32);
            menuStrip1.Stretch = false;
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // sesionToolStripMenuItem1
            // 
            this.sesionToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iniciarToolStripMenuItem,
            this.cerrarToolStripMenuItem});
            this.sesionToolStripMenuItem1.Name = "sesionToolStripMenuItem1";
            this.sesionToolStripMenuItem1.Size = new System.Drawing.Size(80, 28);
            this.sesionToolStripMenuItem1.Text = "Sesion";
            // 
            // iniciarToolStripMenuItem
            // 
            this.iniciarToolStripMenuItem.Image = global::UI.Properties.Resources.Boton_InicioSesion;
            this.iniciarToolStripMenuItem.Name = "iniciarToolStripMenuItem";
            this.iniciarToolStripMenuItem.Size = new System.Drawing.Size(132, 28);
            this.iniciarToolStripMenuItem.Text = "Iniciar";
            this.iniciarToolStripMenuItem.Click += new System.EventHandler(this.iniciarToolStripMenuItem_Click);
            // 
            // cerrarToolStripMenuItem
            // 
            this.cerrarToolStripMenuItem.Image = global::UI.Properties.Resources.Boton_CerrarSesion;
            this.cerrarToolStripMenuItem.Name = "cerrarToolStripMenuItem";
            this.cerrarToolStripMenuItem.Size = new System.Drawing.Size(132, 28);
            this.cerrarToolStripMenuItem.Text = "Cerrar";
            this.cerrarToolStripMenuItem.Click += new System.EventHandler(this.cerrarToolStripMenuItem_Click);
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoToolStripMenuItem1,
            this.altaDeReservaToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(91, 28);
            this.archivoToolStripMenuItem.Text = "Reserva";
            this.archivoToolStripMenuItem.Click += new System.EventHandler(this.archivoToolStripMenuItem_Click);
            // 
            // nuevoToolStripMenuItem1
            // 
            this.nuevoToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("nuevoToolStripMenuItem1.Image")));
            this.nuevoToolStripMenuItem1.Name = "nuevoToolStripMenuItem1";
            this.nuevoToolStripMenuItem1.Size = new System.Drawing.Size(212, 28);
            this.nuevoToolStripMenuItem1.Text = "Nuevo";
            this.nuevoToolStripMenuItem1.Click += new System.EventHandler(this.nuevoToolStripMenuItem1_Click);
            // 
            // altaDeReservaToolStripMenuItem
            // 
            this.altaDeReservaToolStripMenuItem.Name = "altaDeReservaToolStripMenuItem";
            this.altaDeReservaToolStripMenuItem.Size = new System.Drawing.Size(212, 28);
            this.altaDeReservaToolStripMenuItem.Text = "Alta de Reserva";
            this.altaDeReservaToolStripMenuItem.Click += new System.EventHandler(this.altaDeReservaToolStripMenuItem_Click);
            // 
            // alojamientoToolStripMenuItem
            // 
            this.alojamientoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoToolStripMenuItem,
            this.buscarToolStripMenuItem1,
            this.agregarServicioToolStripMenuItem,
            this.cerrarToolStripMenuItem1});
            this.alojamientoToolStripMenuItem.Name = "alojamientoToolStripMenuItem";
            this.alojamientoToolStripMenuItem.Size = new System.Drawing.Size(121, 28);
            this.alojamientoToolStripMenuItem.Text = "Alojamiento";
            // 
            // nuevoToolStripMenuItem
            // 
            this.nuevoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("nuevoToolStripMenuItem.Image")));
            this.nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            this.nuevoToolStripMenuItem.Size = new System.Drawing.Size(220, 28);
            this.nuevoToolStripMenuItem.Text = "Nuevo";
            this.nuevoToolStripMenuItem.Click += new System.EventHandler(this.nuevoToolStripMenuItem_Click);
            // 
            // buscarToolStripMenuItem1
            // 
            this.buscarToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("buscarToolStripMenuItem1.Image")));
            this.buscarToolStripMenuItem1.Name = "buscarToolStripMenuItem1";
            this.buscarToolStripMenuItem1.Size = new System.Drawing.Size(220, 28);
            this.buscarToolStripMenuItem1.Text = "Buscar";
            this.buscarToolStripMenuItem1.Click += new System.EventHandler(this.buscarToolStripMenuItem1_Click);
            // 
            // agregarServicioToolStripMenuItem
            // 
            this.agregarServicioToolStripMenuItem.Name = "agregarServicioToolStripMenuItem";
            this.agregarServicioToolStripMenuItem.Size = new System.Drawing.Size(220, 28);
            this.agregarServicioToolStripMenuItem.Text = "Agregar Servicio";
            this.agregarServicioToolStripMenuItem.Click += new System.EventHandler(this.agregarServicioToolStripMenuItem_Click);
            // 
            // cerrarToolStripMenuItem1
            // 
            this.cerrarToolStripMenuItem1.Name = "cerrarToolStripMenuItem1";
            this.cerrarToolStripMenuItem1.Size = new System.Drawing.Size(220, 28);
            this.cerrarToolStripMenuItem1.Text = "Cerrar";
            this.cerrarToolStripMenuItem1.Click += new System.EventHandler(this.cerrarToolStripMenuItem1_Click);
            // 
            // clienteToolStripMenuItem
            // 
            this.clienteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoToolStripMenuItem2,
            this.modificarAltaDeClienteToolStripMenuItem});
            this.clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            this.clienteToolStripMenuItem.Size = new System.Drawing.Size(80, 28);
            this.clienteToolStripMenuItem.Text = "Cliente";
            // 
            // nuevoToolStripMenuItem2
            // 
            this.nuevoToolStripMenuItem2.Image = global::UI.Properties.Resources.Boton_Agregar;
            this.nuevoToolStripMenuItem2.Name = "nuevoToolStripMenuItem2";
            this.nuevoToolStripMenuItem2.Size = new System.Drawing.Size(282, 28);
            this.nuevoToolStripMenuItem2.Text = "Nuevo";
            this.nuevoToolStripMenuItem2.Click += new System.EventHandler(this.nuevoToolStripMenuItem2_Click);
            // 
            // buscarToolStripMenuItem
            // 
            this.buscarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clienteToolStripMenuItem1});
            this.buscarToolStripMenuItem.Name = "buscarToolStripMenuItem";
            this.buscarToolStripMenuItem.Size = new System.Drawing.Size(80, 28);
            this.buscarToolStripMenuItem.Text = "Buscar";
            // 
            // clienteToolStripMenuItem1
            // 
            this.clienteToolStripMenuItem1.Image = global::UI.Properties.Resources.boton_buscar;
            this.clienteToolStripMenuItem1.Name = "clienteToolStripMenuItem1";
            this.clienteToolStripMenuItem1.Size = new System.Drawing.Size(138, 28);
            this.clienteToolStripMenuItem1.Text = "Cliente";
            this.clienteToolStripMenuItem1.Click += new System.EventHandler(this.clienteToolStripMenuItem1_Click);
            // 
            // listarToolStripMenuItem
            // 
            this.listarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.serviciosConsumidosToolStripMenuItem});
            this.listarToolStripMenuItem.Name = "listarToolStripMenuItem";
            this.listarToolStripMenuItem.Size = new System.Drawing.Size(65, 28);
            this.listarToolStripMenuItem.Text = "Listar";
            // 
            // serviciosConsumidosToolStripMenuItem
            // 
            this.serviciosConsumidosToolStripMenuItem.Name = "serviciosConsumidosToolStripMenuItem";
            this.serviciosConsumidosToolStripMenuItem.Size = new System.Drawing.Size(267, 28);
            this.serviciosConsumidosToolStripMenuItem.Text = "Servicios Consumidos";
            this.serviciosConsumidosToolStripMenuItem.Click += new System.EventHandler(this.serviciosConsumidosToolStripMenuItem_Click);
            // 
            // movimientoToolStripMenuItem
            // 
            this.movimientoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoToolStripMenuItem3});
            this.movimientoToolStripMenuItem.Name = "movimientoToolStripMenuItem";
            this.movimientoToolStripMenuItem.Size = new System.Drawing.Size(66, 28);
            this.movimientoToolStripMenuItem.Text = "Pago";
            // 
            // nuevoToolStripMenuItem3
            // 
            this.nuevoToolStripMenuItem3.Name = "nuevoToolStripMenuItem3";
            this.nuevoToolStripMenuItem3.Size = new System.Drawing.Size(136, 28);
            this.nuevoToolStripMenuItem3.Text = "Nuevo";
            this.nuevoToolStripMenuItem3.Click += new System.EventHandler(this.nuevoToolStripMenuItem3_Click);
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manualDeUsuarioToolStripMenuItem});
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(76, 28);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // manualDeUsuarioToolStripMenuItem
            // 
            this.manualDeUsuarioToolStripMenuItem.Name = "manualDeUsuarioToolStripMenuItem";
            this.manualDeUsuarioToolStripMenuItem.Size = new System.Drawing.Size(238, 28);
            this.manualDeUsuarioToolStripMenuItem.Text = "Manual de Usuario";
            // 
            // administracionToolStripMenuItem
            // 
            this.administracionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.serviciosToolStripMenuItem,
            this.tarifasToolStripMenuItem});
            this.administracionToolStripMenuItem.Name = "administracionToolStripMenuItem";
            this.administracionToolStripMenuItem.Size = new System.Drawing.Size(116, 28);
            this.administracionToolStripMenuItem.Text = "Administrar";
            // 
            // serviciosToolStripMenuItem
            // 
            this.serviciosToolStripMenuItem.Name = "serviciosToolStripMenuItem";
            this.serviciosToolStripMenuItem.Size = new System.Drawing.Size(156, 28);
            this.serviciosToolStripMenuItem.Text = "Servicios";
            this.serviciosToolStripMenuItem.Click += new System.EventHandler(this.serviciosToolStripMenuItem_Click);
            // 
            // tarifasToolStripMenuItem
            // 
            this.tarifasToolStripMenuItem.Name = "tarifasToolStripMenuItem";
            this.tarifasToolStripMenuItem.Size = new System.Drawing.Size(156, 28);
            this.tarifasToolStripMenuItem.Text = "Tarifas";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.btn_Buscar);
            this.groupBox1.Controls.Add(this.dtp_fechaHasta);
            this.groupBox1.Controls.Add(this.dtp_fechaDesde);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1086, 107);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "BUSCAR DISPONIBILIDAD";
            // 
            // btn_Buscar
            // 
            this.btn_Buscar.Location = new System.Drawing.Point(460, 42);
            this.btn_Buscar.Name = "btn_Buscar";
            this.btn_Buscar.Size = new System.Drawing.Size(75, 23);
            this.btn_Buscar.TabIndex = 4;
            this.btn_Buscar.Text = "Buscar";
            this.btn_Buscar.UseVisualStyleBackColor = true;
            this.btn_Buscar.Click += new System.EventHandler(this.btn_Buscar_Click);
            // 
            // dtp_fechaHasta
            // 
            this.dtp_fechaHasta.Location = new System.Drawing.Point(108, 61);
            this.dtp_fechaHasta.Name = "dtp_fechaHasta";
            this.dtp_fechaHasta.Size = new System.Drawing.Size(307, 22);
            this.dtp_fechaHasta.TabIndex = 3;
            // 
            // dtp_fechaDesde
            // 
            this.dtp_fechaDesde.Location = new System.Drawing.Point(108, 26);
            this.dtp_fechaDesde.Name = "dtp_fechaDesde";
            this.dtp_fechaDesde.Size = new System.Drawing.Size(307, 22);
            this.dtp_fechaDesde.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Hasta";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Desde";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.AutoSize = true;
            this.groupBox2.Controls.Add(this.dGV_Alojamientos);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 152);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1086, 212);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "OCUPACION ACTUAL";
            // 
            // dGV_Alojamientos
            // 
            this.dGV_Alojamientos.AllowUserToAddRows = false;
            this.dGV_Alojamientos.AllowUserToDeleteRows = false;
            this.dGV_Alojamientos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dGV_Alojamientos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dGV_Alojamientos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_Alojamientos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column7,
            this.clm_Estado,
            this.Column1,
            this.clm_DNI,
            this.clm_Legajo,
            this.Column2,
            this.Column4,
            this.Column5,
            this.Column6});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dGV_Alojamientos.DefaultCellStyle = dataGridViewCellStyle2;
            this.dGV_Alojamientos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dGV_Alojamientos.Location = new System.Drawing.Point(3, 18);
            this.dGV_Alojamientos.Name = "dGV_Alojamientos";
            this.dGV_Alojamientos.ReadOnly = true;
            this.dGV_Alojamientos.RowHeadersVisible = false;
            this.dGV_Alojamientos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGV_Alojamientos.Size = new System.Drawing.Size(1080, 191);
            this.dGV_Alojamientos.TabIndex = 0;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Número";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // clm_Estado
            // 
            this.clm_Estado.HeaderText = "Estado";
            this.clm_Estado.Name = "clm_Estado";
            this.clm_Estado.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Habitación";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // clm_DNI
            // 
            this.clm_DNI.HeaderText = "DNI";
            this.clm_DNI.Name = "clm_DNI";
            this.clm_DNI.ReadOnly = true;
            // 
            // clm_Legajo
            // 
            this.clm_Legajo.HeaderText = "Legajo";
            this.clm_Legajo.Name = "clm_Legajo";
            this.clm_Legajo.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Responsable";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Ingreso";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Egreso";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Cantidad Personas";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // btn_VerDetalle
            // 
            this.btn_VerDetalle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_VerDetalle.Location = new System.Drawing.Point(1005, 385);
            this.btn_VerDetalle.Name = "btn_VerDetalle";
            this.btn_VerDetalle.Size = new System.Drawing.Size(90, 23);
            this.btn_VerDetalle.TabIndex = 5;
            this.btn_VerDetalle.Text = "Ver Detalle";
            this.btn_VerDetalle.UseVisualStyleBackColor = true;
            this.btn_VerDetalle.Click += new System.EventHandler(this.btn_VerDetalle_Click);
            // 
            // modificarAltaDeClienteToolStripMenuItem
            // 
            this.modificarAltaDeClienteToolStripMenuItem.Name = "modificarAltaDeClienteToolStripMenuItem";
            this.modificarAltaDeClienteToolStripMenuItem.Size = new System.Drawing.Size(282, 28);
            this.modificarAltaDeClienteToolStripMenuItem.Text = "Modificar Alta de Cliente";
            this.modificarAltaDeClienteToolStripMenuItem.Click += new System.EventHandler(this.modificarAltaDeClienteToolStripMenuItem_Click);
            // 
            // VentanaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1110, 420);
            this.Controls.Add(this.btn_VerDetalle);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = menuStrip1;
            this.Name = "VentanaPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VentanaPrincipal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.VentanaPrincipal_FormClosing);
            this.Load += new System.EventHandler(this.VentanaPrincipal_Load);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Alojamientos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem alojamientoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem buscarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem movimientoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manualDeUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administracionToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_Buscar;
        private System.Windows.Forms.DateTimePicker dtp_fechaHasta;
        private System.Windows.Forms.DateTimePicker dtp_fechaDesde;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dGV_Alojamientos;
        private System.Windows.Forms.ToolStripMenuItem sesionToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem iniciarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarToolStripMenuItem;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem agregarServicioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem serviciosConsumidosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem altaDeReservaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serviciosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tarifasToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_Estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_DNI;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_Legajo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.Button btn_VerDetalle;
        private System.Windows.Forms.ToolStripMenuItem modificarAltaDeClienteToolStripMenuItem;
    }
}