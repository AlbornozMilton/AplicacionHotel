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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_Aceptar = new System.Windows.Forms.Button();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.lbl_Fecha = new System.Windows.Forms.Label();
            this.lbl_MostrarFecha = new System.Windows.Forms.Label();
            this.gbx_Alojamiento = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.gbx_Pago = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lbl_Detalle = new System.Windows.Forms.Label();
            this.lbl_Monto = new System.Windows.Forms.Label();
            this.lbl_TipoPago = new System.Windows.Forms.Label();
            this.clm_IdAlojamiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_DniResponsable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_NombreResponsable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.gbx_Alojamiento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gbx_Pago.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Aceptar
            // 
            this.btn_Aceptar.Font = new System.Drawing.Font("BankGothic Lt BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Aceptar.Location = new System.Drawing.Point(205, 403);
            this.btn_Aceptar.Name = "btn_Aceptar";
            this.btn_Aceptar.Size = new System.Drawing.Size(102, 23);
            this.btn_Aceptar.TabIndex = 3;
            this.btn_Aceptar.Text = "Aceptar";
            this.btn_Aceptar.UseVisualStyleBackColor = true;
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Font = new System.Drawing.Font("BankGothic Lt BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancelar.Location = new System.Drawing.Point(313, 403);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(102, 23);
            this.btn_Cancelar.TabIndex = 4;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // lbl_Fecha
            // 
            this.lbl_Fecha.AutoSize = true;
            this.lbl_Fecha.Font = new System.Drawing.Font("BankGothic Lt BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Fecha.Location = new System.Drawing.Point(13, 8);
            this.lbl_Fecha.Name = "lbl_Fecha";
            this.lbl_Fecha.Size = new System.Drawing.Size(58, 17);
            this.lbl_Fecha.TabIndex = 8;
            this.lbl_Fecha.Text = "Fecha";
            // 
            // lbl_MostrarFecha
            // 
            this.lbl_MostrarFecha.AutoSize = true;
            this.lbl_MostrarFecha.Font = new System.Drawing.Font("BankGothic Lt BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MostrarFecha.Location = new System.Drawing.Point(289, 8);
            this.lbl_MostrarFecha.Name = "lbl_MostrarFecha";
            this.lbl_MostrarFecha.Size = new System.Drawing.Size(125, 17);
            this.lbl_MostrarFecha.TabIndex = 9;
            this.lbl_MostrarFecha.Text = "Fecha de Hoy";
            // 
            // gbx_Alojamiento
            // 
            this.gbx_Alojamiento.Controls.Add(this.button1);
            this.gbx_Alojamiento.Controls.Add(this.dataGridView1);
            this.gbx_Alojamiento.Font = new System.Drawing.Font("BankGothic Lt BT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbx_Alojamiento.Location = new System.Drawing.Point(12, 41);
            this.gbx_Alojamiento.Name = "gbx_Alojamiento";
            this.gbx_Alojamiento.Size = new System.Drawing.Size(402, 154);
            this.gbx_Alojamiento.TabIndex = 10;
            this.gbx_Alojamiento.TabStop = false;
            this.gbx_Alojamiento.Text = "Alojamiento";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("BankGothic Lt BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clm_IdAlojamiento,
            this.clm_DniResponsable,
            this.clm_NombreResponsable});
            this.dataGridView1.Location = new System.Drawing.Point(3, 23);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(396, 88);
            this.dataGridView1.TabIndex = 0;
            // 
            // gbx_Pago
            // 
            this.gbx_Pago.Controls.Add(this.textBox2);
            this.gbx_Pago.Controls.Add(this.textBox1);
            this.gbx_Pago.Controls.Add(this.comboBox1);
            this.gbx_Pago.Controls.Add(this.lbl_Detalle);
            this.gbx_Pago.Controls.Add(this.lbl_Monto);
            this.gbx_Pago.Controls.Add(this.lbl_TipoPago);
            this.gbx_Pago.Font = new System.Drawing.Font("BankGothic Lt BT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbx_Pago.Location = new System.Drawing.Point(13, 201);
            this.gbx_Pago.Name = "gbx_Pago";
            this.gbx_Pago.Size = new System.Drawing.Size(401, 196);
            this.gbx_Pago.TabIndex = 11;
            this.gbx_Pago.TabStop = false;
            this.gbx_Pago.Text = "Pago";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("BankGothic Lt BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(192, 122);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(149, 61);
            this.textBox2.TabIndex = 13;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("BankGothic Lt BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(192, 79);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(149, 24);
            this.textBox1.TabIndex = 12;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("BankGothic Lt BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Alojado",
            "Depósito",
            "Deuda",
            "Servicios"});
            this.comboBox1.Location = new System.Drawing.Point(192, 36);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(149, 25);
            this.comboBox1.TabIndex = 11;
            // 
            // lbl_Detalle
            // 
            this.lbl_Detalle.AutoSize = true;
            this.lbl_Detalle.Font = new System.Drawing.Font("BankGothic Lt BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Detalle.Location = new System.Drawing.Point(15, 143);
            this.lbl_Detalle.Name = "lbl_Detalle";
            this.lbl_Detalle.Size = new System.Drawing.Size(75, 17);
            this.lbl_Detalle.TabIndex = 10;
            this.lbl_Detalle.Text = "Detalle";
            // 
            // lbl_Monto
            // 
            this.lbl_Monto.AutoSize = true;
            this.lbl_Monto.Font = new System.Drawing.Font("BankGothic Lt BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Monto.Location = new System.Drawing.Point(15, 82);
            this.lbl_Monto.Name = "lbl_Monto";
            this.lbl_Monto.Size = new System.Drawing.Size(63, 17);
            this.lbl_Monto.TabIndex = 9;
            this.lbl_Monto.Text = "Monto";
            // 
            // lbl_TipoPago
            // 
            this.lbl_TipoPago.AutoSize = true;
            this.lbl_TipoPago.Font = new System.Drawing.Font("BankGothic Lt BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TipoPago.Location = new System.Drawing.Point(15, 39);
            this.lbl_TipoPago.Name = "lbl_TipoPago";
            this.lbl_TipoPago.Size = new System.Drawing.Size(92, 17);
            this.lbl_TipoPago.TabIndex = 8;
            this.lbl_TipoPago.Text = "Tipo Pago";
            // 
            // clm_IdAlojamiento
            // 
            dataGridViewCellStyle12.Font = new System.Drawing.Font("BankGothic Lt BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clm_IdAlojamiento.DefaultCellStyle = dataGridViewCellStyle12;
            this.clm_IdAlojamiento.HeaderText = "ID";
            this.clm_IdAlojamiento.Name = "clm_IdAlojamiento";
            this.clm_IdAlojamiento.ReadOnly = true;
            // 
            // clm_DniResponsable
            // 
            this.clm_DniResponsable.HeaderText = "DNI Responsable";
            this.clm_DniResponsable.Name = "clm_DniResponsable";
            this.clm_DniResponsable.ReadOnly = true;
            // 
            // clm_NombreResponsable
            // 
            this.clm_NombreResponsable.HeaderText = "Nombre";
            this.clm_NombreResponsable.Name = "clm_NombreResponsable";
            this.clm_NombreResponsable.ReadOnly = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("BankGothic Lt BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(199, 122);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(197, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Buscar Alojamiento";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // RegistrarPago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 438);
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gbx_Pago.ResumeLayout(false);
            this.gbx_Pago.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_Aceptar;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.Label lbl_Fecha;
        private System.Windows.Forms.Label lbl_MostrarFecha;
        private System.Windows.Forms.GroupBox gbx_Alojamiento;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox gbx_Pago;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lbl_Detalle;
        private System.Windows.Forms.Label lbl_Monto;
        private System.Windows.Forms.Label lbl_TipoPago;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_IdAlojamiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_DniResponsable;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_NombreResponsable;
        private System.Windows.Forms.Button button1;
    }
}