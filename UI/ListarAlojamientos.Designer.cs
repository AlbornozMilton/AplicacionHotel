namespace UI
{
    partial class ListarAlojamientos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox_Rapida = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_ListarActivos = new System.Windows.Forms.Button();
            this.groupBox_Personalizado = new System.Windows.Forms.GroupBox();
            this.btn_Listar = new System.Windows.Forms.Button();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dGV_ListadoDeAlojamientos = new System.Windows.Forms.DataGridView();
            this.clm_IdAlojamiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_DNIResponsable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_ApeyNom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_NroHabitacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_Aceptar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_verDetalles = new System.Windows.Forms.Button();
            this.groupBox_Rapida.SuspendLayout();
            this.groupBox_Personalizado.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_ListadoDeAlojamientos)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox_Rapida
            // 
            this.groupBox_Rapida.Controls.Add(this.label1);
            this.groupBox_Rapida.Controls.Add(this.btn_ListarActivos);
            this.groupBox_Rapida.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_Rapida.Location = new System.Drawing.Point(13, 13);
            this.groupBox_Rapida.Name = "groupBox_Rapida";
            this.groupBox_Rapida.Size = new System.Drawing.Size(232, 103);
            this.groupBox_Rapida.TabIndex = 0;
            this.groupBox_Rapida.TabStop = false;
            this.groupBox_Rapida.Text = "Rápida";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 46);
            this.label1.TabIndex = 1;
            this.label1.Text = "Búsqueda automatica de alojamientos en estado \'alojado\' y \'reservado\'";
            // 
            // btn_ListarActivos
            // 
            this.btn_ListarActivos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ListarActivos.Location = new System.Drawing.Point(6, 70);
            this.btn_ListarActivos.Name = "btn_ListarActivos";
            this.btn_ListarActivos.Size = new System.Drawing.Size(219, 23);
            this.btn_ListarActivos.TabIndex = 0;
            this.btn_ListarActivos.Text = "Listar Activos";
            this.btn_ListarActivos.UseVisualStyleBackColor = true;
            this.btn_ListarActivos.Click += new System.EventHandler(this.btn_ListarActivos_Click);
            // 
            // groupBox_Personalizado
            // 
            this.groupBox_Personalizado.Controls.Add(this.btn_Listar);
            this.groupBox_Personalizado.Controls.Add(this.checkBox2);
            this.groupBox_Personalizado.Controls.Add(this.checkBox1);
            this.groupBox_Personalizado.Controls.Add(this.label3);
            this.groupBox_Personalizado.Controls.Add(this.label2);
            this.groupBox_Personalizado.Controls.Add(this.dateTimePicker2);
            this.groupBox_Personalizado.Controls.Add(this.dateTimePicker1);
            this.groupBox_Personalizado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_Personalizado.Location = new System.Drawing.Point(251, 13);
            this.groupBox_Personalizado.Name = "groupBox_Personalizado";
            this.groupBox_Personalizado.Size = new System.Drawing.Size(572, 103);
            this.groupBox_Personalizado.TabIndex = 1;
            this.groupBox_Personalizado.TabStop = false;
            this.groupBox_Personalizado.Text = "Personalizado";
            // 
            // btn_Listar
            // 
            this.btn_Listar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Listar.Location = new System.Drawing.Point(490, 45);
            this.btn_Listar.Name = "btn_Listar";
            this.btn_Listar.Size = new System.Drawing.Size(75, 23);
            this.btn_Listar.TabIndex = 6;
            this.btn_Listar.Text = "Listar";
            this.btn_Listar.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox2.Location = new System.Drawing.Point(381, 63);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(93, 20);
            this.checkBox2.TabIndex = 5;
            this.checkBox2.Text = "Cancelado";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(381, 34);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(76, 20);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Text = "Cerrado";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Hasta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Desde";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.Location = new System.Drawing.Point(70, 62);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(293, 22);
            this.dateTimePicker2.TabIndex = 1;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(70, 29);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(293, 22);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dGV_ListadoDeAlojamientos);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(13, 122);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(810, 103);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Resultados";
            // 
            // dGV_ListadoDeAlojamientos
            // 
            this.dGV_ListadoDeAlojamientos.AllowUserToAddRows = false;
            this.dGV_ListadoDeAlojamientos.AllowUserToDeleteRows = false;
            this.dGV_ListadoDeAlojamientos.AllowUserToOrderColumns = true;
            this.dGV_ListadoDeAlojamientos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dGV_ListadoDeAlojamientos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dGV_ListadoDeAlojamientos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_ListadoDeAlojamientos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clm_IdAlojamiento,
            this.clm_DNIResponsable,
            this.clm_ApeyNom,
            this.clm_NroHabitacion});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dGV_ListadoDeAlojamientos.DefaultCellStyle = dataGridViewCellStyle2;
            this.dGV_ListadoDeAlojamientos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dGV_ListadoDeAlojamientos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dGV_ListadoDeAlojamientos.Location = new System.Drawing.Point(3, 25);
            this.dGV_ListadoDeAlojamientos.Name = "dGV_ListadoDeAlojamientos";
            this.dGV_ListadoDeAlojamientos.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dGV_ListadoDeAlojamientos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dGV_ListadoDeAlojamientos.RowHeadersVisible = false;
            this.dGV_ListadoDeAlojamientos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGV_ListadoDeAlojamientos.Size = new System.Drawing.Size(804, 75);
            this.dGV_ListadoDeAlojamientos.TabIndex = 0;
            // 
            // clm_IdAlojamiento
            // 
            this.clm_IdAlojamiento.FillWeight = 35F;
            this.clm_IdAlojamiento.HeaderText = "Numero";
            this.clm_IdAlojamiento.Name = "clm_IdAlojamiento";
            this.clm_IdAlojamiento.ReadOnly = true;
            // 
            // clm_DNIResponsable
            // 
            this.clm_DNIResponsable.FillWeight = 45F;
            this.clm_DNIResponsable.HeaderText = "Responsable";
            this.clm_DNIResponsable.Name = "clm_DNIResponsable";
            this.clm_DNIResponsable.ReadOnly = true;
            // 
            // clm_ApeyNom
            // 
            this.clm_ApeyNom.FillWeight = 150F;
            this.clm_ApeyNom.HeaderText = "Nombre Completo";
            this.clm_ApeyNom.Name = "clm_ApeyNom";
            this.clm_ApeyNom.ReadOnly = true;
            // 
            // clm_NroHabitacion
            // 
            this.clm_NroHabitacion.FillWeight = 40F;
            this.clm_NroHabitacion.HeaderText = "Habitacion";
            this.clm_NroHabitacion.Name = "clm_NroHabitacion";
            this.clm_NroHabitacion.ReadOnly = true;
            // 
            // btn_Aceptar
            // 
            this.btn_Aceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Aceptar.Location = new System.Drawing.Point(732, 340);
            this.btn_Aceptar.Name = "btn_Aceptar";
            this.btn_Aceptar.Size = new System.Drawing.Size(88, 23);
            this.btn_Aceptar.TabIndex = 3;
            this.btn_Aceptar.Text = "Seleccionar";
            this.btn_Aceptar.UseVisualStyleBackColor = true;
            this.btn_Aceptar.Click += new System.EventHandler(this.btn_Aceptar_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(20, 340);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(89, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_verDetalles
            // 
            this.btn_verDetalles.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_verDetalles.Location = new System.Drawing.Point(585, 340);
            this.btn_verDetalles.Name = "btn_verDetalles";
            this.btn_verDetalles.Size = new System.Drawing.Size(123, 23);
            this.btn_verDetalles.TabIndex = 5;
            this.btn_verDetalles.Text = "Ver Detalles";
            this.btn_verDetalles.UseVisualStyleBackColor = true;
            this.btn_verDetalles.Click += new System.EventHandler(this.button1_Click);
            // 
            // ListarAlojamientos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 375);
            this.Controls.Add(this.btn_verDetalles);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_Aceptar);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox_Personalizado);
            this.Controls.Add(this.groupBox_Rapida);
            this.Name = "ListarAlojamientos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ListarAlojamientos";
            this.groupBox_Rapida.ResumeLayout(false);
            this.groupBox_Personalizado.ResumeLayout(false);
            this.groupBox_Personalizado.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGV_ListadoDeAlojamientos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_Rapida;
        private System.Windows.Forms.GroupBox groupBox_Personalizado;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_Aceptar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_ListarActivos;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Listar;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.DataGridView dGV_ListadoDeAlojamientos;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_IdAlojamiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_DNIResponsable;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_ApeyNom;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_NroHabitacion;
        private System.Windows.Forms.Button btn_verDetalles;
    }
}