namespace UI
{
    partial class ConsultarHabitaciones
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dGV_Habs = new System.Windows.Forms.DataGridView();
            this.clm_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_capacidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_CostoBase = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_Aceptar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Habs)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.dGV_Habs);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(726, 278);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Habitaciones";
            // 
            // dGV_Habs
            // 
            this.dGV_Habs.AllowUserToAddRows = false;
            this.dGV_Habs.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dGV_Habs.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dGV_Habs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_Habs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clm_Id,
            this.clm_capacidad,
            this.clm_Nombre,
            this.clm_CostoBase});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dGV_Habs.DefaultCellStyle = dataGridViewCellStyle2;
            this.dGV_Habs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dGV_Habs.Location = new System.Drawing.Point(3, 26);
            this.dGV_Habs.Name = "dGV_Habs";
            this.dGV_Habs.ReadOnly = true;
            this.dGV_Habs.RowHeadersVisible = false;
            this.dGV_Habs.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dGV_Habs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGV_Habs.Size = new System.Drawing.Size(720, 249);
            this.dGV_Habs.TabIndex = 0;
            // 
            // clm_Id
            // 
            this.clm_Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clm_Id.FillWeight = 25F;
            this.clm_Id.HeaderText = "Número";
            this.clm_Id.Name = "clm_Id";
            this.clm_Id.ReadOnly = true;
            // 
            // clm_capacidad
            // 
            this.clm_capacidad.FillWeight = 40F;
            this.clm_capacidad.HeaderText = "Capacidad";
            this.clm_capacidad.Name = "clm_capacidad";
            this.clm_capacidad.ReadOnly = true;
            // 
            // clm_Nombre
            // 
            this.clm_Nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clm_Nombre.FillWeight = 60F;
            this.clm_Nombre.HeaderText = "Cupos Simples";
            this.clm_Nombre.Name = "clm_Nombre";
            this.clm_Nombre.ReadOnly = true;
            // 
            // clm_CostoBase
            // 
            this.clm_CostoBase.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clm_CostoBase.FillWeight = 60F;
            this.clm_CostoBase.HeaderText = "Cupos Dobles";
            this.clm_CostoBase.Name = "clm_CostoBase";
            this.clm_CostoBase.ReadOnly = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(12, 296);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 30);
            this.button1.TabIndex = 5;
            this.button1.Text = "Salir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_Aceptar
            // 
            this.btn_Aceptar.Font = new System.Drawing.Font("Segoe UI Semibold", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Aceptar.Location = new System.Drawing.Point(628, 296);
            this.btn_Aceptar.Name = "btn_Aceptar";
            this.btn_Aceptar.Size = new System.Drawing.Size(110, 30);
            this.btn_Aceptar.TabIndex = 4;
            this.btn_Aceptar.Text = "Seleccionar";
            this.btn_Aceptar.UseVisualStyleBackColor = true;
            this.btn_Aceptar.Click += new System.EventHandler(this.btn_Aceptar_Click);
            // 
            // ConsultarHabitaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::UI.Properties.Resources.FondoPantallas;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(750, 334);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_Aceptar);
            this.Controls.Add(this.groupBox1);
            this.Name = "ConsultarHabitaciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta de Habitaciones";
            this.Load += new System.EventHandler(this.ConsultarHabitaciones_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Habs)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dGV_Habs;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_Aceptar;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_capacidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_CostoBase;
    }
}