namespace UI
{
    partial class ModificarAltaCliente
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tablaResulCliente = new System.Windows.Forms.DataGridView();
            this.btn_nuevoCliente = new System.Windows.Forms.Button();
            this.btn_darAlta = new System.Windows.Forms.Button();
            this.btn_darBaja = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.clm_Dni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_legajo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_aceptar = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaResulCliente)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Controls.Add(this.tablaResulCliente);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 40);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(757, 87);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cliente Seleccionado";
            // 
            // tablaResulCliente
            // 
            this.tablaResulCliente.AllowUserToAddRows = false;
            this.tablaResulCliente.AllowUserToDeleteRows = false;
            this.tablaResulCliente.AllowUserToOrderColumns = true;
            this.tablaResulCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tablaResulCliente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tablaResulCliente.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.tablaResulCliente.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.tablaResulCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaResulCliente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clm_Dni,
            this.clm_legajo,
            this.clm_apellido,
            this.clm_Nombre,
            this.clm_telefono});
            this.tablaResulCliente.Location = new System.Drawing.Point(3, 25);
            this.tablaResulCliente.MultiSelect = false;
            this.tablaResulCliente.Name = "tablaResulCliente";
            this.tablaResulCliente.ReadOnly = true;
            this.tablaResulCliente.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tablaResulCliente.RowHeadersVisible = false;
            this.tablaResulCliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tablaResulCliente.Size = new System.Drawing.Size(748, 56);
            this.tablaResulCliente.StandardTab = true;
            this.tablaResulCliente.TabIndex = 0;
            // 
            // btn_nuevoCliente
            // 
            this.btn_nuevoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_nuevoCliente.Location = new System.Drawing.Point(15, 12);
            this.btn_nuevoCliente.Name = "btn_nuevoCliente";
            this.btn_nuevoCliente.Size = new System.Drawing.Size(160, 25);
            this.btn_nuevoCliente.TabIndex = 12;
            this.btn_nuevoCliente.Text = "Seleccionar Cliente";
            this.btn_nuevoCliente.UseVisualStyleBackColor = true;
            this.btn_nuevoCliente.Click += new System.EventHandler(this.btn_nuevoCliente_Click);
            // 
            // btn_darAlta
            // 
            this.btn_darAlta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_darAlta.Location = new System.Drawing.Point(683, 142);
            this.btn_darAlta.Name = "btn_darAlta";
            this.btn_darAlta.Size = new System.Drawing.Size(80, 25);
            this.btn_darAlta.TabIndex = 13;
            this.btn_darAlta.Text = "Dar Alta";
            this.btn_darAlta.UseVisualStyleBackColor = true;
            this.btn_darAlta.Click += new System.EventHandler(this.btn_darAlta_Click);
            // 
            // btn_darBaja
            // 
            this.btn_darBaja.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_darBaja.Location = new System.Drawing.Point(683, 179);
            this.btn_darBaja.Name = "btn_darBaja";
            this.btn_darBaja.Size = new System.Drawing.Size(80, 25);
            this.btn_darBaja.TabIndex = 14;
            this.btn_darBaja.Text = "Dar Baja";
            this.btn_darBaja.UseVisualStyleBackColor = true;
            this.btn_darBaja.Click += new System.EventHandler(this.btn_darBaja_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(15, 128);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(635, 100);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ayuda";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(437, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Un cliente que esta en Alta, puede participar en las reservas y altas de nuevos A" +
    "lojamiento.";
            // 
            // clm_Dni
            // 
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.clm_Dni.DefaultCellStyle = dataGridViewCellStyle13;
            this.clm_Dni.FillWeight = 50F;
            this.clm_Dni.HeaderText = "DNI";
            this.clm_Dni.Name = "clm_Dni";
            this.clm_Dni.ReadOnly = true;
            // 
            // clm_legajo
            // 
            this.clm_legajo.FillWeight = 40F;
            this.clm_legajo.HeaderText = "Legajo";
            this.clm_legajo.Name = "clm_legajo";
            this.clm_legajo.ReadOnly = true;
            // 
            // clm_apellido
            // 
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.clm_apellido.DefaultCellStyle = dataGridViewCellStyle14;
            this.clm_apellido.FillWeight = 65F;
            this.clm_apellido.HeaderText = "Apellido";
            this.clm_apellido.Name = "clm_apellido";
            this.clm_apellido.ReadOnly = true;
            // 
            // clm_Nombre
            // 
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.clm_Nombre.DefaultCellStyle = dataGridViewCellStyle15;
            this.clm_Nombre.FillWeight = 85F;
            this.clm_Nombre.HeaderText = "Nombre";
            this.clm_Nombre.Name = "clm_Nombre";
            this.clm_Nombre.ReadOnly = true;
            // 
            // clm_telefono
            // 
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.clm_telefono.DefaultCellStyle = dataGridViewCellStyle16;
            this.clm_telefono.FillWeight = 80F;
            this.clm_telefono.HeaderText = "Estado";
            this.clm_telefono.Name = "clm_telefono";
            this.clm_telefono.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(369, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Un cliente que esta en Baja, no puede participar en ningún tipo de actividad.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(363, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Las búsquedas que realiza diariamente solo funcionan para clientes en alta.";
            // 
            // btn_aceptar
            // 
            this.btn_aceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_aceptar.Location = new System.Drawing.Point(15, 234);
            this.btn_aceptar.Name = "btn_aceptar";
            this.btn_aceptar.Size = new System.Drawing.Size(97, 25);
            this.btn_aceptar.TabIndex = 16;
            this.btn_aceptar.Text = "Salir";
            this.btn_aceptar.UseVisualStyleBackColor = true;
            this.btn_aceptar.Click += new System.EventHandler(this.btn_aceptar_Click);
            // 
            // ModificarAltaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 269);
            this.Controls.Add(this.btn_aceptar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_darBaja);
            this.Controls.Add(this.btn_darAlta);
            this.Controls.Add(this.btn_nuevoCliente);
            this.Controls.Add(this.groupBox2);
            this.Name = "ModificarAltaCliente";
            this.Text = "ModificarAltaCliente";
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tablaResulCliente)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView tablaResulCliente;
        private System.Windows.Forms.Button btn_nuevoCliente;
        private System.Windows.Forms.Button btn_darAlta;
        private System.Windows.Forms.Button btn_darBaja;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_Dni;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_legajo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_telefono;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_aceptar;
    }
}