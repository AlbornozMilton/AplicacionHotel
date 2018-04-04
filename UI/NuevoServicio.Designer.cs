namespace UI
{
	partial class NuevoServicio
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NuevoServicio));
			this.lbl_textIngreseCosto = new System.Windows.Forms.Label();
			this.txb_nuevoCosto = new System.Windows.Forms.TextBox();
			this.label_nombre = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.btn_Aceptar = new System.Windows.Forms.Button();
			this.button_Cancelar = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lbl_textIngreseCosto
			// 
			this.lbl_textIngreseCosto.AutoSize = true;
			this.lbl_textIngreseCosto.BackColor = System.Drawing.Color.Transparent;
			this.lbl_textIngreseCosto.Font = new System.Drawing.Font("Segoe UI Semibold", 12.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_textIngreseCosto.ForeColor = System.Drawing.Color.Black;
			this.lbl_textIngreseCosto.Location = new System.Drawing.Point(12, 76);
			this.lbl_textIngreseCosto.Name = "lbl_textIngreseCosto";
			this.lbl_textIngreseCosto.Size = new System.Drawing.Size(120, 23);
			this.lbl_textIngreseCosto.TabIndex = 20;
			this.lbl_textIngreseCosto.Text = "Costo Unitario";
			// 
			// txb_nuevoCosto
			// 
			this.txb_nuevoCosto.Font = new System.Drawing.Font("Segoe UI Semibold", 12.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txb_nuevoCosto.Location = new System.Drawing.Point(190, 73);
			this.txb_nuevoCosto.Name = "txb_nuevoCosto";
			this.txb_nuevoCosto.Size = new System.Drawing.Size(96, 30);
			this.txb_nuevoCosto.TabIndex = 2;
			this.txb_nuevoCosto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txb_nuevoCosto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txb_nuevoCosto_KeyPress);
			// 
			// label_nombre
			// 
			this.label_nombre.AutoSize = true;
			this.label_nombre.BackColor = System.Drawing.Color.Transparent;
			this.label_nombre.Font = new System.Drawing.Font("Segoe UI Semibold", 12.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label_nombre.ForeColor = System.Drawing.Color.Black;
			this.label_nombre.Location = new System.Drawing.Point(12, 30);
			this.label_nombre.Name = "label_nombre";
			this.label_nombre.Size = new System.Drawing.Size(73, 23);
			this.label_nombre.TabIndex = 22;
			this.label_nombre.Text = "Nombre";
			// 
			// textBox1
			// 
			this.textBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 12.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox1.Location = new System.Drawing.Point(91, 27);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(195, 30);
			this.textBox1.TabIndex = 1;
			this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.Black;
			this.label1.Location = new System.Drawing.Point(10, 124);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(63, 23);
			this.label1.TabIndex = 24;
			this.label1.Text = "Detalle";
			// 
			// textBox2
			// 
			this.textBox2.Font = new System.Drawing.Font("Segoe UI Semibold", 12.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox2.Location = new System.Drawing.Point(16, 150);
			this.textBox2.Multiline = true;
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(270, 67);
			this.textBox2.TabIndex = 3;
			this.textBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
			// 
			// btn_Aceptar
			// 
			this.btn_Aceptar.Font = new System.Drawing.Font("Segoe UI Semibold", 12.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_Aceptar.Location = new System.Drawing.Point(176, 256);
			this.btn_Aceptar.Name = "btn_Aceptar";
			this.btn_Aceptar.Size = new System.Drawing.Size(110, 30);
			this.btn_Aceptar.TabIndex = 5;
			this.btn_Aceptar.Text = "Aceptar";
			this.btn_Aceptar.UseVisualStyleBackColor = true;
			this.btn_Aceptar.Click += new System.EventHandler(this.btn_Aceptar_Click);
			// 
			// button_Cancelar
			// 
			this.button_Cancelar.Enabled = false;
			this.button_Cancelar.Font = new System.Drawing.Font("Segoe UI Semibold", 12.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button_Cancelar.Location = new System.Drawing.Point(16, 256);
			this.button_Cancelar.Name = "button_Cancelar";
			this.button_Cancelar.Size = new System.Drawing.Size(110, 30);
			this.button_Cancelar.TabIndex = 4;
			this.button_Cancelar.Text = "Cancelar";
			this.button_Cancelar.UseVisualStyleBackColor = true;
			this.button_Cancelar.Click += new System.EventHandler(this.button_Cancelar_Click);
			// 
			// NuevoServicio
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::UI.Properties.Resources.FondoPantallas;
			this.ClientSize = new System.Drawing.Size(298, 298);
			this.Controls.Add(this.button_Cancelar);
			this.Controls.Add(this.btn_Aceptar);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.label_nombre);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.lbl_textIngreseCosto);
			this.Controls.Add(this.txb_nuevoCosto);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "NuevoServicio";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Nuevo Servicio";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lbl_textIngreseCosto;
		private System.Windows.Forms.TextBox txb_nuevoCosto;
		private System.Windows.Forms.Label label_nombre;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Button btn_Aceptar;
		private System.Windows.Forms.Button button_Cancelar;
	}
}