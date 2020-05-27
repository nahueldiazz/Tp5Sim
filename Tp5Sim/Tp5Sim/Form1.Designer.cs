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
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Evento,
            this.Reloj});
            this.dataGridView1.Location = new System.Drawing.Point(12, 191);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1175, 247);
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
            // capacidad_cine
            // 
            this.capacidad_cine.ForeColor = System.Drawing.SystemColors.InfoText;
            this.capacidad_cine.Location = new System.Drawing.Point(54, 29);
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
            this.hasta.Location = new System.Drawing.Point(223, 140);
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
            this.desde.Location = new System.Drawing.Point(54, 140);
            this.desde.Name = "desde";
            this.desde.Size = new System.Drawing.Size(100, 20);
            this.desde.TabIndex = 6;
            // 
            // minuto_simular
            // 
            this.minuto_simular.Location = new System.Drawing.Point(54, 85);
            this.minuto_simular.Name = "minuto_simular";
            this.minuto_simular.Size = new System.Drawing.Size(100, 20);
            this.minuto_simular.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Capacidad cine";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Minutos a simular";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Desde";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(220, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Hasta";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FloralWhite;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(1061, 140);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 45);
            this.button1.TabIndex = 12;
            this.button1.Text = "Generar";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1199, 450);
            this.Controls.Add(this.button1);
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
        private System.Windows.Forms.Button button1;
    }
}

