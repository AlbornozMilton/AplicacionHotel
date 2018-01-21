namespace UI
{
    partial class ModificarDNICliente
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_aceptar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_aceptar = new System.Windows.Forms.Button();
            this.btn_nuevoCliente = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tablaResulCliente = new System.Windows.Forms.DataGridView();
            this.clm_Dni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_legajo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_inrgeseDNI = new System.Windows.Forms.Label();
            this.textBox_DNI = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaResulCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_aceptar
            // 
            this.btn_aceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_aceptar.Location = new System.Drawing.Point(5, 250);
            this.btn_aceptar.Name = "btn_aceptar";
            this.btn_aceptar.Size = new System.Drawing.Size(97, 25);
            this.btn_aceptar.TabIndex = 21;
            this.btn_aceptar.Text = "Salir";
            this.btn_aceptar.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(8, 169);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(703, 56);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ayuda";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(658, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "El nuevo DNI también cambiará en todos los Alojamientos en el cual el Cliente se " +
    "encuentra.";
            // 
            // button_aceptar
            // 
            this.button_aceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_aceptar.Location = new System.Drawing.Point(814, 250);
            this.button_aceptar.Name = "button_aceptar";
            this.button_aceptar.Size = new System.Drawing.Size(80, 25);
            this.button_aceptar.TabIndex = 19;
            this.button_aceptar.Text = "Aceptar";
            this.button_aceptar.UseVisualStyleBackColor = true;
            // 
            // btn_nuevoCliente
            // 
            this.btn_nuevoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_nuevoCliente.Location = new System.Drawing.Point(8, 13);
            this.btn_nuevoCliente.Name = "btn_nuevoCliente";
            this.btn_nuevoCliente.Size = new System.Drawing.Size(160, 25);
            this.btn_nuevoCliente.TabIndex = 18;
            this.btn_nuevoCliente.Text = "Seleccionar Cliente";
            this.btn_nuevoCliente.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Controls.Add(this.tablaResulCliente);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(5, 41);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(907, 88);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cliente Seleccionado";
            // 
            // tablaResulCliente
            // 
            this.tablaResulCliente.AllowUserToAddRows = false;
            this.tablaResulCliente.AllowUserToDeleteRows = false;
            this.tablaResulCliente.AllowUserToOrderColumns = true;
            this.tablaResulCliente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tablaResulCliente.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.tablaResulCliente.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tablaResulCliente.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.tablaResulCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaResulCliente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clm_Dni,
            this.clm_legajo,
            this.clm_apellido,
            this.clm_Nombre,
            this.clm_telefono});
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tablaResulCliente.DefaultCellStyle = dataGridViewCellStyle18;
            this.tablaResulCliente.Location = new System.Drawing.Point(3, 25);
            this.tablaResulCliente.MultiSelect = false;
            this.tablaResulCliente.Name = "tablaResulCliente";
            this.tablaResulCliente.ReadOnly = true;
            this.tablaResulCliente.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tablaResulCliente.RowHeadersVisible = false;
            this.tablaResulCliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tablaResulCliente.Size = new System.Drawing.Size(898, 57);
            this.tablaResulCliente.StandardTab = true;
            this.tablaResulCliente.TabIndex = 0;
            // 
            // clm_Dni
            // 
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.clm_Dni.DefaultCellStyle = dataGridViewCellStyle14;
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
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.clm_apellido.DefaultCellStyle = dataGridViewCellStyle15;
            this.clm_apellido.FillWeight = 65F;
            this.clm_apellido.HeaderText = "Apellido";
            this.clm_apellido.Name = "clm_apellido";
            this.clm_apellido.ReadOnly = true;
            // 
            // clm_Nombre
            // 
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.clm_Nombre.DefaultCellStyle = dataGridViewCellStyle16;
            this.clm_Nombre.FillWeight = 85F;
            this.clm_Nombre.HeaderText = "Nombre";
            this.clm_Nombre.Name = "clm_Nombre";
            this.clm_Nombre.ReadOnly = true;
            // 
            // clm_telefono
            // 
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.clm_telefono.DefaultCellStyle = dataGridViewCellStyle17;
            this.clm_telefono.FillWeight = 50F;
            this.clm_telefono.HeaderText = "Estado";
            this.clm_telefono.Name = "clm_telefono";
            this.clm_telefono.ReadOnly = true;
            // 
            // txt_inrgeseDNI
            // 
            this.txt_inrgeseDNI.AutoSize = true;
            this.txt_inrgeseDNI.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_inrgeseDNI.Location = new System.Drawing.Point(4, 132);
            this.txt_inrgeseDNI.Name = "txt_inrgeseDNI";
            this.txt_inrgeseDNI.Size = new System.Drawing.Size(146, 20);
            this.txt_inrgeseDNI.TabIndex = 1;
            this.txt_inrgeseDNI.Text = "Ingrese nuevo DNI:";
            // 
            // textBox_DNI
            // 
            this.textBox_DNI.Location = new System.Drawing.Point(156, 129);
            this.textBox_DNI.Multiline = true;
            this.textBox_DNI.Name = "textBox_DNI";
            this.textBox_DNI.Size = new System.Drawing.Size(133, 25);
            this.textBox_DNI.TabIndex = 22;
            // 
            // ModificarDNICliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 287);
            this.Controls.Add(this.textBox_DNI);
            this.Controls.Add(this.txt_inrgeseDNI);
            this.Controls.Add(this.btn_aceptar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button_aceptar);
            this.Controls.Add(this.btn_nuevoCliente);
            this.Controls.Add(this.groupBox2);
            this.Name = "ModificarDNICliente";
            this.Text = "ModificarDNICliente";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tablaResulCliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_aceptar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_aceptar;
        private System.Windows.Forms.Button btn_nuevoCliente;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView tablaResulCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_Dni;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_legajo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_telefono;
        private System.Windows.Forms.Label txt_inrgeseDNI;
        private System.Windows.Forms.TextBox textBox_DNI;
    }
}