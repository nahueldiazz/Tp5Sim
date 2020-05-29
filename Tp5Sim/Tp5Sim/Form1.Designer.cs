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
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.hasta = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.desde = new System.Windows.Forms.TextBox();
            this.minuto_simular = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_generar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(388, 29);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 2;
            // 
            // hasta
            // 
            this.hasta.Location = new System.Drawing.Point(149, 139);
            this.hasta.Name = "hasta";
            this.hasta.Size = new System.Drawing.Size(100, 20);
            this.hasta.TabIndex = 3;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(305, 66);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 4;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(223, 29);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 5;
            // 
            // desde
            // 
            this.desde.Location = new System.Drawing.Point(12, 139);
            this.desde.Name = "desde";
            this.desde.Size = new System.Drawing.Size(100, 20);
            this.desde.TabIndex = 6;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1516, 450);
            this.Controls.Add(this.btn_generar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.minuto_simular);
            this.Controls.Add(this.desde);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.hasta);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.capacidad_cine);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Trabajo prático 5: Colas";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Evento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Reloj;
        private System.Windows.Forms.TextBox capacidad_cine;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox hasta;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox desde;
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
    }
}

