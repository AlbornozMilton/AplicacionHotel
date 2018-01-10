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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dGV_ListadoAlojamientos = new System.Windows.Forms.DataGridView();
            this.btn_BuscarAlojamiento = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dGV_ListadoServicios = new System.Windows.Forms.DataGridView();
            this.clm_Servicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_CostoBase = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_Aceptar = new System.Windows.Forms.Button();
            this.clm_IdAlojmiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dGV_ListadoAlojamientos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dGV_ListadoAlojamientos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_ListadoAlojamientos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clm_IdAlojmiento,
            this.clm_DNIResponsable,
            this.clm_Cliente,
            this.clm_IDHabitacion});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dGV_ListadoAlojamientos.DefaultCellStyle = dataGridViewCellStyle6;
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
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dGV_ListadoServicios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dGV_ListadoServicios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_ListadoServicios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clm_Servicio,
            this.clm_Cantidad,
            this.clm_CostoBase,
            this.clm_Total});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dGV_ListadoServicios.DefaultCellStyle = dataGridViewCellStyle8;
            this.dGV_ListadoServicios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dGV_ListadoServicios.Location = new System.Drawing.Point(3, 22);
            this.dGV_ListadoServicios.Name = "dGV_ListadoServicios";
            this.dGV_ListadoServicios.ReadOnly = true;
            this.dGV_ListadoServicios.RowHeadersVisible = false;
            this.dGV_ListadoServicios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGV_ListadoServicios.Size = new System.Drawing.Size(780, 135);
            this.dGV_ListadoServicios.TabIndex = 0;
            // 
            // clm_Servicio
            // 
            this.clm_Servicio.HeaderText = "Servicio";
            this.clm_Servicio.Name = "clm_Servicio";
            this.clm_Servicio.ReadOnly = true;
            // 
            // clm_Cantidad
            // 
            this.clm_Cantidad.HeaderText = "Cantidad";
            this.clm_Cantidad.Name = "clm_Cantidad";
            this.clm_Cantidad.ReadOnly = true;
            // 
            // clm_CostoBase
            // 
            this.clm_CostoBase.HeaderText = "Costo Base";
            this.clm_CostoBase.Name = "clm_CostoBase";
            this.clm_CostoBase.ReadOnly = true;
            // 
            // clm_Total
            // 
            this.clm_Total.HeaderText = "Total";
            this.clm_Total.Name = "clm_Total";
            this.clm_Total.ReadOnly = true;
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
            // clm_IdAlojmiento
            // 
            this.clm_IdAlojmiento.FillWeight = 35F;
            this.clm_IdAlojmiento.HeaderText = "Numero";
            this.clm_IdAlojmiento.Name = "clm_IdAlojmiento";
            this.clm_IdAlojmiento.ReadOnly = true;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_Servicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_CostoBase;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_Total;
        protected System.Windows.Forms.Button btn_Aceptar;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_IdAlojmiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_DNIResponsable;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_IDHabitacion;
    }
}