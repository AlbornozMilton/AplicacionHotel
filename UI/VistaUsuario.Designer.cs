namespace UI
{
	partial class VistaUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VistaUsuario));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.gbx_datosPersonales = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_valor_dni = new System.Windows.Forms.Label();
            this.lbl_valor_tel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lbl_valor_legajo = new System.Windows.Forms.Label();
            this.lbl_valor_nombre = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbl_valor_apellido = new System.Windows.Forms.Label();
            this.groupBox_direccion = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_valor_nomCiudad = new System.Windows.Forms.Label();
            this.lbl_valor_depto = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lbl_valor_codPostal = new System.Windows.Forms.Label();
            this.lbl_valor_piso = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lbl_valor_direc = new System.Windows.Forms.Label();
            this.gbx_TipoCliente = new System.Windows.Forms.GroupBox();
            this.label17 = new System.Windows.Forms.Label();
            this.lbl_valor_nombreTarifa = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.lbl_valor_tarifaSExcl = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.lbl_valor_tarifaCExcl = new System.Windows.Forms.Label();
            this.gbx_Correo = new System.Windows.Forms.GroupBox();
            this.textBox_correo = new System.Windows.Forms.TextBox();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.btn_modificar = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.gbx_datosPersonales.SuspendLayout();
            this.groupBox_direccion.SuspendLayout();
            this.gbx_TipoCliente.SuspendLayout();
            this.gbx_Correo.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.flowLayoutPanel1.Controls.Add(this.gbx_datosPersonales);
            this.flowLayoutPanel1.Controls.Add(this.groupBox_direccion);
            this.flowLayoutPanel1.Controls.Add(this.gbx_TipoCliente);
            this.flowLayoutPanel1.Controls.Add(this.gbx_Correo);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(690, 293);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // gbx_datosPersonales
            // 
            this.gbx_datosPersonales.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gbx_datosPersonales.Controls.Add(this.label2);
            this.gbx_datosPersonales.Controls.Add(this.lbl_valor_dni);
            this.gbx_datosPersonales.Controls.Add(this.lbl_valor_tel);
            this.gbx_datosPersonales.Controls.Add(this.label4);
            this.gbx_datosPersonales.Controls.Add(this.label10);
            this.gbx_datosPersonales.Controls.Add(this.lbl_valor_legajo);
            this.gbx_datosPersonales.Controls.Add(this.lbl_valor_nombre);
            this.gbx_datosPersonales.Controls.Add(this.label6);
            this.gbx_datosPersonales.Controls.Add(this.label8);
            this.gbx_datosPersonales.Controls.Add(this.lbl_valor_apellido);
            this.gbx_datosPersonales.Font = new System.Drawing.Font("Segoe UI Semibold", 12.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbx_datosPersonales.Location = new System.Drawing.Point(3, 3);
            this.gbx_datosPersonales.Name = "gbx_datosPersonales";
            this.gbx_datosPersonales.Size = new System.Drawing.Size(322, 162);
            this.gbx_datosPersonales.TabIndex = 29;
            this.gbx_datosPersonales.TabStop = false;
            this.gbx_datosPersonales.Text = "Datos Personales";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "DNI:";
            // 
            // lbl_valor_dni
            // 
            this.lbl_valor_dni.AutoSize = true;
            this.lbl_valor_dni.Font = new System.Drawing.Font("Segoe UI Semibold", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_valor_dni.ForeColor = System.Drawing.Color.Blue;
            this.lbl_valor_dni.Location = new System.Drawing.Point(56, 27);
            this.lbl_valor_dni.Name = "lbl_valor_dni";
            this.lbl_valor_dni.Size = new System.Drawing.Size(73, 23);
            this.lbl_valor_dni.TabIndex = 3;
            this.lbl_valor_dni.Text = "0000000";
            // 
            // lbl_valor_tel
            // 
            this.lbl_valor_tel.AutoSize = true;
            this.lbl_valor_tel.Font = new System.Drawing.Font("Segoe UI Semibold", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_valor_tel.ForeColor = System.Drawing.Color.Blue;
            this.lbl_valor_tel.Location = new System.Drawing.Point(109, 130);
            this.lbl_valor_tel.Name = "lbl_valor_tel";
            this.lbl_valor_tel.Size = new System.Drawing.Size(127, 23);
            this.lbl_valor_tel.TabIndex = 11;
            this.lbl_valor_tel.Text = "0000000000000";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 23);
            this.label4.TabIndex = 4;
            this.label4.Text = "LEGAJO:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(6, 130);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(97, 23);
            this.label10.TabIndex = 10;
            this.label10.Text = "TELEFONO:";
            // 
            // lbl_valor_legajo
            // 
            this.lbl_valor_legajo.AutoSize = true;
            this.lbl_valor_legajo.Font = new System.Drawing.Font("Segoe UI Semibold", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_valor_legajo.ForeColor = System.Drawing.Color.Blue;
            this.lbl_valor_legajo.Location = new System.Drawing.Point(87, 52);
            this.lbl_valor_legajo.Name = "lbl_valor_legajo";
            this.lbl_valor_legajo.Size = new System.Drawing.Size(73, 23);
            this.lbl_valor_legajo.TabIndex = 5;
            this.lbl_valor_legajo.Text = "0000000";
            // 
            // lbl_valor_nombre
            // 
            this.lbl_valor_nombre.AutoSize = true;
            this.lbl_valor_nombre.Font = new System.Drawing.Font("Segoe UI Semibold", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_valor_nombre.ForeColor = System.Drawing.Color.Blue;
            this.lbl_valor_nombre.Location = new System.Drawing.Point(98, 105);
            this.lbl_valor_nombre.Name = "lbl_valor_nombre";
            this.lbl_valor_nombre.Size = new System.Drawing.Size(163, 23);
            this.lbl_valor_nombre.TabIndex = 9;
            this.lbl_valor_nombre.Text = "xxxxxxxxxxxxxxxxx";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 23);
            this.label6.TabIndex = 6;
            this.label6.Text = "APELLIDO:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 105);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 23);
            this.label8.TabIndex = 8;
            this.label8.Text = "NOMBRE:";
            // 
            // lbl_valor_apellido
            // 
            this.lbl_valor_apellido.AutoSize = true;
            this.lbl_valor_apellido.Font = new System.Drawing.Font("Segoe UI Semibold", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_valor_apellido.ForeColor = System.Drawing.Color.Blue;
            this.lbl_valor_apellido.Location = new System.Drawing.Point(102, 78);
            this.lbl_valor_apellido.Name = "lbl_valor_apellido";
            this.lbl_valor_apellido.Size = new System.Drawing.Size(145, 23);
            this.lbl_valor_apellido.TabIndex = 7;
            this.lbl_valor_apellido.Text = "xxxxxxxxxxxxxxx";
            // 
            // groupBox_direccion
            // 
            this.groupBox_direccion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox_direccion.Controls.Add(this.label3);
            this.groupBox_direccion.Controls.Add(this.lbl_valor_nomCiudad);
            this.groupBox_direccion.Controls.Add(this.lbl_valor_depto);
            this.groupBox_direccion.Controls.Add(this.label9);
            this.groupBox_direccion.Controls.Add(this.label11);
            this.groupBox_direccion.Controls.Add(this.lbl_valor_codPostal);
            this.groupBox_direccion.Controls.Add(this.lbl_valor_piso);
            this.groupBox_direccion.Controls.Add(this.label14);
            this.groupBox_direccion.Controls.Add(this.label15);
            this.groupBox_direccion.Controls.Add(this.lbl_valor_direc);
            this.groupBox_direccion.Font = new System.Drawing.Font("Segoe UI Semibold", 12.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_direccion.Location = new System.Drawing.Point(331, 3);
            this.groupBox_direccion.Name = "groupBox_direccion";
            this.groupBox_direccion.Size = new System.Drawing.Size(351, 162);
            this.groupBox_direccion.TabIndex = 30;
            this.groupBox_direccion.TabStop = false;
            this.groupBox_direccion.Text = "Dirección";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "CIUDAD:";
            // 
            // lbl_valor_nomCiudad
            // 
            this.lbl_valor_nomCiudad.AutoSize = true;
            this.lbl_valor_nomCiudad.Font = new System.Drawing.Font("Segoe UI Semibold", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_valor_nomCiudad.ForeColor = System.Drawing.Color.Blue;
            this.lbl_valor_nomCiudad.Location = new System.Drawing.Point(89, 26);
            this.lbl_valor_nomCiudad.Name = "lbl_valor_nomCiudad";
            this.lbl_valor_nomCiudad.Size = new System.Drawing.Size(199, 23);
            this.lbl_valor_nomCiudad.TabIndex = 3;
            this.lbl_valor_nomCiudad.Text = "Concepción del Uruguay";
            // 
            // lbl_valor_depto
            // 
            this.lbl_valor_depto.AutoSize = true;
            this.lbl_valor_depto.Font = new System.Drawing.Font("Segoe UI Semibold", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_valor_depto.ForeColor = System.Drawing.Color.Blue;
            this.lbl_valor_depto.Location = new System.Drawing.Point(78, 130);
            this.lbl_valor_depto.Name = "lbl_valor_depto";
            this.lbl_valor_depto.Size = new System.Drawing.Size(37, 23);
            this.lbl_valor_depto.TabIndex = 11;
            this.lbl_valor_depto.Text = "000";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(6, 52);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(144, 23);
            this.label9.TabIndex = 4;
            this.label9.Text = "CÓDIGO POSTAL:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Semibold", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(6, 105);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(51, 23);
            this.label11.TabIndex = 10;
            this.label11.Text = "PISO:";
            // 
            // lbl_valor_codPostal
            // 
            this.lbl_valor_codPostal.AutoSize = true;
            this.lbl_valor_codPostal.Font = new System.Drawing.Font("Segoe UI Semibold", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_valor_codPostal.ForeColor = System.Drawing.Color.Blue;
            this.lbl_valor_codPostal.Location = new System.Drawing.Point(156, 52);
            this.lbl_valor_codPostal.Name = "lbl_valor_codPostal";
            this.lbl_valor_codPostal.Size = new System.Drawing.Size(55, 23);
            this.lbl_valor_codPostal.TabIndex = 5;
            this.lbl_valor_codPostal.Text = "00000";
            // 
            // lbl_valor_piso
            // 
            this.lbl_valor_piso.AccessibleRole = System.Windows.Forms.AccessibleRole.SplitButton;
            this.lbl_valor_piso.AutoSize = true;
            this.lbl_valor_piso.Font = new System.Drawing.Font("Segoe UI Semibold", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_valor_piso.ForeColor = System.Drawing.Color.Blue;
            this.lbl_valor_piso.Location = new System.Drawing.Point(63, 105);
            this.lbl_valor_piso.Name = "lbl_valor_piso";
            this.lbl_valor_piso.Size = new System.Drawing.Size(37, 23);
            this.lbl_valor_piso.TabIndex = 9;
            this.lbl_valor_piso.Text = "000";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI Semibold", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(6, 78);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(61, 23);
            this.label14.TabIndex = 6;
            this.label14.Text = "CALLE:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI Semibold", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(6, 130);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(66, 23);
            this.label15.TabIndex = 8;
            this.label15.Text = "DEPTO:";
            // 
            // lbl_valor_direc
            // 
            this.lbl_valor_direc.AutoSize = true;
            this.lbl_valor_direc.Font = new System.Drawing.Font("Segoe UI Semibold", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_valor_direc.ForeColor = System.Drawing.Color.Blue;
            this.lbl_valor_direc.Location = new System.Drawing.Point(73, 78);
            this.lbl_valor_direc.Name = "lbl_valor_direc";
            this.lbl_valor_direc.Size = new System.Drawing.Size(152, 23);
            this.lbl_valor_direc.TabIndex = 7;
            this.lbl_valor_direc.Text = "Atencio al Este 180";
            // 
            // gbx_TipoCliente
            // 
            this.gbx_TipoCliente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gbx_TipoCliente.Controls.Add(this.label17);
            this.gbx_TipoCliente.Controls.Add(this.lbl_valor_nombreTarifa);
            this.gbx_TipoCliente.Controls.Add(this.label19);
            this.gbx_TipoCliente.Controls.Add(this.lbl_valor_tarifaSExcl);
            this.gbx_TipoCliente.Controls.Add(this.label21);
            this.gbx_TipoCliente.Controls.Add(this.lbl_valor_tarifaCExcl);
            this.gbx_TipoCliente.Font = new System.Drawing.Font("Segoe UI Semibold", 12.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbx_TipoCliente.Location = new System.Drawing.Point(3, 171);
            this.gbx_TipoCliente.Name = "gbx_TipoCliente";
            this.gbx_TipoCliente.Size = new System.Drawing.Size(322, 112);
            this.gbx_TipoCliente.TabIndex = 34;
            this.gbx_TipoCliente.TabStop = false;
            this.gbx_TipoCliente.Text = "Tipo Cliente";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI Semibold", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(6, 27);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(77, 23);
            this.label17.TabIndex = 2;
            this.label17.Text = "Nombre:";
            // 
            // lbl_valor_nombreTarifa
            // 
            this.lbl_valor_nombreTarifa.AutoSize = true;
            this.lbl_valor_nombreTarifa.Font = new System.Drawing.Font("Segoe UI Semibold", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_valor_nombreTarifa.ForeColor = System.Drawing.Color.Blue;
            this.lbl_valor_nombreTarifa.Location = new System.Drawing.Point(89, 27);
            this.lbl_valor_nombreTarifa.Name = "lbl_valor_nombreTarifa";
            this.lbl_valor_nombreTarifa.Size = new System.Drawing.Size(205, 23);
            this.lbl_valor_nombreTarifa.TabIndex = 3;
            this.lbl_valor_nombreTarifa.Text = "Acompañante No Directo";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Segoe UI Semibold", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(6, 52);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(179, 23);
            this.label19.TabIndex = 4;
            this.label19.Text = "Tarifa sin Exclusividad:";
            // 
            // lbl_valor_tarifaSExcl
            // 
            this.lbl_valor_tarifaSExcl.AutoSize = true;
            this.lbl_valor_tarifaSExcl.Font = new System.Drawing.Font("Segoe UI Semibold", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_valor_tarifaSExcl.ForeColor = System.Drawing.Color.Blue;
            this.lbl_valor_tarifaSExcl.Location = new System.Drawing.Point(191, 52);
            this.lbl_valor_tarifaSExcl.Name = "lbl_valor_tarifaSExcl";
            this.lbl_valor_tarifaSExcl.Size = new System.Drawing.Size(37, 23);
            this.lbl_valor_tarifaSExcl.TabIndex = 5;
            this.lbl_valor_tarifaSExcl.Text = "000";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Segoe UI Semibold", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(6, 78);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(186, 23);
            this.label21.TabIndex = 6;
            this.label21.Text = "Tarifa con Exclusividad:";
            // 
            // lbl_valor_tarifaCExcl
            // 
            this.lbl_valor_tarifaCExcl.AutoSize = true;
            this.lbl_valor_tarifaCExcl.Font = new System.Drawing.Font("Segoe UI Semibold", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_valor_tarifaCExcl.ForeColor = System.Drawing.Color.Blue;
            this.lbl_valor_tarifaCExcl.Location = new System.Drawing.Point(198, 78);
            this.lbl_valor_tarifaCExcl.Name = "lbl_valor_tarifaCExcl";
            this.lbl_valor_tarifaCExcl.Size = new System.Drawing.Size(37, 23);
            this.lbl_valor_tarifaCExcl.TabIndex = 7;
            this.lbl_valor_tarifaCExcl.Text = "000";
            // 
            // gbx_Correo
            // 
            this.gbx_Correo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gbx_Correo.Controls.Add(this.textBox_correo);
            this.gbx_Correo.Font = new System.Drawing.Font("Segoe UI Semibold", 12.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbx_Correo.Location = new System.Drawing.Point(331, 172);
            this.gbx_Correo.Name = "gbx_Correo";
            this.gbx_Correo.Size = new System.Drawing.Size(351, 110);
            this.gbx_Correo.TabIndex = 33;
            this.gbx_Correo.TabStop = false;
            this.gbx_Correo.Text = "Correo";
            // 
            // textBox_correo
            // 
            this.textBox_correo.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.textBox_correo.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBox_correo.CausesValidation = false;
            this.textBox_correo.Location = new System.Drawing.Point(6, 48);
            this.textBox_correo.Name = "textBox_correo";
            this.textBox_correo.ReadOnly = true;
            this.textBox_correo.ShortcutsEnabled = false;
            this.textBox_correo.Size = new System.Drawing.Size(339, 30);
            this.textBox_correo.TabIndex = 5;
            this.textBox_correo.TabStop = false;
            this.textBox_correo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_correo.WordWrap = false;
            // 
            // btn_Salir
            // 
            this.btn_Salir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Salir.BackColor = System.Drawing.SystemColors.Control;
            this.btn_Salir.Font = new System.Drawing.Font("Segoe UI Semibold", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Salir.Location = new System.Drawing.Point(592, 311);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(110, 30);
            this.btn_Salir.TabIndex = 2;
            this.btn_Salir.Text = "Salir";
            this.btn_Salir.UseVisualStyleBackColor = false;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // btn_modificar
            // 
            this.btn_modificar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_modificar.BackColor = System.Drawing.SystemColors.Control;
            this.btn_modificar.Font = new System.Drawing.Font("Segoe UI Semibold", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_modificar.Location = new System.Drawing.Point(12, 311);
            this.btn_modificar.Name = "btn_modificar";
            this.btn_modificar.Size = new System.Drawing.Size(152, 30);
            this.btn_modificar.TabIndex = 3;
            this.btn_modificar.Text = "Modificar Datos";
            this.btn_modificar.UseVisualStyleBackColor = false;
            this.btn_modificar.Click += new System.EventHandler(this.btn_modificar_Click);
            // 
            // VistaUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BackgroundImage = global::UI.Properties.Resources.FondoPantallas;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(714, 348);
            this.Controls.Add(this.btn_modificar);
            this.Controls.Add(this.btn_Salir);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "VistaUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cliente";
            this.Load += new System.EventHandler(this.VistaUsuario_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.gbx_datosPersonales.ResumeLayout(false);
            this.gbx_datosPersonales.PerformLayout();
            this.groupBox_direccion.ResumeLayout(false);
            this.groupBox_direccion.PerformLayout();
            this.gbx_TipoCliente.ResumeLayout(false);
            this.gbx_TipoCliente.PerformLayout();
            this.gbx_Correo.ResumeLayout(false);
            this.gbx_Correo.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
		private System.Windows.Forms.GroupBox gbx_datosPersonales;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label lbl_valor_dni;
		private System.Windows.Forms.Label lbl_valor_tel;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label lbl_valor_legajo;
		private System.Windows.Forms.Label lbl_valor_nombre;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label lbl_valor_apellido;
		private System.Windows.Forms.GroupBox groupBox_direccion;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label lbl_valor_nomCiudad;
		private System.Windows.Forms.Label lbl_valor_depto;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label lbl_valor_codPostal;
		private System.Windows.Forms.Label lbl_valor_piso;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label lbl_valor_direc;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.GroupBox gbx_TipoCliente;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.Label lbl_valor_nombreTarifa;
		private System.Windows.Forms.Label label19;
		private System.Windows.Forms.Label lbl_valor_tarifaSExcl;
		private System.Windows.Forms.Label label21;
		private System.Windows.Forms.Label lbl_valor_tarifaCExcl;
		private System.Windows.Forms.Button btn_Salir;
		private System.Windows.Forms.Button btn_modificar;
		private System.Windows.Forms.GroupBox gbx_Correo;
		private System.Windows.Forms.TextBox textBox_correo;
	}
}