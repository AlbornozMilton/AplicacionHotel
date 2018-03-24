namespace UI
{
    partial class AdministrarServicios
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdministrarServicios));
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.dGV_Servicios = new System.Windows.Forms.DataGridView();
			this.clm_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.clm_Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.clm_CostoBase = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.clm_detalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.btn_Aceptar = new System.Windows.Forms.Button();
			this.btn_cancelar = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dGV_Servicios)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.Color.Transparent;
			this.groupBox1.Controls.Add(this.dGV_Servicios);
			this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(13, 13);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(876, 231);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Consulta de Servicios";
			// 
			// dGV_Servicios
			// 
			this.dGV_Servicios.AllowUserToAddRows = false;
			this.dGV_Servicios.AllowUserToDeleteRows = false;
			this.dGV_Servicios.AllowUserToResizeColumns = false;
			this.dGV_Servicios.AllowUserToResizeRows = false;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dGV_Servicios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dGV_Servicios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dGV_Servicios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clm_Id,
            this.clm_Nombre,
            this.clm_CostoBase,
            this.clm_detalle});
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dGV_Servicios.DefaultCellStyle = dataGridViewCellStyle2;
			this.dGV_Servicios.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dGV_Servicios.Location = new System.Drawing.Point(3, 26);
			this.dGV_Servicios.MultiSelect = false;
			this.dGV_Servicios.Name = "dGV_Servicios";
			this.dGV_Servicios.ReadOnly = true;
			this.dGV_Servicios.RowHeadersVisible = false;
			this.dGV_Servicios.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
			this.dGV_Servicios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dGV_Servicios.Size = new System.Drawing.Size(870, 202);
			this.dGV_Servicios.TabIndex = 0;
			// 
			// clm_Id
			// 
			this.clm_Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.clm_Id.FillWeight = 35F;
			this.clm_Id.HeaderText = "Código";
			this.clm_Id.Name = "clm_Id";
			this.clm_Id.ReadOnly = true;
			// 
			// clm_Nombre
			// 
			this.clm_Nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.clm_Nombre.FillWeight = 60F;
			this.clm_Nombre.HeaderText = "Nombre";
			this.clm_Nombre.Name = "clm_Nombre";
			this.clm_Nombre.ReadOnly = true;
			// 
			// clm_CostoBase
			// 
			this.clm_CostoBase.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.clm_CostoBase.FillWeight = 40F;
			this.clm_CostoBase.HeaderText = "Costo Unitario";
			this.clm_CostoBase.Name = "clm_CostoBase";
			this.clm_CostoBase.ReadOnly = true;
			// 
			// clm_detalle
			// 
			this.clm_detalle.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.clm_detalle.HeaderText = "Detalles";
			this.clm_detalle.Name = "clm_detalle";
			this.clm_detalle.ReadOnly = true;
			// 
			// btn_Aceptar
			// 
			this.btn_Aceptar.Font = new System.Drawing.Font("Segoe UI Semibold", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_Aceptar.Location = new System.Drawing.Point(779, 249);
			this.btn_Aceptar.Name = "btn_Aceptar";
			this.btn_Aceptar.Size = new System.Drawing.Size(110, 30);
			this.btn_Aceptar.TabIndex = 2;
			this.btn_Aceptar.Text = "Seleccionar";
			this.btn_Aceptar.UseVisualStyleBackColor = true;
			this.btn_Aceptar.Visible = false;
			this.btn_Aceptar.Click += new System.EventHandler(this.btn_Aceptar_Click);
			// 
			// btn_cancelar
			// 
			this.btn_cancelar.Font = new System.Drawing.Font("Segoe UI Semibold", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_cancelar.Location = new System.Drawing.Point(16, 250);
			this.btn_cancelar.Name = "btn_cancelar";
			this.btn_cancelar.Size = new System.Drawing.Size(110, 30);
			this.btn_cancelar.TabIndex = 3;
			this.btn_cancelar.Text = "Cancelar";
			this.btn_cancelar.UseVisualStyleBackColor = true;
			this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
			// 
			// AdministrarServicios
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.BackgroundImage = global::UI.Properties.Resources.FondoPantallas;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(901, 291);
			this.Controls.Add(this.btn_cancelar);
			this.Controls.Add(this.btn_Aceptar);
			this.Controls.Add(this.groupBox1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "AdministrarServicios";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Consultar Servicios";
			this.Load += new System.EventHandler(this.AdministrarServicios_Load);
			this.groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dGV_Servicios)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dGV_Servicios;
        private System.Windows.Forms.Button btn_Aceptar;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_CostoBase;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_detalle;
		private System.Windows.Forms.Button btn_cancelar;
	}
}