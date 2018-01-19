namespace UI
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dGV_ListadoAlojamientos = new System.Windows.Forms.DataGridView();
            this.clm_IdAlojmiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_DNIResponsable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_IDHabitacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_BuscarAlojamiento = new System.Windows.Forms.Button();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.btn_Aceptar = new System.Windows.Forms.Button();
            this.btn_Visualizar = new System.Windows.Forms.Button();
            this.btn_realizarPago = new System.Windows.Forms.Button();
            this.lbl_txtFechaActual = new System.Windows.Forms.Label();
            this.lbl_txtfechaEstEgreso = new System.Windows.Forms.Label();
            this.lbl_fechaEstEgreso = new System.Windows.Forms.Label();
            this.lbl_fechaActual = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_ListadoAlojamientos)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Controls.Add(this.dGV_ListadoAlojamientos);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.dGV_ListadoAlojamientos.AllowUserToOrderColumns = true;
            this.dGV_ListadoAlojamientos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dGV_ListadoAlojamientos.DefaultCellStyle = dataGridViewCellStyle2;
            this.dGV_ListadoAlojamientos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dGV_ListadoAlojamientos.Location = new System.Drawing.Point(3, 25);
            this.dGV_ListadoAlojamientos.Name = "dGV_ListadoAlojamientos";
            this.dGV_ListadoAlojamientos.ReadOnly = true;
            this.dGV_ListadoAlojamientos.RowHeadersVisible = false;
            this.dGV_ListadoAlojamientos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGV_ListadoAlojamientos.Size = new System.Drawing.Size(810, 58);
            this.dGV_ListadoAlojamientos.TabIndex = 0;
            // 
            // clm_IdAlojmiento
            // 
            this.clm_IdAlojmiento.FillWeight = 30F;
            this.clm_IdAlojmiento.HeaderText = "Número";
            this.clm_IdAlojmiento.Name = "clm_IdAlojmiento";
            this.clm_IdAlojmiento.ReadOnly = true;
            // 
            // clm_estado
            // 
            this.clm_estado.FillWeight = 40F;
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
            this.clm_Cliente.FillWeight = 120F;
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
            // btn_BuscarAlojamiento
            // 
            this.btn_BuscarAlojamiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_BuscarAlojamiento.Location = new System.Drawing.Point(12, 12);
            this.btn_BuscarAlojamiento.Name = "btn_BuscarAlojamiento";
            this.btn_BuscarAlojamiento.Size = new System.Drawing.Size(219, 36);
            this.btn_BuscarAlojamiento.TabIndex = 8;
            this.btn_BuscarAlojamiento.Text = "Buscar Alojamiento";
            this.btn_BuscarAlojamiento.UseVisualStyleBackColor = true;
            this.btn_BuscarAlojamiento.Click += new System.EventHandler(this.btn_BuscarAlojamiento_Click);
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancelar.Location = new System.Drawing.Point(12, 205);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(103, 30);
            this.btn_Cancelar.TabIndex = 11;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            // 
            // btn_Aceptar
            // 
            this.btn_Aceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Aceptar.Location = new System.Drawing.Point(700, 205);
            this.btn_Aceptar.Name = "btn_Aceptar";
            this.btn_Aceptar.Size = new System.Drawing.Size(119, 30);
            this.btn_Aceptar.TabIndex = 10;
            this.btn_Aceptar.Text = "Aceptar";
            this.btn_Aceptar.UseVisualStyleBackColor = true;
            this.btn_Aceptar.Click += new System.EventHandler(this.btn_Aceptar_Click);
            // 
            // btn_Visualizar
            // 
            this.btn_Visualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Visualizar.Location = new System.Drawing.Point(584, 157);
            this.btn_Visualizar.Name = "btn_Visualizar";
            this.btn_Visualizar.Size = new System.Drawing.Size(110, 30);
            this.btn_Visualizar.TabIndex = 12;
            this.btn_Visualizar.Text = "Ver Detalles";
            this.btn_Visualizar.UseVisualStyleBackColor = true;
            this.btn_Visualizar.Click += new System.EventHandler(this.btn_Visualizar_Click);
            // 
            // btn_realizarPago
            // 
            this.btn_realizarPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_realizarPago.Location = new System.Drawing.Point(700, 157);
            this.btn_realizarPago.Name = "btn_realizarPago";
            this.btn_realizarPago.Size = new System.Drawing.Size(119, 30);
            this.btn_realizarPago.TabIndex = 13;
            this.btn_realizarPago.Text = "Realizar Pago";
            this.btn_realizarPago.UseVisualStyleBackColor = true;
            this.btn_realizarPago.Click += new System.EventHandler(this.btn_realizarPago_Click);
            // 
            // lbl_txtFechaActual
            // 
            this.lbl_txtFechaActual.AutoSize = true;
            this.lbl_txtFechaActual.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_txtFechaActual.Location = new System.Drawing.Point(606, 8);
            this.lbl_txtFechaActual.Name = "lbl_txtFechaActual";
            this.lbl_txtFechaActual.Size = new System.Drawing.Size(107, 20);
            this.lbl_txtFechaActual.TabIndex = 14;
            this.lbl_txtFechaActual.Text = "Fecha Actual:";
            // 
            // lbl_txtfechaEstEgreso
            // 
            this.lbl_txtfechaEstEgreso.AutoSize = true;
            this.lbl_txtfechaEstEgreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_txtfechaEstEgreso.Location = new System.Drawing.Point(529, 28);
            this.lbl_txtfechaEstEgreso.Name = "lbl_txtfechaEstEgreso";
            this.lbl_txtfechaEstEgreso.Size = new System.Drawing.Size(184, 20);
            this.lbl_txtfechaEstEgreso.TabIndex = 15;
            this.lbl_txtfechaEstEgreso.Text = "Fecha Estimada Egreso:";
            // 
            // lbl_fechaEstEgreso
            // 
            this.lbl_fechaEstEgreso.AutoSize = true;
            this.lbl_fechaEstEgreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fechaEstEgreso.Location = new System.Drawing.Point(719, 28);
            this.lbl_fechaEstEgreso.Name = "lbl_fechaEstEgreso";
            this.lbl_fechaEstEgreso.Size = new System.Drawing.Size(105, 20);
            this.lbl_fechaEstEgreso.TabIndex = 16;
            this.lbl_fechaEstEgreso.Text = "dd / mm / yyyy";
            // 
            // lbl_fechaActual
            // 
            this.lbl_fechaActual.AutoSize = true;
            this.lbl_fechaActual.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fechaActual.Location = new System.Drawing.Point(719, 8);
            this.lbl_fechaActual.Name = "lbl_fechaActual";
            this.lbl_fechaActual.Size = new System.Drawing.Size(105, 20);
            this.lbl_fechaActual.TabIndex = 17;
            this.lbl_fechaActual.Text = "dd / mm / yyyy";
            // 
            // CerrarAlojamiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 245);
            this.Controls.Add(this.lbl_fechaActual);
            this.Controls.Add(this.lbl_fechaEstEgreso);
            this.Controls.Add(this.lbl_txtfechaEstEgreso);
            this.Controls.Add(this.lbl_txtFechaActual);
            this.Controls.Add(this.btn_realizarPago);
            this.Controls.Add(this.btn_Visualizar);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_Aceptar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btn_BuscarAlojamiento);
            this.Name = "CerrarAlojamiento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CerrarAlojamiento";
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGV_ListadoAlojamientos)).EndInit();
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
        private System.Windows.Forms.Button btn_realizarPago;
        private System.Windows.Forms.Label lbl_txtFechaActual;
        private System.Windows.Forms.Label lbl_txtfechaEstEgreso;
        private System.Windows.Forms.Label lbl_fechaEstEgreso;
        private System.Windows.Forms.Label lbl_fechaActual;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_IdAlojmiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_DNIResponsable;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_IDHabitacion;
    }
}