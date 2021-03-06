﻿namespace UI
{
    partial class ModificarAltaCliente
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModificarAltaCliente));
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.tablaResulCliente = new System.Windows.Forms.DataGridView();
			this.clm_Dni = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.clm_legajo = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.clm_apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.clm_Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.clm_tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.clm_telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.btn_nuevoCliente = new System.Windows.Forms.Button();
			this.btn_darAlta = new System.Windows.Forms.Button();
			this.btn_darBaja = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.btn_aceptar = new System.Windows.Forms.Button();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.tablaResulCliente)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox2
			// 
			this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox2.BackColor = System.Drawing.Color.Transparent;
			this.groupBox2.Controls.Add(this.tablaResulCliente);
			this.groupBox2.Font = new System.Drawing.Font("Segoe UI Semibold", 12.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox2.Location = new System.Drawing.Point(11, 48);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(1052, 84);
			this.groupBox2.TabIndex = 4;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Cliente Seleccionado";
			// 
			// tablaResulCliente
			// 
			this.tablaResulCliente.AllowUserToAddRows = false;
			this.tablaResulCliente.AllowUserToDeleteRows = false;
			this.tablaResulCliente.AllowUserToResizeColumns = false;
			this.tablaResulCliente.AllowUserToResizeRows = false;
			this.tablaResulCliente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.tablaResulCliente.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.tablaResulCliente.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 12.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.tablaResulCliente.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.tablaResulCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.tablaResulCliente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clm_Dni,
            this.clm_legajo,
            this.clm_apellido,
            this.clm_Nombre,
            this.clm_tipo,
            this.clm_telefono});
			dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI Semibold", 12.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.tablaResulCliente.DefaultCellStyle = dataGridViewCellStyle6;
			this.tablaResulCliente.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tablaResulCliente.Location = new System.Drawing.Point(3, 26);
			this.tablaResulCliente.MultiSelect = false;
			this.tablaResulCliente.Name = "tablaResulCliente";
			this.tablaResulCliente.ReadOnly = true;
			this.tablaResulCliente.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.tablaResulCliente.RowHeadersVisible = false;
			dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			this.tablaResulCliente.RowsDefaultCellStyle = dataGridViewCellStyle7;
			this.tablaResulCliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.tablaResulCliente.Size = new System.Drawing.Size(1046, 55);
			this.tablaResulCliente.StandardTab = true;
			this.tablaResulCliente.TabIndex = 0;
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
			// clm_Nombre
			// 
			this.clm_Nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			this.clm_Nombre.DefaultCellStyle = dataGridViewCellStyle4;
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
			// clm_telefono
			// 
			this.clm_telefono.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			this.clm_telefono.DefaultCellStyle = dataGridViewCellStyle5;
			this.clm_telefono.FillWeight = 30F;
			this.clm_telefono.HeaderText = "Estado";
			this.clm_telefono.Name = "clm_telefono";
			this.clm_telefono.ReadOnly = true;
			// 
			// btn_nuevoCliente
			// 
			this.btn_nuevoCliente.Font = new System.Drawing.Font("Segoe UI Semibold", 12.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_nuevoCliente.Location = new System.Drawing.Point(12, 12);
			this.btn_nuevoCliente.Name = "btn_nuevoCliente";
			this.btn_nuevoCliente.Size = new System.Drawing.Size(150, 30);
			this.btn_nuevoCliente.TabIndex = 12;
			this.btn_nuevoCliente.Text = "Buscar Cliente";
			this.btn_nuevoCliente.UseVisualStyleBackColor = true;
			this.btn_nuevoCliente.Click += new System.EventHandler(this.btn_nuevoCliente_Click);
			// 
			// btn_darAlta
			// 
			this.btn_darAlta.Font = new System.Drawing.Font("Segoe UI Semibold", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_darAlta.Location = new System.Drawing.Point(975, 149);
			this.btn_darAlta.Name = "btn_darAlta";
			this.btn_darAlta.Size = new System.Drawing.Size(85, 30);
			this.btn_darAlta.TabIndex = 13;
			this.btn_darAlta.Text = "Dar Alta";
			this.btn_darAlta.UseVisualStyleBackColor = true;
			this.btn_darAlta.Click += new System.EventHandler(this.btn_darAlta_Click);
			// 
			// btn_darBaja
			// 
			this.btn_darBaja.Font = new System.Drawing.Font("Segoe UI Semibold", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_darBaja.Location = new System.Drawing.Point(975, 210);
			this.btn_darBaja.Name = "btn_darBaja";
			this.btn_darBaja.Size = new System.Drawing.Size(85, 30);
			this.btn_darBaja.TabIndex = 14;
			this.btn_darBaja.Text = "Dar Baja";
			this.btn_darBaja.UseVisualStyleBackColor = true;
			this.btn_darBaja.Click += new System.EventHandler(this.btn_darBaja_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.Color.Transparent;
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 12.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(11, 138);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(962, 102);
			this.groupBox1.TabIndex = 15;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Ayuda";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(16, 62);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(532, 20);
			this.label2.TabIndex = 1;
			this.label2.Text = "Un cliente que esta en Baja, no puede participar en ningún tipo de actividad.";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(16, 30);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(628, 20);
			this.label1.TabIndex = 0;
			this.label1.Text = "Un cliente que esta en Alta, puede participar en las reservas y altas de nuevos A" +
    "lojamiento.";
			// 
			// btn_aceptar
			// 
			this.btn_aceptar.Font = new System.Drawing.Font("Segoe UI Semibold", 12.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_aceptar.Location = new System.Drawing.Point(11, 245);
			this.btn_aceptar.Name = "btn_aceptar";
			this.btn_aceptar.Size = new System.Drawing.Size(110, 30);
			this.btn_aceptar.TabIndex = 16;
			this.btn_aceptar.Text = "Salir";
			this.btn_aceptar.UseVisualStyleBackColor = true;
			this.btn_aceptar.Click += new System.EventHandler(this.btn_aceptar_Click);
			// 
			// ModificarAltaCliente
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.BackgroundImage = global::UI.Properties.Resources.FondoPantallas;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(1076, 283);
			this.Controls.Add(this.btn_aceptar);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.btn_darBaja);
			this.Controls.Add(this.btn_darAlta);
			this.Controls.Add(this.btn_nuevoCliente);
			this.Controls.Add(this.groupBox2);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "ModificarAltaCliente";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Modificar Estado Cliente";
			this.groupBox2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.tablaResulCliente)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView tablaResulCliente;
        private System.Windows.Forms.Button btn_nuevoCliente;
        private System.Windows.Forms.Button btn_darAlta;
        private System.Windows.Forms.Button btn_darBaja;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_aceptar;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_Dni;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_legajo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_telefono;
    }
}