﻿namespace UI
{
    partial class ActualizarTarifas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_ConsultarTarifas = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dGV_Tarifas = new System.Windows.Forms.DataGridView();
            this.clm_Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_CostoSinEx = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_CostoConEx = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txb_Tarifa = new System.Windows.Forms.TextBox();
            this.btn_Aceptar = new System.Windows.Forms.Button();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.lbl_ = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Tarifas)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_ConsultarTarifas
            // 
            this.btn_ConsultarTarifas.Font = new System.Drawing.Font("BankGothic Lt BT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ConsultarTarifas.Location = new System.Drawing.Point(13, 13);
            this.btn_ConsultarTarifas.Name = "btn_ConsultarTarifas";
            this.btn_ConsultarTarifas.Size = new System.Drawing.Size(187, 23);
            this.btn_ConsultarTarifas.TabIndex = 0;
            this.btn_ConsultarTarifas.Text = "Consultar Tarifas";
            this.btn_ConsultarTarifas.UseVisualStyleBackColor = true;
            this.btn_ConsultarTarifas.Click += new System.EventHandler(this.btn_ConsultarTarifas_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dGV_Tarifas);
            this.groupBox1.Location = new System.Drawing.Point(12, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(596, 92);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // dGV_Tarifas
            // 
            this.dGV_Tarifas.AllowUserToAddRows = false;
            this.dGV_Tarifas.AllowUserToDeleteRows = false;
            this.dGV_Tarifas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("BankGothic Lt BT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dGV_Tarifas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dGV_Tarifas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_Tarifas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clm_Nombre,
            this.clm_CostoSinEx,
            this.clm_CostoConEx});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("BankGothic Lt BT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dGV_Tarifas.DefaultCellStyle = dataGridViewCellStyle8;
            this.dGV_Tarifas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dGV_Tarifas.Location = new System.Drawing.Point(3, 16);
            this.dGV_Tarifas.Name = "dGV_Tarifas";
            this.dGV_Tarifas.ReadOnly = true;
            this.dGV_Tarifas.RowHeadersVisible = false;
            this.dGV_Tarifas.Size = new System.Drawing.Size(590, 73);
            this.dGV_Tarifas.TabIndex = 1;
            // 
            // clm_Nombre
            // 
            this.clm_Nombre.HeaderText = "Nombre";
            this.clm_Nombre.Name = "clm_Nombre";
            this.clm_Nombre.ReadOnly = true;
            // 
            // clm_CostoSinEx
            // 
            this.clm_CostoSinEx.HeaderText = "Tarifa s/Exclusividad";
            this.clm_CostoSinEx.Name = "clm_CostoSinEx";
            this.clm_CostoSinEx.ReadOnly = true;
            // 
            // clm_CostoConEx
            // 
            this.clm_CostoConEx.HeaderText = "Tarifa c/Exclusividad";
            this.clm_CostoConEx.Name = "clm_CostoConEx";
            this.clm_CostoConEx.ReadOnly = true;
            // 
            // txb_Tarifa
            // 
            this.txb_Tarifa.Location = new System.Drawing.Point(152, 140);
            this.txb_Tarifa.Name = "txb_Tarifa";
            this.txb_Tarifa.Size = new System.Drawing.Size(100, 20);
            this.txb_Tarifa.TabIndex = 3;
            // 
            // btn_Aceptar
            // 
            this.btn_Aceptar.Font = new System.Drawing.Font("BankGothic Lt BT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Aceptar.Location = new System.Drawing.Point(517, 169);
            this.btn_Aceptar.Name = "btn_Aceptar";
            this.btn_Aceptar.Size = new System.Drawing.Size(91, 23);
            this.btn_Aceptar.TabIndex = 4;
            this.btn_Aceptar.Text = "Aceptar";
            this.btn_Aceptar.UseVisualStyleBackColor = true;
            this.btn_Aceptar.Click += new System.EventHandler(this.btn_Aceptar_Click);
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Font = new System.Drawing.Font("BankGothic Lt BT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancelar.Location = new System.Drawing.Point(16, 169);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(94, 23);
            this.btn_Cancelar.TabIndex = 5;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            // 
            // lbl_
            // 
            this.lbl_.AutoSize = true;
            this.lbl_.Font = new System.Drawing.Font("BankGothic Lt BT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_.Location = new System.Drawing.Point(13, 142);
            this.lbl_.Name = "lbl_";
            this.lbl_.Size = new System.Drawing.Size(112, 16);
            this.lbl_.TabIndex = 19;
            this.lbl_.Text = "Nueva Tarifa";
            // 
            // ActualizarTarifas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 204);
            this.Controls.Add(this.lbl_);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_Aceptar);
            this.Controls.Add(this.txb_Tarifa);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_ConsultarTarifas);
            this.Name = "ActualizarTarifas";
            this.Text = "ActualizarTarifas";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Tarifas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_ConsultarTarifas;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dGV_Tarifas;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_CostoSinEx;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_CostoConEx;
        private System.Windows.Forms.TextBox txb_Tarifa;
        private System.Windows.Forms.Button btn_Aceptar;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.Label lbl_;
    }
}