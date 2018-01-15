﻿namespace UI
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
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.btn_Aceptar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tablaResulClientes = new System.Windows.Forms.DataGridView();
            this.btn_nuevoCliente = new System.Windows.Forms.Button();
            this.clm_Dni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_legajo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Buscar)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaResulClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Cancelar.BackColor = System.Drawing.SystemColors.Control;
            this.btn_Cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancelar.Location = new System.Drawing.Point(13, 403);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(111, 29);
            this.btn_Cancelar.TabIndex = 0;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = false;
            this.btn_Cancelar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_Aceptar
            // 
            this.btn_Aceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Aceptar.BackColor = System.Drawing.SystemColors.Control;
            this.btn_Aceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Aceptar.Location = new System.Drawing.Point(722, 403);
            this.btn_Aceptar.Name = "btn_Aceptar";
            this.btn_Aceptar.Size = new System.Drawing.Size(111, 29);
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
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
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
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(824, 144);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Búsqueda";
            // 
            // textBox_Legajo
            // 
            this.textBox_Legajo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Legajo.Location = new System.Drawing.Point(347, 68);
            this.textBox_Legajo.Name = "textBox_Legajo";
            this.textBox_Legajo.Size = new System.Drawing.Size(168, 26);
            this.textBox_Legajo.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(194, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Ingrese Legajo:";
            // 
            // radioButton_legajo
            // 
            this.radioButton_legajo.AutoSize = true;
            this.radioButton_legajo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_legajo.Location = new System.Drawing.Point(23, 69);
            this.radioButton_legajo.Name = "radioButton_legajo";
            this.radioButton_legajo.Size = new System.Drawing.Size(103, 24);
            this.radioButton_legajo.TabIndex = 2;
            this.radioButton_legajo.Text = "Por Legajo";
            this.radioButton_legajo.UseVisualStyleBackColor = true;
            this.radioButton_legajo.CheckedChanged += new System.EventHandler(this.radioButton_legajo_CheckedChanged);
            // 
            // btn_Buscar
            // 
            this.btn_Buscar.Image = global::UI.Properties.Resources.boton_buscar;
            this.btn_Buscar.Location = new System.Drawing.Point(541, 52);
            this.btn_Buscar.Name = "btn_Buscar";
            this.btn_Buscar.Size = new System.Drawing.Size(56, 54);
            this.btn_Buscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btn_Buscar.TabIndex = 6;
            this.btn_Buscar.TabStop = false;
            this.btn_Buscar.Click += new System.EventHandler(this.btn_Buscar_Click);
            // 
            // textBox_Nombre
            // 
            this.textBox_Nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Nombre.Location = new System.Drawing.Point(347, 104);
            this.textBox_Nombre.Name = "textBox_Nombre";
            this.textBox_Nombre.Size = new System.Drawing.Size(168, 26);
            this.textBox_Nombre.TabIndex = 5;
            // 
            // textBox_DNI
            // 
            this.textBox_DNI.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_DNI.Location = new System.Drawing.Point(347, 31);
            this.textBox_DNI.Name = "textBox_DNI";
            this.textBox_DNI.Size = new System.Drawing.Size(168, 26);
            this.textBox_DNI.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(194, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ingrese Nombre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(194, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ingrese DNI:";
            // 
            // radioButton_nombre
            // 
            this.radioButton_nombre.AutoSize = true;
            this.radioButton_nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_nombre.Location = new System.Drawing.Point(23, 105);
            this.radioButton_nombre.Name = "radioButton_nombre";
            this.radioButton_nombre.Size = new System.Drawing.Size(111, 24);
            this.radioButton_nombre.TabIndex = 3;
            this.radioButton_nombre.Text = "Por Nombre";
            this.radioButton_nombre.UseVisualStyleBackColor = true;
            this.radioButton_nombre.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.Location = new System.Drawing.Point(23, 32);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(83, 24);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Por DNI";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Controls.Add(this.tablaResulClientes);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 163);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(824, 234);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Resultados";
            // 
            // tablaResulClientes
            // 
            this.tablaResulClientes.AllowUserToAddRows = false;
            this.tablaResulClientes.AllowUserToDeleteRows = false;
            this.tablaResulClientes.AllowUserToOrderColumns = true;
            this.tablaResulClientes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tablaResulClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tablaResulClientes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.tablaResulClientes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.tablaResulClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaResulClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clm_Dni,
            this.clm_legajo,
            this.clm_apellido,
            this.clm_Nombre,
            this.clm_telefono});
            this.tablaResulClientes.Location = new System.Drawing.Point(3, 25);
            this.tablaResulClientes.MultiSelect = false;
            this.tablaResulClientes.Name = "tablaResulClientes";
            this.tablaResulClientes.ReadOnly = true;
            this.tablaResulClientes.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tablaResulClientes.RowHeadersVisible = false;
            this.tablaResulClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tablaResulClientes.Size = new System.Drawing.Size(818, 203);
            this.tablaResulClientes.StandardTab = true;
            this.tablaResulClientes.TabIndex = 0;
            // 
            // btn_nuevoCliente
            // 
            this.btn_nuevoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_nuevoCliente.Location = new System.Drawing.Point(654, 52);
            this.btn_nuevoCliente.Name = "btn_nuevoCliente";
            this.btn_nuevoCliente.Size = new System.Drawing.Size(129, 39);
            this.btn_nuevoCliente.TabIndex = 11;
            this.btn_nuevoCliente.Text = "Nuevo Cliente";
            this.btn_nuevoCliente.UseVisualStyleBackColor = true;
            this.btn_nuevoCliente.Click += new System.EventHandler(this.btn_nuevoCliente_Click);
            // 
            // clm_Dni
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.clm_Dni.DefaultCellStyle = dataGridViewCellStyle1;
            this.clm_Dni.FillWeight = 50F;
            this.clm_Dni.HeaderText = "DNI";
            this.clm_Dni.Name = "clm_Dni";
            this.clm_Dni.ReadOnly = true;
            // 
            // clm_legajo
            // 
            this.clm_legajo.FillWeight = 40F;
            this.clm_legajo.HeaderText = "Legajo";
            this.clm_legajo.Name = "clm_legajo";
            this.clm_legajo.ReadOnly = true;
            // 
            // clm_apellido
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.clm_apellido.DefaultCellStyle = dataGridViewCellStyle2;
            this.clm_apellido.FillWeight = 65F;
            this.clm_apellido.HeaderText = "Apellido";
            this.clm_apellido.Name = "clm_apellido";
            this.clm_apellido.ReadOnly = true;
            // 
            // clm_Nombre
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.clm_Nombre.DefaultCellStyle = dataGridViewCellStyle3;
            this.clm_Nombre.FillWeight = 85F;
            this.clm_Nombre.HeaderText = "Nombre";
            this.clm_Nombre.Name = "clm_Nombre";
            this.clm_Nombre.ReadOnly = true;
            // 
            // clm_telefono
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.clm_telefono.DefaultCellStyle = dataGridViewCellStyle4;
            this.clm_telefono.FillWeight = 80F;
            this.clm_telefono.HeaderText = "Telefono";
            this.clm_telefono.Name = "clm_telefono";
            this.clm_telefono.ReadOnly = true;
            // 
            // BuscarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(849, 435);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_Aceptar);
            this.Controls.Add(this.btn_Cancelar);
            this.Name = "BuscarCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscar Cliente";
            this.Load += new System.EventHandler(this.BuscarCliente_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Buscar)).EndInit();
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
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_Dni;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_legajo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_telefono;
    }
}