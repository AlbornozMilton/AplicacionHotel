namespace UI
{
    partial class BuscarCliente
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BuscarCliente));
			this.btn_Cancelar = new System.Windows.Forms.Button();
			this.btn_Aceptar = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.lbl_Buscar = new System.Windows.Forms.Label();
			this.btn_nuevoCliente = new System.Windows.Forms.Button();
			this.textBox_Legajo = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.radioButton_legajo = new System.Windows.Forms.RadioButton();
			this.btn_Buscar = new System.Windows.Forms.PictureBox();
			this.textBox_Nombre = new System.Windows.Forms.TextBox();
			this.textBox_DNI = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.radioButton_nombre = new System.Windows.Forms.RadioButton();
			this.radioButton1 = new System.Windows.Forms.RadioButton();
			this.gpb_altas = new System.Windows.Forms.GroupBox();
			this.rbn_Alta = new System.Windows.Forms.RadioButton();
			this.rbn_baja = new System.Windows.Forms.RadioButton();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.tablaResulClientes = new System.Windows.Forms.DataGridView();
			this.clm_Dni = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.clm_legajo = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.clm_apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.clm_nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.clm_Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.button_verDatosCliente = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.btn_Buscar)).BeginInit();
			this.gpb_altas.SuspendLayout();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.tablaResulClientes)).BeginInit();
			this.SuspendLayout();
			// 
			// btn_Cancelar
			// 
			this.btn_Cancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_Cancelar.BackColor = System.Drawing.SystemColors.Control;
			this.btn_Cancelar.Font = new System.Drawing.Font("Segoe UI Semibold", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_Cancelar.Location = new System.Drawing.Point(12, 399);
			this.btn_Cancelar.Name = "btn_Cancelar";
			this.btn_Cancelar.Size = new System.Drawing.Size(110, 30);
			this.btn_Cancelar.TabIndex = 0;
			this.btn_Cancelar.Text = "Cancelar";
			this.btn_Cancelar.UseVisualStyleBackColor = false;
			this.btn_Cancelar.Click += new System.EventHandler(this.button1_Click);
			// 
			// btn_Aceptar
			// 
			this.btn_Aceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_Aceptar.BackColor = System.Drawing.SystemColors.Control;
			this.btn_Aceptar.Font = new System.Drawing.Font("Segoe UI Semibold", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_Aceptar.Location = new System.Drawing.Point(904, 399);
			this.btn_Aceptar.Name = "btn_Aceptar";
			this.btn_Aceptar.Size = new System.Drawing.Size(110, 30);
			this.btn_Aceptar.TabIndex = 1;
			this.btn_Aceptar.Text = "Seleccionar";
			this.btn_Aceptar.UseVisualStyleBackColor = false;
			this.btn_Aceptar.Click += new System.EventHandler(this.btn_Aceptar_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox1.BackColor = System.Drawing.Color.Transparent;
			this.groupBox1.Controls.Add(this.lbl_Buscar);
			this.groupBox1.Controls.Add(this.btn_nuevoCliente);
			this.groupBox1.Controls.Add(this.textBox_Legajo);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.radioButton_legajo);
			this.groupBox1.Controls.Add(this.btn_Buscar);
			this.groupBox1.Controls.Add(this.textBox_Nombre);
			this.groupBox1.Controls.Add(this.textBox_DNI);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.radioButton_nombre);
			this.groupBox1.Controls.Add(this.radioButton1);
			this.groupBox1.Controls.Add(this.gpb_altas);
			this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 12.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(13, 13);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(1001, 150);
			this.groupBox1.TabIndex = 2;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Búsqueda";
			// 
			// lbl_Buscar
			// 
			this.lbl_Buscar.AutoSize = true;
			this.lbl_Buscar.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_Buscar.Location = new System.Drawing.Point(625, 37);
			this.lbl_Buscar.Name = "lbl_Buscar";
			this.lbl_Buscar.Size = new System.Drawing.Size(50, 19);
			this.lbl_Buscar.TabIndex = 15;
			this.lbl_Buscar.Text = "Buscar";
			this.lbl_Buscar.Visible = false;
			// 
			// btn_nuevoCliente
			// 
			this.btn_nuevoCliente.BackColor = System.Drawing.SystemColors.MenuHighlight;
			this.btn_nuevoCliente.Font = new System.Drawing.Font("Segoe UI Semibold", 12.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_nuevoCliente.ForeColor = System.Drawing.Color.White;
			this.btn_nuevoCliente.Location = new System.Drawing.Point(768, 59);
			this.btn_nuevoCliente.Name = "btn_nuevoCliente";
			this.btn_nuevoCliente.Size = new System.Drawing.Size(168, 47);
			this.btn_nuevoCliente.TabIndex = 11;
			this.btn_nuevoCliente.Text = "Nuevo Cliente";
			this.btn_nuevoCliente.UseVisualStyleBackColor = false;
			this.btn_nuevoCliente.Click += new System.EventHandler(this.btn_nuevoCliente_Click);
			// 
			// textBox_Legajo
			// 
			this.textBox_Legajo.Font = new System.Drawing.Font("Segoe UI Semibold", 12.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox_Legajo.Location = new System.Drawing.Point(347, 68);
			this.textBox_Legajo.Name = "textBox_Legajo";
			this.textBox_Legajo.Size = new System.Drawing.Size(168, 30);
			this.textBox_Legajo.TabIndex = 10;
			this.textBox_Legajo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(194, 71);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(125, 23);
			this.label4.TabIndex = 9;
			this.label4.Text = "Ingrese Legajo:";
			// 
			// radioButton_legajo
			// 
			this.radioButton_legajo.AutoSize = true;
			this.radioButton_legajo.Font = new System.Drawing.Font("Segoe UI Semibold", 12.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.radioButton_legajo.Location = new System.Drawing.Point(23, 69);
			this.radioButton_legajo.Name = "radioButton_legajo";
			this.radioButton_legajo.Size = new System.Drawing.Size(108, 27);
			this.radioButton_legajo.TabIndex = 2;
			this.radioButton_legajo.Text = "Por Legajo";
			this.radioButton_legajo.UseVisualStyleBackColor = true;
			this.radioButton_legajo.CheckedChanged += new System.EventHandler(this.radioButton_legajo_CheckedChanged);
			// 
			// btn_Buscar
			// 
			this.btn_Buscar.Image = global::UI.Properties.Resources.boton_buscar;
			this.btn_Buscar.Location = new System.Drawing.Point(559, 14);
			this.btn_Buscar.Name = "btn_Buscar";
			this.btn_Buscar.Size = new System.Drawing.Size(62, 62);
			this.btn_Buscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.btn_Buscar.TabIndex = 6;
			this.btn_Buscar.TabStop = false;
			this.btn_Buscar.Click += new System.EventHandler(this.btn_Buscar_Click);
			this.btn_Buscar.MouseLeave += new System.EventHandler(this.btn_Buscar_MouseLeave);
			this.btn_Buscar.MouseHover += new System.EventHandler(this.btn_Buscar_MouseHover);
			// 
			// textBox_Nombre
			// 
			this.textBox_Nombre.Font = new System.Drawing.Font("Segoe UI Semibold", 12.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox_Nombre.Location = new System.Drawing.Point(347, 104);
			this.textBox_Nombre.Name = "textBox_Nombre";
			this.textBox_Nombre.Size = new System.Drawing.Size(168, 30);
			this.textBox_Nombre.TabIndex = 5;
			this.textBox_Nombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// textBox_DNI
			// 
			this.textBox_DNI.Font = new System.Drawing.Font("Segoe UI Semibold", 12.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox_DNI.Location = new System.Drawing.Point(347, 31);
			this.textBox_DNI.Name = "textBox_DNI";
			this.textBox_DNI.Size = new System.Drawing.Size(168, 30);
			this.textBox_DNI.TabIndex = 4;
			this.textBox_DNI.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(194, 107);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(138, 23);
			this.label2.TabIndex = 3;
			this.label2.Text = "Ingrese Nombre:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(194, 34);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(105, 23);
			this.label1.TabIndex = 2;
			this.label1.Text = "Ingrese DNI:";
			// 
			// radioButton_nombre
			// 
			this.radioButton_nombre.AutoSize = true;
			this.radioButton_nombre.Font = new System.Drawing.Font("Segoe UI Semibold", 12.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.radioButton_nombre.Location = new System.Drawing.Point(23, 105);
			this.radioButton_nombre.Name = "radioButton_nombre";
			this.radioButton_nombre.Size = new System.Drawing.Size(121, 27);
			this.radioButton_nombre.TabIndex = 3;
			this.radioButton_nombre.Text = "Por Nombre";
			this.radioButton_nombre.UseVisualStyleBackColor = true;
			this.radioButton_nombre.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
			// 
			// radioButton1
			// 
			this.radioButton1.AutoSize = true;
			this.radioButton1.Checked = true;
			this.radioButton1.Font = new System.Drawing.Font("Segoe UI Semibold", 12.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.radioButton1.Location = new System.Drawing.Point(23, 32);
			this.radioButton1.Name = "radioButton1";
			this.radioButton1.Size = new System.Drawing.Size(88, 27);
			this.radioButton1.TabIndex = 0;
			this.radioButton1.TabStop = true;
			this.radioButton1.Text = "Por DNI";
			this.radioButton1.UseVisualStyleBackColor = true;
			this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
			// 
			// gpb_altas
			// 
			this.gpb_altas.Controls.Add(this.rbn_Alta);
			this.gpb_altas.Controls.Add(this.rbn_baja);
			this.gpb_altas.Location = new System.Drawing.Point(550, 65);
			this.gpb_altas.Name = "gpb_altas";
			this.gpb_altas.Size = new System.Drawing.Size(82, 73);
			this.gpb_altas.TabIndex = 14;
			this.gpb_altas.TabStop = false;
			// 
			// rbn_Alta
			// 
			this.rbn_Alta.AutoSize = true;
			this.rbn_Alta.Font = new System.Drawing.Font("Segoe UI Semibold", 12.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rbn_Alta.Location = new System.Drawing.Point(0, 17);
			this.rbn_Alta.Name = "rbn_Alta";
			this.rbn_Alta.Size = new System.Drawing.Size(82, 27);
			this.rbn_Alta.TabIndex = 12;
			this.rbn_Alta.TabStop = true;
			this.rbn_Alta.Text = "En Alta";
			this.rbn_Alta.UseVisualStyleBackColor = true;
			this.rbn_Alta.CheckedChanged += new System.EventHandler(this.rbn_Alta_CheckedChanged);
			// 
			// rbn_baja
			// 
			this.rbn_baja.AutoSize = true;
			this.rbn_baja.Font = new System.Drawing.Font("Segoe UI Semibold", 12.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rbn_baja.Location = new System.Drawing.Point(0, 45);
			this.rbn_baja.Name = "rbn_baja";
			this.rbn_baja.Size = new System.Drawing.Size(84, 27);
			this.rbn_baja.TabIndex = 13;
			this.rbn_baja.TabStop = true;
			this.rbn_baja.Text = "En Baja";
			this.rbn_baja.UseVisualStyleBackColor = true;
			this.rbn_baja.CheckedChanged += new System.EventHandler(this.rbn_baja_CheckedChanged);
			// 
			// groupBox2
			// 
			this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox2.BackColor = System.Drawing.Color.Transparent;
			this.groupBox2.Controls.Add(this.tablaResulClientes);
			this.groupBox2.Font = new System.Drawing.Font("Segoe UI Semibold", 12.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox2.Location = new System.Drawing.Point(12, 163);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(1002, 230);
			this.groupBox2.TabIndex = 3;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Resultados";
			// 
			// tablaResulClientes
			// 
			this.tablaResulClientes.AllowUserToAddRows = false;
			this.tablaResulClientes.AllowUserToDeleteRows = false;
			this.tablaResulClientes.AllowUserToOrderColumns = true;
			this.tablaResulClientes.AllowUserToResizeColumns = false;
			this.tablaResulClientes.AllowUserToResizeRows = false;
			this.tablaResulClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.tablaResulClientes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.tablaResulClientes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 12.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.tablaResulClientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.tablaResulClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.tablaResulClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clm_Dni,
            this.clm_legajo,
            this.clm_apellido,
            this.clm_nom,
            this.clm_Nombre});
			this.tablaResulClientes.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tablaResulClientes.Location = new System.Drawing.Point(3, 26);
			this.tablaResulClientes.MultiSelect = false;
			this.tablaResulClientes.Name = "tablaResulClientes";
			this.tablaResulClientes.ReadOnly = true;
			this.tablaResulClientes.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.tablaResulClientes.RowHeadersVisible = false;
			this.tablaResulClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.tablaResulClientes.Size = new System.Drawing.Size(996, 201);
			this.tablaResulClientes.StandardTab = true;
			this.tablaResulClientes.TabIndex = 0;
			// 
			// clm_Dni
			// 
			this.clm_Dni.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			this.clm_Dni.DefaultCellStyle = dataGridViewCellStyle2;
			this.clm_Dni.FillWeight = 40F;
			this.clm_Dni.HeaderText = "DNI";
			this.clm_Dni.Name = "clm_Dni";
			this.clm_Dni.ReadOnly = true;
			// 
			// clm_legajo
			// 
			this.clm_legajo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.clm_legajo.FillWeight = 40F;
			this.clm_legajo.HeaderText = "Legajo";
			this.clm_legajo.Name = "clm_legajo";
			this.clm_legajo.ReadOnly = true;
			// 
			// clm_apellido
			// 
			this.clm_apellido.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			this.clm_apellido.DefaultCellStyle = dataGridViewCellStyle3;
			this.clm_apellido.FillWeight = 70F;
			this.clm_apellido.HeaderText = "Apellido";
			this.clm_apellido.Name = "clm_apellido";
			this.clm_apellido.ReadOnly = true;
			// 
			// clm_nom
			// 
			this.clm_nom.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.clm_nom.FillWeight = 70F;
			this.clm_nom.HeaderText = "Nombre";
			this.clm_nom.Name = "clm_nom";
			this.clm_nom.ReadOnly = true;
			// 
			// clm_Nombre
			// 
			this.clm_Nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			this.clm_Nombre.DefaultCellStyle = dataGridViewCellStyle4;
			this.clm_Nombre.FillWeight = 70F;
			this.clm_Nombre.HeaderText = "Tipo Cliente";
			this.clm_Nombre.Name = "clm_Nombre";
			this.clm_Nombre.ReadOnly = true;
			// 
			// button_verDatosCliente
			// 
			this.button_verDatosCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.button_verDatosCliente.BackColor = System.Drawing.SystemColors.Control;
			this.button_verDatosCliente.Font = new System.Drawing.Font("Segoe UI Semibold", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button_verDatosCliente.Location = new System.Drawing.Point(788, 399);
			this.button_verDatosCliente.Name = "button_verDatosCliente";
			this.button_verDatosCliente.Size = new System.Drawing.Size(110, 30);
			this.button_verDatosCliente.TabIndex = 4;
			this.button_verDatosCliente.Text = "Ver Datos";
			this.button_verDatosCliente.UseVisualStyleBackColor = false;
			this.button_verDatosCliente.Click += new System.EventHandler(this.button_verDatosCliente_Click);
			// 
			// BuscarCliente
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.BackgroundImage = global::UI.Properties.Resources.FondoPantallas;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(1026, 441);
			this.Controls.Add(this.button_verDatosCliente);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.btn_Aceptar);
			this.Controls.Add(this.btn_Cancelar);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "BuscarCliente";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Buscar Cliente";
			this.Load += new System.EventHandler(this.BuscarCliente_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.btn_Buscar)).EndInit();
			this.gpb_altas.ResumeLayout(false);
			this.gpb_altas.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.tablaResulClientes)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.Button btn_Aceptar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox_Nombre;
        private System.Windows.Forms.TextBox textBox_DNI;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButton_nombre;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.DataGridView tablaResulClientes;
        private System.Windows.Forms.PictureBox btn_Buscar;
        private System.Windows.Forms.TextBox textBox_Legajo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton radioButton_legajo;
        private System.Windows.Forms.Button btn_nuevoCliente;
        private System.Windows.Forms.GroupBox gpb_altas;
        private System.Windows.Forms.RadioButton rbn_Alta;
        private System.Windows.Forms.RadioButton rbn_baja;
        private System.Windows.Forms.Label lbl_Buscar;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_Dni;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_legajo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_Nombre;
		private System.Windows.Forms.Button button_verDatosCliente;
	}
}