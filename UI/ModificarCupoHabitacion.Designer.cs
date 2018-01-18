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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_buscarHab = new System.Windows.Forms.Button();
            this.gpb_Hab = new System.Windows.Forms.GroupBox();
            this.dataGridView_cupos = new System.Windows.Forms.DataGridView();
            this.dGV_Habs = new System.Windows.Forms.DataGridView();
            this.clm_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_capacidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_CostoBase = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox_cupos = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.txt_ModAlta = new System.Windows.Forms.Label();
            this.btn_confirmar = new System.Windows.Forms.Button();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_alta = new System.Windows.Forms.DataGridViewButtonColumn();
            this.gpb_Hab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_cupos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Habs)).BeginInit();
            this.groupBox_cupos.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_buscarHab
            // 
            this.btn_buscarHab.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_buscarHab.Location = new System.Drawing.Point(12, 12);
            this.btn_buscarHab.Name = "btn_buscarHab";
            this.btn_buscarHab.Size = new System.Drawing.Size(174, 25);
            this.btn_buscarHab.TabIndex = 16;
            this.btn_buscarHab.Text = "Consultar Habitación";
            this.btn_buscarHab.UseVisualStyleBackColor = true;
            this.btn_buscarHab.Click += new System.EventHandler(this.btn_buscarHab_Click);
            // 
            // gpb_Hab
            // 
            this.gpb_Hab.BackColor = System.Drawing.SystemColors.Control;
            this.gpb_Hab.Controls.Add(this.dGV_Habs);
            this.gpb_Hab.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpb_Hab.Location = new System.Drawing.Point(9, 45);
            this.gpb_Hab.Name = "gpb_Hab";
            this.gpb_Hab.Size = new System.Drawing.Size(695, 71);
            this.gpb_Hab.TabIndex = 15;
            this.gpb_Hab.TabStop = false;
            this.gpb_Hab.Text = "Habitación Seleccionada";
            // 
            // dataGridView_cupos
            // 
            this.dataGridView_cupos.AllowUserToAddRows = false;
            this.dataGridView_cupos.AllowUserToDeleteRows = false;
            this.dataGridView_cupos.AllowUserToOrderColumns = true;
            this.dataGridView_cupos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_cupos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView_cupos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_cupos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn11,
            this.clm_alta});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_cupos.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView_cupos.Location = new System.Drawing.Point(6, 22);
            this.dataGridView_cupos.Name = "dataGridView_cupos";
            this.dataGridView_cupos.ReadOnly = true;
            this.dataGridView_cupos.RowHeadersVisible = false;
            this.dataGridView_cupos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_cupos.Size = new System.Drawing.Size(168, 103);
            this.dataGridView_cupos.TabIndex = 0;
            // 
            // dGV_Habs
            // 
            this.dGV_Habs.AllowUserToAddRows = false;
            this.dGV_Habs.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dGV_Habs.DefaultCellStyle = dataGridViewCellStyle2;
            this.dGV_Habs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dGV_Habs.Location = new System.Drawing.Point(3, 19);
            this.dGV_Habs.Name = "dGV_Habs";
            this.dGV_Habs.ReadOnly = true;
            this.dGV_Habs.RowHeadersVisible = false;
            this.dGV_Habs.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dGV_Habs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGV_Habs.Size = new System.Drawing.Size(689, 49);
            this.dGV_Habs.TabIndex = 1;
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
            // groupBox_cupos
            // 
            this.groupBox_cupos.Controls.Add(this.txt_ModAlta);
            this.groupBox_cupos.Controls.Add(this.button3);
            this.groupBox_cupos.Controls.Add(this.button2);
            this.groupBox_cupos.Controls.Add(this.button1);
            this.groupBox_cupos.Controls.Add(this.dataGridView_cupos);
            this.groupBox_cupos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_cupos.Location = new System.Drawing.Point(12, 122);
            this.groupBox_cupos.Name = "groupBox_cupos";
            this.groupBox_cupos.Size = new System.Drawing.Size(414, 145);
            this.groupBox_cupos.TabIndex = 17;
            this.groupBox_cupos.TabStop = false;
            this.groupBox_cupos.Text = "Cupos";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(270, 42);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(270, 71);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(270, 99);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // txt_ModAlta
            // 
            this.txt_ModAlta.AutoSize = true;
            this.txt_ModAlta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ModAlta.Location = new System.Drawing.Point(265, 26);
            this.txt_ModAlta.Name = "txt_ModAlta";
            this.txt_ModAlta.Size = new System.Drawing.Size(85, 13);
            this.txt_ModAlta.TabIndex = 18;
            this.txt_ModAlta.Text = "Modificar Alta";
            // 
            // btn_confirmar
            // 
            this.btn_confirmar.Location = new System.Drawing.Point(646, 274);
            this.btn_confirmar.Name = "btn_confirmar";
            this.btn_confirmar.Size = new System.Drawing.Size(75, 23);
            this.btn_confirmar.TabIndex = 18;
            this.btn_confirmar.Text = "Confirmar";
            this.btn_confirmar.UseVisualStyleBackColor = true;
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Location = new System.Drawing.Point(12, 276);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancelar.TabIndex = 19;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.FillWeight = 40F;
            this.dataGridViewTextBoxColumn11.HeaderText = "Tipo";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            this.dataGridViewTextBoxColumn11.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // clm_alta
            // 
            this.clm_alta.FillWeight = 40F;
            this.clm_alta.HeaderText = "Estado";
            this.clm_alta.Name = "clm_alta";
            this.clm_alta.ReadOnly = true;
            this.clm_alta.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clm_alta.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // ModificarCupoHabitacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 311);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_confirmar);
            this.Controls.Add(this.groupBox_cupos);
            this.Controls.Add(this.btn_buscarHab);
            this.Controls.Add(this.gpb_Hab);
            this.Name = "ModificarCupoHabitacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificar Cupos de Habitación";
            this.Load += new System.EventHandler(this.ModificarCupoHabitacion_Load);
            this.gpb_Hab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_cupos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Habs)).EndInit();
            this.groupBox_cupos.ResumeLayout(false);
            this.groupBox_cupos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_buscarHab;
        private System.Windows.Forms.GroupBox gpb_Hab;
        private System.Windows.Forms.DataGridView dataGridView_cupos;
        private System.Windows.Forms.DataGridView dGV_Habs;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_capacidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_CostoBase;
        private System.Windows.Forms.GroupBox groupBox_cupos;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label txt_ModAlta;
        private System.Windows.Forms.Button btn_confirmar;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewButtonColumn clm_alta;
    }
}