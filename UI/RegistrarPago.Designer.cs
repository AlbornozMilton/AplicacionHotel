namespace UI
{
    partial class RegistrarPago
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_Aceptar = new System.Windows.Forms.Button();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.lbl_MostrarFecha = new System.Windows.Forms.Label();
            this.gbx_Alojamiento = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dGV_ListadoAlojamientos = new System.Windows.Forms.DataGridView();
            this.gbx_Pago = new System.Windows.Forms.GroupBox();
            this.ck_ModificarMonto = new System.Windows.Forms.CheckBox();
            this.txb_Detalle = new System.Windows.Forms.TextBox();
            this.txb_Monto = new System.Windows.Forms.TextBox();
            this.cbx_TipoPago = new System.Windows.Forms.ComboBox();
            this.lbl_Detalle = new System.Windows.Forms.Label();
            this.lbl_Monto = new System.Windows.Forms.Label();
            this.lbl_TipoPago = new System.Windows.Forms.Label();
            this.lbl_Fecha = new System.Windows.Forms.Label();
            this.clm_IdAlojamiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_DniResponsable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_NombreResponsable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_NroHabitacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbx_Alojamiento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_ListadoAlojamientos)).BeginInit();
            this.gbx_Pago.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Aceptar
            // 
            this.btn_Aceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Aceptar.Location = new System.Drawing.Point(678, 329);
            this.btn_Aceptar.Name = "btn_Aceptar";
            this.btn_Aceptar.Size = new System.Drawing.Size(102, 36);
            this.btn_Aceptar.TabIndex = 3;
            this.btn_Aceptar.Text = "Aceptar";
            this.btn_Aceptar.UseVisualStyleBackColor = true;
            this.btn_Aceptar.Click += new System.EventHandler(this.btn_Aceptar_Click);
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancelar.Location = new System.Drawing.Point(15, 329);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(109, 36);
            this.btn_Cancelar.TabIndex = 4;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // lbl_MostrarFecha
            // 
            this.lbl_MostrarFecha.AutoSize = true;
            this.lbl_MostrarFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MostrarFecha.Location = new System.Drawing.Point(260, 8);
            this.lbl_MostrarFecha.Name = "lbl_MostrarFecha";
            this.lbl_MostrarFecha.Size = new System.Drawing.Size(103, 20);
            this.lbl_MostrarFecha.TabIndex = 9;
            this.lbl_MostrarFecha.Text = "Fecha Actual";
            // 
            // gbx_Alojamiento
            // 
            this.gbx_Alojamiento.Controls.Add(this.button2);
            this.gbx_Alojamiento.Controls.Add(this.button1);
            this.gbx_Alojamiento.Controls.Add(this.dGV_ListadoAlojamientos);
            this.gbx_Alojamiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbx_Alojamiento.Location = new System.Drawing.Point(12, 41);
            this.gbx_Alojamiento.Name = "gbx_Alojamiento";
            this.gbx_Alojamiento.Size = new System.Drawing.Size(774, 154);
            this.gbx_Alojamiento.TabIndex = 10;
            this.gbx_Alojamiento.TabStop = false;
            this.gbx_Alojamiento.Text = "Alojamiento Elegido";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(656, 97);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 30);
            this.button2.TabIndex = 2;
            this.button2.Text = "Ver Detalles";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(3, 97);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(197, 31);
            this.button1.TabIndex = 1;
            this.button1.Text = "Buscar otro Alojamiento";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dGV_ListadoAlojamientos
            // 
            this.dGV_ListadoAlojamientos.AllowUserToAddRows = false;
            this.dGV_ListadoAlojamientos.AllowUserToDeleteRows = false;
            this.dGV_ListadoAlojamientos.AllowUserToOrderColumns = true;
            this.dGV_ListadoAlojamientos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dGV_ListadoAlojamientos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dGV_ListadoAlojamientos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dGV_ListadoAlojamientos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_ListadoAlojamientos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clm_IdAlojamiento,
            this.clm_estado,
            this.clm_DniResponsable,
            this.clm_NombreResponsable,
            this.clm_NroHabitacion});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dGV_ListadoAlojamientos.DefaultCellStyle = dataGridViewCellStyle3;
            this.dGV_ListadoAlojamientos.Location = new System.Drawing.Point(3, 23);
            this.dGV_ListadoAlojamientos.Name = "dGV_ListadoAlojamientos";
            this.dGV_ListadoAlojamientos.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dGV_ListadoAlojamientos.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dGV_ListadoAlojamientos.RowHeadersVisible = false;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dGV_ListadoAlojamientos.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dGV_ListadoAlojamientos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGV_ListadoAlojamientos.Size = new System.Drawing.Size(765, 58);
            this.dGV_ListadoAlojamientos.TabIndex = 0;
            // 
            // gbx_Pago
            // 
            this.gbx_Pago.Controls.Add(this.ck_ModificarMonto);
            this.gbx_Pago.Controls.Add(this.txb_Detalle);
            this.gbx_Pago.Controls.Add(this.txb_Monto);
            this.gbx_Pago.Controls.Add(this.cbx_TipoPago);
            this.gbx_Pago.Controls.Add(this.lbl_Detalle);
            this.gbx_Pago.Controls.Add(this.lbl_Monto);
            this.gbx_Pago.Controls.Add(this.lbl_TipoPago);
            this.gbx_Pago.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbx_Pago.Location = new System.Drawing.Point(13, 201);
            this.gbx_Pago.Name = "gbx_Pago";
            this.gbx_Pago.Size = new System.Drawing.Size(767, 110);
            this.gbx_Pago.TabIndex = 11;
            this.gbx_Pago.TabStop = false;
            this.gbx_Pago.Text = "Pago";
            // 
            // ck_ModificarMonto
            // 
            this.ck_ModificarMonto.AutoSize = true;
            this.ck_ModificarMonto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ck_ModificarMonto.Location = new System.Drawing.Point(208, 81);
            this.ck_ModificarMonto.Name = "ck_ModificarMonto";
            this.ck_ModificarMonto.Size = new System.Drawing.Size(135, 22);
            this.ck_ModificarMonto.TabIndex = 14;
            this.ck_ModificarMonto.Text = "Modificar Monto";
            this.ck_ModificarMonto.UseVisualStyleBackColor = true;
            this.ck_ModificarMonto.CheckedChanged += new System.EventHandler(this.ck_ModificarMonto_CheckedChanged);
            // 
            // txb_Detalle
            // 
            this.txb_Detalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_Detalle.Location = new System.Drawing.Point(397, 46);
            this.txb_Detalle.Multiline = true;
            this.txb_Detalle.Name = "txb_Detalle";
            this.txb_Detalle.Size = new System.Drawing.Size(364, 57);
            this.txb_Detalle.TabIndex = 13;
            // 
            // txb_Monto
            // 
            this.txb_Monto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_Monto.Location = new System.Drawing.Point(127, 79);
            this.txb_Monto.Name = "txb_Monto";
            this.txb_Monto.ReadOnly = true;
            this.txb_Monto.Size = new System.Drawing.Size(66, 24);
            this.txb_Monto.TabIndex = 12;
            // 
            // cbx_TipoPago
            // 
            this.cbx_TipoPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_TipoPago.FormattingEnabled = true;
            this.cbx_TipoPago.Location = new System.Drawing.Point(127, 34);
            this.cbx_TipoPago.Name = "cbx_TipoPago";
            this.cbx_TipoPago.Size = new System.Drawing.Size(149, 26);
            this.cbx_TipoPago.TabIndex = 11;
            this.cbx_TipoPago.SelectedIndexChanged += new System.EventHandler(this.cbx_TipoPago_SelectedIndexChanged);
            // 
            // lbl_Detalle
            // 
            this.lbl_Detalle.AutoSize = true;
            this.lbl_Detalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Detalle.Location = new System.Drawing.Point(394, 25);
            this.lbl_Detalle.Name = "lbl_Detalle";
            this.lbl_Detalle.Size = new System.Drawing.Size(53, 18);
            this.lbl_Detalle.TabIndex = 10;
            this.lbl_Detalle.Text = "Detalle";
            // 
            // lbl_Monto
            // 
            this.lbl_Monto.AutoSize = true;
            this.lbl_Monto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Monto.Location = new System.Drawing.Point(35, 83);
            this.lbl_Monto.Name = "lbl_Monto";
            this.lbl_Monto.Size = new System.Drawing.Size(51, 18);
            this.lbl_Monto.TabIndex = 9;
            this.lbl_Monto.Text = "Monto";
            // 
            // lbl_TipoPago
            // 
            this.lbl_TipoPago.AutoSize = true;
            this.lbl_TipoPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TipoPago.Location = new System.Drawing.Point(35, 38);
            this.lbl_TipoPago.Name = "lbl_TipoPago";
            this.lbl_TipoPago.Size = new System.Drawing.Size(76, 18);
            this.lbl_TipoPago.TabIndex = 8;
            this.lbl_TipoPago.Text = "Tipo Pago";
            // 
            // lbl_Fecha
            // 
            this.lbl_Fecha.AutoSize = true;
            this.lbl_Fecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Fecha.Location = new System.Drawing.Point(13, 8);
            this.lbl_Fecha.Name = "lbl_Fecha";
            this.lbl_Fecha.Size = new System.Drawing.Size(241, 20);
            this.lbl_Fecha.TabIndex = 8;
            this.lbl_Fecha.Text = "La Fecha de Pago será la actual:";
            // 
            // clm_IdAlojamiento
            // 
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clm_IdAlojamiento.DefaultCellStyle = dataGridViewCellStyle2;
            this.clm_IdAlojamiento.FillWeight = 35F;
            this.clm_IdAlojamiento.HeaderText = "Número";
            this.clm_IdAlojamiento.Name = "clm_IdAlojamiento";
            this.clm_IdAlojamiento.ReadOnly = true;
            // 
            // clm_estado
            // 
            this.clm_estado.FillWeight = 35F;
            this.clm_estado.HeaderText = "Estado";
            this.clm_estado.Name = "clm_estado";
            this.clm_estado.ReadOnly = true;
            // 
            // clm_DniResponsable
            // 
            this.clm_DniResponsable.FillWeight = 50F;
            this.clm_DniResponsable.HeaderText = "Responsable";
            this.clm_DniResponsable.Name = "clm_DniResponsable";
            this.clm_DniResponsable.ReadOnly = true;
            // 
            // clm_NombreResponsable
            // 
            this.clm_NombreResponsable.FillWeight = 150F;
            this.clm_NombreResponsable.HeaderText = "Nombre";
            this.clm_NombreResponsable.Name = "clm_NombreResponsable";
            this.clm_NombreResponsable.ReadOnly = true;
            // 
            // clm_NroHabitacion
            // 
            this.clm_NroHabitacion.FillWeight = 40F;
            this.clm_NroHabitacion.HeaderText = "Habitación";
            this.clm_NroHabitacion.Name = "clm_NroHabitacion";
            this.clm_NroHabitacion.ReadOnly = true;
            // 
            // RegistrarPago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 370);
            this.Controls.Add(this.gbx_Pago);
            this.Controls.Add(this.gbx_Alojamiento);
            this.Controls.Add(this.lbl_MostrarFecha);
            this.Controls.Add(this.lbl_Fecha);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_Aceptar);
            this.Name = "RegistrarPago";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegistrarPago";
            this.gbx_Alojamiento.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGV_ListadoAlojamientos)).EndInit();
            this.gbx_Pago.ResumeLayout(false);
            this.gbx_Pago.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_Aceptar;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.Label lbl_MostrarFecha;
        private System.Windows.Forms.GroupBox gbx_Alojamiento;
        private System.Windows.Forms.DataGridView dGV_ListadoAlojamientos;
        private System.Windows.Forms.GroupBox gbx_Pago;
        private System.Windows.Forms.TextBox txb_Detalle;
        private System.Windows.Forms.TextBox txb_Monto;
        private System.Windows.Forms.ComboBox cbx_TipoPago;
        private System.Windows.Forms.Label lbl_Detalle;
        private System.Windows.Forms.Label lbl_Monto;
        private System.Windows.Forms.Label lbl_TipoPago;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox ck_ModificarMonto;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lbl_Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_IdAlojamiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_DniResponsable;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_NombreResponsable;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_NroHabitacion;
    }
}