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
            this.btn_BuscarAlojamiento = new System.Windows.Forms.Button();
            this.cBox_Servicios = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.selector_Cant_Servicio = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Aceptar = new System.Windows.Forms.Button();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.selector_Cant_Servicio)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_BuscarAlojamiento
            // 
            this.btn_BuscarAlojamiento.Font = new System.Drawing.Font("BankGothic Lt BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_BuscarAlojamiento.Location = new System.Drawing.Point(55, 39);
            this.btn_BuscarAlojamiento.Name = "btn_BuscarAlojamiento";
            this.btn_BuscarAlojamiento.Size = new System.Drawing.Size(215, 25);
            this.btn_BuscarAlojamiento.TabIndex = 0;
            this.btn_BuscarAlojamiento.Text = "Buscar Alojamiento";
            this.btn_BuscarAlojamiento.UseVisualStyleBackColor = true;
            this.btn_BuscarAlojamiento.Click += new System.EventHandler(this.btn_BuscarAlojamiento_Click);
            // 
            // cBox_Servicios
            // 
            this.cBox_Servicios.Font = new System.Drawing.Font("BankGothic Lt BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBox_Servicios.FormattingEnabled = true;
            this.cBox_Servicios.Items.AddRange(new object[] {
            "Televisor",
            "Calefacción",
            "Aire Acondicionado",
            "Salida de Baño"});
            this.cBox_Servicios.Location = new System.Drawing.Point(39, 146);
            this.cBox_Servicios.Name = "cBox_Servicios";
            this.cBox_Servicios.Size = new System.Drawing.Size(174, 25);
            this.cBox_Servicios.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("BankGothic Lt BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Seleccione Servicio";
            // 
            // selector_Cant_Servicio
            // 
            this.selector_Cant_Servicio.Font = new System.Drawing.Font("BankGothic Lt BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selector_Cant_Servicio.Location = new System.Drawing.Point(39, 223);
            this.selector_Cant_Servicio.Name = "selector_Cant_Servicio";
            this.selector_Cant_Servicio.Size = new System.Drawing.Size(120, 24);
            this.selector_Cant_Servicio.TabIndex = 3;
            this.selector_Cant_Servicio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("BankGothic Lt BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(258, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ingrese Cantidad Consumida";
            // 
            // btn_Aceptar
            // 
            this.btn_Aceptar.Font = new System.Drawing.Font("BankGothic Lt BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Aceptar.Location = new System.Drawing.Point(81, 297);
            this.btn_Aceptar.Name = "btn_Aceptar";
            this.btn_Aceptar.Size = new System.Drawing.Size(101, 23);
            this.btn_Aceptar.TabIndex = 5;
            this.btn_Aceptar.Text = "Aceptar";
            this.btn_Aceptar.UseVisualStyleBackColor = true;
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Font = new System.Drawing.Font("BankGothic Lt BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancelar.Location = new System.Drawing.Point(205, 297);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(101, 23);
            this.btn_Cancelar.TabIndex = 6;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            // 
            // AgregarServicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 332);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_Aceptar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.selector_Cant_Servicio);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cBox_Servicios);
            this.Controls.Add(this.btn_BuscarAlojamiento);
            this.Name = "AgregarServicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AgregarServicio";
            ((System.ComponentModel.ISupportInitialize)(this.selector_Cant_Servicio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_BuscarAlojamiento;
        private System.Windows.Forms.ComboBox cBox_Servicios;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown selector_Cant_Servicio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Aceptar;
        private System.Windows.Forms.Button btn_Cancelar;
    }
}