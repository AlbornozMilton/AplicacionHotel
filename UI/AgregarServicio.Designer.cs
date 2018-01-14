namespace UI
{
    partial class AgregarServicio
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_BuscarAlojamiento = new System.Windows.Forms.Button();
            this.cBox_Servicios = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cant_Servicio = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Aceptar = new System.Windows.Forms.Button();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dGV_ListadoAlojamientos = new System.Windows.Forms.DataGridView();
            this.clm_IdAlojmiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_DNIResponsable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_IDHabitacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl_msgdate = new System.Windows.Forms.Label();
            this.lbl_fecha = new System.Windows.Forms.Label();
            this.lbl_costoServicio = new System.Windows.Forms.Label();
            this.lbl_costo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cant_Servicio)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_ListadoAlojamientos)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_BuscarAlojamiento
            // 
            this.btn_BuscarAlojamiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_BuscarAlojamiento.Location = new System.Drawing.Point(15, 4);
            this.btn_BuscarAlojamiento.Name = "btn_BuscarAlojamiento";
            this.btn_BuscarAlojamiento.Size = new System.Drawing.Size(215, 25);
            this.btn_BuscarAlojamiento.TabIndex = 0;
            this.btn_BuscarAlojamiento.Text = "Buscar Alojamiento";
            this.btn_BuscarAlojamiento.UseVisualStyleBackColor = true;
            this.btn_BuscarAlojamiento.Click += new System.EventHandler(this.btn_BuscarAlojamiento_Click);
            // 
            // cBox_Servicios
            // 
            this.cBox_Servicios.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBox_Servicios.FormattingEnabled = true;
            this.cBox_Servicios.Items.AddRange(new object[] {
            "Bata",
            "Calefacción",
            "Aire Acondicionado",
            "Seguridad Medica",
            "Recargo por Fumar"});
            this.cBox_Servicios.Location = new System.Drawing.Point(12, 157);
            this.cBox_Servicios.Name = "cBox_Servicios";
            this.cBox_Servicios.Size = new System.Drawing.Size(218, 28);
            this.cBox_Servicios.TabIndex = 1;
            this.cBox_Servicios.SelectedIndexChanged += new System.EventHandler(this.cBox_Servicios_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Seleccione Servicio";
            // 
            // cant_Servicio
            // 
            this.cant_Servicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cant_Servicio.Location = new System.Drawing.Point(175, 201);
            this.cant_Servicio.Name = "cant_Servicio";
            this.cant_Servicio.Size = new System.Drawing.Size(55, 26);
            this.cant_Servicio.TabIndex = 3;
            this.cant_Servicio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cant_Servicio.ValueChanged += new System.EventHandler(this.cant_Servicio_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Cantidad Consumida";
            // 
            // btn_Aceptar
            // 
            this.btn_Aceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Aceptar.Location = new System.Drawing.Point(769, 201);
            this.btn_Aceptar.Name = "btn_Aceptar";
            this.btn_Aceptar.Size = new System.Drawing.Size(103, 29);
            this.btn_Aceptar.TabIndex = 5;
            this.btn_Aceptar.Text = "Aceptar";
            this.btn_Aceptar.UseVisualStyleBackColor = true;
            this.btn_Aceptar.Click += new System.EventHandler(this.btn_Aceptar_Click);
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancelar.Location = new System.Drawing.Point(630, 203);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(107, 29);
            this.btn_Cancelar.TabIndex = 6;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Controls.Add(this.dGV_ListadoAlojamientos);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 35);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(863, 82);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Alojamiento Seleccionado";
            // 
            // dGV_ListadoAlojamientos
            // 
            this.dGV_ListadoAlojamientos.AllowUserToAddRows = false;
            this.dGV_ListadoAlojamientos.AllowUserToDeleteRows = false;
            this.dGV_ListadoAlojamientos.AllowUserToOrderColumns = true;
            this.dGV_ListadoAlojamientos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dGV_ListadoAlojamientos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dGV_ListadoAlojamientos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_ListadoAlojamientos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clm_IdAlojmiento,
            this.clm_estado,
            this.clm_DNIResponsable,
            this.clm_Cliente,
            this.clm_IDHabitacion});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dGV_ListadoAlojamientos.DefaultCellStyle = dataGridViewCellStyle6;
            this.dGV_ListadoAlojamientos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dGV_ListadoAlojamientos.Location = new System.Drawing.Point(3, 25);
            this.dGV_ListadoAlojamientos.Name = "dGV_ListadoAlojamientos";
            this.dGV_ListadoAlojamientos.ReadOnly = true;
            this.dGV_ListadoAlojamientos.RowHeadersVisible = false;
            this.dGV_ListadoAlojamientos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGV_ListadoAlojamientos.Size = new System.Drawing.Size(857, 54);
            this.dGV_ListadoAlojamientos.TabIndex = 0;
            // 
            // clm_IdAlojmiento
            // 
            this.clm_IdAlojmiento.FillWeight = 35F;
            this.clm_IdAlojmiento.HeaderText = "Número";
            this.clm_IdAlojmiento.Name = "clm_IdAlojmiento";
            this.clm_IdAlojmiento.ReadOnly = true;
            // 
            // clm_estado
            // 
            this.clm_estado.FillWeight = 35F;
            this.clm_estado.HeaderText = "Estado";
            this.clm_estado.Name = "clm_estado";
            this.clm_estado.ReadOnly = true;
            // 
            // clm_DNIResponsable
            // 
            this.clm_DNIResponsable.FillWeight = 45F;
            this.clm_DNIResponsable.HeaderText = "Responsable";
            this.clm_DNIResponsable.Name = "clm_DNIResponsable";
            this.clm_DNIResponsable.ReadOnly = true;
            // 
            // clm_Cliente
            // 
            this.clm_Cliente.FillWeight = 140F;
            this.clm_Cliente.HeaderText = "Cliente";
            this.clm_Cliente.Name = "clm_Cliente";
            this.clm_Cliente.ReadOnly = true;
            // 
            // clm_IDHabitacion
            // 
            this.clm_IDHabitacion.FillWeight = 40F;
            this.clm_IDHabitacion.HeaderText = "Habitacion";
            this.clm_IDHabitacion.Name = "clm_IDHabitacion";
            this.clm_IDHabitacion.ReadOnly = true;
            // 
            // lbl_msgdate
            // 
            this.lbl_msgdate.AutoSize = true;
            this.lbl_msgdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_msgdate.Location = new System.Drawing.Point(271, 157);
            this.lbl_msgdate.Name = "lbl_msgdate";
            this.lbl_msgdate.Size = new System.Drawing.Size(209, 20);
            this.lbl_msgdate.TabIndex = 8;
            this.lbl_msgdate.Text = "La Fecha de Consumo será:";
            // 
            // lbl_fecha
            // 
            this.lbl_fecha.AutoSize = true;
            this.lbl_fecha.Location = new System.Drawing.Point(486, 162);
            this.lbl_fecha.Name = "lbl_fecha";
            this.lbl_fecha.Size = new System.Drawing.Size(42, 13);
            this.lbl_fecha.TabIndex = 9;
            this.lbl_fecha.Text = "FECHA";
            // 
            // lbl_costoServicio
            // 
            this.lbl_costoServicio.AutoSize = true;
            this.lbl_costoServicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_costoServicio.Location = new System.Drawing.Point(271, 192);
            this.lbl_costoServicio.Name = "lbl_costoServicio";
            this.lbl_costoServicio.Size = new System.Drawing.Size(136, 20);
            this.lbl_costoServicio.TabIndex = 10;
            this.lbl_costoServicio.Text = "Costo de Servicio:";
            // 
            // lbl_costo
            // 
            this.lbl_costo.AutoSize = true;
            this.lbl_costo.Location = new System.Drawing.Point(413, 197);
            this.lbl_costo.Name = "lbl_costo";
            this.lbl_costo.Size = new System.Drawing.Size(44, 13);
            this.lbl_costo.TabIndex = 11;
            this.lbl_costo.Text = "COSTO";
            // 
            // AgregarServicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 235);
            this.Controls.Add(this.lbl_costo);
            this.Controls.Add(this.lbl_costoServicio);
            this.Controls.Add(this.lbl_fecha);
            this.Controls.Add(this.lbl_msgdate);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_Aceptar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cant_Servicio);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cBox_Servicios);
            this.Controls.Add(this.btn_BuscarAlojamiento);
            this.Name = "AgregarServicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AgregarServicio";
            ((System.ComponentModel.ISupportInitialize)(this.cant_Servicio)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGV_ListadoAlojamientos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_BuscarAlojamiento;
        private System.Windows.Forms.ComboBox cBox_Servicios;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown cant_Servicio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Aceptar;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dGV_ListadoAlojamientos;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_IdAlojmiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_DNIResponsable;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_IDHabitacion;
        private System.Windows.Forms.Label lbl_msgdate;
        private System.Windows.Forms.Label lbl_fecha;
        private System.Windows.Forms.Label lbl_costoServicio;
        private System.Windows.Forms.Label lbl_costo;
    }
}