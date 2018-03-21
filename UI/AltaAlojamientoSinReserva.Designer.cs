﻿namespace UI
{
    partial class AltaAlojamientoSinReserva
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AltaAlojamientoSinReserva));
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txb_IdAloj = new System.Windows.Forms.TextBox();
			this.txb_fechaActual = new System.Windows.Forms.TextBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.btn_VerificarDisponibilidad = new System.Windows.Forms.Button();
			this.dtp_fechaHasta = new System.Windows.Forms.DateTimePicker();
			this.dtp_fechaDesde = new System.Windows.Forms.DateTimePicker();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.dGV_ClienteResponsable = new System.Windows.Forms.DataGridView();
			this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.clm_legajo = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.clm_nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.btn_AgregarCliente = new System.Windows.Forms.Button();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.button_visualizarReserva = new System.Windows.Forms.Button();
			this.btn_quitarCliente = new System.Windows.Forms.Button();
			this.dGV_Acompañantes = new System.Windows.Forms.DataGridView();
			this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.clm_legajoAcomp = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.clm_nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.btn_AgregarAcompañante = new System.Windows.Forms.Button();
			this.btn_Aceptar = new System.Windows.Forms.Button();
			this.btn_Cancelar = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.txb_CostoBase = new System.Windows.Forms.TextBox();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.txb_planta = new System.Windows.Forms.TextBox();
			this.lbl_planta = new System.Windows.Forms.Label();
			this.txb_capacidad = new System.Windows.Forms.TextBox();
			this.lbl_capacidad = new System.Windows.Forms.Label();
			this.ck_Exclusividad = new System.Windows.Forms.CheckBox();
			this.txb_NroHabitacion = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.btn_Comprobar = new System.Windows.Forms.PictureBox();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dGV_ClienteResponsable)).BeginInit();
			this.groupBox3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dGV_Acompañantes)).BeginInit();
			this.groupBox4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.btn_Comprobar)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(20, 12);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(27, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "ID";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(642, 9);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(108, 23);
			this.label2.TabIndex = 1;
			this.label2.Text = "Fecha Actual";
			// 
			// txb_IdAloj
			// 
			this.txb_IdAloj.Enabled = false;
			this.txb_IdAloj.Font = new System.Drawing.Font("Segoe UI Semibold", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txb_IdAloj.Location = new System.Drawing.Point(67, 9);
			this.txb_IdAloj.Name = "txb_IdAloj";
			this.txb_IdAloj.ReadOnly = true;
			this.txb_IdAloj.Size = new System.Drawing.Size(131, 30);
			this.txb_IdAloj.TabIndex = 2;
			this.txb_IdAloj.TabStop = false;
			this.txb_IdAloj.Text = "En proceso...";
			this.txb_IdAloj.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txb_IdAloj.WordWrap = false;
			// 
			// txb_fechaActual
			// 
			this.txb_fechaActual.Enabled = false;
			this.txb_fechaActual.Font = new System.Drawing.Font("Segoe UI Semibold", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txb_fechaActual.Location = new System.Drawing.Point(756, 5);
			this.txb_fechaActual.Name = "txb_fechaActual";
			this.txb_fechaActual.ReadOnly = true;
			this.txb_fechaActual.Size = new System.Drawing.Size(121, 30);
			this.txb_fechaActual.TabIndex = 3;
			this.txb_fechaActual.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.Color.Transparent;
			this.groupBox1.Controls.Add(this.btn_VerificarDisponibilidad);
			this.groupBox1.Controls.Add(this.dtp_fechaHasta);
			this.groupBox1.Controls.Add(this.dtp_fechaDesde);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 12.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(12, 50);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(865, 105);
			this.groupBox1.TabIndex = 4;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Disponibilidad de Habitaciones";
			// 
			// btn_VerificarDisponibilidad
			// 
			this.btn_VerificarDisponibilidad.BackColor = System.Drawing.SystemColors.MenuHighlight;
			this.btn_VerificarDisponibilidad.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.btn_VerificarDisponibilidad.Location = new System.Drawing.Point(621, 42);
			this.btn_VerificarDisponibilidad.Name = "btn_VerificarDisponibilidad";
			this.btn_VerificarDisponibilidad.Size = new System.Drawing.Size(210, 44);
			this.btn_VerificarDisponibilidad.TabIndex = 4;
			this.btn_VerificarDisponibilidad.Text = "Verificar Disponibilidad";
			this.btn_VerificarDisponibilidad.UseVisualStyleBackColor = false;
			this.btn_VerificarDisponibilidad.Click += new System.EventHandler(this.btn_VerificarDisponibilidad_Click);
			// 
			// dtp_fechaHasta
			// 
			this.dtp_fechaHasta.Location = new System.Drawing.Point(172, 64);
			this.dtp_fechaHasta.Name = "dtp_fechaHasta";
			this.dtp_fechaHasta.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.dtp_fechaHasta.Size = new System.Drawing.Size(406, 30);
			this.dtp_fechaHasta.TabIndex = 3;
			this.dtp_fechaHasta.Value = new System.DateTime(2018, 1, 3, 0, 0, 0, 0);
			this.dtp_fechaHasta.ValueChanged += new System.EventHandler(this.dtp_fechaHasta_ValueChanged);
			// 
			// dtp_fechaDesde
			// 
			this.dtp_fechaDesde.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.dtp_fechaDesde.CalendarTrailingForeColor = System.Drawing.Color.Black;
			this.dtp_fechaDesde.Cursor = System.Windows.Forms.Cursors.Default;
			this.dtp_fechaDesde.Enabled = false;
			this.dtp_fechaDesde.Location = new System.Drawing.Point(172, 28);
			this.dtp_fechaDesde.Name = "dtp_fechaDesde";
			this.dtp_fechaDesde.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.dtp_fechaDesde.Size = new System.Drawing.Size(406, 30);
			this.dtp_fechaDesde.TabIndex = 2;
			this.dtp_fechaDesde.ValueChanged += new System.EventHandler(this.dtp_fechaDesde_ValueChanged);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(17, 63);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(111, 23);
			this.label4.TabIndex = 1;
			this.label4.Text = "Fecha Egreso";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(17, 31);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(117, 23);
			this.label3.TabIndex = 0;
			this.label3.Text = "Fecha Ingreso";
			// 
			// groupBox2
			// 
			this.groupBox2.BackColor = System.Drawing.Color.Transparent;
			this.groupBox2.Controls.Add(this.dGV_ClienteResponsable);
			this.groupBox2.Controls.Add(this.btn_AgregarCliente);
			this.groupBox2.Enabled = false;
			this.groupBox2.Font = new System.Drawing.Font("Segoe UI Semibold", 12.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox2.Location = new System.Drawing.Point(12, 240);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(865, 129);
			this.groupBox2.TabIndex = 5;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Cliente Responsable";
			// 
			// dGV_ClienteResponsable
			// 
			this.dGV_ClienteResponsable.AllowUserToAddRows = false;
			this.dGV_ClienteResponsable.AllowUserToDeleteRows = false;
			this.dGV_ClienteResponsable.AllowUserToResizeColumns = false;
			this.dGV_ClienteResponsable.AllowUserToResizeRows = false;
			this.dGV_ClienteResponsable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 12.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dGV_ClienteResponsable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dGV_ClienteResponsable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dGV_ClienteResponsable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.clm_legajo,
            this.dataGridViewTextBoxColumn6,
            this.clm_nombre,
            this.dataGridViewTextBoxColumn7});
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 12.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dGV_ClienteResponsable.DefaultCellStyle = dataGridViewCellStyle2;
			this.dGV_ClienteResponsable.Location = new System.Drawing.Point(6, 56);
			this.dGV_ClienteResponsable.Name = "dGV_ClienteResponsable";
			this.dGV_ClienteResponsable.ReadOnly = true;
			this.dGV_ClienteResponsable.RowHeadersVisible = false;
			this.dGV_ClienteResponsable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dGV_ClienteResponsable.Size = new System.Drawing.Size(853, 62);
			this.dGV_ClienteResponsable.TabIndex = 14;
			// 
			// dataGridViewTextBoxColumn5
			// 
			this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn5.FillWeight = 40F;
			this.dataGridViewTextBoxColumn5.HeaderText = "DNI";
			this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
			this.dataGridViewTextBoxColumn5.ReadOnly = true;
			// 
			// clm_legajo
			// 
			this.clm_legajo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.clm_legajo.FillWeight = 40F;
			this.clm_legajo.HeaderText = "Legajo";
			this.clm_legajo.Name = "clm_legajo";
			this.clm_legajo.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn6
			// 
			this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn6.FillWeight = 70F;
			this.dataGridViewTextBoxColumn6.HeaderText = "Apellido";
			this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
			this.dataGridViewTextBoxColumn6.ReadOnly = true;
			// 
			// clm_nombre
			// 
			this.clm_nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.clm_nombre.FillWeight = 70F;
			this.clm_nombre.HeaderText = "Nombre";
			this.clm_nombre.Name = "clm_nombre";
			this.clm_nombre.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn7
			// 
			this.dataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn7.FillWeight = 70F;
			this.dataGridViewTextBoxColumn7.HeaderText = "Tipo Cliente";
			this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
			this.dataGridViewTextBoxColumn7.ReadOnly = true;
			// 
			// btn_AgregarCliente
			// 
			this.btn_AgregarCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btn_AgregarCliente.Location = new System.Drawing.Point(749, 20);
			this.btn_AgregarCliente.Name = "btn_AgregarCliente";
			this.btn_AgregarCliente.Size = new System.Drawing.Size(110, 30);
			this.btn_AgregarCliente.TabIndex = 9;
			this.btn_AgregarCliente.Text = "Agregar Responsable";
			this.btn_AgregarCliente.UseVisualStyleBackColor = true;
			this.btn_AgregarCliente.Click += new System.EventHandler(this.btn_AgregarCliente_Click);
			// 
			// groupBox3
			// 
			this.groupBox3.BackColor = System.Drawing.Color.Transparent;
			this.groupBox3.Controls.Add(this.button_visualizarReserva);
			this.groupBox3.Controls.Add(this.btn_quitarCliente);
			this.groupBox3.Controls.Add(this.dGV_Acompañantes);
			this.groupBox3.Controls.Add(this.btn_AgregarAcompañante);
			this.groupBox3.Enabled = false;
			this.groupBox3.Font = new System.Drawing.Font("Segoe UI Semibold", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox3.Location = new System.Drawing.Point(12, 375);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(865, 176);
			this.groupBox3.TabIndex = 8;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Otros Clientes";
			// 
			// button_visualizarReserva
			// 
			this.button_visualizarReserva.BackColor = System.Drawing.SystemColors.MenuHighlight;
			this.button_visualizarReserva.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.button_visualizarReserva.Location = new System.Drawing.Point(6, 20);
			this.button_visualizarReserva.Name = "button_visualizarReserva";
			this.button_visualizarReserva.Size = new System.Drawing.Size(236, 30);
			this.button_visualizarReserva.TabIndex = 13;
			this.button_visualizarReserva.Text = "Ver Detalles de Reserva";
			this.button_visualizarReserva.UseVisualStyleBackColor = false;
			this.button_visualizarReserva.Visible = false;
			this.button_visualizarReserva.Click += new System.EventHandler(this.button_visualizarReserva_Click);
			// 
			// btn_quitarCliente
			// 
			this.btn_quitarCliente.Location = new System.Drawing.Point(622, 20);
			this.btn_quitarCliente.Name = "btn_quitarCliente";
			this.btn_quitarCliente.Size = new System.Drawing.Size(110, 30);
			this.btn_quitarCliente.TabIndex = 12;
			this.btn_quitarCliente.Text = "Quitar Cliente";
			this.btn_quitarCliente.UseVisualStyleBackColor = true;
			this.btn_quitarCliente.Click += new System.EventHandler(this.btn_quitarCliente_Click);
			// 
			// dGV_Acompañantes
			// 
			this.dGV_Acompañantes.AllowUserToAddRows = false;
			this.dGV_Acompañantes.AllowUserToDeleteRows = false;
			this.dGV_Acompañantes.AllowUserToOrderColumns = true;
			this.dGV_Acompañantes.AllowUserToResizeColumns = false;
			this.dGV_Acompañantes.AllowUserToResizeRows = false;
			this.dGV_Acompañantes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dGV_Acompañantes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
			this.dGV_Acompañantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dGV_Acompañantes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.clm_legajoAcomp,
            this.dataGridViewTextBoxColumn2,
            this.clm_nom,
            this.dataGridViewTextBoxColumn3});
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Semibold", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dGV_Acompañantes.DefaultCellStyle = dataGridViewCellStyle4;
			this.dGV_Acompañantes.Location = new System.Drawing.Point(6, 53);
			this.dGV_Acompañantes.Margin = new System.Windows.Forms.Padding(0);
			this.dGV_Acompañantes.Name = "dGV_Acompañantes";
			this.dGV_Acompañantes.ReadOnly = true;
			this.dGV_Acompañantes.RowHeadersVisible = false;
			this.dGV_Acompañantes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dGV_Acompañantes.Size = new System.Drawing.Size(853, 120);
			this.dGV_Acompañantes.TabIndex = 10;
			// 
			// dataGridViewTextBoxColumn1
			// 
			this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn1.FillWeight = 40F;
			this.dataGridViewTextBoxColumn1.HeaderText = "DNI";
			this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
			this.dataGridViewTextBoxColumn1.ReadOnly = true;
			// 
			// clm_legajoAcomp
			// 
			this.clm_legajoAcomp.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.clm_legajoAcomp.FillWeight = 40F;
			this.clm_legajoAcomp.HeaderText = "Legajo";
			this.clm_legajoAcomp.Name = "clm_legajoAcomp";
			this.clm_legajoAcomp.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn2
			// 
			this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn2.FillWeight = 70F;
			this.dataGridViewTextBoxColumn2.HeaderText = "Apellido";
			this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
			this.dataGridViewTextBoxColumn2.ReadOnly = true;
			// 
			// clm_nom
			// 
			this.clm_nom.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.clm_nom.FillWeight = 70F;
			this.clm_nom.HeaderText = "Nombre";
			this.clm_nom.Name = "clm_nom";
			this.clm_nom.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn3
			// 
			this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn3.FillWeight = 70F;
			this.dataGridViewTextBoxColumn3.HeaderText = "Tipo Cliente";
			this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
			this.dataGridViewTextBoxColumn3.ReadOnly = true;
			// 
			// btn_AgregarAcompañante
			// 
			this.btn_AgregarAcompañante.Location = new System.Drawing.Point(749, 20);
			this.btn_AgregarAcompañante.Name = "btn_AgregarAcompañante";
			this.btn_AgregarAcompañante.Size = new System.Drawing.Size(110, 30);
			this.btn_AgregarAcompañante.TabIndex = 11;
			this.btn_AgregarAcompañante.Text = "Agregar Cliente";
			this.btn_AgregarAcompañante.UseVisualStyleBackColor = true;
			this.btn_AgregarAcompañante.Click += new System.EventHandler(this.btn_AgregarAcompañante_Click);
			// 
			// btn_Aceptar
			// 
			this.btn_Aceptar.Enabled = false;
			this.btn_Aceptar.Font = new System.Drawing.Font("Segoe UI Semibold", 12.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_Aceptar.Location = new System.Drawing.Point(758, 623);
			this.btn_Aceptar.Name = "btn_Aceptar";
			this.btn_Aceptar.Size = new System.Drawing.Size(110, 30);
			this.btn_Aceptar.TabIndex = 9;
			this.btn_Aceptar.Text = "Aceptar";
			this.btn_Aceptar.UseVisualStyleBackColor = true;
			this.btn_Aceptar.Click += new System.EventHandler(this.btn_Aceptar_Click);
			// 
			// btn_Cancelar
			// 
			this.btn_Cancelar.Font = new System.Drawing.Font("Segoe UI Semibold", 12.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_Cancelar.Location = new System.Drawing.Point(14, 622);
			this.btn_Cancelar.Name = "btn_Cancelar";
			this.btn_Cancelar.Size = new System.Drawing.Size(110, 30);
			this.btn_Cancelar.TabIndex = 10;
			this.btn_Cancelar.Text = "Cancelar";
			this.btn_Cancelar.UseVisualStyleBackColor = true;
			this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.BackColor = System.Drawing.Color.Transparent;
			this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(16, 581);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(94, 23);
			this.label5.TabIndex = 11;
			this.label5.Text = "Costo Base";
			// 
			// txb_CostoBase
			// 
			this.txb_CostoBase.Enabled = false;
			this.txb_CostoBase.Font = new System.Drawing.Font("Segoe UI Semibold", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txb_CostoBase.Location = new System.Drawing.Point(125, 578);
			this.txb_CostoBase.Name = "txb_CostoBase";
			this.txb_CostoBase.ReadOnly = true;
			this.txb_CostoBase.Size = new System.Drawing.Size(100, 30);
			this.txb_CostoBase.TabIndex = 12;
			this.txb_CostoBase.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// groupBox4
			// 
			this.groupBox4.BackColor = System.Drawing.Color.Transparent;
			this.groupBox4.Controls.Add(this.txb_planta);
			this.groupBox4.Controls.Add(this.lbl_planta);
			this.groupBox4.Controls.Add(this.txb_capacidad);
			this.groupBox4.Controls.Add(this.lbl_capacidad);
			this.groupBox4.Controls.Add(this.ck_Exclusividad);
			this.groupBox4.Controls.Add(this.txb_NroHabitacion);
			this.groupBox4.Controls.Add(this.label6);
			this.groupBox4.Enabled = false;
			this.groupBox4.Font = new System.Drawing.Font("Segoe UI Semibold", 12.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox4.Location = new System.Drawing.Point(12, 161);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(865, 73);
			this.groupBox4.TabIndex = 14;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "Habitación Seleccionada";
			// 
			// txb_planta
			// 
			this.txb_planta.Font = new System.Drawing.Font("Segoe UI Semibold", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txb_planta.Location = new System.Drawing.Point(267, 28);
			this.txb_planta.Name = "txb_planta";
			this.txb_planta.ReadOnly = true;
			this.txb_planta.Size = new System.Drawing.Size(68, 30);
			this.txb_planta.TabIndex = 25;
			this.txb_planta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// lbl_planta
			// 
			this.lbl_planta.AutoSize = true;
			this.lbl_planta.Font = new System.Drawing.Font("Segoe UI Semibold", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_planta.Location = new System.Drawing.Point(203, 31);
			this.lbl_planta.Name = "lbl_planta";
			this.lbl_planta.Size = new System.Drawing.Size(58, 23);
			this.lbl_planta.TabIndex = 24;
			this.lbl_planta.Text = "Planta";
			// 
			// txb_capacidad
			// 
			this.txb_capacidad.Font = new System.Drawing.Font("Segoe UI Semibold", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txb_capacidad.Location = new System.Drawing.Point(493, 29);
			this.txb_capacidad.Name = "txb_capacidad";
			this.txb_capacidad.ReadOnly = true;
			this.txb_capacidad.Size = new System.Drawing.Size(33, 30);
			this.txb_capacidad.TabIndex = 23;
			this.txb_capacidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// lbl_capacidad
			// 
			this.lbl_capacidad.AutoSize = true;
			this.lbl_capacidad.Font = new System.Drawing.Font("Segoe UI Semibold", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_capacidad.Location = new System.Drawing.Point(397, 32);
			this.lbl_capacidad.Name = "lbl_capacidad";
			this.lbl_capacidad.Size = new System.Drawing.Size(90, 23);
			this.lbl_capacidad.TabIndex = 22;
			this.lbl_capacidad.Text = "Capacidad";
			// 
			// ck_Exclusividad
			// 
			this.ck_Exclusividad.AutoSize = true;
			this.ck_Exclusividad.Location = new System.Drawing.Point(597, 30);
			this.ck_Exclusividad.Name = "ck_Exclusividad";
			this.ck_Exclusividad.Size = new System.Drawing.Size(234, 27);
			this.ck_Exclusividad.TabIndex = 15;
			this.ck_Exclusividad.Text = "Exclusividad de Habitación";
			this.ck_Exclusividad.UseVisualStyleBackColor = true;
			this.ck_Exclusividad.CheckedChanged += new System.EventHandler(this.ck_Exclusividad_CheckedChanged);
			// 
			// txb_NroHabitacion
			// 
			this.txb_NroHabitacion.Location = new System.Drawing.Point(87, 28);
			this.txb_NroHabitacion.Name = "txb_NroHabitacion";
			this.txb_NroHabitacion.ReadOnly = true;
			this.txb_NroHabitacion.Size = new System.Drawing.Size(41, 30);
			this.txb_NroHabitacion.TabIndex = 16;
			this.txb_NroHabitacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(8, 32);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(73, 23);
			this.label6.TabIndex = 0;
			this.label6.Text = "Número";
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.BackColor = System.Drawing.Color.Transparent;
			this.label14.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label14.Location = new System.Drawing.Point(644, 585);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(91, 19);
			this.label14.TabIndex = 28;
			this.label14.Text = "CONFIRMAR";
			this.label14.Visible = false;
			// 
			// btn_Comprobar
			// 
			this.btn_Comprobar.BackColor = System.Drawing.Color.Transparent;
			this.btn_Comprobar.Image = global::UI.Properties.Resources.Boton_Go;
			this.btn_Comprobar.InitialImage = null;
			this.btn_Comprobar.Location = new System.Drawing.Point(575, 557);
			this.btn_Comprobar.Name = "btn_Comprobar";
			this.btn_Comprobar.Size = new System.Drawing.Size(63, 61);
			this.btn_Comprobar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.btn_Comprobar.TabIndex = 27;
			this.btn_Comprobar.TabStop = false;
			this.btn_Comprobar.Click += new System.EventHandler(this.btn_Comprobar_Click);
			this.btn_Comprobar.MouseLeave += new System.EventHandler(this.btn_Comprobar_MouseLeave);
			this.btn_Comprobar.MouseHover += new System.EventHandler(this.btn_Comprobar_MouseHover);
			// 
			// AltaAlojamientoSinReserva
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.BackgroundImage = global::UI.Properties.Resources.FondoPantallas;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(889, 664);
			this.Controls.Add(this.label14);
			this.Controls.Add(this.btn_Comprobar);
			this.Controls.Add(this.groupBox4);
			this.Controls.Add(this.txb_CostoBase);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.btn_Cancelar);
			this.Controls.Add(this.btn_Aceptar);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.txb_fechaActual);
			this.Controls.Add(this.txb_IdAloj);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "AltaAlojamientoSinReserva";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Alta de Alojamiento";
			this.Load += new System.EventHandler(this.AltaAlojamientoSinReserva_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dGV_ClienteResponsable)).EndInit();
			this.groupBox3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dGV_Acompañantes)).EndInit();
			this.groupBox4.ResumeLayout(false);
			this.groupBox4.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.btn_Comprobar)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txb_IdAloj;
        private System.Windows.Forms.TextBox txb_fechaActual;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_VerificarDisponibilidad;
        private System.Windows.Forms.DateTimePicker dtp_fechaHasta;
        private System.Windows.Forms.DateTimePicker dtp_fechaDesde;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_AgregarCliente;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_AgregarAcompañante;
        private System.Windows.Forms.DataGridView dGV_Acompañantes;
        private System.Windows.Forms.Button btn_Aceptar;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txb_CostoBase;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txb_NroHabitacion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox ck_Exclusividad;
        private System.Windows.Forms.Button btn_quitarCliente;
        private System.Windows.Forms.DataGridView dGV_ClienteResponsable;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_legajo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_legajoAcomp;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Button button_visualizarReserva;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.PictureBox btn_Comprobar;
		private System.Windows.Forms.TextBox txb_planta;
		private System.Windows.Forms.Label lbl_planta;
		private System.Windows.Forms.TextBox txb_capacidad;
		private System.Windows.Forms.Label lbl_capacidad;
	}
}