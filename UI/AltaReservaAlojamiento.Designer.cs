namespace UI
{
    partial class AltaReservaAlojamiento
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txb_fechaActual = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_VerificarDisponibilidad = new System.Windows.Forms.Button();
            this.dtp_fechaHasta = new System.Windows.Forms.DateTimePicker();
            this.dtp_fechaDesde = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cont_CuposDobles = new System.Windows.Forms.NumericUpDown();
            this.cont_CuposSimples = new System.Windows.Forms.NumericUpDown();
            this.label15 = new System.Windows.Forms.Label();
            this.tbx_NroHab = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ck_Exclusividad = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dGV_ClienteResponsable = new System.Windows.Forms.DataGridView();
            this.clm_Dni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_Legajo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.contador_NoDirecto = new System.Windows.Forms.NumericUpDown();
            this.contador_Directo = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.contador_Exceptuado = new System.Windows.Forms.NumericUpDown();
            this.contador_Convenio = new System.Windows.Forms.NumericUpDown();
            this.contador_Titular = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.btn_Aceptar = new System.Windows.Forms.Button();
            this.txb_CostoBase = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txb_Deposito = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.btn_Confirmar = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cont_CuposDobles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cont_CuposSimples)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_ClienteResponsable)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contador_NoDirecto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contador_Directo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contador_Exceptuado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contador_Convenio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contador_Titular)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Confirmar)).BeginInit();
            this.SuspendLayout();
            // 
            // txb_fechaActual
            // 
            this.txb_fechaActual.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_fechaActual.Location = new System.Drawing.Point(577, 19);
            this.txb_fechaActual.Name = "txb_fechaActual";
            this.txb_fechaActual.ReadOnly = true;
            this.txb_fechaActual.Size = new System.Drawing.Size(100, 22);
            this.txb_fechaActual.TabIndex = 7;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(93, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 6;
            this.textBox1.Text = "En proceso...";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(447, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Fecha Actual";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(47, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "ID";
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.btn_VerificarDisponibilidad);
            this.groupBox1.Controls.Add(this.dtp_fechaHasta);
            this.groupBox1.Controls.Add(this.dtp_fechaDesde);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(6, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(755, 107);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Disponibilidad";
            // 
            // btn_VerificarDisponibilidad
            // 
            this.btn_VerificarDisponibilidad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_VerificarDisponibilidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_VerificarDisponibilidad.Location = new System.Drawing.Point(588, 31);
            this.btn_VerificarDisponibilidad.Name = "btn_VerificarDisponibilidad";
            this.btn_VerificarDisponibilidad.Size = new System.Drawing.Size(135, 39);
            this.btn_VerificarDisponibilidad.TabIndex = 4;
            this.btn_VerificarDisponibilidad.Text = "Verificar Disponibilidad";
            this.btn_VerificarDisponibilidad.UseVisualStyleBackColor = false;
            this.btn_VerificarDisponibilidad.Click += new System.EventHandler(this.btn_VerificarDisponibilidad_Click);
            // 
            // dtp_fechaHasta
            // 
            this.dtp_fechaHasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_fechaHasta.Location = new System.Drawing.Point(170, 57);
            this.dtp_fechaHasta.Name = "dtp_fechaHasta";
            this.dtp_fechaHasta.Size = new System.Drawing.Size(361, 22);
            this.dtp_fechaHasta.TabIndex = 3;
            this.dtp_fechaHasta.ValueChanged += new System.EventHandler(this.dtp_fechaHasta_ValueChanged);
            // 
            // dtp_fechaDesde
            // 
            this.dtp_fechaDesde.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.dtp_fechaDesde.CalendarTrailingForeColor = System.Drawing.Color.Black;
            this.dtp_fechaDesde.Cursor = System.Windows.Forms.Cursors.Default;
            this.dtp_fechaDesde.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_fechaDesde.Location = new System.Drawing.Point(170, 25);
            this.dtp_fechaDesde.Name = "dtp_fechaDesde";
            this.dtp_fechaDesde.Size = new System.Drawing.Size(361, 22);
            this.dtp_fechaDesde.TabIndex = 2;
            this.dtp_fechaDesde.ValueChanged += new System.EventHandler(this.dtp_fechaDesde_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "Fecha Egreso";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Fecha Ingreso";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox4.Controls.Add(this.cont_CuposDobles);
            this.groupBox4.Controls.Add(this.cont_CuposSimples);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Controls.Add(this.tbx_NroHab);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.ck_Exclusividad);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(6, 160);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(755, 53);
            this.groupBox4.TabIndex = 15;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Habitación Seleccionada";
            // 
            // cont_CuposDobles
            // 
            this.cont_CuposDobles.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cont_CuposDobles.Location = new System.Drawing.Point(446, 23);
            this.cont_CuposDobles.Name = "cont_CuposDobles";
            this.cont_CuposDobles.Size = new System.Drawing.Size(50, 22);
            this.cont_CuposDobles.TabIndex = 20;
            this.cont_CuposDobles.ValueChanged += new System.EventHandler(this.cont_CuposDobles_ValueChanged);
            // 
            // cont_CuposSimples
            // 
            this.cont_CuposSimples.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cont_CuposSimples.Location = new System.Drawing.Point(266, 23);
            this.cont_CuposSimples.Name = "cont_CuposSimples";
            this.cont_CuposSimples.Size = new System.Drawing.Size(50, 22);
            this.cont_CuposSimples.TabIndex = 19;
            this.cont_CuposSimples.ValueChanged += new System.EventHandler(this.cont_CuposSimples_ValueChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(333, 27);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(94, 16);
            this.label15.TabIndex = 18;
            this.label15.Text = "Cupos Dobles";
            // 
            // tbx_NroHab
            // 
            this.tbx_NroHab.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_NroHab.Location = new System.Drawing.Point(77, 23);
            this.tbx_NroHab.Name = "tbx_NroHab";
            this.tbx_NroHab.ReadOnly = true;
            this.tbx_NroHab.Size = new System.Drawing.Size(44, 22);
            this.tbx_NroHab.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(150, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 16);
            this.label7.TabIndex = 1;
            this.label7.Text = "Cupos Simples";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(21, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "Nro";
            // 
            // ck_Exclusividad
            // 
            this.ck_Exclusividad.AutoSize = true;
            this.ck_Exclusividad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ck_Exclusividad.Location = new System.Drawing.Point(529, 25);
            this.ck_Exclusividad.Name = "ck_Exclusividad";
            this.ck_Exclusividad.Size = new System.Drawing.Size(190, 20);
            this.ck_Exclusividad.TabIndex = 17;
            this.ck_Exclusividad.Text = "Exclusividad de Habitacion";
            this.ck_Exclusividad.UseVisualStyleBackColor = true;
            this.ck_Exclusividad.CheckedChanged += new System.EventHandler(this.ck_Exclusividad_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.AutoSize = true;
            this.groupBox2.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Controls.Add(this.dGV_ClienteResponsable);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(6, 219);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(755, 148);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cliente Responsable";
            // 
            // dGV_ClienteResponsable
            // 
            this.dGV_ClienteResponsable.AllowUserToAddRows = false;
            this.dGV_ClienteResponsable.AllowUserToDeleteRows = false;
            this.dGV_ClienteResponsable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dGV_ClienteResponsable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dGV_ClienteResponsable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_ClienteResponsable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clm_Dni,
            this.clm_Legajo,
            this.clm_Apellido,
            this.clm_Nombre});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dGV_ClienteResponsable.DefaultCellStyle = dataGridViewCellStyle2;
            this.dGV_ClienteResponsable.Location = new System.Drawing.Point(6, 52);
            this.dGV_ClienteResponsable.Name = "dGV_ClienteResponsable";
            this.dGV_ClienteResponsable.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dGV_ClienteResponsable.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dGV_ClienteResponsable.RowHeadersVisible = false;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dGV_ClienteResponsable.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dGV_ClienteResponsable.Size = new System.Drawing.Size(743, 68);
            this.dGV_ClienteResponsable.TabIndex = 10;
            // 
            // clm_Dni
            // 
            this.clm_Dni.HeaderText = "Dni";
            this.clm_Dni.Name = "clm_Dni";
            this.clm_Dni.ReadOnly = true;
            // 
            // clm_Legajo
            // 
            this.clm_Legajo.HeaderText = "Legajo";
            this.clm_Legajo.Name = "clm_Legajo";
            this.clm_Legajo.ReadOnly = true;
            // 
            // clm_Apellido
            // 
            this.clm_Apellido.HeaderText = "Apellido";
            this.clm_Apellido.Name = "clm_Apellido";
            this.clm_Apellido.ReadOnly = true;
            // 
            // clm_Nombre
            // 
            this.clm_Nombre.HeaderText = "Nombre";
            this.clm_Nombre.Name = "clm_Nombre";
            this.clm_Nombre.ReadOnly = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(588, 17);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(161, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Ingresar Responsable";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox3.Controls.Add(this.contador_NoDirecto);
            this.groupBox3.Controls.Add(this.contador_Directo);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.contador_Exceptuado);
            this.groupBox3.Controls.Add(this.contador_Convenio);
            this.groupBox3.Controls.Add(this.contador_Titular);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(6, 373);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(755, 103);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Categorización";
            // 
            // contador_NoDirecto
            // 
            this.contador_NoDirecto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contador_NoDirecto.Location = new System.Drawing.Point(619, 49);
            this.contador_NoDirecto.Name = "contador_NoDirecto";
            this.contador_NoDirecto.Size = new System.Drawing.Size(35, 22);
            this.contador_NoDirecto.TabIndex = 37;
            // 
            // contador_Directo
            // 
            this.contador_Directo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contador_Directo.Location = new System.Drawing.Point(619, 19);
            this.contador_Directo.Name = "contador_Directo";
            this.contador_Directo.Size = new System.Drawing.Size(35, 22);
            this.contador_Directo.TabIndex = 36;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(420, 52);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(159, 16);
            this.label10.TabIndex = 35;
            this.label10.Text = "Acompañante No Directo";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(420, 24);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(138, 16);
            this.label11.TabIndex = 34;
            this.label11.Text = "Acompañante Directo";
            // 
            // contador_Exceptuado
            // 
            this.contador_Exceptuado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contador_Exceptuado.Location = new System.Drawing.Point(218, 77);
            this.contador_Exceptuado.Name = "contador_Exceptuado";
            this.contador_Exceptuado.Size = new System.Drawing.Size(35, 22);
            this.contador_Exceptuado.TabIndex = 33;
            this.contador_Exceptuado.ValueChanged += new System.EventHandler(this.contador_Exceptuado_ValueChanged);
            // 
            // contador_Convenio
            // 
            this.contador_Convenio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contador_Convenio.Location = new System.Drawing.Point(218, 49);
            this.contador_Convenio.Name = "contador_Convenio";
            this.contador_Convenio.Size = new System.Drawing.Size(35, 22);
            this.contador_Convenio.TabIndex = 32;
            // 
            // contador_Titular
            // 
            this.contador_Titular.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contador_Titular.Location = new System.Drawing.Point(218, 22);
            this.contador_Titular.Name = "contador_Titular";
            this.contador_Titular.Size = new System.Drawing.Size(35, 22);
            this.contador_Titular.TabIndex = 31;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(40, 80);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(128, 16);
            this.label9.TabIndex = 30;
            this.label9.Text = "Afiliado Exceptuado";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(40, 52);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(136, 16);
            this.label8.TabIndex = 29;
            this.label8.Text = "Afiliado por Convenio";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(40, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 16);
            this.label5.TabIndex = 28;
            this.label5.Text = "Afiliado Titular";
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.Control;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(35, 588);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(92, 23);
            this.button5.TabIndex = 19;
            this.button5.Text = "Cancelar";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // btn_Aceptar
            // 
            this.btn_Aceptar.BackColor = System.Drawing.SystemColors.Control;
            this.btn_Aceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Aceptar.Location = new System.Drawing.Point(663, 588);
            this.btn_Aceptar.Name = "btn_Aceptar";
            this.btn_Aceptar.Size = new System.Drawing.Size(92, 23);
            this.btn_Aceptar.TabIndex = 18;
            this.btn_Aceptar.Text = "Aceptar";
            this.btn_Aceptar.UseVisualStyleBackColor = false;
            this.btn_Aceptar.Click += new System.EventHandler(this.btn_Aceptar_Click);
            this.btn_Aceptar.MouseHover += new System.EventHandler(this.button4_MouseHover);
            // 
            // txb_CostoBase
            // 
            this.txb_CostoBase.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_CostoBase.Location = new System.Drawing.Point(140, 513);
            this.txb_CostoBase.Name = "txb_CostoBase";
            this.txb_CostoBase.ReadOnly = true;
            this.txb_CostoBase.Size = new System.Drawing.Size(100, 22);
            this.txb_CostoBase.TabIndex = 22;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(34, 516);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(78, 16);
            this.label12.TabIndex = 21;
            this.label12.Text = "Costo Base";
            // 
            // txb_Deposito
            // 
            this.txb_Deposito.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_Deposito.Location = new System.Drawing.Point(140, 548);
            this.txb_Deposito.Name = "txb_Deposito";
            this.txb_Deposito.ReadOnly = true;
            this.txb_Deposito.Size = new System.Drawing.Size(100, 22);
            this.txb_Deposito.TabIndex = 24;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(34, 551);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(63, 16);
            this.label13.TabIndex = 23;
            this.label13.Text = "Deposito";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(624, 531);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(85, 13);
            this.label14.TabIndex = 26;
            this.label14.Text = "COMPROBAR";
            this.label14.Visible = false;
            // 
            // btn_Confirmar
            // 
            this.btn_Confirmar.Image = global::UI.Properties.Resources.Boton_Ok_2;
            this.btn_Confirmar.InitialImage = null;
            this.btn_Confirmar.Location = new System.Drawing.Point(555, 505);
            this.btn_Confirmar.Name = "btn_Confirmar";
            this.btn_Confirmar.Size = new System.Drawing.Size(63, 62);
            this.btn_Confirmar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btn_Confirmar.TabIndex = 25;
            this.btn_Confirmar.TabStop = false;
            this.btn_Confirmar.Click += new System.EventHandler(this.btn_Confirmar_Click);
            this.btn_Confirmar.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave_1);
            this.btn_Confirmar.MouseHover += new System.EventHandler(this.pictureBox1_MouseHover);
            // 
            // AltaReservaAlojamiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(773, 623);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.btn_Confirmar);
            this.Controls.Add(this.txb_Deposito);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.txb_CostoBase);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.btn_Aceptar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txb_fechaActual);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "AltaReservaAlojamiento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AltaReservaAlojamiento";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cont_CuposDobles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cont_CuposSimples)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGV_ClienteResponsable)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contador_NoDirecto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contador_Directo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contador_Exceptuado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contador_Convenio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contador_Titular)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Confirmar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txb_fechaActual;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_VerificarDisponibilidad;
        private System.Windows.Forms.DateTimePicker dtp_fechaHasta;
        private System.Windows.Forms.DateTimePicker dtp_fechaDesde;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox tbx_NroHab;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckBox ck_Exclusividad;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.NumericUpDown contador_NoDirecto;
        private System.Windows.Forms.NumericUpDown contador_Directo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown contador_Exceptuado;
        private System.Windows.Forms.NumericUpDown contador_Convenio;
        private System.Windows.Forms.NumericUpDown contador_Titular;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btn_Aceptar;
        private System.Windows.Forms.TextBox txb_CostoBase;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txb_Deposito;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.PictureBox btn_Confirmar;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DataGridView dGV_ClienteResponsable;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_Dni;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_Legajo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_Nombre;
        private System.Windows.Forms.NumericUpDown cont_CuposDobles;
        private System.Windows.Forms.NumericUpDown cont_CuposSimples;
        private System.Windows.Forms.Label label15;
    }
}