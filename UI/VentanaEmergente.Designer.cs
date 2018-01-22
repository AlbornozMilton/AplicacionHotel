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
            this.pictureBox_icon = new System.Windows.Forms.PictureBox();
            this.lbl_TextPrincipal = new System.Windows.Forms.Label();
            this.lbl_TextAux = new System.Windows.Forms.Label();
            this.btn_Aceptar = new System.Windows.Forms.Button();
            this.button_cancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_icon)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox_icon
            // 
            this.pictureBox_icon.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_icon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox_icon.Location = new System.Drawing.Point(36, 30);
            this.pictureBox_icon.Name = "pictureBox_icon";
            this.pictureBox_icon.Size = new System.Drawing.Size(57, 57);
            this.pictureBox_icon.TabIndex = 3;
            this.pictureBox_icon.TabStop = false;
            // 
            // lbl_TextPrincipal
            // 
            this.lbl_TextPrincipal.AutoSize = true;
            this.lbl_TextPrincipal.BackColor = System.Drawing.Color.Transparent;
            this.lbl_TextPrincipal.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TextPrincipal.Location = new System.Drawing.Point(111, 39);
            this.lbl_TextPrincipal.MaximumSize = new System.Drawing.Size(300, 0);
            this.lbl_TextPrincipal.Name = "lbl_TextPrincipal";
            this.lbl_TextPrincipal.Size = new System.Drawing.Size(112, 19);
            this.lbl_TextPrincipal.TabIndex = 9;
            this.lbl_TextPrincipal.Text = "lbl_TextPrincipal";
            // 
            // lbl_TextAux
            // 
            this.lbl_TextAux.AutoSize = true;
            this.lbl_TextAux.BackColor = System.Drawing.Color.Transparent;
            this.lbl_TextAux.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TextAux.Location = new System.Drawing.Point(111, 86);
            this.lbl_TextAux.MaximumSize = new System.Drawing.Size(350, 0);
            this.lbl_TextAux.Name = "lbl_TextAux";
            this.lbl_TextAux.Size = new System.Drawing.Size(62, 20);
            this.lbl_TextAux.TabIndex = 10;
            this.lbl_TextAux.Text = "textAux";
            // 
            // btn_Aceptar
            // 
            this.btn_Aceptar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Aceptar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_Aceptar.Font = new System.Drawing.Font("Segoe UI Semibold", 12.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Aceptar.Location = new System.Drawing.Point(157, 113);
            this.btn_Aceptar.Name = "btn_Aceptar";
            this.btn_Aceptar.Size = new System.Drawing.Size(110, 30);
            this.btn_Aceptar.TabIndex = 11;
            this.btn_Aceptar.Text = "Aceptar";
            this.btn_Aceptar.UseVisualStyleBackColor = true;
            this.btn_Aceptar.Click += new System.EventHandler(this.btn_Aceptar_Click);
            // 
            // button_cancelar
            // 
            this.button_cancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_cancelar.Font = new System.Drawing.Font("Segoe UI Semibold", 12.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_cancelar.Location = new System.Drawing.Point(55, 113);
            this.button_cancelar.Name = "button_cancelar";
            this.button_cancelar.Size = new System.Drawing.Size(110, 30);
            this.button_cancelar.TabIndex = 12;
            this.button_cancelar.Text = "Salir";
            this.button_cancelar.UseVisualStyleBackColor = true;
            this.button_cancelar.Click += new System.EventHandler(this.button_cancelar_Click);
            // 
            // VentanaEmergente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::UI.Properties.Resources.FondoPantallas;
            this.ClientSize = new System.Drawing.Size(421, 155);
            this.Controls.Add(this.button_cancelar);
            this.Controls.Add(this.btn_Aceptar);
            this.Controls.Add(this.lbl_TextAux);
            this.Controls.Add(this.lbl_TextPrincipal);
            this.Controls.Add(this.pictureBox_icon);
            this.Name = "VentanaEmergente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aplicación Hotel";
            this.Load += new System.EventHandler(this.VentanaEmergente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_icon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox_icon;
        private System.Windows.Forms.Label lbl_TextPrincipal;
        private System.Windows.Forms.Label lbl_TextAux;
        private System.Windows.Forms.Button btn_Aceptar;
        private System.Windows.Forms.Button button_cancelar;
    }
}