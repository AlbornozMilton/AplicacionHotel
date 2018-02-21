namespace UI
{
	partial class AgregarCiudad
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgregarCiudad));
			this.groupBox_disponibilidad = new System.Windows.Forms.GroupBox();
			this.tBx_codPostal = new System.Windows.Forms.TextBox();
			this.tbx_codPostal_existente = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.cbx_ciudades = new System.Windows.Forms.ComboBox();
			this.label_cbx_ciudades = new System.Windows.Forms.Label();
			this.tBx_nombrecCiudad = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.groupBox_disponibilidad.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox_disponibilidad
			// 
			this.groupBox_disponibilidad.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.groupBox_disponibilidad.BackColor = System.Drawing.Color.Transparent;
			this.groupBox_disponibilidad.Controls.Add(this.tBx_codPostal);
			this.groupBox_disponibilidad.Controls.Add(this.tbx_codPostal_existente);
			this.groupBox_disponibilidad.Controls.Add(this.label4);
			this.groupBox_disponibilidad.Controls.Add(this.cbx_ciudades);
			this.groupBox_disponibilidad.Controls.Add(this.label_cbx_ciudades);
			this.groupBox_disponibilidad.Controls.Add(this.tBx_nombrecCiudad);
			this.groupBox_disponibilidad.Controls.Add(this.label2);
			this.groupBox_disponibilidad.Controls.Add(this.label1);
			this.groupBox_disponibilidad.Font = new System.Drawing.Font("Segoe UI Semibold", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox_disponibilidad.Location = new System.Drawing.Point(12, 12);
			this.groupBox_disponibilidad.Name = "groupBox_disponibilidad";
			this.groupBox_disponibilidad.Size = new System.Drawing.Size(766, 131);
			this.groupBox_disponibilidad.TabIndex = 4;
			this.groupBox_disponibilidad.TabStop = false;
			this.groupBox_disponibilidad.Text = "Datos de Ciudad";
			// 
			// tBx_codPostal
			// 
			this.tBx_codPostal.Font = new System.Drawing.Font("Segoe UI Semibold", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tBx_codPostal.Location = new System.Drawing.Point(591, 76);
			this.tBx_codPostal.Name = "tBx_codPostal";
			this.tBx_codPostal.Size = new System.Drawing.Size(154, 30);
			this.tBx_codPostal.TabIndex = 2;
			this.tBx_codPostal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.tBx_codPostal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tBx_codPostal_KeyPress);
			// 
			// tbx_codPostal_existente
			// 
			this.tbx_codPostal_existente.Enabled = false;
			this.tbx_codPostal_existente.Font = new System.Drawing.Font("Segoe UI Semibold", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbx_codPostal_existente.Location = new System.Drawing.Point(591, 29);
			this.tbx_codPostal_existente.Name = "tbx_codPostal_existente";
			this.tbx_codPostal_existente.Size = new System.Drawing.Size(154, 30);
			this.tbx_codPostal_existente.TabIndex = 28;
			this.tbx_codPostal_existente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(470, 31);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(115, 23);
			this.label4.TabIndex = 27;
			this.label4.Text = "Código Postal";
			// 
			// cbx_ciudades
			// 
			this.cbx_ciudades.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbx_ciudades.Font = new System.Drawing.Font("Segoe UI Semibold", 12.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbx_ciudades.FormattingEnabled = true;
			this.cbx_ciudades.Location = new System.Drawing.Point(183, 28);
			this.cbx_ciudades.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.cbx_ciudades.Name = "cbx_ciudades";
			this.cbx_ciudades.Size = new System.Drawing.Size(282, 31);
			this.cbx_ciudades.Sorted = true;
			this.cbx_ciudades.TabIndex = 26;
			this.cbx_ciudades.TabStop = false;
			this.cbx_ciudades.SelectedIndexChanged += new System.EventHandler(this.cbx_ciudades_SelectedIndexChanged);
			// 
			// label_cbx_ciudades
			// 
			this.label_cbx_ciudades.AutoSize = true;
			this.label_cbx_ciudades.Location = new System.Drawing.Point(15, 31);
			this.label_cbx_ciudades.Name = "label_cbx_ciudades";
			this.label_cbx_ciudades.Size = new System.Drawing.Size(161, 23);
			this.label_cbx_ciudades.TabIndex = 5;
			this.label_cbx_ciudades.Text = "Ciudades Existentes";
			// 
			// tBx_nombrecCiudad
			// 
			this.tBx_nombrecCiudad.Font = new System.Drawing.Font("Segoe UI Semibold", 12.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tBx_nombrecCiudad.Location = new System.Drawing.Point(94, 76);
			this.tBx_nombrecCiudad.Name = "tBx_nombrecCiudad";
			this.tBx_nombrecCiudad.Size = new System.Drawing.Size(371, 30);
			this.tBx_nombrecCiudad.TabIndex = 1;
			this.tBx_nombrecCiudad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tBx_nombrecCiudad_KeyPress);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(470, 79);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(115, 23);
			this.label2.TabIndex = 1;
			this.label2.Text = "Código Postal";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(15, 79);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(73, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Nombre";
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.Transparent;
			this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 12.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.Location = new System.Drawing.Point(668, 152);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(110, 30);
			this.button1.TabIndex = 5;
			this.button1.Text = "Agregar";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.Color.Transparent;
			this.button2.Font = new System.Drawing.Font("Segoe UI Semibold", 12.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button2.Location = new System.Drawing.Point(12, 152);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(110, 30);
			this.button2.TabIndex = 6;
			this.button2.Text = "Cancelar";
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// AgregarCiudad
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::UI.Properties.Resources.FondoPantallas;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(790, 194);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.groupBox_disponibilidad);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "AgregarCiudad";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Agregar Ciudad";
			this.Load += new System.EventHandler(this.AgregarCiudad_Load);
			this.groupBox_disponibilidad.ResumeLayout(false);
			this.groupBox_disponibilidad.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox_disponibilidad;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox tBx_nombrecCiudad;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Label label_cbx_ciudades;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ComboBox cbx_ciudades;
		private System.Windows.Forms.TextBox tBx_codPostal;
		private System.Windows.Forms.TextBox tbx_codPostal_existente;
	}
}