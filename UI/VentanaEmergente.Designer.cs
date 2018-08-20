namespace UI
{
    partial class VentanaEmergente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentanaEmergente));
            this.btn_Aceptar = new System.Windows.Forms.Button();
            this.button_cancelar = new System.Windows.Forms.Button();
            this.pictureBox_icon = new System.Windows.Forms.PictureBox();
            this.lbl_TextPrincipal = new System.Windows.Forms.Label();
            this.lbl_TextAux = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_icon)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Aceptar
            // 
            this.btn_Aceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Aceptar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_Aceptar.Font = new System.Drawing.Font("Segoe UI Semibold", 12.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Aceptar.Location = new System.Drawing.Point(228, 139);
            this.btn_Aceptar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Aceptar.Name = "btn_Aceptar";
            this.btn_Aceptar.Size = new System.Drawing.Size(147, 37);
            this.btn_Aceptar.TabIndex = 11;
            this.btn_Aceptar.Text = "Aceptar";
            this.btn_Aceptar.UseVisualStyleBackColor = true;
            this.btn_Aceptar.Click += new System.EventHandler(this.btn_Aceptar_Click);
            // 
            // button_cancelar
            // 
            this.button_cancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_cancelar.Font = new System.Drawing.Font("Segoe UI Semibold", 12.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_cancelar.Location = new System.Drawing.Point(73, 139);
            this.button_cancelar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_cancelar.Name = "button_cancelar";
            this.button_cancelar.Size = new System.Drawing.Size(147, 37);
            this.button_cancelar.TabIndex = 12;
            this.button_cancelar.Text = "Salir";
            this.button_cancelar.UseVisualStyleBackColor = true;
            this.button_cancelar.Click += new System.EventHandler(this.button_cancelar_Click);
            // 
            // pictureBox_icon
            // 
            this.pictureBox_icon.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_icon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox_icon.Location = new System.Drawing.Point(36, 32);
            this.pictureBox_icon.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox_icon.Name = "pictureBox_icon";
            this.pictureBox_icon.Size = new System.Drawing.Size(76, 70);
            this.pictureBox_icon.TabIndex = 3;
            this.pictureBox_icon.TabStop = false;
            // 
            // lbl_TextPrincipal
            // 
            this.lbl_TextPrincipal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_TextPrincipal.AutoSize = true;
            this.lbl_TextPrincipal.BackColor = System.Drawing.Color.Transparent;
            this.lbl_TextPrincipal.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TextPrincipal.Location = new System.Drawing.Point(145, 57);
            this.lbl_TextPrincipal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_TextPrincipal.MaximumSize = new System.Drawing.Size(400, 0);
            this.lbl_TextPrincipal.Name = "lbl_TextPrincipal";
            this.lbl_TextPrincipal.Size = new System.Drawing.Size(131, 23);
            this.lbl_TextPrincipal.TabIndex = 9;
            this.lbl_TextPrincipal.Text = "lbl_TextPrincipal";
            this.lbl_TextPrincipal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_TextAux
            // 
            this.lbl_TextAux.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_TextAux.AutoSize = true;
            this.lbl_TextAux.BackColor = System.Drawing.Color.Transparent;
            this.lbl_TextAux.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TextAux.Location = new System.Drawing.Point(249, 100);
            this.lbl_TextAux.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_TextAux.MaximumSize = new System.Drawing.Size(467, 0);
            this.lbl_TextAux.Name = "lbl_TextAux";
            this.lbl_TextAux.Size = new System.Drawing.Size(80, 25);
            this.lbl_TextAux.TabIndex = 10;
            this.lbl_TextAux.Text = "textAux";
            this.lbl_TextAux.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // VentanaEmergente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(561, 191);
            this.Controls.Add(this.lbl_TextAux);
            this.Controls.Add(this.pictureBox_icon);
            this.Controls.Add(this.lbl_TextPrincipal);
            this.Controls.Add(this.button_cancelar);
            this.Controls.Add(this.btn_Aceptar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "VentanaEmergente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aplicación Hotel";
            this.Load += new System.EventHandler(this.VentanaEmergente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_icon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_Aceptar;
        private System.Windows.Forms.Button button_cancelar;
		private System.Windows.Forms.PictureBox pictureBox_icon;
		private System.Windows.Forms.Label lbl_TextPrincipal;
		private System.Windows.Forms.Label lbl_TextAux;
	}
}