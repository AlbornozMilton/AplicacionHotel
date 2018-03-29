namespace UI
{
	partial class UserAdmin
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserAdmin));
			this.groupBox_disponibilidad = new System.Windows.Forms.GroupBox();
			this.txb_newPass = new System.Windows.Forms.TextBox();
			this.txb_oldPass = new System.Windows.Forms.TextBox();
			this.label_oldPass = new System.Windows.Forms.Label();
			this.txb_userName = new System.Windows.Forms.TextBox();
			this.label_newPass = new System.Windows.Forms.Label();
			this.label_userName = new System.Windows.Forms.Label();
			this.button_aceptar = new System.Windows.Forms.Button();
			this.button_cancelar = new System.Windows.Forms.Button();
			this.groupBox_disponibilidad.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox_disponibilidad
			// 
			this.groupBox_disponibilidad.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.groupBox_disponibilidad.BackColor = System.Drawing.Color.Transparent;
			this.groupBox_disponibilidad.Controls.Add(this.txb_newPass);
			this.groupBox_disponibilidad.Controls.Add(this.txb_oldPass);
			this.groupBox_disponibilidad.Controls.Add(this.label_oldPass);
			this.groupBox_disponibilidad.Controls.Add(this.txb_userName);
			this.groupBox_disponibilidad.Controls.Add(this.label_newPass);
			this.groupBox_disponibilidad.Controls.Add(this.label_userName);
			this.groupBox_disponibilidad.Font = new System.Drawing.Font("Segoe UI Semibold", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox_disponibilidad.Location = new System.Drawing.Point(12, 12);
			this.groupBox_disponibilidad.Name = "groupBox_disponibilidad";
			this.groupBox_disponibilidad.Size = new System.Drawing.Size(416, 182);
			this.groupBox_disponibilidad.TabIndex = 5;
			this.groupBox_disponibilidad.TabStop = false;
			this.groupBox_disponibilidad.Text = "Datos de Usuario";
			// 
			// txb_newPass
			// 
			this.txb_newPass.Font = new System.Drawing.Font("Segoe UI Semibold", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txb_newPass.Location = new System.Drawing.Point(203, 137);
			this.txb_newPass.Name = "txb_newPass";
			this.txb_newPass.Size = new System.Drawing.Size(195, 30);
			this.txb_newPass.TabIndex = 3;
			this.txb_newPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txb_newPass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txb_newPass_KeyPress);
			// 
			// txb_oldPass
			// 
			this.txb_oldPass.Font = new System.Drawing.Font("Segoe UI Semibold", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txb_oldPass.Location = new System.Drawing.Point(203, 88);
			this.txb_oldPass.Name = "txb_oldPass";
			this.txb_oldPass.Size = new System.Drawing.Size(195, 30);
			this.txb_oldPass.TabIndex = 2;
			this.txb_oldPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txb_oldPass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txb_oldPass_KeyPress);
			// 
			// label_oldPass
			// 
			this.label_oldPass.AutoSize = true;
			this.label_oldPass.Location = new System.Drawing.Point(15, 91);
			this.label_oldPass.Name = "label_oldPass";
			this.label_oldPass.Size = new System.Drawing.Size(139, 23);
			this.label_oldPass.TabIndex = 27;
			this.label_oldPass.Text = "Contraseña Vieja";
			// 
			// txb_userName
			// 
			this.txb_userName.Font = new System.Drawing.Font("Segoe UI Semibold", 12.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txb_userName.Location = new System.Drawing.Point(203, 38);
			this.txb_userName.Name = "txb_userName";
			this.txb_userName.Size = new System.Drawing.Size(195, 30);
			this.txb_userName.TabIndex = 1;
			this.txb_userName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txb_userName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txb_userName_KeyPress);
			// 
			// label_newPass
			// 
			this.label_newPass.AutoSize = true;
			this.label_newPass.Location = new System.Drawing.Point(15, 140);
			this.label_newPass.Name = "label_newPass";
			this.label_newPass.Size = new System.Drawing.Size(152, 23);
			this.label_newPass.TabIndex = 1;
			this.label_newPass.Text = "Contraseña Nueva";
			// 
			// label_userName
			// 
			this.label_userName.AutoSize = true;
			this.label_userName.Location = new System.Drawing.Point(15, 41);
			this.label_userName.Name = "label_userName";
			this.label_userName.Size = new System.Drawing.Size(160, 23);
			this.label_userName.TabIndex = 0;
			this.label_userName.Text = "Nombre de Usuario";
			// 
			// button_aceptar
			// 
			this.button_aceptar.BackColor = System.Drawing.Color.Transparent;
			this.button_aceptar.Font = new System.Drawing.Font("Segoe UI Semibold", 12.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button_aceptar.Location = new System.Drawing.Point(318, 200);
			this.button_aceptar.Name = "button_aceptar";
			this.button_aceptar.Size = new System.Drawing.Size(110, 30);
			this.button_aceptar.TabIndex = 6;
			this.button_aceptar.Text = "Aceptar";
			this.button_aceptar.UseVisualStyleBackColor = false;
			this.button_aceptar.Click += new System.EventHandler(this.button_aceptar_Click);
			// 
			// button_cancelar
			// 
			this.button_cancelar.BackColor = System.Drawing.Color.Transparent;
			this.button_cancelar.Font = new System.Drawing.Font("Segoe UI Semibold", 12.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button_cancelar.Location = new System.Drawing.Point(12, 200);
			this.button_cancelar.Name = "button_cancelar";
			this.button_cancelar.Size = new System.Drawing.Size(110, 30);
			this.button_cancelar.TabIndex = 7;
			this.button_cancelar.Text = "Cancelar";
			this.button_cancelar.UseVisualStyleBackColor = false;
			this.button_cancelar.Click += new System.EventHandler(this.button_cancelar_Click);
			// 
			// UserAdmin
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::UI.Properties.Resources.FondoPantallas;
			this.ClientSize = new System.Drawing.Size(440, 236);
			this.Controls.Add(this.button_cancelar);
			this.Controls.Add(this.button_aceptar);
			this.Controls.Add(this.groupBox_disponibilidad);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "UserAdmin";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "UserAdmin";
			this.Load += new System.EventHandler(this.UserAdmin_Load);
			this.groupBox_disponibilidad.ResumeLayout(false);
			this.groupBox_disponibilidad.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox_disponibilidad;
		private System.Windows.Forms.TextBox txb_newPass;
		private System.Windows.Forms.TextBox txb_oldPass;
		private System.Windows.Forms.Label label_oldPass;
		private System.Windows.Forms.TextBox txb_userName;
		private System.Windows.Forms.Label label_newPass;
		private System.Windows.Forms.Label label_userName;
		private System.Windows.Forms.Button button_aceptar;
		private System.Windows.Forms.Button button_cancelar;
	}
}