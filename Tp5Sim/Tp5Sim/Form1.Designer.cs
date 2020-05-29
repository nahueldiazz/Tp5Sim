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
            this.Evento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Reloj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Llegada_cliente_s_entrada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Proxima_llegada_SE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tiempo_atencion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fin_de_venta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad_entrada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cola_de_ventas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Llegada_cliente_CE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Proxima_llegada_CE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.llegan_n_personas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tiempo_ingreso_sala = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proximo_ingreso_sala = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cola_sala = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.capacidad_del_cine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cliente_CE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad_ent_vendidas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Personas_afuera = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.capacidad_cine = new System.Windows.Forms.TextBox();
            this.minimoClienteSinEntrada = new System.Windows.Forms.TextBox();
            this.hasta_input = new System.Windows.Forms.TextBox();
            this.maxClienteSinEntrada = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Evento,
            this.Reloj,
            this.Llegada_cliente_s_entrada,
            this.Proxima_llegada_SE,
            this.tiempo_atencion,
            this.fin_de_venta,
            this.cantidad_entrada,
            this.cola_de_ventas,
            this.Llegada_cliente_CE,
            this.Proxima_llegada_CE,
            this.llegan_n_personas,
            this.tiempo_ingreso_sala,
            this.proximo_ingreso_sala,
            this.Cola_sala,
            this.capacidad_del_cine,
            this.cliente_CE,
            this.Cantidad_ent_vendidas,
            this.Personas_afuera});
            this.dataGridView1.Location = new System.Drawing.Point(12, 191);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1470, 247);
            this.dataGridView1.TabIndex = 0;
            // 
            // Evento
            // 
            this.Evento.HeaderText = "Evento";
            this.Evento.Name = "Evento";
            // 
            // Reloj
            // 
            this.Reloj.HeaderText = "Reloj";
            this.Reloj.Name = "Reloj";
            // 
            // Llegada_cliente_s_entrada
            // 
            this.Llegada_cliente_s_entrada.HeaderText = "Llegada Cliente SE";
            this.Llegada_cliente_s_entrada.Name = "Llegada_cliente_s_entrada";
            // 
            // Proxima_llegada_SE
            // 
            this.Proxima_llegada_SE.HeaderText = "Proxima llegada SE";
            this.Proxima_llegada_SE.Name = "Proxima_llegada_SE";
            // 
            // tiempo_atencion
            // 
            this.tiempo_atencion.HeaderText = "Tiempo Atencion";
            this.tiempo_atencion.Name = "tiempo_atencion";
            // 
            // fin_de_venta
            // 
            this.fin_de_venta.HeaderText = "Fin de Venta";
            this.fin_de_venta.Name = "fin_de_venta";
            // 
            // cantidad_entrada
            // 
            this.cantidad_entrada.HeaderText = "Cantidad de entradas a comprar";
            this.cantidad_entrada.Name = "cantidad_entrada";
            // 
            // cola_de_ventas
            // 
            this.cola_de_ventas.HeaderText = "Cola de ventas";
            this.cola_de_ventas.Name = "cola_de_ventas";
            // 
            // Llegada_cliente_CE
            // 
            this.Llegada_cliente_CE.HeaderText = "Llegada Cliente CE";
            this.Llegada_cliente_CE.Name = "Llegada_cliente_CE";
            // 
            // Proxima_llegada_CE
            // 
            this.Proxima_llegada_CE.HeaderText = "Proxima llegada CE";
            this.Proxima_llegada_CE.Name = "Proxima_llegada_CE";
            // 
            // llegan_n_personas
            // 
            this.llegan_n_personas.HeaderText = "Llegan n Personas";
            this.llegan_n_personas.Name = "llegan_n_personas";
            // 
            // tiempo_ingreso_sala
            // 
            this.tiempo_ingreso_sala.HeaderText = "Ingreso a sala";
            this.tiempo_ingreso_sala.Name = "tiempo_ingreso_sala";
            // 
            // proximo_ingreso_sala
            // 
            this.proximo_ingreso_sala.HeaderText = "Proximo ingreso sala";
            this.proximo_ingreso_sala.Name = "proximo_ingreso_sala";
            // 
            // Cola_sala
            // 
            this.Cola_sala.HeaderText = "Cola sala";
            this.Cola_sala.Name = "Cola_sala";
            // 
            // capacidad_del_cine
            // 
            this.capacidad_del_cine.HeaderText = "Capacidad cine";
            this.capacidad_del_cine.Name = "capacidad_del_cine";
            // 
            // cliente_CE
            // 
            this.cliente_CE.HeaderText = "Cliente con EA";
            this.cliente_CE.Name = "cliente_CE";
            // 
            // Cantidad_ent_vendidas
            // 
            this.Cantidad_ent_vendidas.HeaderText = "Cantidad entradas vendidas";
            this.Cantidad_ent_vendidas.Name = "Cantidad_ent_vendidas";
            // 
            // Personas_afuera
            // 
            this.Personas_afuera.HeaderText = "Personas que quedan afuera";
            this.Personas_afuera.Name = "Personas_afuera";
            // 
            // capacidad_cine
            // 
            this.capacidad_cine.ForeColor = System.Drawing.SystemColors.InfoText;
            this.capacidad_cine.Location = new System.Drawing.Point(12, 28);
            this.capacidad_cine.Name = "capacidad_cine";
            this.capacidad_cine.Size = new System.Drawing.Size(100, 20);
            this.capacidad_cine.TabIndex = 1;
            // 
            // minimoClienteSinEntrada
            // 
            this.minimoClienteSinEntrada.Location = new System.Drawing.Point(28, 31);
            this.minimoClienteSinEntrada.Name = "minimoClienteSinEntrada";
            this.minimoClienteSinEntrada.Size = new System.Drawing.Size(41, 20);
            this.minimoClienteSinEntrada.TabIndex = 2;
            // 
            // hasta_input
            // 
            this.hasta_input.Location = new System.Drawing.Point(149, 139);
            this.hasta_input.Name = "hasta_input";
            this.hasta_input.Size = new System.Drawing.Size(100, 20);
            this.hasta_input.TabIndex = 3;
            // 
            // maxClienteSinEntrada
            // 
            this.maxClienteSinEntrada.Location = new System.Drawing.Point(141, 31);
            this.maxClienteSinEntrada.Name = "maxClienteSinEntrada";
            this.maxClienteSinEntrada.Size = new System.Drawing.Size(41, 20);
            this.maxClienteSinEntrada.TabIndex = 4;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(1015, 65);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 5;
            // 
            // desde_input
            // 
            this.desde_input.Location = new System.Drawing.Point(12, 139);
            this.desde_input.Name = "desde_input";
            this.desde_input.Size = new System.Drawing.Size(100, 20);
            this.desde_input.TabIndex = 6;
            // 
            // minuto_simular
            // 
            this.minuto_simular.Location = new System.Drawing.Point(12, 84);
            this.minuto_simular.Name = "minuto_simular";
            this.minuto_simular.Size = new System.Drawing.Size(100, 20);
            this.minuto_simular.TabIndex = 7;
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
            this.btn_generar.Location = new System.Drawing.Point(1372, 140);
            this.btn_generar.Name = "btn_generar";
            this.btn_generar.Size = new System.Drawing.Size(110, 45);
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
            this.groupBox1.Location = new System.Drawing.Point(328, 12);
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
            this.groupBox2.Location = new System.Drawing.Point(328, 97);
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
            // 
            // MaximoClienteConEntrada
            // 
            this.MaximoClienteConEntrada.Location = new System.Drawing.Point(141, 31);
            this.MaximoClienteConEntrada.Name = "MaximoClienteConEntrada";
            this.MaximoClienteConEntrada.Size = new System.Drawing.Size(41, 20);
            this.MaximoClienteConEntrada.TabIndex = 4;
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
            // 
            // maximoVenta
            // 
            this.maximoVenta.Location = new System.Drawing.Point(141, 31);
            this.maximoVenta.Name = "maximoVenta";
            this.maximoVenta.Size = new System.Drawing.Size(41, 20);
            this.maximoVenta.TabIndex = 4;
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
            // 
            // maximoEntradaSala
            // 
            this.maximoEntradaSala.Location = new System.Drawing.Point(141, 31);
            this.maximoEntradaSala.Name = "maximoEntradaSala";
            this.maximoEntradaSala.Size = new System.Drawing.Size(41, 20);
            this.maximoEntradaSala.TabIndex = 4;
            // 
            // minuto_llegada_Ce
            // 
            this.minuto_llegada_Ce.Location = new System.Drawing.Point(149, 84);
            this.minuto_llegada_Ce.Name = "minuto_llegada_Ce";
            this.minuto_llegada_Ce.Size = new System.Drawing.Size(100, 20);
            this.minuto_llegada_Ce.TabIndex = 17;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(105, 65);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(217, 13);
            this.label13.TabIndex = 18;
            this.label13.Text = "Minuto desde que llegan cliente con entrada";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1516, 450);
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
            this.Controls.Add(this.textBox5);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn Evento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Reloj;
        private System.Windows.Forms.TextBox capacidad_cine;
        private System.Windows.Forms.TextBox minimoClienteSinEntrada;
        private System.Windows.Forms.TextBox hasta_input;
        private System.Windows.Forms.TextBox maxClienteSinEntrada;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox desde_input;
        private System.Windows.Forms.TextBox minuto_simular;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_generar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Llegada_cliente_s_entrada;
        private System.Windows.Forms.DataGridViewTextBoxColumn Proxima_llegada_SE;
        private System.Windows.Forms.DataGridViewTextBoxColumn tiempo_atencion;
        private System.Windows.Forms.DataGridViewTextBoxColumn fin_de_venta;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad_entrada;
        private System.Windows.Forms.DataGridViewTextBoxColumn cola_de_ventas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Llegada_cliente_CE;
        private System.Windows.Forms.DataGridViewTextBoxColumn Proxima_llegada_CE;
        private System.Windows.Forms.DataGridViewTextBoxColumn llegan_n_personas;
        private System.Windows.Forms.DataGridViewTextBoxColumn tiempo_ingreso_sala;
        private System.Windows.Forms.DataGridViewTextBoxColumn proximo_ingreso_sala;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cola_sala;
        private System.Windows.Forms.DataGridViewTextBoxColumn capacidad_del_cine;
        private System.Windows.Forms.DataGridViewTextBoxColumn cliente_CE;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad_ent_vendidas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Personas_afuera;
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
    }
}

