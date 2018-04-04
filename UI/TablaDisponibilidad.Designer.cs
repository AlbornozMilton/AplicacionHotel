namespace UI
{
    partial class TablaDisponibilidad
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
			this.components = new System.ComponentModel.Container();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TablaDisponibilidad));
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.dGV_TablaHabitaciones = new System.Windows.Forms.DataGridView();
			this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.btn_Seleccionar = new System.Windows.Forms.Button();
			this.btn_Cancelar = new System.Windows.Forms.Button();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dGV_TablaHabitaciones)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox2
			// 
			this.groupBox2.BackColor = System.Drawing.Color.Transparent;
			this.groupBox2.Controls.Add(this.dGV_TablaHabitaciones);
			this.groupBox2.Font = new System.Drawing.Font("Segoe UI Semibold", 12.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox2.Location = new System.Drawing.Point(10, 12);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(737, 298);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Disponibilidad de Habitaciones ";
			// 
			// dGV_TablaHabitaciones
			// 
			this.dGV_TablaHabitaciones.AllowUserToAddRows = false;
			this.dGV_TablaHabitaciones.AllowUserToDeleteRows = false;
			this.dGV_TablaHabitaciones.AllowUserToResizeColumns = false;
			this.dGV_TablaHabitaciones.AllowUserToResizeRows = false;
			this.dGV_TablaHabitaciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 12.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dGV_TablaHabitaciones.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dGV_TablaHabitaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dGV_TablaHabitaciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column3,
            this.Column2});
			this.dGV_TablaHabitaciones.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dGV_TablaHabitaciones.Location = new System.Drawing.Point(3, 26);
			this.dGV_TablaHabitaciones.MultiSelect = false;
			this.dGV_TablaHabitaciones.Name = "dGV_TablaHabitaciones";
			this.dGV_TablaHabitaciones.ReadOnly = true;
			this.dGV_TablaHabitaciones.RowHeadersVisible = false;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			this.dGV_TablaHabitaciones.RowsDefaultCellStyle = dataGridViewCellStyle2;
			this.dGV_TablaHabitaciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dGV_TablaHabitaciones.Size = new System.Drawing.Size(731, 269);
			this.dGV_TablaHabitaciones.TabIndex = 0;
			// 
			// Column1
			// 
			this.Column1.FillWeight = 60F;
			this.Column1.HeaderText = "Número";
			this.Column1.Name = "Column1";
			this.Column1.ReadOnly = true;
			// 
			// Column3
			// 
			this.Column3.HeaderText = "Planta";
			this.Column3.Name = "Column3";
			this.Column3.ReadOnly = true;
			// 
			// Column2
			// 
			this.Column2.HeaderText = "Capacidad";
			this.Column2.Name = "Column2";
			this.Column2.ReadOnly = true;
			// 
			// btn_Seleccionar
			// 
			this.btn_Seleccionar.Font = new System.Drawing.Font("Segoe UI Semibold", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_Seleccionar.Location = new System.Drawing.Point(637, 316);
			this.btn_Seleccionar.Name = "btn_Seleccionar";
			this.btn_Seleccionar.Size = new System.Drawing.Size(110, 30);
			this.btn_Seleccionar.TabIndex = 2;
			this.btn_Seleccionar.Text = "Seleccionar";
			this.btn_Seleccionar.UseVisualStyleBackColor = true;
			this.btn_Seleccionar.Click += new System.EventHandler(this.btn_Seleccionar_Click);
			// 
			// btn_Cancelar
			// 
			this.btn_Cancelar.Font = new System.Drawing.Font("Segoe UI Semibold", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_Cancelar.Location = new System.Drawing.Point(13, 316);
			this.btn_Cancelar.Name = "btn_Cancelar";
			this.btn_Cancelar.Size = new System.Drawing.Size(110, 30);
			this.btn_Cancelar.TabIndex = 3;
			this.btn_Cancelar.Text = "Cancelar";
			this.btn_Cancelar.UseVisualStyleBackColor = true;
			this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
			// 
			// TablaDisponibilidad
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.BackgroundImage = global::UI.Properties.Resources.FondoPantallas;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(759, 356);
			this.Controls.Add(this.btn_Cancelar);
			this.Controls.Add(this.btn_Seleccionar);
			this.Controls.Add(this.groupBox2);
			this.DoubleBuffered = true;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "TablaDisponibilidad";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Tabla de Disponibilidad";
			this.Load += new System.EventHandler(this.TablaDisponibilidad_Load);
			this.groupBox2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dGV_TablaHabitaciones)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dGV_TablaHabitaciones;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private System.Windows.Forms.Button btn_Seleccionar;
        private System.Windows.Forms.Button btn_Cancelar;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
	}
}