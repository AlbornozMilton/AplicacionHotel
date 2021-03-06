﻿namespace UI
{
    partial class CerrarAlojamiento
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CerrarAlojamiento));
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.dGV_ListadoAlojamientos = new System.Windows.Forms.DataGridView();
			this.clm_IdAlojmiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.clm_estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.clm_IDHabitacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.clm_DNIResponsable = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.clm_nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.btn_BuscarAlojamiento = new System.Windows.Forms.Button();
			this.btn_Cancelar = new System.Windows.Forms.Button();
			this.btn_Aceptar = new System.Windows.Forms.Button();
			this.btn_Visualizar = new System.Windows.Forms.Button();
			this.lbl_txtFechaActual = new System.Windows.Forms.Label();
			this.lbl_txtfechaEstEgreso = new System.Windows.Forms.Label();
			this.lbl_fechaEstEgreso = new System.Windows.Forms.Label();
			this.lbl_fechaActual = new System.Windows.Forms.Label();
			this.pictureBox_deuda = new System.Windows.Forms.PictureBox();
			this.label_deuda = new System.Windows.Forms.Label();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dGV_ListadoAlojamientos)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_deuda)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox2
			// 
			this.groupBox2.BackColor = System.Drawing.Color.Transparent;
			this.groupBox2.Controls.Add(this.dGV_ListadoAlojamientos);
			this.groupBox2.Font = new System.Drawing.Font("Segoe UI Semibold", 12.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox2.Location = new System.Drawing.Point(9, 63);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(816, 86);
			this.groupBox2.TabIndex = 9;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Alojamiento Seleccionado";
			// 
			// dGV_ListadoAlojamientos
			// 
			this.dGV_ListadoAlojamientos.AllowUserToAddRows = false;
			this.dGV_ListadoAlojamientos.AllowUserToDeleteRows = false;
			this.dGV_ListadoAlojamientos.AllowUserToResizeColumns = false;
			this.dGV_ListadoAlojamientos.AllowUserToResizeRows = false;
			this.dGV_ListadoAlojamientos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 12.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dGV_ListadoAlojamientos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dGV_ListadoAlojamientos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dGV_ListadoAlojamientos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clm_IdAlojmiento,
            this.clm_estado,
            this.clm_IDHabitacion,
            this.clm_DNIResponsable,
            this.clm_nom});
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 12.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dGV_ListadoAlojamientos.DefaultCellStyle = dataGridViewCellStyle2;
			this.dGV_ListadoAlojamientos.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dGV_ListadoAlojamientos.Location = new System.Drawing.Point(3, 26);
			this.dGV_ListadoAlojamientos.Name = "dGV_ListadoAlojamientos";
			this.dGV_ListadoAlojamientos.ReadOnly = true;
			this.dGV_ListadoAlojamientos.RowHeadersVisible = false;
			this.dGV_ListadoAlojamientos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dGV_ListadoAlojamientos.Size = new System.Drawing.Size(810, 57);
			this.dGV_ListadoAlojamientos.TabIndex = 0;
			// 
			// clm_IdAlojmiento
			// 
			this.clm_IdAlojmiento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.clm_IdAlojmiento.FillWeight = 35F;
			this.clm_IdAlojmiento.HeaderText = "Número";
			this.clm_IdAlojmiento.Name = "clm_IdAlojmiento";
			this.clm_IdAlojmiento.ReadOnly = true;
			// 
			// clm_estado
			// 
			this.clm_estado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.clm_estado.FillWeight = 35F;
			this.clm_estado.HeaderText = "Estado";
			this.clm_estado.Name = "clm_estado";
			this.clm_estado.ReadOnly = true;
			// 
			// clm_IDHabitacion
			// 
			this.clm_IDHabitacion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.clm_IDHabitacion.FillWeight = 40F;
			this.clm_IDHabitacion.HeaderText = "Habitación";
			this.clm_IDHabitacion.Name = "clm_IDHabitacion";
			this.clm_IDHabitacion.ReadOnly = true;
			// 
			// clm_DNIResponsable
			// 
			this.clm_DNIResponsable.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.clm_DNIResponsable.FillWeight = 45F;
			this.clm_DNIResponsable.HeaderText = "Responsable";
			this.clm_DNIResponsable.Name = "clm_DNIResponsable";
			this.clm_DNIResponsable.ReadOnly = true;
			// 
			// clm_nom
			// 
			this.clm_nom.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.clm_nom.FillWeight = 140F;
			this.clm_nom.HeaderText = "Nombre Completo";
			this.clm_nom.Name = "clm_nom";
			this.clm_nom.ReadOnly = true;
			// 
			// btn_BuscarAlojamiento
			// 
			this.btn_BuscarAlojamiento.Font = new System.Drawing.Font("Segoe UI Semibold", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_BuscarAlojamiento.Location = new System.Drawing.Point(12, 12);
			this.btn_BuscarAlojamiento.Name = "btn_BuscarAlojamiento";
			this.btn_BuscarAlojamiento.Size = new System.Drawing.Size(219, 30);
			this.btn_BuscarAlojamiento.TabIndex = 8;
			this.btn_BuscarAlojamiento.Text = "Buscar Alojamiento";
			this.btn_BuscarAlojamiento.UseVisualStyleBackColor = true;
			this.btn_BuscarAlojamiento.Click += new System.EventHandler(this.btn_BuscarAlojamiento_Click);
			// 
			// btn_Cancelar
			// 
			this.btn_Cancelar.Font = new System.Drawing.Font("Segoe UI Semibold", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_Cancelar.Location = new System.Drawing.Point(12, 193);
			this.btn_Cancelar.Name = "btn_Cancelar";
			this.btn_Cancelar.Size = new System.Drawing.Size(110, 30);
			this.btn_Cancelar.TabIndex = 11;
			this.btn_Cancelar.Text = "Cancelar";
			this.btn_Cancelar.UseVisualStyleBackColor = true;
			this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
			// 
			// btn_Aceptar
			// 
			this.btn_Aceptar.Enabled = false;
			this.btn_Aceptar.Font = new System.Drawing.Font("Segoe UI Semibold", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_Aceptar.Location = new System.Drawing.Point(712, 193);
			this.btn_Aceptar.Name = "btn_Aceptar";
			this.btn_Aceptar.Size = new System.Drawing.Size(110, 30);
			this.btn_Aceptar.TabIndex = 10;
			this.btn_Aceptar.Text = "Aceptar";
			this.btn_Aceptar.UseVisualStyleBackColor = true;
			this.btn_Aceptar.Click += new System.EventHandler(this.btn_Aceptar_Click);
			// 
			// btn_Visualizar
			// 
			this.btn_Visualizar.Font = new System.Drawing.Font("Segoe UI Semibold", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_Visualizar.Location = new System.Drawing.Point(712, 157);
			this.btn_Visualizar.Name = "btn_Visualizar";
			this.btn_Visualizar.Size = new System.Drawing.Size(110, 30);
			this.btn_Visualizar.TabIndex = 12;
			this.btn_Visualizar.Text = "Ver Detalles";
			this.btn_Visualizar.UseVisualStyleBackColor = true;
			this.btn_Visualizar.Click += new System.EventHandler(this.btn_Visualizar_Click);
			// 
			// lbl_txtFechaActual
			// 
			this.lbl_txtFechaActual.AutoSize = true;
			this.lbl_txtFechaActual.BackColor = System.Drawing.Color.Transparent;
			this.lbl_txtFechaActual.Font = new System.Drawing.Font("Segoe UI Semibold", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_txtFechaActual.Location = new System.Drawing.Point(578, 9);
			this.lbl_txtFechaActual.Name = "lbl_txtFechaActual";
			this.lbl_txtFechaActual.Size = new System.Drawing.Size(112, 23);
			this.lbl_txtFechaActual.TabIndex = 14;
			this.lbl_txtFechaActual.Text = "Fecha Actual:";
			// 
			// lbl_txtfechaEstEgreso
			// 
			this.lbl_txtfechaEstEgreso.AutoSize = true;
			this.lbl_txtfechaEstEgreso.BackColor = System.Drawing.Color.Transparent;
			this.lbl_txtfechaEstEgreso.Font = new System.Drawing.Font("Segoe UI Semibold", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_txtfechaEstEgreso.Location = new System.Drawing.Point(501, 35);
			this.lbl_txtfechaEstEgreso.Name = "lbl_txtfechaEstEgreso";
			this.lbl_txtfechaEstEgreso.Size = new System.Drawing.Size(189, 23);
			this.lbl_txtfechaEstEgreso.TabIndex = 15;
			this.lbl_txtfechaEstEgreso.Text = "Fecha Estimada Egreso:";
			// 
			// lbl_fechaEstEgreso
			// 
			this.lbl_fechaEstEgreso.AutoSize = true;
			this.lbl_fechaEstEgreso.BackColor = System.Drawing.Color.Transparent;
			this.lbl_fechaEstEgreso.Font = new System.Drawing.Font("Segoe UI Semibold", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_fechaEstEgreso.ForeColor = System.Drawing.SystemColors.MenuText;
			this.lbl_fechaEstEgreso.Location = new System.Drawing.Point(695, 35);
			this.lbl_fechaEstEgreso.Name = "lbl_fechaEstEgreso";
			this.lbl_fechaEstEgreso.Size = new System.Drawing.Size(130, 23);
			this.lbl_fechaEstEgreso.TabIndex = 16;
			this.lbl_fechaEstEgreso.Text = "dd / mm / yyyy";
			// 
			// lbl_fechaActual
			// 
			this.lbl_fechaActual.AutoSize = true;
			this.lbl_fechaActual.BackColor = System.Drawing.Color.Transparent;
			this.lbl_fechaActual.Font = new System.Drawing.Font("Segoe UI Semibold", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_fechaActual.ForeColor = System.Drawing.Color.OrangeRed;
			this.lbl_fechaActual.Location = new System.Drawing.Point(695, 9);
			this.lbl_fechaActual.Name = "lbl_fechaActual";
			this.lbl_fechaActual.Size = new System.Drawing.Size(130, 23);
			this.lbl_fechaActual.TabIndex = 17;
			this.lbl_fechaActual.Text = "dd / mm / yyyy";
			// 
			// pictureBox_deuda
			// 
			this.pictureBox_deuda.BackColor = System.Drawing.SystemColors.MenuHighlight;
			this.pictureBox_deuda.Location = new System.Drawing.Point(12, 152);
			this.pictureBox_deuda.Name = "pictureBox_deuda";
			this.pictureBox_deuda.Size = new System.Drawing.Size(43, 19);
			this.pictureBox_deuda.TabIndex = 18;
			this.pictureBox_deuda.TabStop = false;
			this.pictureBox_deuda.Visible = false;
			// 
			// label_deuda
			// 
			this.label_deuda.AutoSize = true;
			this.label_deuda.BackColor = System.Drawing.Color.Transparent;
			this.label_deuda.Font = new System.Drawing.Font("Segoe UI Semibold", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label_deuda.ForeColor = System.Drawing.SystemColors.MenuHighlight;
			this.label_deuda.Location = new System.Drawing.Point(61, 149);
			this.label_deuda.Name = "label_deuda";
			this.label_deuda.Size = new System.Drawing.Size(176, 23);
			this.label_deuda.TabIndex = 19;
			this.label_deuda.Text = "Servicios Consumidos";
			this.label_deuda.Visible = false;
			// 
			// CerrarAlojamiento
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.BackgroundImage = global::UI.Properties.Resources.FondoPantallas;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(834, 231);
			this.Controls.Add(this.label_deuda);
			this.Controls.Add(this.pictureBox_deuda);
			this.Controls.Add(this.lbl_fechaActual);
			this.Controls.Add(this.lbl_fechaEstEgreso);
			this.Controls.Add(this.lbl_txtfechaEstEgreso);
			this.Controls.Add(this.lbl_txtFechaActual);
			this.Controls.Add(this.btn_Visualizar);
			this.Controls.Add(this.btn_Cancelar);
			this.Controls.Add(this.btn_Aceptar);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.btn_BuscarAlojamiento);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "CerrarAlojamiento";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Cerrar Alojamiento";
			this.groupBox2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dGV_ListadoAlojamientos)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_deuda)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dGV_ListadoAlojamientos;
        private System.Windows.Forms.Button btn_BuscarAlojamiento;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.Button btn_Aceptar;
        private System.Windows.Forms.Button btn_Visualizar;
        private System.Windows.Forms.Label lbl_txtFechaActual;
        private System.Windows.Forms.Label lbl_txtfechaEstEgreso;
        private System.Windows.Forms.Label lbl_fechaEstEgreso;
        private System.Windows.Forms.Label lbl_fechaActual;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_IdAlojmiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_IDHabitacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_DNIResponsable;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_nom;
		private System.Windows.Forms.PictureBox pictureBox_deuda;
		private System.Windows.Forms.Label label_deuda;
	}
}