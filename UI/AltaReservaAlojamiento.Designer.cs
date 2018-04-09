namespace UI
{
    partial class AltaReservaAlojamiento
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AltaReservaAlojamiento));
			this.txb_fechaActual = new System.Windows.Forms.TextBox();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.btn_VerificarDisponibilidad = new System.Windows.Forms.Button();
			this.dtp_fechaHasta = new System.Windows.Forms.DateTimePicker();
			this.dtp_fechaDesde = new System.Windows.Forms.DateTimePicker();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.dGV_Habs = new System.Windows.Forms.DataGridView();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.dGV_ClienteResponsable = new System.Windows.Forms.DataGridView();
			this.clm_Dni = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.clm_Legajo = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.clm_Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.clm_Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.clm_tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.button2 = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			this.btn_Aceptar = new System.Windows.Forms.Button();
			this.txb_CostoBase = new System.Windows.Forms.TextBox();
			this.label12 = new System.Windows.Forms.Label();
			this.txb_Deposito = new System.Windows.Forms.TextBox();
			this.label13 = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.btn_Confirmar = new System.Windows.Forms.PictureBox();
			this.button1 = new System.Windows.Forms.Button();
			this.groupBox_excl = new System.Windows.Forms.GroupBox();
			this.dGV_excl = new System.Windows.Forms.DataGridView();
			this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewButtonColumn1 = new System.Windows.Forms.DataGridViewButtonColumn();
			this.clm_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.clmk_tipoCliente = new System.Windows.Forms.DataGridViewComboBoxColumn();
			this.groupBox1.SuspendLayout();
			this.groupBox4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dGV_Habs)).BeginInit();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dGV_ClienteResponsable)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.btn_Confirmar)).BeginInit();
			this.groupBox_excl.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dGV_excl)).BeginInit();
			this.SuspendLayout();
			// 
			// txb_fechaActual
			// 
			this.txb_fechaActual.Enabled = false;
			this.txb_fechaActual.Font = new System.Drawing.Font("Segoe UI Semibold", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txb_fechaActual.Location = new System.Drawing.Point(768, 7);
			this.txb_fechaActual.Name = "txb_fechaActual";
			this.txb_fechaActual.ReadOnly = true;
			this.txb_fechaActual.Size = new System.Drawing.Size(118, 30);
			this.txb_fechaActual.TabIndex = 7;
			this.txb_fechaActual.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// textBox1
			// 
			this.textBox1.Enabled = false;
			this.textBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.textBox1.Location = new System.Drawing.Point(58, 6);
			this.textBox1.Name = "textBox1";
			this.textBox1.ReadOnly = true;
			this.textBox1.Size = new System.Drawing.Size(116, 30);
			this.textBox1.TabIndex = 6;
			this.textBox1.Text = "En proceso...";
			this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(656, 9);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(108, 23);
			this.label2.TabIndex = 5;
			this.label2.Text = "Fecha Actual";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(27, 23);
			this.label1.TabIndex = 4;
			this.label1.Text = "ID";
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
			this.groupBox1.Location = new System.Drawing.Point(12, 44);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(880, 97);
			this.groupBox1.TabIndex = 8;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Disponibilidad de Habitaciones";
			// 
			// btn_VerificarDisponibilidad
			// 
			this.btn_VerificarDisponibilidad.BackColor = System.Drawing.SystemColors.MenuHighlight;
			this.btn_VerificarDisponibilidad.Font = new System.Drawing.Font("Segoe UI Semibold", 12.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_VerificarDisponibilidad.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.btn_VerificarDisponibilidad.Location = new System.Drawing.Point(654, 31);
			this.btn_VerificarDisponibilidad.Name = "btn_VerificarDisponibilidad";
			this.btn_VerificarDisponibilidad.Size = new System.Drawing.Size(199, 41);
			this.btn_VerificarDisponibilidad.TabIndex = 1;
			this.btn_VerificarDisponibilidad.Text = "Verificar Disponibilidad";
			this.btn_VerificarDisponibilidad.UseVisualStyleBackColor = false;
			this.btn_VerificarDisponibilidad.Click += new System.EventHandler(this.btn_VerificarDisponibilidad_Click);
			// 
			// dtp_fechaHasta
			// 
			this.dtp_fechaHasta.Font = new System.Drawing.Font("Segoe UI Semibold", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtp_fechaHasta.Location = new System.Drawing.Point(170, 57);
			this.dtp_fechaHasta.Name = "dtp_fechaHasta";
			this.dtp_fechaHasta.Size = new System.Drawing.Size(448, 30);
			this.dtp_fechaHasta.TabIndex = 3;
			this.dtp_fechaHasta.TabStop = false;
			this.dtp_fechaHasta.ValueChanged += new System.EventHandler(this.dtp_fechaHasta_ValueChanged);
			// 
			// dtp_fechaDesde
			// 
			this.dtp_fechaDesde.AccessibleRole = System.Windows.Forms.AccessibleRole.Row;
			this.dtp_fechaDesde.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.dtp_fechaDesde.CalendarTrailingForeColor = System.Drawing.Color.Black;
			this.dtp_fechaDesde.Cursor = System.Windows.Forms.Cursors.Default;
			this.dtp_fechaDesde.Font = new System.Drawing.Font("Segoe UI Semibold", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtp_fechaDesde.Location = new System.Drawing.Point(170, 25);
			this.dtp_fechaDesde.Name = "dtp_fechaDesde";
			this.dtp_fechaDesde.Size = new System.Drawing.Size(448, 30);
			this.dtp_fechaDesde.TabIndex = 2;
			this.dtp_fechaDesde.TabStop = false;
			this.dtp_fechaDesde.ValueChanged += new System.EventHandler(this.dtp_fechaDesde_ValueChanged);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(17, 63);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(142, 23);
			this.label4.TabIndex = 1;
			this.label4.Text = "Fecha Est. Egreso";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(17, 31);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(148, 23);
			this.label3.TabIndex = 0;
			this.label3.Text = "Fecha Est. Ingreso";
			// 
			// groupBox4
			// 
			this.groupBox4.BackColor = System.Drawing.Color.Transparent;
			this.groupBox4.Controls.Add(this.dGV_Habs);
			this.groupBox4.Enabled = false;
			this.groupBox4.Font = new System.Drawing.Font("Segoe UI Semibold", 12.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox4.Location = new System.Drawing.Point(12, 147);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(541, 288);
			this.groupBox4.TabIndex = 15;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "Habitaciones Seleccionadas";
			// 
			// dGV_Habs
			// 
			this.dGV_Habs.AllowUserToAddRows = false;
			this.dGV_Habs.AllowUserToDeleteRows = false;
			this.dGV_Habs.AllowUserToResizeColumns = false;
			this.dGV_Habs.AllowUserToResizeRows = false;
			this.dGV_Habs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 12.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dGV_Habs.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dGV_Habs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dGV_Habs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clm_Id,
            this.dataGridViewTextBoxColumn1,
            this.clmk_tipoCliente});
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 12.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dGV_Habs.DefaultCellStyle = dataGridViewCellStyle2;
			this.dGV_Habs.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dGV_Habs.Location = new System.Drawing.Point(3, 26);
			this.dGV_Habs.Name = "dGV_Habs";
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 12.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dGV_Habs.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
			this.dGV_Habs.RowHeadersVisible = false;
			this.dGV_Habs.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
			this.dGV_Habs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dGV_Habs.Size = new System.Drawing.Size(535, 259);
			this.dGV_Habs.TabIndex = 2;
			this.dGV_Habs.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dGV_Habs_DataError);
			// 
			// groupBox2
			// 
			this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox2.BackColor = System.Drawing.Color.Transparent;
			this.groupBox2.Controls.Add(this.dGV_ClienteResponsable);
			this.groupBox2.Controls.Add(this.button2);
			this.groupBox2.Font = new System.Drawing.Font("Segoe UI Semibold", 12.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox2.Location = new System.Drawing.Point(12, 441);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(880, 124);
			this.groupBox2.TabIndex = 16;
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
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Semibold", 12.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dGV_ClienteResponsable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
			this.dGV_ClienteResponsable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dGV_ClienteResponsable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clm_Dni,
            this.clm_Legajo,
            this.clm_Apellido,
            this.clm_Nombre,
            this.clm_tipo});
			dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Semibold", 12.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dGV_ClienteResponsable.DefaultCellStyle = dataGridViewCellStyle5;
			this.dGV_ClienteResponsable.Location = new System.Drawing.Point(6, 52);
			this.dGV_ClienteResponsable.Name = "dGV_ClienteResponsable";
			this.dGV_ClienteResponsable.ReadOnly = true;
			dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI Semibold", 12.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dGV_ClienteResponsable.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
			this.dGV_ClienteResponsable.RowHeadersVisible = false;
			dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dGV_ClienteResponsable.RowsDefaultCellStyle = dataGridViewCellStyle7;
			this.dGV_ClienteResponsable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dGV_ClienteResponsable.Size = new System.Drawing.Size(868, 61);
			this.dGV_ClienteResponsable.TabIndex = 10;
			// 
			// clm_Dni
			// 
			this.clm_Dni.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.clm_Dni.FillWeight = 40F;
			this.clm_Dni.HeaderText = "DNI";
			this.clm_Dni.Name = "clm_Dni";
			this.clm_Dni.ReadOnly = true;
			// 
			// clm_Legajo
			// 
			this.clm_Legajo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.clm_Legajo.FillWeight = 40F;
			this.clm_Legajo.HeaderText = "Legajo";
			this.clm_Legajo.Name = "clm_Legajo";
			this.clm_Legajo.ReadOnly = true;
			// 
			// clm_Apellido
			// 
			this.clm_Apellido.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.clm_Apellido.FillWeight = 70F;
			this.clm_Apellido.HeaderText = "Apellido";
			this.clm_Apellido.Name = "clm_Apellido";
			this.clm_Apellido.ReadOnly = true;
			// 
			// clm_Nombre
			// 
			this.clm_Nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.clm_Nombre.FillWeight = 70F;
			this.clm_Nombre.HeaderText = "Nombre";
			this.clm_Nombre.Name = "clm_Nombre";
			this.clm_Nombre.ReadOnly = true;
			// 
			// clm_tipo
			// 
			this.clm_tipo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.clm_tipo.FillWeight = 70F;
			this.clm_tipo.HeaderText = "Tipo";
			this.clm_tipo.Name = "clm_tipo";
			this.clm_tipo.ReadOnly = true;
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.Color.White;
			this.button2.Font = new System.Drawing.Font("Segoe UI Semibold", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button2.Location = new System.Drawing.Point(738, 16);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(135, 30);
			this.button2.TabIndex = 9;
			this.button2.Text = "Buscar Cliente";
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button5
			// 
			this.button5.BackColor = System.Drawing.Color.White;
			this.button5.Font = new System.Drawing.Font("Segoe UI Semibold", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button5.Location = new System.Drawing.Point(12, 659);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(125, 30);
			this.button5.TabIndex = 19;
			this.button5.Text = "Cancelar";
			this.button5.UseVisualStyleBackColor = false;
			this.button5.Click += new System.EventHandler(this.button5_Click);
			// 
			// btn_Aceptar
			// 
			this.btn_Aceptar.BackColor = System.Drawing.Color.White;
			this.btn_Aceptar.Enabled = false;
			this.btn_Aceptar.Font = new System.Drawing.Font("Segoe UI Semibold", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_Aceptar.Location = new System.Drawing.Point(760, 659);
			this.btn_Aceptar.Name = "btn_Aceptar";
			this.btn_Aceptar.Size = new System.Drawing.Size(125, 30);
			this.btn_Aceptar.TabIndex = 18;
			this.btn_Aceptar.Text = "Aceptar";
			this.btn_Aceptar.UseVisualStyleBackColor = false;
			this.btn_Aceptar.Click += new System.EventHandler(this.btn_Aceptar_Click);
			// 
			// txb_CostoBase
			// 
			this.txb_CostoBase.Enabled = false;
			this.txb_CostoBase.Font = new System.Drawing.Font("Segoe UI Semibold", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txb_CostoBase.Location = new System.Drawing.Point(122, 599);
			this.txb_CostoBase.Name = "txb_CostoBase";
			this.txb_CostoBase.ReadOnly = true;
			this.txb_CostoBase.Size = new System.Drawing.Size(83, 30);
			this.txb_CostoBase.TabIndex = 22;
			this.txb_CostoBase.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.BackColor = System.Drawing.Color.Transparent;
			this.label12.Font = new System.Drawing.Font("Segoe UI Semibold", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label12.Location = new System.Drawing.Point(13, 602);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(94, 23);
			this.label12.TabIndex = 21;
			this.label12.Text = "Costo Base";
			// 
			// txb_Deposito
			// 
			this.txb_Deposito.Enabled = false;
			this.txb_Deposito.Font = new System.Drawing.Font("Segoe UI Semibold", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txb_Deposito.Location = new System.Drawing.Point(320, 599);
			this.txb_Deposito.Name = "txb_Deposito";
			this.txb_Deposito.ReadOnly = true;
			this.txb_Deposito.Size = new System.Drawing.Size(83, 30);
			this.txb_Deposito.TabIndex = 24;
			this.txb_Deposito.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.BackColor = System.Drawing.Color.Transparent;
			this.label13.Font = new System.Drawing.Font("Segoe UI Semibold", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label13.Location = new System.Drawing.Point(236, 602);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(78, 23);
			this.label13.TabIndex = 23;
			this.label13.Text = "Depósito";
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.BackColor = System.Drawing.Color.Transparent;
			this.label14.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label14.Location = new System.Drawing.Point(694, 606);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(96, 19);
			this.label14.TabIndex = 26;
			this.label14.Text = "COMPROBAR";
			this.label14.Visible = false;
			// 
			// btn_Confirmar
			// 
			this.btn_Confirmar.BackColor = System.Drawing.Color.Transparent;
			this.btn_Confirmar.Image = global::UI.Properties.Resources.Boton_Go;
			this.btn_Confirmar.InitialImage = null;
			this.btn_Confirmar.Location = new System.Drawing.Point(796, 581);
			this.btn_Confirmar.Name = "btn_Confirmar";
			this.btn_Confirmar.Size = new System.Drawing.Size(63, 61);
			this.btn_Confirmar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.btn_Confirmar.TabIndex = 25;
			this.btn_Confirmar.TabStop = false;
			this.btn_Confirmar.Click += new System.EventHandler(this.btn_Confirmar_Click);
			this.btn_Confirmar.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave_1);
			this.btn_Confirmar.MouseHover += new System.EventHandler(this.pictureBox1_MouseHover);
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.OrangeRed;
			this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 12.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.button1.Location = new System.Drawing.Point(720, 287);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(145, 41);
			this.button1.TabIndex = 28;
			this.button1.Text = "No es TOUR";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// groupBox_excl
			// 
			this.groupBox_excl.BackColor = System.Drawing.Color.Transparent;
			this.groupBox_excl.Controls.Add(this.dGV_excl);
			this.groupBox_excl.Font = new System.Drawing.Font("Segoe UI Semibold", 12.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox_excl.Location = new System.Drawing.Point(569, 147);
			this.groupBox_excl.Name = "groupBox_excl";
			this.groupBox_excl.Size = new System.Drawing.Size(122, 288);
			this.groupBox_excl.TabIndex = 29;
			this.groupBox_excl.TabStop = false;
			this.groupBox_excl.Text = "Exclusividad";
			// 
			// dGV_excl
			// 
			this.dGV_excl.AllowUserToAddRows = false;
			this.dGV_excl.AllowUserToDeleteRows = false;
			this.dGV_excl.AllowUserToResizeColumns = false;
			this.dGV_excl.AllowUserToResizeRows = false;
			this.dGV_excl.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI Semibold", 12.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dGV_excl.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
			this.dGV_excl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dGV_excl.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewButtonColumn1});
			dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI Semibold", 12.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dGV_excl.DefaultCellStyle = dataGridViewCellStyle9;
			this.dGV_excl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dGV_excl.Location = new System.Drawing.Point(3, 26);
			this.dGV_excl.Name = "dGV_excl";
			dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI Semibold", 12.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dGV_excl.RowHeadersDefaultCellStyle = dataGridViewCellStyle10;
			this.dGV_excl.RowHeadersVisible = false;
			this.dGV_excl.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
			this.dGV_excl.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dGV_excl.Size = new System.Drawing.Size(116, 259);
			this.dGV_excl.TabIndex = 2;
			// 
			// dataGridViewTextBoxColumn2
			// 
			this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn2.FillWeight = 40F;
			this.dataGridViewTextBoxColumn2.HeaderText = "Nro";
			this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
			// 
			// dataGridViewButtonColumn1
			// 
			this.dataGridViewButtonColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewButtonColumn1.FillWeight = 45F;
			this.dataGridViewButtonColumn1.HeaderText = "Excl";
			this.dataGridViewButtonColumn1.Name = "dataGridViewButtonColumn1";
			this.dataGridViewButtonColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridViewButtonColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			// 
			// clm_Id
			// 
			this.clm_Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.clm_Id.FillWeight = 40F;
			this.clm_Id.HeaderText = "Número";
			this.clm_Id.Name = "clm_Id";
			// 
			// dataGridViewTextBoxColumn1
			// 
			this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn1.FillWeight = 40F;
			this.dataGridViewTextBoxColumn1.HeaderText = "Planta";
			this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
			// 
			// clmk_tipoCliente
			// 
			this.clmk_tipoCliente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.clmk_tipoCliente.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
			this.clmk_tipoCliente.HeaderText = "Tipo Cliente";
			this.clmk_tipoCliente.Items.AddRange(new object[] {
            "Acomp. Directo",
            "Acomp. No Direct,",
            "Convenio",
            "Titular",
            "Titular Exceptuado"});
			this.clmk_tipoCliente.Name = "clmk_tipoCliente";
			this.clmk_tipoCliente.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.clmk_tipoCliente.Sorted = true;
			this.clmk_tipoCliente.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			// 
			// AltaReservaAlojamiento
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.BackgroundImage = global::UI.Properties.Resources.FondoPantallas;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(898, 701);
			this.Controls.Add(this.groupBox_excl);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label14);
			this.Controls.Add(this.btn_Confirmar);
			this.Controls.Add(this.txb_Deposito);
			this.Controls.Add(this.label13);
			this.Controls.Add(this.txb_CostoBase);
			this.Controls.Add(this.label12);
			this.Controls.Add(this.button5);
			this.Controls.Add(this.btn_Aceptar);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox4);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.txb_fechaActual);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.DoubleBuffered = true;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "AltaReservaAlojamiento";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Nueva Reserva";
			this.Load += new System.EventHandler(this.AltaReservaAlojamiento_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox4.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dGV_Habs)).EndInit();
			this.groupBox2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dGV_ClienteResponsable)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.btn_Confirmar)).EndInit();
			this.groupBox_excl.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dGV_excl)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txb_fechaActual;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_VerificarDisponibilidad;
        private System.Windows.Forms.DateTimePicker dtp_fechaHasta;
        private System.Windows.Forms.DateTimePicker dtp_fechaDesde;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btn_Aceptar;
        private System.Windows.Forms.TextBox txb_CostoBase;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txb_Deposito;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.PictureBox btn_Confirmar;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DataGridView dGV_ClienteResponsable;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_Dni;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_Legajo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_tipo;
		private System.Windows.Forms.DataGridView dGV_Habs;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.GroupBox groupBox_excl;
		private System.Windows.Forms.DataGridView dGV_excl;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
		private System.Windows.Forms.DataGridViewButtonColumn dataGridViewButtonColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn clm_Id;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewComboBoxColumn clmk_tipoCliente;
	}
}