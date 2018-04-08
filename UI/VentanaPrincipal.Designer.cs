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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			this.sesionToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.iniciarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.cerrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.nuevoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.altaDeReservaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.cancelarReservaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.alojamientoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.nuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.buscarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.agregarServicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.cerrarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.clienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.nuevoToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
			this.buscarToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
			this.modificarAltaDeClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.modificarDatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.listarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.listaPersonalizadaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.serviciosConsumidosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.alojamientosConDeudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.movimientoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.nuevoToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
			this.administracionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.serviciosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.consultarHabitacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.tarifasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.actualizarTarifasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.modificarAltaDeCuposToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.agregarCiudadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.agregarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.modificarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.serviciosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.nuevoToolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
			this.eliminarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.actulizarCostosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.nuevoUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.eliminarUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.cambiarContraseñaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.groupBox_disponibilidad = new System.Windows.Forms.GroupBox();
			this.btn_Buscar = new System.Windows.Forms.Button();
			this.dtp_fechaHasta = new System.Windows.Forms.DateTimePicker();
			this.dtp_fechaDesde = new System.Windows.Forms.DateTimePicker();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.btn_VerDetalle = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.dGV_Alojamientos = new System.Windows.Forms.DataGridView();
			this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.clm_Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.clm_DNI = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.clm_Legajo = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.clm_Ref = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
			this.groupBox_ColorsRef = new System.Windows.Forms.GroupBox();
			this.label10 = new System.Windows.Forms.Label();
			this.pictureBox9 = new System.Windows.Forms.PictureBox();
			this.label9 = new System.Windows.Forms.Label();
			this.pictureBox8 = new System.Windows.Forms.PictureBox();
			this.pictureBox7 = new System.Windows.Forms.PictureBox();
			this.label8 = new System.Windows.Forms.Label();
			this.pictureBox6 = new System.Windows.Forms.PictureBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.pictureBox5 = new System.Windows.Forms.PictureBox();
			this.pictureBox4 = new System.Windows.Forms.PictureBox();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			menuStrip1 = new System.Windows.Forms.MenuStrip();
			menuStrip1.SuspendLayout();
			this.groupBox_disponibilidad.SuspendLayout();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dGV_Alojamientos)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
			this.groupBox_ColorsRef.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			menuStrip1.BackColor = System.Drawing.Color.Yellow;
			menuStrip1.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			menuStrip1.ImageScalingSize = new System.Drawing.Size(25, 25);
			menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sesionToolStripMenuItem1,
            this.archivoToolStripMenuItem,
            this.alojamientoToolStripMenuItem,
            this.clienteToolStripMenuItem,
            this.listarToolStripMenuItem,
            this.movimientoToolStripMenuItem,
            this.administracionToolStripMenuItem,
            this.usuariosToolStripMenuItem});
			menuStrip1.Location = new System.Drawing.Point(0, 0);
			menuStrip1.Name = "menuStrip1";
			menuStrip1.ShowItemToolTips = true;
			menuStrip1.Size = new System.Drawing.Size(1362, 38);
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
			this.sesionToolStripMenuItem1.Size = new System.Drawing.Size(90, 34);
			this.sesionToolStripMenuItem1.Text = "Sesión";
			// 
			// iniciarToolStripMenuItem
			// 
			this.iniciarToolStripMenuItem.Image = global::UI.Properties.Resources.Boton_InicioSesion;
			this.iniciarToolStripMenuItem.Name = "iniciarToolStripMenuItem";
			this.iniciarToolStripMenuItem.Size = new System.Drawing.Size(189, 34);
			this.iniciarToolStripMenuItem.Text = "Re-Iniciar";
			this.iniciarToolStripMenuItem.Click += new System.EventHandler(this.iniciarToolStripMenuItem_Click);
			// 
			// cerrarToolStripMenuItem
			// 
			this.cerrarToolStripMenuItem.Image = global::UI.Properties.Resources.Boton_CerrarSesion;
			this.cerrarToolStripMenuItem.Name = "cerrarToolStripMenuItem";
			this.cerrarToolStripMenuItem.Size = new System.Drawing.Size(189, 34);
			this.cerrarToolStripMenuItem.Text = "Cerrar";
			this.cerrarToolStripMenuItem.Click += new System.EventHandler(this.cerrarToolStripMenuItem_Click);
			// 
			// archivoToolStripMenuItem
			// 
			this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoToolStripMenuItem1,
            this.altaDeReservaToolStripMenuItem,
            this.cancelarReservaToolStripMenuItem});
			this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
			this.archivoToolStripMenuItem.Size = new System.Drawing.Size(102, 34);
			this.archivoToolStripMenuItem.Text = "Reserva";
			// 
			// nuevoToolStripMenuItem1
			// 
			this.nuevoToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("nuevoToolStripMenuItem1.Image")));
			this.nuevoToolStripMenuItem1.Name = "nuevoToolStripMenuItem1";
			this.nuevoToolStripMenuItem1.Size = new System.Drawing.Size(249, 34);
			this.nuevoToolStripMenuItem1.Text = "Nuevo";
			this.nuevoToolStripMenuItem1.Click += new System.EventHandler(this.nuevoToolStripMenuItem1_Click);
			// 
			// altaDeReservaToolStripMenuItem
			// 
			this.altaDeReservaToolStripMenuItem.Image = global::UI.Properties.Resources.Boton_AltaReserva;
			this.altaDeReservaToolStripMenuItem.Name = "altaDeReservaToolStripMenuItem";
			this.altaDeReservaToolStripMenuItem.Size = new System.Drawing.Size(249, 34);
			this.altaDeReservaToolStripMenuItem.Text = "Alta de Reserva";
			this.altaDeReservaToolStripMenuItem.Click += new System.EventHandler(this.altaDeReservaToolStripMenuItem_Click);
			// 
			// cancelarReservaToolStripMenuItem
			// 
			this.cancelarReservaToolStripMenuItem.Image = global::UI.Properties.Resources.Boton_Cerrar_Cancelar;
			this.cancelarReservaToolStripMenuItem.Name = "cancelarReservaToolStripMenuItem";
			this.cancelarReservaToolStripMenuItem.Size = new System.Drawing.Size(249, 34);
			this.cancelarReservaToolStripMenuItem.Text = "Cancelar";
			this.cancelarReservaToolStripMenuItem.Click += new System.EventHandler(this.cancelarReservaToolStripMenuItem_Click);
			// 
			// alojamientoToolStripMenuItem
			// 
			this.alojamientoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoToolStripMenuItem,
            this.buscarToolStripMenuItem1,
            this.agregarServicioToolStripMenuItem,
            this.cerrarToolStripMenuItem1});
			this.alojamientoToolStripMenuItem.Name = "alojamientoToolStripMenuItem";
			this.alojamientoToolStripMenuItem.Size = new System.Drawing.Size(147, 34);
			this.alojamientoToolStripMenuItem.Text = "Alojamiento";
			// 
			// nuevoToolStripMenuItem
			// 
			this.nuevoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("nuevoToolStripMenuItem.Image")));
			this.nuevoToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Transparent;
			this.nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
			this.nuevoToolStripMenuItem.Size = new System.Drawing.Size(260, 34);
			this.nuevoToolStripMenuItem.Text = "Nuevo";
			this.nuevoToolStripMenuItem.Click += new System.EventHandler(this.nuevoToolStripMenuItem_Click);
			// 
			// buscarToolStripMenuItem1
			// 
			this.buscarToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("buscarToolStripMenuItem1.Image")));
			this.buscarToolStripMenuItem1.Name = "buscarToolStripMenuItem1";
			this.buscarToolStripMenuItem1.Size = new System.Drawing.Size(260, 34);
			this.buscarToolStripMenuItem1.Text = "Buscar";
			this.buscarToolStripMenuItem1.Click += new System.EventHandler(this.buscarToolStripMenuItem1_Click);
			// 
			// agregarServicioToolStripMenuItem
			// 
			this.agregarServicioToolStripMenuItem.Image = global::UI.Properties.Resources.Boton_Agregar;
			this.agregarServicioToolStripMenuItem.Name = "agregarServicioToolStripMenuItem";
			this.agregarServicioToolStripMenuItem.Size = new System.Drawing.Size(260, 34);
			this.agregarServicioToolStripMenuItem.Text = "Agregar Servicio";
			this.agregarServicioToolStripMenuItem.Click += new System.EventHandler(this.agregarServicioToolStripMenuItem_Click);
			// 
			// cerrarToolStripMenuItem1
			// 
			this.cerrarToolStripMenuItem1.Image = global::UI.Properties.Resources.Boton_Cerrar;
			this.cerrarToolStripMenuItem1.Name = "cerrarToolStripMenuItem1";
			this.cerrarToolStripMenuItem1.Size = new System.Drawing.Size(260, 34);
			this.cerrarToolStripMenuItem1.Text = "Cerrar";
			this.cerrarToolStripMenuItem1.Click += new System.EventHandler(this.cerrarToolStripMenuItem1_Click);
			// 
			// clienteToolStripMenuItem
			// 
			this.clienteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoToolStripMenuItem2,
            this.buscarToolStripMenuItem2,
            this.modificarAltaDeClienteToolStripMenuItem,
            this.modificarDatosToolStripMenuItem});
			this.clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
			this.clienteToolStripMenuItem.Size = new System.Drawing.Size(96, 34);
			this.clienteToolStripMenuItem.Text = "Cliente";
			// 
			// nuevoToolStripMenuItem2
			// 
			this.nuevoToolStripMenuItem2.Image = global::UI.Properties.Resources.Boton_Agregar;
			this.nuevoToolStripMenuItem2.Name = "nuevoToolStripMenuItem2";
			this.nuevoToolStripMenuItem2.Size = new System.Drawing.Size(261, 34);
			this.nuevoToolStripMenuItem2.Text = "Nuevo";
			this.nuevoToolStripMenuItem2.Click += new System.EventHandler(this.nuevoToolStripMenuItem2_Click);
			// 
			// buscarToolStripMenuItem2
			// 
			this.buscarToolStripMenuItem2.Image = global::UI.Properties.Resources.boton_buscar;
			this.buscarToolStripMenuItem2.Name = "buscarToolStripMenuItem2";
			this.buscarToolStripMenuItem2.Size = new System.Drawing.Size(261, 34);
			this.buscarToolStripMenuItem2.Text = "Buscar";
			this.buscarToolStripMenuItem2.Click += new System.EventHandler(this.buscarToolStripMenuItem2_Click);
			// 
			// modificarAltaDeClienteToolStripMenuItem
			// 
			this.modificarAltaDeClienteToolStripMenuItem.Image = global::UI.Properties.Resources.Boton_Editar;
			this.modificarAltaDeClienteToolStripMenuItem.Name = "modificarAltaDeClienteToolStripMenuItem";
			this.modificarAltaDeClienteToolStripMenuItem.Size = new System.Drawing.Size(261, 34);
			this.modificarAltaDeClienteToolStripMenuItem.Text = "Modificar Estado";
			this.modificarAltaDeClienteToolStripMenuItem.Click += new System.EventHandler(this.modificarAltaDeClienteToolStripMenuItem_Click);
			// 
			// modificarDatosToolStripMenuItem
			// 
			this.modificarDatosToolStripMenuItem.Image = global::UI.Properties.Resources.Boton_Editar;
			this.modificarDatosToolStripMenuItem.Name = "modificarDatosToolStripMenuItem";
			this.modificarDatosToolStripMenuItem.Size = new System.Drawing.Size(261, 34);
			this.modificarDatosToolStripMenuItem.Text = "Modificar Datos";
			this.modificarDatosToolStripMenuItem.Click += new System.EventHandler(this.modificarDatosToolStripMenuItem_Click);
			// 
			// listarToolStripMenuItem
			// 
			this.listarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listaPersonalizadaToolStripMenuItem,
            this.serviciosConsumidosToolStripMenuItem,
            this.alojamientosConDeudaToolStripMenuItem});
			this.listarToolStripMenuItem.Name = "listarToolStripMenuItem";
			this.listarToolStripMenuItem.Size = new System.Drawing.Size(78, 34);
			this.listarToolStripMenuItem.Text = "Listar";
			// 
			// listaPersonalizadaToolStripMenuItem
			// 
			this.listaPersonalizadaToolStripMenuItem.Image = global::UI.Properties.Resources.Boton_Listar;
			this.listaPersonalizadaToolStripMenuItem.Name = "listaPersonalizadaToolStripMenuItem";
			this.listaPersonalizadaToolStripMenuItem.Size = new System.Drawing.Size(502, 34);
			this.listaPersonalizadaToolStripMenuItem.Text = "Lista Personalizada de Alojamientos";
			this.listaPersonalizadaToolStripMenuItem.Click += new System.EventHandler(this.listaPersonalizadaToolStripMenuItem_Click);
			// 
			// serviciosConsumidosToolStripMenuItem
			// 
			this.serviciosConsumidosToolStripMenuItem.Image = global::UI.Properties.Resources.Boton_Listar;
			this.serviciosConsumidosToolStripMenuItem.Name = "serviciosConsumidosToolStripMenuItem";
			this.serviciosConsumidosToolStripMenuItem.Size = new System.Drawing.Size(502, 34);
			this.serviciosConsumidosToolStripMenuItem.Text = "Servicios Consumidos de un Alojamiento";
			this.serviciosConsumidosToolStripMenuItem.Click += new System.EventHandler(this.serviciosConsumidosToolStripMenuItem_Click);
			// 
			// alojamientosConDeudaToolStripMenuItem
			// 
			this.alojamientosConDeudaToolStripMenuItem.Image = global::UI.Properties.Resources.Boton_Listar;
			this.alojamientosConDeudaToolStripMenuItem.Name = "alojamientosConDeudaToolStripMenuItem";
			this.alojamientosConDeudaToolStripMenuItem.Size = new System.Drawing.Size(502, 34);
			this.alojamientosConDeudaToolStripMenuItem.Text = "Alojamientos con Servicios Impagos";
			this.alojamientosConDeudaToolStripMenuItem.Click += new System.EventHandler(this.alojamientosConDeudaToolStripMenuItem_Click);
			// 
			// movimientoToolStripMenuItem
			// 
			this.movimientoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoToolStripMenuItem3});
			this.movimientoToolStripMenuItem.Name = "movimientoToolStripMenuItem";
			this.movimientoToolStripMenuItem.Size = new System.Drawing.Size(74, 34);
			this.movimientoToolStripMenuItem.Text = "Pago";
			// 
			// nuevoToolStripMenuItem3
			// 
			this.nuevoToolStripMenuItem3.Image = global::UI.Properties.Resources.Boton_Agregar;
			this.nuevoToolStripMenuItem3.Name = "nuevoToolStripMenuItem3";
			this.nuevoToolStripMenuItem3.Size = new System.Drawing.Size(216, 34);
			this.nuevoToolStripMenuItem3.Text = "Nuevo Pago";
			this.nuevoToolStripMenuItem3.Click += new System.EventHandler(this.nuevoToolStripMenuItem3_Click);
			// 
			// administracionToolStripMenuItem
			// 
			this.administracionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.serviciosToolStripMenuItem,
            this.consultarHabitacionesToolStripMenuItem,
            this.tarifasToolStripMenuItem,
            this.actualizarTarifasToolStripMenuItem,
            this.modificarAltaDeCuposToolStripMenuItem,
            this.agregarCiudadToolStripMenuItem,
            this.serviciosToolStripMenuItem1});
			this.administracionToolStripMenuItem.Name = "administracionToolStripMenuItem";
			this.administracionToolStripMenuItem.Size = new System.Drawing.Size(141, 34);
			this.administracionToolStripMenuItem.Text = "Administrar";
			// 
			// serviciosToolStripMenuItem
			// 
			this.serviciosToolStripMenuItem.Image = global::UI.Properties.Resources.Boton_Consultar;
			this.serviciosToolStripMenuItem.Name = "serviciosToolStripMenuItem";
			this.serviciosToolStripMenuItem.Size = new System.Drawing.Size(380, 34);
			this.serviciosToolStripMenuItem.Text = "Consultar Servicios";
			this.serviciosToolStripMenuItem.Click += new System.EventHandler(this.serviciosToolStripMenuItem_Click);
			// 
			// consultarHabitacionesToolStripMenuItem
			// 
			this.consultarHabitacionesToolStripMenuItem.Image = global::UI.Properties.Resources.Boton_Consultar;
			this.consultarHabitacionesToolStripMenuItem.Name = "consultarHabitacionesToolStripMenuItem";
			this.consultarHabitacionesToolStripMenuItem.Size = new System.Drawing.Size(380, 34);
			this.consultarHabitacionesToolStripMenuItem.Text = "Consultar Habitaciones";
			this.consultarHabitacionesToolStripMenuItem.Click += new System.EventHandler(this.consultarHabitacionesToolStripMenuItem_Click);
			// 
			// tarifasToolStripMenuItem
			// 
			this.tarifasToolStripMenuItem.Image = global::UI.Properties.Resources.Boton_Consultar;
			this.tarifasToolStripMenuItem.Name = "tarifasToolStripMenuItem";
			this.tarifasToolStripMenuItem.Size = new System.Drawing.Size(380, 34);
			this.tarifasToolStripMenuItem.Text = "Consultar Tarifas";
			this.tarifasToolStripMenuItem.Click += new System.EventHandler(this.tarifasToolStripMenuItem_Click);
			// 
			// actualizarTarifasToolStripMenuItem
			// 
			this.actualizarTarifasToolStripMenuItem.Image = global::UI.Properties.Resources.Boton_Actualizar;
			this.actualizarTarifasToolStripMenuItem.Name = "actualizarTarifasToolStripMenuItem";
			this.actualizarTarifasToolStripMenuItem.Size = new System.Drawing.Size(380, 34);
			this.actualizarTarifasToolStripMenuItem.Text = "Actualizar Costos de Tarifa";
			this.actualizarTarifasToolStripMenuItem.Click += new System.EventHandler(this.actualizarTarifasToolStripMenuItem_Click);
			// 
			// modificarAltaDeCuposToolStripMenuItem
			// 
			this.modificarAltaDeCuposToolStripMenuItem.Image = global::UI.Properties.Resources.Boton_Editar;
			this.modificarAltaDeCuposToolStripMenuItem.Name = "modificarAltaDeCuposToolStripMenuItem";
			this.modificarAltaDeCuposToolStripMenuItem.Size = new System.Drawing.Size(380, 34);
			this.modificarAltaDeCuposToolStripMenuItem.Text = "Modificar Alta de Habitación";
			this.modificarAltaDeCuposToolStripMenuItem.Click += new System.EventHandler(this.modificarAltaDeCuposToolStripMenuItem_Click);
			// 
			// agregarCiudadToolStripMenuItem
			// 
			this.agregarCiudadToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarToolStripMenuItem,
            this.modificarToolStripMenuItem,
            this.eliminarToolStripMenuItem});
			this.agregarCiudadToolStripMenuItem.Image = global::UI.Properties.Resources.Boton_Consultar;
			this.agregarCiudadToolStripMenuItem.Name = "agregarCiudadToolStripMenuItem";
			this.agregarCiudadToolStripMenuItem.Size = new System.Drawing.Size(380, 34);
			this.agregarCiudadToolStripMenuItem.Text = "Ciudad";
			// 
			// agregarToolStripMenuItem
			// 
			this.agregarToolStripMenuItem.Image = global::UI.Properties.Resources.Boton_Agregar;
			this.agregarToolStripMenuItem.Name = "agregarToolStripMenuItem";
			this.agregarToolStripMenuItem.Size = new System.Drawing.Size(190, 34);
			this.agregarToolStripMenuItem.Text = "Agregar";
			this.agregarToolStripMenuItem.Click += new System.EventHandler(this.agregarToolStripMenuItem_Click);
			// 
			// modificarToolStripMenuItem
			// 
			this.modificarToolStripMenuItem.Image = global::UI.Properties.Resources.Boton_Editar;
			this.modificarToolStripMenuItem.Name = "modificarToolStripMenuItem";
			this.modificarToolStripMenuItem.Size = new System.Drawing.Size(190, 34);
			this.modificarToolStripMenuItem.Text = "Modificar";
			this.modificarToolStripMenuItem.Click += new System.EventHandler(this.modificarToolStripMenuItem_Click);
			// 
			// eliminarToolStripMenuItem
			// 
			this.eliminarToolStripMenuItem.Image = global::UI.Properties.Resources.Boton_Cerrar_Cancelar;
			this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
			this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(190, 34);
			this.eliminarToolStripMenuItem.Text = "Eliminar";
			this.eliminarToolStripMenuItem.Click += new System.EventHandler(this.eliminarToolStripMenuItem_Click);
			// 
			// serviciosToolStripMenuItem1
			// 
			this.serviciosToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoToolStripMenuItem4,
            this.eliminarToolStripMenuItem1,
            this.actulizarCostosToolStripMenuItem});
			this.serviciosToolStripMenuItem1.Image = global::UI.Properties.Resources.Boton_Consultar;
			this.serviciosToolStripMenuItem1.Name = "serviciosToolStripMenuItem1";
			this.serviciosToolStripMenuItem1.Size = new System.Drawing.Size(380, 34);
			this.serviciosToolStripMenuItem1.Text = "Servicios";
			// 
			// nuevoToolStripMenuItem4
			// 
			this.nuevoToolStripMenuItem4.Image = global::UI.Properties.Resources.Boton_Agregar;
			this.nuevoToolStripMenuItem4.Name = "nuevoToolStripMenuItem4";
			this.nuevoToolStripMenuItem4.Size = new System.Drawing.Size(277, 34);
			this.nuevoToolStripMenuItem4.Text = "Nuevo";
			this.nuevoToolStripMenuItem4.Click += new System.EventHandler(this.nuevoToolStripMenuItem4_Click);
			// 
			// eliminarToolStripMenuItem1
			// 
			this.eliminarToolStripMenuItem1.Image = global::UI.Properties.Resources.Boton_Cerrar_Cancelar;
			this.eliminarToolStripMenuItem1.Name = "eliminarToolStripMenuItem1";
			this.eliminarToolStripMenuItem1.Size = new System.Drawing.Size(277, 34);
			this.eliminarToolStripMenuItem1.Text = "Eliminar";
			this.eliminarToolStripMenuItem1.Click += new System.EventHandler(this.eliminarToolStripMenuItem1_Click);
			// 
			// actulizarCostosToolStripMenuItem
			// 
			this.actulizarCostosToolStripMenuItem.Image = global::UI.Properties.Resources.Boton_Actualizar;
			this.actulizarCostosToolStripMenuItem.Name = "actulizarCostosToolStripMenuItem";
			this.actulizarCostosToolStripMenuItem.Size = new System.Drawing.Size(277, 34);
			this.actulizarCostosToolStripMenuItem.Text = "Actulizar un Costo";
			this.actulizarCostosToolStripMenuItem.Click += new System.EventHandler(this.actulizarCostosToolStripMenuItem_Click);
			// 
			// usuariosToolStripMenuItem
			// 
			this.usuariosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoUsuarioToolStripMenuItem,
            this.eliminarUsuarioToolStripMenuItem,
            this.cambiarContraseñaToolStripMenuItem});
			this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
			this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(109, 34);
			this.usuariosToolStripMenuItem.Text = "Usuarios";
			// 
			// nuevoUsuarioToolStripMenuItem
			// 
			this.nuevoUsuarioToolStripMenuItem.Image = global::UI.Properties.Resources.Boton_Agregar;
			this.nuevoUsuarioToolStripMenuItem.Name = "nuevoUsuarioToolStripMenuItem";
			this.nuevoUsuarioToolStripMenuItem.Size = new System.Drawing.Size(295, 34);
			this.nuevoUsuarioToolStripMenuItem.Text = "Nuevo Usuario";
			this.nuevoUsuarioToolStripMenuItem.Click += new System.EventHandler(this.nuevoUsuarioToolStripMenuItem_Click);
			// 
			// eliminarUsuarioToolStripMenuItem
			// 
			this.eliminarUsuarioToolStripMenuItem.Image = global::UI.Properties.Resources.Boton_Cerrar_Cancelar;
			this.eliminarUsuarioToolStripMenuItem.Name = "eliminarUsuarioToolStripMenuItem";
			this.eliminarUsuarioToolStripMenuItem.Size = new System.Drawing.Size(295, 34);
			this.eliminarUsuarioToolStripMenuItem.Text = "Eliminar Usuario";
			this.eliminarUsuarioToolStripMenuItem.Click += new System.EventHandler(this.eliminarUsuarioToolStripMenuItem_Click);
			// 
			// cambiarContraseñaToolStripMenuItem
			// 
			this.cambiarContraseñaToolStripMenuItem.Image = global::UI.Properties.Resources.Boton_Actualizar;
			this.cambiarContraseñaToolStripMenuItem.Name = "cambiarContraseñaToolStripMenuItem";
			this.cambiarContraseñaToolStripMenuItem.Size = new System.Drawing.Size(295, 34);
			this.cambiarContraseñaToolStripMenuItem.Text = "Cambiar Contraseña";
			this.cambiarContraseñaToolStripMenuItem.Click += new System.EventHandler(this.cambiarContraseñaToolStripMenuItem_Click);
			// 
			// groupBox_disponibilidad
			// 
			this.groupBox_disponibilidad.AutoSize = true;
			this.groupBox_disponibilidad.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.groupBox_disponibilidad.BackColor = System.Drawing.Color.Transparent;
			this.groupBox_disponibilidad.Controls.Add(this.btn_Buscar);
			this.groupBox_disponibilidad.Controls.Add(this.dtp_fechaHasta);
			this.groupBox_disponibilidad.Controls.Add(this.dtp_fechaDesde);
			this.groupBox_disponibilidad.Controls.Add(this.label2);
			this.groupBox_disponibilidad.Controls.Add(this.label1);
			this.groupBox_disponibilidad.Font = new System.Drawing.Font("Segoe UI Semibold", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox_disponibilidad.Location = new System.Drawing.Point(12, 41);
			this.groupBox_disponibilidad.Name = "groupBox_disponibilidad";
			this.groupBox_disponibilidad.Size = new System.Drawing.Size(682, 132);
			this.groupBox_disponibilidad.TabIndex = 3;
			this.groupBox_disponibilidad.TabStop = false;
			this.groupBox_disponibilidad.Text = "BUSCAR DISPONIBILIDAD";
			// 
			// btn_Buscar
			// 
			this.btn_Buscar.BackColor = System.Drawing.SystemColors.MenuHighlight;
			this.btn_Buscar.ForeColor = System.Drawing.Color.White;
			this.btn_Buscar.Location = new System.Drawing.Point(466, 47);
			this.btn_Buscar.Name = "btn_Buscar";
			this.btn_Buscar.Size = new System.Drawing.Size(210, 44);
			this.btn_Buscar.TabIndex = 1;
			this.btn_Buscar.Text = "Verificar Disponibilidad";
			this.btn_Buscar.UseVisualStyleBackColor = false;
			this.btn_Buscar.Click += new System.EventHandler(this.btn_Buscar_Click);
			// 
			// dtp_fechaHasta
			// 
			this.dtp_fechaHasta.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
			this.dtp_fechaHasta.Location = new System.Drawing.Point(101, 73);
			this.dtp_fechaHasta.Name = "dtp_fechaHasta";
			this.dtp_fechaHasta.RightToLeftLayout = true;
			this.dtp_fechaHasta.Size = new System.Drawing.Size(346, 30);
			this.dtp_fechaHasta.TabIndex = 3;
			this.dtp_fechaHasta.TabStop = false;
			// 
			// dtp_fechaDesde
			// 
			this.dtp_fechaDesde.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
			this.dtp_fechaDesde.Location = new System.Drawing.Point(101, 38);
			this.dtp_fechaDesde.Name = "dtp_fechaDesde";
			this.dtp_fechaDesde.Size = new System.Drawing.Size(346, 30);
			this.dtp_fechaDesde.TabIndex = 2;
			this.dtp_fechaDesde.TabStop = false;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(29, 79);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(54, 23);
			this.label2.TabIndex = 1;
			this.label2.Text = "Hasta";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(26, 43);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(57, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Desde";
			// 
			// groupBox2
			// 
			this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox2.AutoSize = true;
			this.groupBox2.BackColor = System.Drawing.Color.Transparent;
			this.groupBox2.Controls.Add(this.pictureBox1);
			this.groupBox2.Controls.Add(this.btn_VerDetalle);
			this.groupBox2.Controls.Add(this.button1);
			this.groupBox2.Controls.Add(this.dGV_Alojamientos);
			this.groupBox2.Font = new System.Drawing.Font("Segoe UI Semibold", 12.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlText;
			this.groupBox2.Location = new System.Drawing.Point(12, 177);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(1345, 376);
			this.groupBox2.TabIndex = 4;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "OCUPACIÓN ACTUAL";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.pictureBox1.BackColor = System.Drawing.SystemColors.AppWorkspace;
			this.pictureBox1.Image = global::UI.Properties.Resources.gears_200;
			this.pictureBox1.Location = new System.Drawing.Point(664, 223);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(63, 56);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 7;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Visible = false;
			// 
			// btn_VerDetalle
			// 
			this.btn_VerDetalle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_VerDetalle.Location = new System.Drawing.Point(1198, 29);
			this.btn_VerDetalle.Name = "btn_VerDetalle";
			this.btn_VerDetalle.Size = new System.Drawing.Size(141, 30);
			this.btn_VerDetalle.TabIndex = 5;
			this.btn_VerDetalle.Text = "Ver Detalles";
			this.btn_VerDetalle.UseVisualStyleBackColor = true;
			this.btn_VerDetalle.Click += new System.EventHandler(this.btn_VerDetalle_Click);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(3, 29);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(141, 30);
			this.button1.TabIndex = 6;
			this.button1.Text = "Actualizar";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// dGV_Alojamientos
			// 
			this.dGV_Alojamientos.AllowUserToAddRows = false;
			this.dGV_Alojamientos.AllowUserToDeleteRows = false;
			this.dGV_Alojamientos.AllowUserToResizeColumns = false;
			this.dGV_Alojamientos.AllowUserToResizeRows = false;
			this.dGV_Alojamientos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dGV_Alojamientos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 12.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
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
            this.clm_Ref});
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 12.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dGV_Alojamientos.DefaultCellStyle = dataGridViewCellStyle2;
			this.dGV_Alojamientos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
			this.dGV_Alojamientos.Location = new System.Drawing.Point(3, 65);
			this.dGV_Alojamientos.MultiSelect = false;
			this.dGV_Alojamientos.Name = "dGV_Alojamientos";
			this.dGV_Alojamientos.ReadOnly = true;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 12.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.GrayText;
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dGV_Alojamientos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
			this.dGV_Alojamientos.RowHeadersVisible = false;
			this.dGV_Alojamientos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dGV_Alojamientos.Size = new System.Drawing.Size(1336, 296);
			this.dGV_Alojamientos.TabIndex = 0;
			// 
			// Column7
			// 
			this.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Column7.FillWeight = 35F;
			this.Column7.HeaderText = "Número";
			this.Column7.Name = "Column7";
			this.Column7.ReadOnly = true;
			// 
			// clm_Estado
			// 
			this.clm_Estado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.clm_Estado.FillWeight = 38F;
			this.clm_Estado.HeaderText = "Estado";
			this.clm_Estado.Name = "clm_Estado";
			this.clm_Estado.ReadOnly = true;
			// 
			// Column1
			// 
			this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Column1.FillWeight = 40F;
			this.Column1.HeaderText = "Habitación";
			this.Column1.Name = "Column1";
			this.Column1.ReadOnly = true;
			// 
			// clm_DNI
			// 
			this.clm_DNI.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.clm_DNI.FillWeight = 45F;
			this.clm_DNI.HeaderText = "Responsable";
			this.clm_DNI.Name = "clm_DNI";
			this.clm_DNI.ReadOnly = true;
			// 
			// clm_Legajo
			// 
			this.clm_Legajo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.clm_Legajo.FillWeight = 45F;
			this.clm_Legajo.HeaderText = "Legajo";
			this.clm_Legajo.Name = "clm_Legajo";
			this.clm_Legajo.ReadOnly = true;
			// 
			// Column2
			// 
			this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Column2.HeaderText = "Nombre";
			this.Column2.Name = "Column2";
			this.Column2.ReadOnly = true;
			// 
			// Column4
			// 
			this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Column4.FillWeight = 50F;
			this.Column4.HeaderText = "Ingreso";
			this.Column4.Name = "Column4";
			this.Column4.ReadOnly = true;
			// 
			// Column5
			// 
			this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Column5.FillWeight = 50F;
			this.Column5.HeaderText = "Egreso";
			this.Column5.Name = "Column5";
			this.Column5.ReadOnly = true;
			// 
			// clm_Ref
			// 
			this.clm_Ref.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.clm_Ref.FillWeight = 15F;
			this.clm_Ref.HeaderText = "Ref";
			this.clm_Ref.Name = "clm_Ref";
			this.clm_Ref.ReadOnly = true;
			// 
			// timer1
			// 
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// groupBox_ColorsRef
			// 
			this.groupBox_ColorsRef.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox_ColorsRef.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.groupBox_ColorsRef.BackColor = System.Drawing.Color.Transparent;
			this.groupBox_ColorsRef.Controls.Add(this.label10);
			this.groupBox_ColorsRef.Controls.Add(this.pictureBox9);
			this.groupBox_ColorsRef.Controls.Add(this.label9);
			this.groupBox_ColorsRef.Controls.Add(this.pictureBox8);
			this.groupBox_ColorsRef.Controls.Add(this.pictureBox7);
			this.groupBox_ColorsRef.Controls.Add(this.label8);
			this.groupBox_ColorsRef.Controls.Add(this.pictureBox6);
			this.groupBox_ColorsRef.Controls.Add(this.label7);
			this.groupBox_ColorsRef.Controls.Add(this.label6);
			this.groupBox_ColorsRef.Controls.Add(this.pictureBox5);
			this.groupBox_ColorsRef.Controls.Add(this.pictureBox4);
			this.groupBox_ColorsRef.Controls.Add(this.pictureBox3);
			this.groupBox_ColorsRef.Controls.Add(this.pictureBox2);
			this.groupBox_ColorsRef.Controls.Add(this.label5);
			this.groupBox_ColorsRef.Controls.Add(this.label3);
			this.groupBox_ColorsRef.Controls.Add(this.label4);
			this.groupBox_ColorsRef.Font = new System.Drawing.Font("Segoe UI Semibold", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox_ColorsRef.Location = new System.Drawing.Point(700, 43);
			this.groupBox_ColorsRef.Name = "groupBox_ColorsRef";
			this.groupBox_ColorsRef.Size = new System.Drawing.Size(653, 130);
			this.groupBox_ColorsRef.TabIndex = 5;
			this.groupBox_ColorsRef.TabStop = false;
			this.groupBox_ColorsRef.Text = "REFERENCIAS DE COLORES PARA ALOJAMIENTOS";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(415, 101);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(67, 23);
			this.label10.TabIndex = 18;
			this.label10.Text = "Normal";
			// 
			// pictureBox9
			// 
			this.pictureBox9.BackColor = System.Drawing.Color.White;
			this.pictureBox9.Location = new System.Drawing.Point(366, 105);
			this.pictureBox9.Name = "pictureBox9";
			this.pictureBox9.Size = new System.Drawing.Size(43, 19);
			this.pictureBox9.TabIndex = 17;
			this.pictureBox9.TabStop = false;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(415, 25);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(120, 23);
			this.label9.TabIndex = 16;
			this.label9.Text = "Falta de Cierre";
			// 
			// pictureBox8
			// 
			this.pictureBox8.BackColor = System.Drawing.Color.DarkViolet;
			this.pictureBox8.Location = new System.Drawing.Point(366, 29);
			this.pictureBox8.Name = "pictureBox8";
			this.pictureBox8.Size = new System.Drawing.Size(43, 19);
			this.pictureBox8.TabIndex = 15;
			this.pictureBox8.TabStop = false;
			// 
			// pictureBox7
			// 
			this.pictureBox7.BackColor = System.Drawing.Color.OrangeRed;
			this.pictureBox7.Location = new System.Drawing.Point(366, 79);
			this.pictureBox7.Name = "pictureBox7";
			this.pictureBox7.Size = new System.Drawing.Size(43, 19);
			this.pictureBox7.TabIndex = 14;
			this.pictureBox7.TabStop = false;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(415, 75);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(89, 23);
			this.label8.TabIndex = 13;
			this.label8.Text = "Adeudado";
			// 
			// pictureBox6
			// 
			this.pictureBox6.BackColor = System.Drawing.Color.Orange;
			this.pictureBox6.Location = new System.Drawing.Point(366, 53);
			this.pictureBox6.Name = "pictureBox6";
			this.pictureBox6.Size = new System.Drawing.Size(43, 19);
			this.pictureBox6.TabIndex = 12;
			this.pictureBox6.TabStop = false;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(414, 49);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(237, 23);
			this.label7.TabIndex = 11;
			this.label7.Text = "Cerrado sin Pago de Servicios";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(59, 101);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(135, 23);
			this.label6.TabIndex = 10;
			this.label6.Text = "Falta dar de Alta";
			// 
			// pictureBox5
			// 
			this.pictureBox5.BackColor = System.Drawing.Color.Pink;
			this.pictureBox5.Location = new System.Drawing.Point(10, 105);
			this.pictureBox5.Name = "pictureBox5";
			this.pictureBox5.Size = new System.Drawing.Size(43, 19);
			this.pictureBox5.TabIndex = 9;
			this.pictureBox5.TabStop = false;
			// 
			// pictureBox4
			// 
			this.pictureBox4.BackColor = System.Drawing.Color.DarkTurquoise;
			this.pictureBox4.Location = new System.Drawing.Point(10, 79);
			this.pictureBox4.Name = "pictureBox4";
			this.pictureBox4.Size = new System.Drawing.Size(43, 19);
			this.pictureBox4.TabIndex = 8;
			this.pictureBox4.TabStop = false;
			// 
			// pictureBox3
			// 
			this.pictureBox3.BackColor = System.Drawing.Color.Aquamarine;
			this.pictureBox3.Location = new System.Drawing.Point(10, 53);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(43, 19);
			this.pictureBox3.TabIndex = 7;
			this.pictureBox3.TabStop = false;
			// 
			// pictureBox2
			// 
			this.pictureBox2.BackColor = System.Drawing.Color.Gold;
			this.pictureBox2.Location = new System.Drawing.Point(10, 29);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(43, 19);
			this.pictureBox2.TabIndex = 6;
			this.pictureBox2.TabStop = false;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(59, 77);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(175, 23);
			this.label5.TabIndex = 5;
			this.label5.Text = "Realizar el Cierre Hoy";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(59, 49);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(213, 23);
			this.label3.TabIndex = 1;
			this.label3.Text = "Reserva a Dar de Alta Hoy";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(59, 25);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(269, 23);
			this.label4.TabIndex = 0;
			this.label4.Text = "Sin Depósito tras 72hs de Reserva";
			// 
			// VentanaPrincipal
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(1362, 541);
			this.Controls.Add(this.groupBox_ColorsRef);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox_disponibilidad);
			this.Controls.Add(menuStrip1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = menuStrip1;
			this.Name = "VentanaPrincipal";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Sistema de Información de Alojamientos - FJPPER";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.VentanaPrincipal_FormClosing);
			this.Load += new System.EventHandler(this.VentanaPrincipal_Load);
			menuStrip1.ResumeLayout(false);
			menuStrip1.PerformLayout();
			this.groupBox_disponibilidad.ResumeLayout(false);
			this.groupBox_disponibilidad.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dGV_Alojamientos)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
			this.groupBox_ColorsRef.ResumeLayout(false);
			this.groupBox_ColorsRef.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
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
        private System.Windows.Forms.ToolStripMenuItem listarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem movimientoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administracionToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox_disponibilidad;
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
        private System.Windows.Forms.ToolStripMenuItem agregarServicioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem serviciosConsumidosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem altaDeReservaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serviciosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tarifasToolStripMenuItem;
        private System.Windows.Forms.Button btn_VerDetalle;
        private System.Windows.Forms.ToolStripMenuItem modificarAltaDeClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actualizarTarifasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarHabitacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarAltaDeCuposToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem modificarDatosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cancelarReservaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem alojamientosConDeudaToolStripMenuItem;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ToolStripMenuItem listaPersonalizadaToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.GroupBox groupBox_ColorsRef;
		private System.Windows.Forms.PictureBox pictureBox3;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.PictureBox pictureBox4;
		private System.Windows.Forms.PictureBox pictureBox5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.PictureBox pictureBox7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.PictureBox pictureBox6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.PictureBox pictureBox8;
		private System.Windows.Forms.ToolStripMenuItem agregarCiudadToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem agregarToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem modificarToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
		private System.Windows.Forms.DataGridViewTextBoxColumn clm_Estado;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
		private System.Windows.Forms.DataGridViewTextBoxColumn clm_DNI;
		private System.Windows.Forms.DataGridViewTextBoxColumn clm_Legajo;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
		private System.Windows.Forms.DataGridViewTextBoxColumn clm_Ref;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.PictureBox pictureBox9;
		private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem cambiarContraseñaToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem nuevoUsuarioToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem eliminarUsuarioToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem serviciosToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem4;
		private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem actulizarCostosToolStripMenuItem;
	}
}