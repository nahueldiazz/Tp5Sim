namespace Tp5Sim
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.capacidad_cine = new System.Windows.Forms.TextBox();
            this.minimoClienteSinEntrada = new System.Windows.Forms.TextBox();
            this.hasta_input = new System.Windows.Forms.TextBox();
            this.maxClienteSinEntrada = new System.Windows.Forms.TextBox();
            this.desde_input = new System.Windows.Forms.TextBox();
            this.minuto_simular = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_generar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.minimoClientConEntrada = new System.Windows.Forms.TextBox();
            this.MaximoClienteConEntrada = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.minimoTiempoVenta = new System.Windows.Forms.TextBox();
            this.maximoVenta = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.minimoEntradaSala = new System.Windows.Forms.TextBox();
            this.maximoEntradaSala = new System.Windows.Forms.TextBox();
            this.minuto_llegada_Ce = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.minutos_ingrso_cine = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txt_desc_total_otorgado = new System.Windows.Forms.TextBox();
            this.txt_personace_no_entra = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txt_pr_se_llena_cine = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txt_cola_vta_max = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.personas_en_cola_por_entrar = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.txt_cant_entrada_vend_en_cine = new System.Windows.Forms.TextBox();
            this.iteracion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.evento2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reloj2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Llegada_cliente_s_entrada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Proxima_llegada_SE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tiempo_atencion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fin_de_venta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad_entrada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoVendedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cola_de_ventas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Llegada_cliente_CE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Proxima_llegada_CE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.llegan_n_personas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tiempo_ingreso_sala = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proximo_ingreso_sala = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoCortador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cola_sala = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.capacidad_del_cine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cliente_CE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad_ent_vendidas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iteracion,
            this.evento2,
            this.reloj2,
            this.Llegada_cliente_s_entrada,
            this.Proxima_llegada_SE,
            this.tiempo_atencion,
            this.fin_de_venta,
            this.cantidad_entrada,
            this.estadoVendedor,
            this.cola_de_ventas,
            this.Llegada_cliente_CE,
            this.Proxima_llegada_CE,
            this.llegan_n_personas,
            this.tiempo_ingreso_sala,
            this.proximo_ingreso_sala,
            this.estadoCortador,
            this.Cola_sala,
            this.capacidad_del_cine,
            this.cliente_CE,
            this.Cantidad_ent_vendidas});
            this.dataGridView1.Location = new System.Drawing.Point(0, 182);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1121, 247);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // capacidad_cine
            // 
            this.capacidad_cine.ForeColor = System.Drawing.SystemColors.InfoText;
            this.capacidad_cine.Location = new System.Drawing.Point(12, 28);
            this.capacidad_cine.Name = "capacidad_cine";
            this.capacidad_cine.Size = new System.Drawing.Size(100, 20);
            this.capacidad_cine.TabIndex = 1;
            this.capacidad_cine.Text = "100";
            // 
            // minimoClienteSinEntrada
            // 
            this.minimoClienteSinEntrada.Location = new System.Drawing.Point(28, 31);
            this.minimoClienteSinEntrada.Name = "minimoClienteSinEntrada";
            this.minimoClienteSinEntrada.Size = new System.Drawing.Size(41, 20);
            this.minimoClienteSinEntrada.TabIndex = 2;
            this.minimoClienteSinEntrada.Text = "0,33";
            // 
            // hasta_input
            // 
            this.hasta_input.Location = new System.Drawing.Point(149, 139);
            this.hasta_input.Name = "hasta_input";
            this.hasta_input.Size = new System.Drawing.Size(100, 20);
            this.hasta_input.TabIndex = 3;
            this.hasta_input.Text = "20";
            // 
            // maxClienteSinEntrada
            // 
            this.maxClienteSinEntrada.Location = new System.Drawing.Point(141, 31);
            this.maxClienteSinEntrada.Name = "maxClienteSinEntrada";
            this.maxClienteSinEntrada.Size = new System.Drawing.Size(41, 20);
            this.maxClienteSinEntrada.TabIndex = 4;
            this.maxClienteSinEntrada.Text = "0,5";
            // 
            // desde_input
            // 
            this.desde_input.Location = new System.Drawing.Point(12, 139);
            this.desde_input.Name = "desde_input";
            this.desde_input.Size = new System.Drawing.Size(100, 20);
            this.desde_input.TabIndex = 6;
            this.desde_input.Text = "0";
            // 
            // minuto_simular
            // 
            this.minuto_simular.Location = new System.Drawing.Point(12, 84);
            this.minuto_simular.Name = "minuto_simular";
            this.minuto_simular.Size = new System.Drawing.Size(100, 20);
            this.minuto_simular.TabIndex = 7;
            this.minuto_simular.Text = "20";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Capacidad cine";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Minutos a simular";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Desde";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(146, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Hasta";
            // 
            // btn_generar
            // 
            this.btn_generar.BackColor = System.Drawing.Color.FloralWhite;
            this.btn_generar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_generar.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_generar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_generar.Location = new System.Drawing.Point(808, 123);
            this.btn_generar.Name = "btn_generar";
            this.btn_generar.Size = new System.Drawing.Size(110, 34);
            this.btn_generar.TabIndex = 12;
            this.btn_generar.Text = "Generar";
            this.btn_generar.UseVisualStyleBackColor = false;
            this.btn_generar.Click += new System.EventHandler(this.btn_generar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.minimoClienteSinEntrada);
            this.groupBox1.Controls.Add(this.maxClienteSinEntrada);
            this.groupBox1.Location = new System.Drawing.Point(342, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(209, 62);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tiempo llegada clientes sin entrada";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(156, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(14, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "B";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(14, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "A";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.minimoClientConEntrada);
            this.groupBox2.Controls.Add(this.MaximoClienteConEntrada);
            this.groupBox2.Location = new System.Drawing.Point(342, 97);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(209, 62);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tiempo llegada clientes con entrada";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(156, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(14, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "B";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(43, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(14, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "A";
            // 
            // minimoClientConEntrada
            // 
            this.minimoClientConEntrada.Location = new System.Drawing.Point(28, 31);
            this.minimoClientConEntrada.Name = "minimoClientConEntrada";
            this.minimoClientConEntrada.Size = new System.Drawing.Size(41, 20);
            this.minimoClientConEntrada.TabIndex = 2;
            this.minimoClientConEntrada.Text = "0,28";
            // 
            // MaximoClienteConEntrada
            // 
            this.MaximoClienteConEntrada.Location = new System.Drawing.Point(141, 31);
            this.MaximoClienteConEntrada.Name = "MaximoClienteConEntrada";
            this.MaximoClienteConEntrada.Size = new System.Drawing.Size(41, 20);
            this.MaximoClienteConEntrada.TabIndex = 4;
            this.MaximoClienteConEntrada.Text = "0,38";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.minimoTiempoVenta);
            this.groupBox3.Controls.Add(this.maximoVenta);
            this.groupBox3.Location = new System.Drawing.Point(571, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(209, 62);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tiempo de venta";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(156, 15);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(14, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "B";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(43, 15);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(14, 13);
            this.label10.TabIndex = 14;
            this.label10.Text = "A";
            // 
            // minimoTiempoVenta
            // 
            this.minimoTiempoVenta.Location = new System.Drawing.Point(28, 31);
            this.minimoTiempoVenta.Name = "minimoTiempoVenta";
            this.minimoTiempoVenta.Size = new System.Drawing.Size(41, 20);
            this.minimoTiempoVenta.TabIndex = 2;
            this.minimoTiempoVenta.Text = "1";
            // 
            // maximoVenta
            // 
            this.maximoVenta.Location = new System.Drawing.Point(141, 31);
            this.maximoVenta.Name = "maximoVenta";
            this.maximoVenta.Size = new System.Drawing.Size(41, 20);
            this.maximoVenta.TabIndex = 4;
            this.maximoVenta.Text = "2";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.minimoEntradaSala);
            this.groupBox4.Controls.Add(this.maximoEntradaSala);
            this.groupBox4.Location = new System.Drawing.Point(571, 97);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(209, 62);
            this.groupBox4.TabIndex = 16;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Entrada a sala";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(156, 15);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(14, 13);
            this.label11.TabIndex = 15;
            this.label11.Text = "B";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(43, 15);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(14, 13);
            this.label12.TabIndex = 14;
            this.label12.Text = "A";
            // 
            // minimoEntradaSala
            // 
            this.minimoEntradaSala.Location = new System.Drawing.Point(28, 31);
            this.minimoEntradaSala.Name = "minimoEntradaSala";
            this.minimoEntradaSala.Size = new System.Drawing.Size(41, 20);
            this.minimoEntradaSala.TabIndex = 2;
            this.minimoEntradaSala.Text = "0,01";
            // 
            // maximoEntradaSala
            // 
            this.maximoEntradaSala.Location = new System.Drawing.Point(141, 31);
            this.maximoEntradaSala.Name = "maximoEntradaSala";
            this.maximoEntradaSala.Size = new System.Drawing.Size(41, 20);
            this.maximoEntradaSala.TabIndex = 4;
            this.maximoEntradaSala.Text = "0,05";
            // 
            // minuto_llegada_Ce
            // 
            this.minuto_llegada_Ce.Location = new System.Drawing.Point(149, 84);
            this.minuto_llegada_Ce.Name = "minuto_llegada_Ce";
            this.minuto_llegada_Ce.Size = new System.Drawing.Size(100, 20);
            this.minuto_llegada_Ce.TabIndex = 17;
            this.minuto_llegada_Ce.Text = "12";
            this.minuto_llegada_Ce.TextChanged += new System.EventHandler(this.minuto_llegada_Ce_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(146, 65);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(190, 13);
            this.label13.TabIndex = 18;
            this.label13.Text = "Minutos que llegan cliente con entrada";
            // 
            // minutos_ingrso_cine
            // 
            this.minutos_ingrso_cine.Location = new System.Drawing.Point(149, 27);
            this.minutos_ingrso_cine.Name = "minutos_ingrso_cine";
            this.minutos_ingrso_cine.Size = new System.Drawing.Size(100, 20);
            this.minutos_ingrso_cine.TabIndex = 19;
            this.minutos_ingrso_cine.Text = "16";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(146, 9);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(135, 13);
            this.label14.TabIndex = 20;
            this.label14.Text = "Minuto que entran a la sala";
            // 
            // txt_desc_total_otorgado
            // 
            this.txt_desc_total_otorgado.Enabled = false;
            this.txt_desc_total_otorgado.Location = new System.Drawing.Point(342, 518);
            this.txt_desc_total_otorgado.Name = "txt_desc_total_otorgado";
            this.txt_desc_total_otorgado.Size = new System.Drawing.Size(47, 20);
            this.txt_desc_total_otorgado.TabIndex = 27;
            // 
            // txt_personace_no_entra
            // 
            this.txt_personace_no_entra.Enabled = false;
            this.txt_personace_no_entra.Location = new System.Drawing.Point(342, 485);
            this.txt_personace_no_entra.Name = "txt_personace_no_entra";
            this.txt_personace_no_entra.Size = new System.Drawing.Size(47, 20);
            this.txt_personace_no_entra.TabIndex = 26;
            this.txt_personace_no_entra.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(12, 454);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(186, 13);
            this.label15.TabIndex = 25;
            this.label15.Text = "a) Probabilidad de que el cine se llene";
            // 
            // txt_pr_se_llena_cine
            // 
            this.txt_pr_se_llena_cine.Enabled = false;
            this.txt_pr_se_llena_cine.Location = new System.Drawing.Point(342, 451);
            this.txt_pr_se_llena_cine.Name = "txt_pr_se_llena_cine";
            this.txt_pr_se_llena_cine.Size = new System.Drawing.Size(47, 20);
            this.txt_pr_se_llena_cine.TabIndex = 24;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(424, 454);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(302, 13);
            this.label16.TabIndex = 28;
            this.label16.Text = "d) Cantidad maxima de personas en cola para comprar entrada";
            this.label16.Click += new System.EventHandler(this.label16_Click);
            // 
            // txt_cola_vta_max
            // 
            this.txt_cola_vta_max.Enabled = false;
            this.txt_cola_vta_max.Location = new System.Drawing.Point(801, 451);
            this.txt_cola_vta_max.Name = "txt_cola_vta_max";
            this.txt_cola_vta_max.Size = new System.Drawing.Size(47, 20);
            this.txt_cola_vta_max.TabIndex = 29;
            this.txt_cola_vta_max.TextChanged += new System.EventHandler(this.txt_cola_vta_max_TextChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(424, 485);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(343, 13);
            this.label17.TabIndex = 30;
            this.label17.Text = "e) Cantidad de personas que quedaron en cola esperando entrar a sala";
            // 
            // personas_en_cola_por_entrar
            // 
            this.personas_en_cola_por_entrar.Enabled = false;
            this.personas_en_cola_por_entrar.Location = new System.Drawing.Point(801, 485);
            this.personas_en_cola_por_entrar.Name = "personas_en_cola_por_entrar";
            this.personas_en_cola_por_entrar.Size = new System.Drawing.Size(47, 20);
            this.personas_en_cola_por_entrar.TabIndex = 31;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(12, 488);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(313, 13);
            this.label18.TabIndex = 32;
            this.label18.Text = "b) Probabilidad de que una persona con entrada no pueda entrar";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(12, 521);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(220, 13);
            this.label19.TabIndex = 33;
            this.label19.Text = "c) ¿Cuánto es el descuento (en %) otorgado?";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(424, 521);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(201, 13);
            this.label20.TabIndex = 34;
            this.label20.Text = "f) Cantidad de entradas vendidas en cine";
            // 
            // txt_cant_entrada_vend_en_cine
            // 
            this.txt_cant_entrada_vend_en_cine.Enabled = false;
            this.txt_cant_entrada_vend_en_cine.Location = new System.Drawing.Point(801, 520);
            this.txt_cant_entrada_vend_en_cine.Name = "txt_cant_entrada_vend_en_cine";
            this.txt_cant_entrada_vend_en_cine.Size = new System.Drawing.Size(47, 20);
            this.txt_cant_entrada_vend_en_cine.TabIndex = 35;
            // 
            // iteracion
            // 
            this.iteracion.HeaderText = "Iteracion";
            this.iteracion.MinimumWidth = 2;
            this.iteracion.Name = "iteracion";
            this.iteracion.ReadOnly = true;
            this.iteracion.Width = 2;
            // 
            // evento2
            // 
            this.evento2.HeaderText = "Evento";
            this.evento2.Name = "evento2";
            this.evento2.ReadOnly = true;
            this.evento2.Width = 150;
            // 
            // reloj2
            // 
            this.reloj2.HeaderText = "Reloj (minutos)";
            this.reloj2.Name = "reloj2";
            this.reloj2.ReadOnly = true;
            this.reloj2.Width = 70;
            // 
            // Llegada_cliente_s_entrada
            // 
            this.Llegada_cliente_s_entrada.HeaderText = "Llegada Cliente SE";
            this.Llegada_cliente_s_entrada.Name = "Llegada_cliente_s_entrada";
            this.Llegada_cliente_s_entrada.ReadOnly = true;
            this.Llegada_cliente_s_entrada.Width = 70;
            // 
            // Proxima_llegada_SE
            // 
            this.Proxima_llegada_SE.HeaderText = "Proxima llegada SE";
            this.Proxima_llegada_SE.Name = "Proxima_llegada_SE";
            this.Proxima_llegada_SE.ReadOnly = true;
            this.Proxima_llegada_SE.Width = 70;
            // 
            // tiempo_atencion
            // 
            this.tiempo_atencion.HeaderText = "Tiempo Atencion";
            this.tiempo_atencion.Name = "tiempo_atencion";
            this.tiempo_atencion.ReadOnly = true;
            this.tiempo_atencion.Width = 70;
            // 
            // fin_de_venta
            // 
            this.fin_de_venta.HeaderText = "Fin de Venta";
            this.fin_de_venta.Name = "fin_de_venta";
            this.fin_de_venta.ReadOnly = true;
            this.fin_de_venta.Width = 70;
            // 
            // cantidad_entrada
            // 
            this.cantidad_entrada.HeaderText = "Cantidad de entradas a comprar";
            this.cantidad_entrada.Name = "cantidad_entrada";
            this.cantidad_entrada.ReadOnly = true;
            this.cantidad_entrada.Width = 70;
            // 
            // estadoVendedor
            // 
            this.estadoVendedor.HeaderText = "Estado vendedor";
            this.estadoVendedor.Name = "estadoVendedor";
            this.estadoVendedor.ReadOnly = true;
            this.estadoVendedor.Width = 70;
            // 
            // cola_de_ventas
            // 
            this.cola_de_ventas.HeaderText = "Cola de ventas";
            this.cola_de_ventas.Name = "cola_de_ventas";
            this.cola_de_ventas.ReadOnly = true;
            this.cola_de_ventas.Width = 70;
            // 
            // Llegada_cliente_CE
            // 
            this.Llegada_cliente_CE.HeaderText = "Llegada Cliente CE";
            this.Llegada_cliente_CE.Name = "Llegada_cliente_CE";
            this.Llegada_cliente_CE.ReadOnly = true;
            this.Llegada_cliente_CE.Width = 70;
            // 
            // Proxima_llegada_CE
            // 
            this.Proxima_llegada_CE.HeaderText = "Proxima llegada CE";
            this.Proxima_llegada_CE.Name = "Proxima_llegada_CE";
            this.Proxima_llegada_CE.ReadOnly = true;
            this.Proxima_llegada_CE.Width = 70;
            // 
            // llegan_n_personas
            // 
            this.llegan_n_personas.HeaderText = "Llegan n Personas CE";
            this.llegan_n_personas.Name = "llegan_n_personas";
            this.llegan_n_personas.ReadOnly = true;
            this.llegan_n_personas.Width = 70;
            // 
            // tiempo_ingreso_sala
            // 
            this.tiempo_ingreso_sala.HeaderText = "Ingreso a sala";
            this.tiempo_ingreso_sala.Name = "tiempo_ingreso_sala";
            this.tiempo_ingreso_sala.ReadOnly = true;
            this.tiempo_ingreso_sala.Width = 70;
            // 
            // proximo_ingreso_sala
            // 
            this.proximo_ingreso_sala.HeaderText = "Proximo ingreso sala";
            this.proximo_ingreso_sala.Name = "proximo_ingreso_sala";
            this.proximo_ingreso_sala.ReadOnly = true;
            this.proximo_ingreso_sala.Width = 70;
            // 
            // estadoCortador
            // 
            this.estadoCortador.HeaderText = "Estado cortador Ent";
            this.estadoCortador.Name = "estadoCortador";
            this.estadoCortador.ReadOnly = true;
            this.estadoCortador.Width = 70;
            // 
            // Cola_sala
            // 
            this.Cola_sala.HeaderText = "Cola sala";
            this.Cola_sala.Name = "Cola_sala";
            this.Cola_sala.ReadOnly = true;
            this.Cola_sala.Width = 70;
            // 
            // capacidad_del_cine
            // 
            this.capacidad_del_cine.HeaderText = "Capacidad cine";
            this.capacidad_del_cine.Name = "capacidad_del_cine";
            this.capacidad_del_cine.ReadOnly = true;
            this.capacidad_del_cine.Width = 70;
            // 
            // cliente_CE
            // 
            this.cliente_CE.HeaderText = "Cliente con EA";
            this.cliente_CE.Name = "cliente_CE";
            this.cliente_CE.ReadOnly = true;
            this.cliente_CE.Width = 70;
            // 
            // Cantidad_ent_vendidas
            // 
            this.Cantidad_ent_vendidas.HeaderText = "Cantidad entradas vendidas";
            this.Cantidad_ent_vendidas.Name = "Cantidad_ent_vendidas";
            this.Cantidad_ent_vendidas.ReadOnly = true;
            this.Cantidad_ent_vendidas.Width = 70;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1133, 618);
            this.Controls.Add(this.txt_cant_entrada_vend_en_cine);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.personas_en_cola_por_entrar);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.txt_cola_vta_max);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txt_desc_total_otorgado);
            this.Controls.Add(this.txt_personace_no_entra);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txt_pr_se_llena_cine);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.minutos_ingrso_cine);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.minuto_llegada_Ce);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_generar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.minuto_simular);
            this.Controls.Add(this.desde_input);
            this.Controls.Add(this.hasta_input);
            this.Controls.Add(this.capacidad_cine);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Trabajo prático 5: Colas";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox capacidad_cine;
        private System.Windows.Forms.TextBox minimoClienteSinEntrada;
        private System.Windows.Forms.TextBox hasta_input;
        private System.Windows.Forms.TextBox maxClienteSinEntrada;
        private System.Windows.Forms.TextBox desde_input;
        private System.Windows.Forms.TextBox minuto_simular;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_generar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox minimoClientConEntrada;
        private System.Windows.Forms.TextBox MaximoClienteConEntrada;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox minimoTiempoVenta;
        private System.Windows.Forms.TextBox maximoVenta;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox minimoEntradaSala;
        private System.Windows.Forms.TextBox maximoEntradaSala;
        private System.Windows.Forms.TextBox minuto_llegada_Ce;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox minutos_ingrso_cine;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txt_desc_total_otorgado;
        private System.Windows.Forms.TextBox txt_personace_no_entra;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txt_pr_se_llena_cine;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txt_cola_vta_max;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox personas_en_cola_por_entrar;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txt_cant_entrada_vend_en_cine;
        private System.Windows.Forms.DataGridViewTextBoxColumn iteracion;
        private System.Windows.Forms.DataGridViewTextBoxColumn evento2;
        private System.Windows.Forms.DataGridViewTextBoxColumn reloj2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Llegada_cliente_s_entrada;
        private System.Windows.Forms.DataGridViewTextBoxColumn Proxima_llegada_SE;
        private System.Windows.Forms.DataGridViewTextBoxColumn tiempo_atencion;
        private System.Windows.Forms.DataGridViewTextBoxColumn fin_de_venta;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad_entrada;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoVendedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn cola_de_ventas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Llegada_cliente_CE;
        private System.Windows.Forms.DataGridViewTextBoxColumn Proxima_llegada_CE;
        private System.Windows.Forms.DataGridViewTextBoxColumn llegan_n_personas;
        private System.Windows.Forms.DataGridViewTextBoxColumn tiempo_ingreso_sala;
        private System.Windows.Forms.DataGridViewTextBoxColumn proximo_ingreso_sala;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoCortador;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cola_sala;
        private System.Windows.Forms.DataGridViewTextBoxColumn capacidad_del_cine;
        private System.Windows.Forms.DataGridViewTextBoxColumn cliente_CE;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad_ent_vendidas;
    }
}

