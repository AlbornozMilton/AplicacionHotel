namespace UI
{
    partial class ListarServiciosConsumidos
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dGV_ListadoAlojamientos = new System.Windows.Forms.DataGridView();
            this.btn_BuscarAlojamiento = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dGV_ListadoServicios = new System.Windows.Forms.DataGridView();
            this.btn_Aceptar = new System.Windows.Forms.Button();
            this.clm_Servicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_CostoBase = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_fechaConsumo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_IdAlojmiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_DNIResponsable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_IDHabitacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_ListadoAlojamientos)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_ListadoServicios)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Controls.Add(this.dGV_ListadoAlojamientos);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(9, 43);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(789, 82);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Alojamiento Seleccionado";
            // 
            // dGV_ListadoAlojamientos
            // 
            this.dGV_ListadoAlojamientos.AllowUserToAddRows = false;
            this.dGV_ListadoAlojamientos.AllowUserToDeleteRows = false;
            this.dGV_ListadoAlojamientos.AllowUserToOrderColumns = true;
            this.dGV_ListadoAlojamientos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dGV_ListadoAlojamientos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dGV_ListadoAlojamientos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_ListadoAlojamientos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clm_IdAlojmiento,
            this.clm_estado,
            this.clm_DNIResponsable,
            this.clm_Cliente,
            this.clm_IDHabitacion});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dGV_ListadoAlojamientos.DefaultCellStyle = dataGridViewCellStyle2;
            this.dGV_ListadoAlojamientos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dGV_ListadoAlojamientos.Location = new System.Drawing.Point(3, 22);
            this.dGV_ListadoAlojamientos.Name = "dGV_ListadoAlojamientos";
            this.dGV_ListadoAlojamientos.ReadOnly = true;
            this.dGV_ListadoAlojamientos.RowHeadersVisible = false;
            this.dGV_ListadoAlojamientos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGV_ListadoAlojamientos.Size = new System.Drawing.Size(783, 57);
            this.dGV_ListadoAlojamientos.TabIndex = 0;
            // 
            // btn_BuscarAlojamiento
            // 
            this.btn_BuscarAlojamiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_BuscarAlojamiento.Location = new System.Drawing.Point(12, 12);
            this.btn_BuscarAlojamiento.Name = "btn_BuscarAlojamiento";
            this.btn_BuscarAlojamiento.Size = new System.Drawing.Size(215, 25);
            this.btn_BuscarAlojamiento.TabIndex = 8;
            this.btn_BuscarAlojamiento.Text = "Buscar Alojamiento";
            this.btn_BuscarAlojamiento.UseVisualStyleBackColor = true;
            this.btn_BuscarAlojamiento.Click += new System.EventHandler(this.btn_BuscarAlojamiento_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dGV_ListadoServicios);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 131);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(786, 160);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Servicios Consumidos";
            // 
            // dGV_ListadoServicios
            // 
            this.dGV_ListadoServicios.AllowUserToAddRows = false;
            this.dGV_ListadoServicios.AllowUserToDeleteRows = false;
            this.dGV_ListadoServicios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dGV_ListadoServicios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dGV_ListadoServicios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_ListadoServicios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clm_Servicio,
            this.clm_Cantidad,
            this.clm_CostoBase,
            this.clm_fechaConsumo,
            this.clm_Total});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dGV_ListadoServicios.DefaultCellStyle = dataGridViewCellStyle4;
            this.dGV_ListadoServicios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dGV_ListadoServicios.Location = new System.Drawing.Point(3, 22);
            this.dGV_ListadoServicios.Name = "dGV_ListadoServicios";
            this.dGV_ListadoServicios.ReadOnly = true;
            this.dGV_ListadoServicios.RowHeadersVisible = false;
            this.dGV_ListadoServicios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGV_ListadoServicios.Size = new System.Drawing.Size(780, 135);
            this.dGV_ListadoServicios.TabIndex = 0;
            // 
            // btn_Aceptar
            // 
            this.btn_Aceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Aceptar.Location = new System.Drawing.Point(15, 305);
            this.btn_Aceptar.Name = "btn_Aceptar";
            this.btn_Aceptar.Size = new System.Drawing.Size(107, 30);
            this.btn_Aceptar.TabIndex = 12;
            this.btn_Aceptar.Text = "Salir";
            this.btn_Aceptar.UseVisualStyleBackColor = true;
            // 
            // clm_Servicio
            // 
            this.clm_Servicio.FillWeight = 90F;
            this.clm_Servicio.HeaderText = "Servicio";
            this.clm_Servicio.Name = "clm_Servicio";
            this.clm_Servicio.ReadOnly = true;
            // 
            // clm_Cantidad
            // 
            this.clm_Cantidad.FillWeight = 50F;
            this.clm_Cantidad.HeaderText = "Cantidad";
            this.clm_Cantidad.Name = "clm_Cantidad";
            this.clm_Cantidad.ReadOnly = true;
            // 
            // clm_CostoBase
            // 
            this.clm_CostoBase.FillWeight = 80F;
            this.clm_CostoBase.HeaderText = "Costo Base";
            this.clm_CostoBase.Name = "clm_CostoBase";
            this.clm_CostoBase.ReadOnly = true;
            // 
            // clm_fechaConsumo
            // 
            this.clm_fechaConsumo.FillWeight = 120F;
            this.clm_fechaConsumo.HeaderText = "Fecha Consumo";
            this.clm_fechaConsumo.Name = "clm_fechaConsumo";
            this.clm_fechaConsumo.ReadOnly = true;
            // 
            // clm_Total
            // 
            this.clm_Total.FillWeight = 80F;
            this.clm_Total.HeaderText = "Total";
            this.clm_Total.Name = "clm_Total";
            this.clm_Total.ReadOnly = true;
            // 
            // clm_IdAlojmiento
            // 
            this.clm_IdAlojmiento.FillWeight = 35F;
            this.clm_IdAlojmiento.HeaderText = "Numero";
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
            this.clm_DNIResponsable.FillWeight = 40F;
            this.clm_DNIResponsable.HeaderText = "Responsable";
            this.clm_DNIResponsable.Name = "clm_DNIResponsable";
            this.clm_DNIResponsable.ReadOnly = true;
            // 
            // clm_Cliente
            // 
            this.clm_Cliente.FillWeight = 150F;
            this.clm_Cliente.HeaderText = "Nombre Completo";
            this.clm_Cliente.Name = "clm_Cliente";
            this.clm_Cliente.ReadOnly = true;
            // 
            // clm_IDHabitacion
            // 
            this.clm_IDHabitacion.FillWeight = 35F;
            this.clm_IDHabitacion.HeaderText = "Habitacion";
            this.clm_IDHabitacion.Name = "clm_IDHabitacion";
            this.clm_IDHabitacion.ReadOnly = true;
            // 
            // ListarServiciosConsumidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 347);
            this.Controls.Add(this.btn_Aceptar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btn_BuscarAlojamiento);
            this.Name = "ListarServiciosConsumidos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ListarServiciosConsumidos";
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGV_ListadoAlojamientos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGV_ListadoServicios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dGV_ListadoAlojamientos;
        private System.Windows.Forms.Button btn_BuscarAlojamiento;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dGV_ListadoServicios;
        protected System.Windows.Forms.Button btn_Aceptar;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_Servicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_CostoBase;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_fechaConsumo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_Total;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_IdAlojmiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_DNIResponsable;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_IDHabitacion;
    }
}