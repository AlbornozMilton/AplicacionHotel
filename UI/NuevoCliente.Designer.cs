namespace UI
{
    partial class NuevoCliente
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
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.pestaña_DatosGenerales = new System.Windows.Forms.TabPage();
			this.label18 = new System.Windows.Forms.Label();
			this.label17 = new System.Windows.Forms.Label();
			this.label16 = new System.Windows.Forms.Label();
			this.label15 = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.label_legajo = new System.Windows.Forms.Label();
			this.txb_legajo = new System.Windows.Forms.TextBox();
			this.cbx_tipo = new System.Windows.Forms.ComboBox();
			this.txb_telefono = new System.Windows.Forms.TextBox();
			this.txb_nombre = new System.Windows.Forms.TextBox();
			this.txb_apellido = new System.Windows.Forms.TextBox();
			this.tbx_dni = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.pestaña_Ubicacion = new System.Windows.Forms.TabPage();
			this.label22 = new System.Windows.Forms.Label();
			this.label21 = new System.Windows.Forms.Label();
			this.label19 = new System.Windows.Forms.Label();
			this.cbx_calles = new System.Windows.Forms.ComboBox();
			this.cbx_ciudades = new System.Windows.Forms.ComboBox();
			this.txb_nroDepto = new System.Windows.Forms.TextBox();
			this.txb_piso = new System.Windows.Forms.TextBox();
			this.txb_nroCalle = new System.Windows.Forms.TextBox();
			this.label12 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.txb_codPostal = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.pestaña_Adicional = new System.Windows.Forms.TabPage();
			this.txb_correo = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.tabControl1.SuspendLayout();
			this.pestaña_DatosGenerales.SuspendLayout();
			this.pestaña_Ubicacion.SuspendLayout();
			this.pestaña_Adicional.SuspendLayout();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.button1.BackColor = System.Drawing.SystemColors.Control;
			this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.Location = new System.Drawing.Point(522, 301);
			this.button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(110, 30);
			this.button1.TabIndex = 14;
			this.button1.Text = "Aceptar";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.button2.BackColor = System.Drawing.SystemColors.Control;
			this.button2.Font = new System.Drawing.Font("Segoe UI Semibold", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button2.Location = new System.Drawing.Point(12, 301);
			this.button2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(110, 30);
			this.button2.TabIndex = 15;
			this.button2.Text = "Cancelar";
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.pestaña_DatosGenerales);
			this.tabControl1.Controls.Add(this.pestaña_Ubicacion);
			this.tabControl1.Controls.Add(this.pestaña_Adicional);
			this.tabControl1.Font = new System.Drawing.Font("Segoe UI Semibold", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tabControl1.Location = new System.Drawing.Point(12, 12);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(620, 283);
			this.tabControl1.TabIndex = 16;
			// 
			// pestaña_DatosGenerales
			// 
			this.pestaña_DatosGenerales.Controls.Add(this.label18);
			this.pestaña_DatosGenerales.Controls.Add(this.label17);
			this.pestaña_DatosGenerales.Controls.Add(this.label16);
			this.pestaña_DatosGenerales.Controls.Add(this.label15);
			this.pestaña_DatosGenerales.Controls.Add(this.label14);
			this.pestaña_DatosGenerales.Controls.Add(this.label13);
			this.pestaña_DatosGenerales.Controls.Add(this.label_legajo);
			this.pestaña_DatosGenerales.Controls.Add(this.txb_legajo);
			this.pestaña_DatosGenerales.Controls.Add(this.cbx_tipo);
			this.pestaña_DatosGenerales.Controls.Add(this.txb_telefono);
			this.pestaña_DatosGenerales.Controls.Add(this.txb_nombre);
			this.pestaña_DatosGenerales.Controls.Add(this.txb_apellido);
			this.pestaña_DatosGenerales.Controls.Add(this.tbx_dni);
			this.pestaña_DatosGenerales.Controls.Add(this.label4);
			this.pestaña_DatosGenerales.Controls.Add(this.label1);
			this.pestaña_DatosGenerales.Controls.Add(this.label2);
			this.pestaña_DatosGenerales.Controls.Add(this.label3);
			this.pestaña_DatosGenerales.Controls.Add(this.label6);
			this.pestaña_DatosGenerales.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.pestaña_DatosGenerales.Location = new System.Drawing.Point(4, 32);
			this.pestaña_DatosGenerales.Name = "pestaña_DatosGenerales";
			this.pestaña_DatosGenerales.Padding = new System.Windows.Forms.Padding(3);
			this.pestaña_DatosGenerales.Size = new System.Drawing.Size(612, 247);
			this.pestaña_DatosGenerales.TabIndex = 0;
			this.pestaña_DatosGenerales.Text = "Datos Generales";
			this.pestaña_DatosGenerales.UseVisualStyleBackColor = true;
			// 
			// label18
			// 
			this.label18.AutoSize = true;
			this.label18.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label18.ForeColor = System.Drawing.Color.Red;
			this.label18.Location = new System.Drawing.Point(466, 207);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(111, 15);
			this.label18.TabIndex = 37;
			this.label18.Text = "Campo Obligatiorio";
			// 
			// label17
			// 
			this.label17.AutoSize = true;
			this.label17.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label17.ForeColor = System.Drawing.Color.Red;
			this.label17.Location = new System.Drawing.Point(466, 171);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(111, 15);
			this.label17.TabIndex = 36;
			this.label17.Text = "Campo Obligatiorio";
			// 
			// label16
			// 
			this.label16.AutoSize = true;
			this.label16.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label16.ForeColor = System.Drawing.Color.Red;
			this.label16.Location = new System.Drawing.Point(466, 135);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(111, 15);
			this.label16.TabIndex = 35;
			this.label16.Text = "Campo Obligatiorio";
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label15.ForeColor = System.Drawing.Color.Red;
			this.label15.Location = new System.Drawing.Point(466, 99);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(111, 15);
			this.label15.TabIndex = 34;
			this.label15.Text = "Campo Obligatiorio";
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label14.ForeColor = System.Drawing.Color.Red;
			this.label14.Location = new System.Drawing.Point(466, 64);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(111, 15);
			this.label14.TabIndex = 33;
			this.label14.Text = "Campo Obligatiorio";
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label13.ForeColor = System.Drawing.Color.Red;
			this.label13.Location = new System.Drawing.Point(466, 28);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(111, 15);
			this.label13.TabIndex = 32;
			this.label13.Text = "Campo Obligatiorio";
			// 
			// label_legajo
			// 
			this.label_legajo.AutoSize = true;
			this.label_legajo.Font = new System.Drawing.Font("Segoe UI Semibold", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label_legajo.Location = new System.Drawing.Point(26, 58);
			this.label_legajo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label_legajo.Name = "label_legajo";
			this.label_legajo.Size = new System.Drawing.Size(60, 23);
			this.label_legajo.TabIndex = 31;
			this.label_legajo.Text = "Legajo";
			// 
			// txb_legajo
			// 
			this.txb_legajo.Font = new System.Drawing.Font("Segoe UI Semibold", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txb_legajo.Location = new System.Drawing.Point(165, 55);
			this.txb_legajo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.txb_legajo.Name = "txb_legajo";
			this.txb_legajo.Size = new System.Drawing.Size(282, 30);
			this.txb_legajo.TabIndex = 22;
			this.txb_legajo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txb_legajo_KeyPress);
			this.txb_legajo.Leave += new System.EventHandler(this.txb_legajo_Leave);
			// 
			// cbx_tipo
			// 
			this.cbx_tipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbx_tipo.Font = new System.Drawing.Font("Segoe UI Semibold", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbx_tipo.FormattingEnabled = true;
			this.cbx_tipo.Location = new System.Drawing.Point(165, 198);
			this.cbx_tipo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.cbx_tipo.Name = "cbx_tipo";
			this.cbx_tipo.Size = new System.Drawing.Size(282, 31);
			this.cbx_tipo.TabIndex = 30;
			this.cbx_tipo.SelectedIndexChanged += new System.EventHandler(this.cbx_tipo_SelectedIndexChanged);
			// 
			// txb_telefono
			// 
			this.txb_telefono.Font = new System.Drawing.Font("Segoe UI Semibold", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txb_telefono.Location = new System.Drawing.Point(165, 162);
			this.txb_telefono.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.txb_telefono.Name = "txb_telefono";
			this.txb_telefono.Size = new System.Drawing.Size(282, 30);
			this.txb_telefono.TabIndex = 28;
			this.txb_telefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txb_telefono_KeyPress);
			this.txb_telefono.Leave += new System.EventHandler(this.txb_telefono_Leave);
			// 
			// txb_nombre
			// 
			this.txb_nombre.Font = new System.Drawing.Font("Segoe UI Semibold", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txb_nombre.Location = new System.Drawing.Point(165, 126);
			this.txb_nombre.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.txb_nombre.Name = "txb_nombre";
			this.txb_nombre.Size = new System.Drawing.Size(282, 30);
			this.txb_nombre.TabIndex = 25;
			this.txb_nombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txb_nombre_KeyPress);
			this.txb_nombre.Leave += new System.EventHandler(this.txb_nombre_Leave);
			// 
			// txb_apellido
			// 
			this.txb_apellido.Font = new System.Drawing.Font("Segoe UI Semibold", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txb_apellido.Location = new System.Drawing.Point(165, 90);
			this.txb_apellido.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.txb_apellido.Name = "txb_apellido";
			this.txb_apellido.Size = new System.Drawing.Size(282, 30);
			this.txb_apellido.TabIndex = 24;
			this.txb_apellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txb_apellido_KeyPress);
			this.txb_apellido.Leave += new System.EventHandler(this.txb_apellido_Leave);
			// 
			// tbx_dni
			// 
			this.tbx_dni.Font = new System.Drawing.Font("Segoe UI Semibold", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbx_dni.Location = new System.Drawing.Point(165, 19);
			this.tbx_dni.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.tbx_dni.Name = "tbx_dni";
			this.tbx_dni.Size = new System.Drawing.Size(282, 30);
			this.tbx_dni.TabIndex = 20;
			this.tbx_dni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbx_dni_KeyPress);
			this.tbx_dni.Leave += new System.EventHandler(this.tbx_dni_Leave);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(26, 201);
			this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(43, 23);
			this.label4.TabIndex = 29;
			this.label4.Text = "Tipo";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(26, 22);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(40, 23);
			this.label1.TabIndex = 21;
			this.label1.Text = "DNI";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(25, 93);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(72, 23);
			this.label2.TabIndex = 23;
			this.label2.Text = "Apellido";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(25, 129);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(73, 23);
			this.label3.TabIndex = 26;
			this.label3.Text = "Nombre";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(25, 165);
			this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(75, 23);
			this.label6.TabIndex = 27;
			this.label6.Text = "Teléfono";
			// 
			// pestaña_Ubicacion
			// 
			this.pestaña_Ubicacion.Controls.Add(this.label22);
			this.pestaña_Ubicacion.Controls.Add(this.label21);
			this.pestaña_Ubicacion.Controls.Add(this.label19);
			this.pestaña_Ubicacion.Controls.Add(this.cbx_calles);
			this.pestaña_Ubicacion.Controls.Add(this.cbx_ciudades);
			this.pestaña_Ubicacion.Controls.Add(this.txb_nroDepto);
			this.pestaña_Ubicacion.Controls.Add(this.txb_piso);
			this.pestaña_Ubicacion.Controls.Add(this.txb_nroCalle);
			this.pestaña_Ubicacion.Controls.Add(this.label12);
			this.pestaña_Ubicacion.Controls.Add(this.label11);
			this.pestaña_Ubicacion.Controls.Add(this.label10);
			this.pestaña_Ubicacion.Controls.Add(this.txb_codPostal);
			this.pestaña_Ubicacion.Controls.Add(this.label9);
			this.pestaña_Ubicacion.Controls.Add(this.label8);
			this.pestaña_Ubicacion.Controls.Add(this.label7);
			this.pestaña_Ubicacion.Location = new System.Drawing.Point(4, 32);
			this.pestaña_Ubicacion.Name = "pestaña_Ubicacion";
			this.pestaña_Ubicacion.Padding = new System.Windows.Forms.Padding(3);
			this.pestaña_Ubicacion.Size = new System.Drawing.Size(612, 247);
			this.pestaña_Ubicacion.TabIndex = 1;
			this.pestaña_Ubicacion.Text = "Ubicación";
			this.pestaña_Ubicacion.UseVisualStyleBackColor = true;
			// 
			// label22
			// 
			this.label22.AutoSize = true;
			this.label22.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label22.ForeColor = System.Drawing.Color.Red;
			this.label22.Location = new System.Drawing.Point(482, 139);
			this.label22.Name = "label22";
			this.label22.Size = new System.Drawing.Size(111, 15);
			this.label22.TabIndex = 38;
			this.label22.Text = "Campo Obligatiorio";
			// 
			// label21
			// 
			this.label21.AutoSize = true;
			this.label21.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label21.ForeColor = System.Drawing.Color.Red;
			this.label21.Location = new System.Drawing.Point(482, 102);
			this.label21.Name = "label21";
			this.label21.Size = new System.Drawing.Size(111, 15);
			this.label21.TabIndex = 37;
			this.label21.Text = "Campo Obligatiorio";
			// 
			// label19
			// 
			this.label19.AutoSize = true;
			this.label19.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label19.ForeColor = System.Drawing.Color.Red;
			this.label19.Location = new System.Drawing.Point(482, 29);
			this.label19.Name = "label19";
			this.label19.Size = new System.Drawing.Size(111, 15);
			this.label19.TabIndex = 36;
			this.label19.Text = "Campo Obligatiorio";
			// 
			// cbx_calles
			// 
			this.cbx_calles.Font = new System.Drawing.Font("Segoe UI Semibold", 12.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbx_calles.FormattingEnabled = true;
			this.cbx_calles.ItemHeight = 23;
			this.cbx_calles.Location = new System.Drawing.Point(181, 93);
			this.cbx_calles.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.cbx_calles.Name = "cbx_calles";
			this.cbx_calles.Size = new System.Drawing.Size(282, 31);
			this.cbx_calles.TabIndex = 29;
			this.cbx_calles.SelectedIndexChanged += new System.EventHandler(this.cbx_calles_SelectedIndexChanged);
			this.cbx_calles.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbx_calles_KeyPress);
			this.cbx_calles.Leave += new System.EventHandler(this.cbx_calles_Leave);
			// 
			// cbx_ciudades
			// 
			this.cbx_ciudades.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbx_ciudades.Font = new System.Drawing.Font("Segoe UI Semibold", 12.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbx_ciudades.FormattingEnabled = true;
			this.cbx_ciudades.Location = new System.Drawing.Point(181, 20);
			this.cbx_ciudades.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.cbx_ciudades.Name = "cbx_ciudades";
			this.cbx_ciudades.Size = new System.Drawing.Size(282, 31);
			this.cbx_ciudades.Sorted = true;
			this.cbx_ciudades.TabIndex = 25;
			this.cbx_ciudades.SelectedIndexChanged += new System.EventHandler(this.cbx_ciudades_SelectedIndexChanged);
			// 
			// txb_nroDepto
			// 
			this.txb_nroDepto.Font = new System.Drawing.Font("Segoe UI Semibold", 12.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txb_nroDepto.Location = new System.Drawing.Point(181, 201);
			this.txb_nroDepto.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.txb_nroDepto.Name = "txb_nroDepto";
			this.txb_nroDepto.Size = new System.Drawing.Size(282, 30);
			this.txb_nroDepto.TabIndex = 35;
			this.txb_nroDepto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txb_nroDepto_KeyPress);
			// 
			// txb_piso
			// 
			this.txb_piso.Font = new System.Drawing.Font("Segoe UI Semibold", 12.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txb_piso.Location = new System.Drawing.Point(181, 166);
			this.txb_piso.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.txb_piso.Name = "txb_piso";
			this.txb_piso.Size = new System.Drawing.Size(282, 30);
			this.txb_piso.TabIndex = 33;
			this.txb_piso.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txb_piso_KeyPress);
			// 
			// txb_nroCalle
			// 
			this.txb_nroCalle.Font = new System.Drawing.Font("Segoe UI Semibold", 12.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txb_nroCalle.Location = new System.Drawing.Point(181, 130);
			this.txb_nroCalle.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.txb_nroCalle.Name = "txb_nroCalle";
			this.txb_nroCalle.Size = new System.Drawing.Size(282, 30);
			this.txb_nroCalle.TabIndex = 31;
			this.txb_nroCalle.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txb_nroCalle_KeyPress);
			this.txb_nroCalle.Leave += new System.EventHandler(this.txb_nroCalle_Leave);
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Font = new System.Drawing.Font("Segoe UI Semibold", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label12.Location = new System.Drawing.Point(20, 204);
			this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(155, 23);
			this.label12.TabIndex = 34;
			this.label12.Text = "Nro Departamento";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Font = new System.Drawing.Font("Segoe UI Semibold", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label11.Location = new System.Drawing.Point(20, 133);
			this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(81, 23);
			this.label11.TabIndex = 32;
			this.label11.Text = "Nro Calle";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.Location = new System.Drawing.Point(20, 23);
			this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(64, 23);
			this.label10.TabIndex = 30;
			this.label10.Text = "Ciudad";
			// 
			// txb_codPostal
			// 
			this.txb_codPostal.Font = new System.Drawing.Font("Segoe UI Semibold", 12.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txb_codPostal.Location = new System.Drawing.Point(181, 57);
			this.txb_codPostal.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.txb_codPostal.Name = "txb_codPostal";
			this.txb_codPostal.Size = new System.Drawing.Size(282, 30);
			this.txb_codPostal.TabIndex = 27;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(20, 60);
			this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(115, 23);
			this.label9.TabIndex = 28;
			this.label9.Text = "Código Postal";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(20, 96);
			this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(47, 23);
			this.label8.TabIndex = 26;
			this.label8.Text = "Calle";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(20, 169);
			this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(41, 23);
			this.label7.TabIndex = 24;
			this.label7.Text = "Piso";
			// 
			// pestaña_Adicional
			// 
			this.pestaña_Adicional.Controls.Add(this.txb_correo);
			this.pestaña_Adicional.Controls.Add(this.label5);
			this.pestaña_Adicional.Location = new System.Drawing.Point(4, 32);
			this.pestaña_Adicional.Name = "pestaña_Adicional";
			this.pestaña_Adicional.Padding = new System.Windows.Forms.Padding(3);
			this.pestaña_Adicional.Size = new System.Drawing.Size(612, 247);
			this.pestaña_Adicional.TabIndex = 2;
			this.pestaña_Adicional.Text = "Adicional";
			this.pestaña_Adicional.UseVisualStyleBackColor = true;
			// 
			// txb_correo
			// 
			this.txb_correo.Font = new System.Drawing.Font("Segoe UI Semibold", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txb_correo.Location = new System.Drawing.Point(176, 27);
			this.txb_correo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.txb_correo.Name = "txb_correo";
			this.txb_correo.Size = new System.Drawing.Size(392, 30);
			this.txb_correo.TabIndex = 15;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 12.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(32, 30);
			this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(62, 23);
			this.label5.TabIndex = 14;
			this.label5.Text = "Correo";
			// 
			// NuevoCliente
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.BackgroundImage = global::UI.Properties.Resources.FondoPantallas;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(644, 336);
			this.Controls.Add(this.tabControl1);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.MaximizeBox = false;
			this.Name = "NuevoCliente";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Nuevo Cliente";
			this.Load += new System.EventHandler(this.NuevoCliente_Load);
			this.tabControl1.ResumeLayout(false);
			this.pestaña_DatosGenerales.ResumeLayout(false);
			this.pestaña_DatosGenerales.PerformLayout();
			this.pestaña_Ubicacion.ResumeLayout(false);
			this.pestaña_Ubicacion.PerformLayout();
			this.pestaña_Adicional.ResumeLayout(false);
			this.pestaña_Adicional.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage pestaña_DatosGenerales;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label_legajo;
        private System.Windows.Forms.TextBox txb_legajo;
        private System.Windows.Forms.ComboBox cbx_tipo;
        private System.Windows.Forms.TextBox txb_telefono;
        private System.Windows.Forms.TextBox txb_nombre;
        private System.Windows.Forms.TextBox txb_apellido;
        private System.Windows.Forms.TextBox tbx_dni;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TabPage pestaña_Ubicacion;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.ComboBox cbx_calles;
        private System.Windows.Forms.ComboBox cbx_ciudades;
        private System.Windows.Forms.TextBox txb_nroDepto;
        private System.Windows.Forms.TextBox txb_piso;
        private System.Windows.Forms.TextBox txb_nroCalle;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txb_codPostal;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TabPage pestaña_Adicional;
        private System.Windows.Forms.TextBox txb_correo;
        private System.Windows.Forms.Label label5;
    }
}