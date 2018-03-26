namespace UI
{
    partial class ModificarCupoHabitacion
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModificarCupoHabitacion));
			this.btn_buscarHab = new System.Windows.Forms.Button();
			this.gpb_Hab = new System.Windows.Forms.GroupBox();
			this.dGV_Habs = new System.Windows.Forms.DataGridView();
			this.btn_confirmar = new System.Windows.Forms.Button();
			this.btn_Cancelar = new System.Windows.Forms.Button();
			this.clm_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.clm_capacidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.clm_Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.clm_Alta = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.btn_alta = new System.Windows.Forms.Button();
			this.gpb_Hab.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dGV_Habs)).BeginInit();
			this.SuspendLayout();
			// 
			// btn_buscarHab
			// 
			this.btn_buscarHab.Font = new System.Drawing.Font("Segoe UI Semibold", 12.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_buscarHab.Location = new System.Drawing.Point(12, 9);
			this.btn_buscarHab.Name = "btn_buscarHab";
			this.btn_buscarHab.Size = new System.Drawing.Size(196, 30);
			this.btn_buscarHab.TabIndex = 16;
			this.btn_buscarHab.Text = "Seleciconar Habitación";
			this.btn_buscarHab.UseVisualStyleBackColor = true;
			this.btn_buscarHab.Click += new System.EventHandler(this.btn_buscarHab_Click);
			// 
			// gpb_Hab
			// 
			this.gpb_Hab.BackColor = System.Drawing.Color.Transparent;
			this.gpb_Hab.Controls.Add(this.dGV_Habs);
			this.gpb_Hab.Font = new System.Drawing.Font("Segoe UI Semibold", 12.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.gpb_Hab.Location = new System.Drawing.Point(9, 43);
			this.gpb_Hab.Name = "gpb_Hab";
			this.gpb_Hab.Size = new System.Drawing.Size(445, 88);
			this.gpb_Hab.TabIndex = 15;
			this.gpb_Hab.TabStop = false;
			this.gpb_Hab.Text = "Habitación Seleccionada";
			// 
			// dGV_Habs
			// 
			this.dGV_Habs.AllowUserToAddRows = false;
			this.dGV_Habs.AllowUserToDeleteRows = false;
			this.dGV_Habs.AllowUserToResizeColumns = false;
			this.dGV_Habs.AllowUserToResizeRows = false;
			this.dGV_Habs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 12.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.clm_Alta});
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 12.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
			this.dGV_Habs.Size = new System.Drawing.Size(439, 59);
			this.dGV_Habs.TabIndex = 1;
			// 
			// btn_confirmar
			// 
			this.btn_confirmar.Enabled = false;
			this.btn_confirmar.Font = new System.Drawing.Font("Segoe UI Semibold", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_confirmar.Location = new System.Drawing.Point(459, 146);
			this.btn_confirmar.Name = "btn_confirmar";
			this.btn_confirmar.Size = new System.Drawing.Size(110, 30);
			this.btn_confirmar.TabIndex = 18;
			this.btn_confirmar.Text = "Aceptar";
			this.btn_confirmar.UseVisualStyleBackColor = true;
			this.btn_confirmar.Click += new System.EventHandler(this.btn_confirmar_Click);
			// 
			// btn_Cancelar
			// 
			this.btn_Cancelar.Font = new System.Drawing.Font("Segoe UI Semibold", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_Cancelar.Location = new System.Drawing.Point(12, 146);
			this.btn_Cancelar.Name = "btn_Cancelar";
			this.btn_Cancelar.Size = new System.Drawing.Size(110, 30);
			this.btn_Cancelar.TabIndex = 19;
			this.btn_Cancelar.Text = "Cancelar";
			this.btn_Cancelar.UseVisualStyleBackColor = true;
			this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
			// 
			// clm_Id
			// 
			this.clm_Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.clm_Id.FillWeight = 40F;
			this.clm_Id.HeaderText = "Número";
			this.clm_Id.Name = "clm_Id";
			this.clm_Id.ReadOnly = true;
			// 
			// clm_capacidad
			// 
			this.clm_capacidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.clm_capacidad.FillWeight = 40F;
			this.clm_capacidad.HeaderText = "Capacidad";
			this.clm_capacidad.Name = "clm_capacidad";
			this.clm_capacidad.ReadOnly = true;
			// 
			// clm_Nombre
			// 
			this.clm_Nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.clm_Nombre.FillWeight = 40F;
			this.clm_Nombre.HeaderText = "Planta";
			this.clm_Nombre.Name = "clm_Nombre";
			this.clm_Nombre.ReadOnly = true;
			// 
			// clm_Alta
			// 
			this.clm_Alta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.clm_Alta.FillWeight = 40F;
			this.clm_Alta.HeaderText = "Estado";
			this.clm_Alta.Name = "clm_Alta";
			this.clm_Alta.ReadOnly = true;
			// 
			// btn_alta
			// 
			this.btn_alta.BackColor = System.Drawing.Color.Red;
			this.btn_alta.Font = new System.Drawing.Font("Segoe UI Semibold", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_alta.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.btn_alta.Location = new System.Drawing.Point(459, 96);
			this.btn_alta.Name = "btn_alta";
			this.btn_alta.Size = new System.Drawing.Size(110, 32);
			this.btn_alta.TabIndex = 20;
			this.btn_alta.Text = "a/b";
			this.btn_alta.UseVisualStyleBackColor = false;
			this.btn_alta.Visible = false;
			this.btn_alta.Click += new System.EventHandler(this.btn_alta_Click);
			// 
			// ModificarCupoHabitacion
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.BackgroundImage = global::UI.Properties.Resources.FondoPantallas;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(581, 181);
			this.Controls.Add(this.btn_alta);
			this.Controls.Add(this.btn_Cancelar);
			this.Controls.Add(this.btn_confirmar);
			this.Controls.Add(this.btn_buscarHab);
			this.Controls.Add(this.gpb_Hab);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MinimizeBox = false;
			this.Name = "ModificarCupoHabitacion";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Modificar Cupos de Habitación";
			this.gpb_Hab.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dGV_Habs)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_buscarHab;
        private System.Windows.Forms.GroupBox gpb_Hab;
        private System.Windows.Forms.DataGridView dGV_Habs;
        private System.Windows.Forms.Button btn_confirmar;
        private System.Windows.Forms.Button btn_Cancelar;
		private System.Windows.Forms.DataGridViewTextBoxColumn clm_Id;
		private System.Windows.Forms.DataGridViewTextBoxColumn clm_capacidad;
		private System.Windows.Forms.DataGridViewTextBoxColumn clm_Nombre;
		private System.Windows.Forms.DataGridViewTextBoxColumn clm_Alta;
		private System.Windows.Forms.Button btn_alta;
	}
}