﻿namespace UI
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox_Rapida = new System.Windows.Forms.GroupBox();
            this.btn_ListarActivos = new System.Windows.Forms.Button();
            this.txt_busquedaRapida = new System.Windows.Forms.Label();
            this.groupBox_Personalizado = new System.Windows.Forms.GroupBox();
            this.checkBox_todos = new System.Windows.Forms.CheckBox();
            this.btn_Listar = new System.Windows.Forms.Button();
            this.checkBox_cancelado = new System.Windows.Forms.CheckBox();
            this.checkBox_cerrado = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker_hasta = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_desde = new System.Windows.Forms.DateTimePicker();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dGV_ListadoDeAlojamientos = new System.Windows.Forms.DataGridView();
            this.clm_IdAlojamiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_NroHabitacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_DNIResponsable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_ApeyNom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_tipoCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_Aceptar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_verDetalles = new System.Windows.Forms.Button();
            this.button_CancelarAloj = new System.Windows.Forms.Button();
            this.button_realizarPago = new System.Windows.Forms.Button();
            this.groupBox_Rapida.SuspendLayout();
            this.groupBox_Personalizado.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_ListadoDeAlojamientos)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox_Rapida
            // 
            this.groupBox_Rapida.BackColor = System.Drawing.Color.Transparent;
            this.groupBox_Rapida.Controls.Add(this.btn_ListarActivos);
            this.groupBox_Rapida.Controls.Add(this.txt_busquedaRapida);
            this.groupBox_Rapida.Font = new System.Drawing.Font("Segoe UI Semibold", 12.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_Rapida.Location = new System.Drawing.Point(13, 13);
            this.groupBox_Rapida.Name = "groupBox_Rapida";
            this.groupBox_Rapida.Size = new System.Drawing.Size(463, 103);
            this.groupBox_Rapida.TabIndex = 0;
            this.groupBox_Rapida.TabStop = false;
            this.groupBox_Rapida.Text = "Rápida";
            // 
            // btn_ListarActivos
            // 
            this.btn_ListarActivos.Font = new System.Drawing.Font("Segoe UI Semibold", 12.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ListarActivos.Location = new System.Drawing.Point(251, 37);
            this.btn_ListarActivos.Name = "btn_ListarActivos";
            this.btn_ListarActivos.Size = new System.Drawing.Size(196, 30);
            this.btn_ListarActivos.TabIndex = 0;
            this.btn_ListarActivos.Text = "Listar Activos";
            this.btn_ListarActivos.UseVisualStyleBackColor = true;
            this.btn_ListarActivos.Click += new System.EventHandler(this.btn_ListarActivos_Click);
            // 
            // txt_busquedaRapida
            // 
            this.txt_busquedaRapida.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_busquedaRapida.Location = new System.Drawing.Point(6, 33);
            this.txt_busquedaRapida.Name = "txt_busquedaRapida";
            this.txt_busquedaRapida.Size = new System.Drawing.Size(219, 59);
            this.txt_busquedaRapida.TabIndex = 1;
            this.txt_busquedaRapida.Text = "Búsqueda automática de Alojamientos en estado \'Alojado\' y \'Reservado\'.";
            // 
            // groupBox_Personalizado
            // 
            this.groupBox_Personalizado.BackColor = System.Drawing.Color.Transparent;
            this.groupBox_Personalizado.Controls.Add(this.checkBox_todos);
            this.groupBox_Personalizado.Controls.Add(this.btn_Listar);
            this.groupBox_Personalizado.Controls.Add(this.checkBox_cancelado);
            this.groupBox_Personalizado.Controls.Add(this.checkBox_cerrado);
            this.groupBox_Personalizado.Controls.Add(this.label3);
            this.groupBox_Personalizado.Controls.Add(this.label2);
            this.groupBox_Personalizado.Controls.Add(this.dateTimePicker_hasta);
            this.groupBox_Personalizado.Controls.Add(this.dateTimePicker_desde);
            this.groupBox_Personalizado.Font = new System.Drawing.Font("Segoe UI Semibold", 12.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_Personalizado.Location = new System.Drawing.Point(482, 13);
            this.groupBox_Personalizado.Name = "groupBox_Personalizado";
            this.groupBox_Personalizado.Size = new System.Drawing.Size(691, 103);
            this.groupBox_Personalizado.TabIndex = 1;
            this.groupBox_Personalizado.TabStop = false;
            this.groupBox_Personalizado.Text = "Personalizado";
            // 
            // checkBox_todos
            // 
            this.checkBox_todos.AutoSize = true;
            this.checkBox_todos.Font = new System.Drawing.Font("Segoe UI Semibold", 12.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_todos.Location = new System.Drawing.Point(420, 72);
            this.checkBox_todos.Name = "checkBox_todos";
            this.checkBox_todos.Size = new System.Drawing.Size(73, 27);
            this.checkBox_todos.TabIndex = 7;
            this.checkBox_todos.Text = "Todos";
            this.checkBox_todos.UseVisualStyleBackColor = true;
            // 
            // btn_Listar
            // 
            this.btn_Listar.Font = new System.Drawing.Font("Segoe UI Semibold", 12.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Listar.Location = new System.Drawing.Point(544, 45);
            this.btn_Listar.Name = "btn_Listar";
            this.btn_Listar.Size = new System.Drawing.Size(141, 30);
            this.btn_Listar.TabIndex = 6;
            this.btn_Listar.Text = "Listar";
            this.btn_Listar.UseVisualStyleBackColor = true;
            this.btn_Listar.Click += new System.EventHandler(this.btn_Listar_Click);
            // 
            // checkBox_cancelado
            // 
            this.checkBox_cancelado.AutoSize = true;
            this.checkBox_cancelado.Font = new System.Drawing.Font("Segoe UI Semibold", 12.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_cancelado.Location = new System.Drawing.Point(420, 48);
            this.checkBox_cancelado.Name = "checkBox_cancelado";
            this.checkBox_cancelado.Size = new System.Drawing.Size(109, 27);
            this.checkBox_cancelado.TabIndex = 5;
            this.checkBox_cancelado.Text = "Cancelado";
            this.checkBox_cancelado.UseVisualStyleBackColor = true;
            // 
            // checkBox_cerrado
            // 
            this.checkBox_cerrado.AutoSize = true;
            this.checkBox_cerrado.Font = new System.Drawing.Font("Segoe UI Semibold", 12.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_cerrado.Location = new System.Drawing.Point(420, 23);
            this.checkBox_cerrado.Name = "checkBox_cerrado";
            this.checkBox_cerrado.Size = new System.Drawing.Size(90, 27);
            this.checkBox_cerrado.TabIndex = 4;
            this.checkBox_cerrado.Text = "Cerrado";
            this.checkBox_cerrado.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "Hasta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Desde";
            // 
            // dateTimePicker_hasta
            // 
            this.dateTimePicker_hasta.Font = new System.Drawing.Font("Segoe UI Semibold", 12.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker_hasta.Location = new System.Drawing.Point(76, 62);
            this.dateTimePicker_hasta.Name = "dateTimePicker_hasta";
            this.dateTimePicker_hasta.Size = new System.Drawing.Size(333, 30);
            this.dateTimePicker_hasta.TabIndex = 1;
            // 
            // dateTimePicker_desde
            // 
            this.dateTimePicker_desde.Font = new System.Drawing.Font("Segoe UI Semibold", 12.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker_desde.Location = new System.Drawing.Point(76, 29);
            this.dateTimePicker_desde.Name = "dateTimePicker_desde";
            this.dateTimePicker_desde.Size = new System.Drawing.Size(333, 30);
            this.dateTimePicker_desde.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.dGV_ListadoDeAlojamientos);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI Semibold", 12.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(13, 122);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1163, 289);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Alojamientos";
            // 
            // dGV_ListadoDeAlojamientos
            // 
            this.dGV_ListadoDeAlojamientos.AllowUserToAddRows = false;
            this.dGV_ListadoDeAlojamientos.AllowUserToDeleteRows = false;
            this.dGV_ListadoDeAlojamientos.AllowUserToOrderColumns = true;
            this.dGV_ListadoDeAlojamientos.AllowUserToResizeColumns = false;
            this.dGV_ListadoDeAlojamientos.AllowUserToResizeRows = false;
            this.dGV_ListadoDeAlojamientos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 12.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dGV_ListadoDeAlojamientos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dGV_ListadoDeAlojamientos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_ListadoDeAlojamientos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clm_IdAlojamiento,
            this.clm_estado,
            this.clm_NroHabitacion,
            this.clm_DNIResponsable,
            this.clm_ApeyNom,
            this.clm_tipoCliente});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 12.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dGV_ListadoDeAlojamientos.DefaultCellStyle = dataGridViewCellStyle3;
            this.dGV_ListadoDeAlojamientos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dGV_ListadoDeAlojamientos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dGV_ListadoDeAlojamientos.Location = new System.Drawing.Point(3, 26);
            this.dGV_ListadoDeAlojamientos.Name = "dGV_ListadoDeAlojamientos";
            this.dGV_ListadoDeAlojamientos.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Semibold", 12.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dGV_ListadoDeAlojamientos.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dGV_ListadoDeAlojamientos.RowHeadersVisible = false;
            this.dGV_ListadoDeAlojamientos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGV_ListadoDeAlojamientos.Size = new System.Drawing.Size(1157, 260);
            this.dGV_ListadoDeAlojamientos.TabIndex = 0;
            // 
            // clm_IdAlojamiento
            // 
            this.clm_IdAlojamiento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            this.clm_IdAlojamiento.DefaultCellStyle = dataGridViewCellStyle2;
            this.clm_IdAlojamiento.FillWeight = 30F;
            this.clm_IdAlojamiento.HeaderText = "Número";
            this.clm_IdAlojamiento.Name = "clm_IdAlojamiento";
            this.clm_IdAlojamiento.ReadOnly = true;
            // 
            // clm_estado
            // 
            this.clm_estado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clm_estado.FillWeight = 40F;
            this.clm_estado.HeaderText = "Estado";
            this.clm_estado.Name = "clm_estado";
            this.clm_estado.ReadOnly = true;
            // 
            // clm_NroHabitacion
            // 
            this.clm_NroHabitacion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clm_NroHabitacion.FillWeight = 40F;
            this.clm_NroHabitacion.HeaderText = "Habitación";
            this.clm_NroHabitacion.Name = "clm_NroHabitacion";
            this.clm_NroHabitacion.ReadOnly = true;
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
            this.clm_ApeyNom.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clm_ApeyNom.FillWeight = 120F;
            this.clm_ApeyNom.HeaderText = "Nombre Completo";
            this.clm_ApeyNom.Name = "clm_ApeyNom";
            this.clm_ApeyNom.ReadOnly = true;
            // 
            // clm_tipoCliente
            // 
            this.clm_tipoCliente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clm_tipoCliente.FillWeight = 90F;
            this.clm_tipoCliente.HeaderText = "Tipo Cliente";
            this.clm_tipoCliente.Name = "clm_tipoCliente";
            this.clm_tipoCliente.ReadOnly = true;
            // 
            // btn_Aceptar
            // 
            this.btn_Aceptar.Font = new System.Drawing.Font("Segoe UI Semibold", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Aceptar.Location = new System.Drawing.Point(1066, 417);
            this.btn_Aceptar.Name = "btn_Aceptar";
            this.btn_Aceptar.Size = new System.Drawing.Size(110, 30);
            this.btn_Aceptar.TabIndex = 3;
            this.btn_Aceptar.Text = "Seleccionar";
            this.btn_Aceptar.UseVisualStyleBackColor = true;
            this.btn_Aceptar.Click += new System.EventHandler(this.btn_Aceptar_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Segoe UI Semibold", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(13, 417);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(110, 30);
            this.button2.TabIndex = 4;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_verDetalles
            // 
            this.btn_verDetalles.Font = new System.Drawing.Font("Segoe UI Semibold", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_verDetalles.Location = new System.Drawing.Point(950, 417);
            this.btn_verDetalles.Name = "btn_verDetalles";
            this.btn_verDetalles.Size = new System.Drawing.Size(110, 30);
            this.btn_verDetalles.TabIndex = 5;
            this.btn_verDetalles.Text = "Ver Detalles";
            this.btn_verDetalles.UseVisualStyleBackColor = true;
            this.btn_verDetalles.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_CancelarAloj
            // 
            this.button_CancelarAloj.Font = new System.Drawing.Font("Segoe UI Semibold", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_CancelarAloj.Location = new System.Drawing.Point(615, 417);
            this.button_CancelarAloj.Name = "button_CancelarAloj";
            this.button_CancelarAloj.Size = new System.Drawing.Size(191, 30);
            this.button_CancelarAloj.TabIndex = 6;
            this.button_CancelarAloj.Text = "Cancelar Alojamiento";
            this.button_CancelarAloj.UseVisualStyleBackColor = true;
            this.button_CancelarAloj.Click += new System.EventHandler(this.button_CancelarAloj_Click);
            // 
            // button_realizarPago
            // 
            this.button_realizarPago.Font = new System.Drawing.Font("Segoe UI Semibold", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_realizarPago.Location = new System.Drawing.Point(812, 417);
            this.button_realizarPago.Name = "button_realizarPago";
            this.button_realizarPago.Size = new System.Drawing.Size(132, 30);
            this.button_realizarPago.TabIndex = 7;
            this.button_realizarPago.Text = "Realizar Pago";
            this.button_realizarPago.UseVisualStyleBackColor = true;
            this.button_realizarPago.Click += new System.EventHandler(this.button_realizarPago_Click);
            // 
            // ListarAlojamientos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::UI.Properties.Resources.FondoPantallas;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1188, 451);
            this.Controls.Add(this.button_realizarPago);
            this.Controls.Add(this.button_CancelarAloj);
            this.Controls.Add(this.btn_verDetalles);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_Aceptar);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox_Personalizado);
            this.Controls.Add(this.groupBox_Rapida);
            this.MaximizeBox = false;
            this.Name = "ListarAlojamientos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listar Alojamientos";
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
        private System.Windows.Forms.Label txt_busquedaRapida;
        private System.Windows.Forms.Button btn_ListarActivos;
        private System.Windows.Forms.DateTimePicker dateTimePicker_hasta;
        private System.Windows.Forms.DateTimePicker dateTimePicker_desde;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Listar;
        private System.Windows.Forms.CheckBox checkBox_cancelado;
        private System.Windows.Forms.CheckBox checkBox_cerrado;
        private System.Windows.Forms.DataGridView dGV_ListadoDeAlojamientos;
        private System.Windows.Forms.Button btn_verDetalles;
        private System.Windows.Forms.CheckBox checkBox_todos;
        private System.Windows.Forms.Button button_CancelarAloj;
        private System.Windows.Forms.Button button_realizarPago;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_IdAlojamiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_NroHabitacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_DNIResponsable;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_ApeyNom;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_tipoCliente;
    }
}