namespace ingre
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtTrabajador = new System.Windows.Forms.TextBox();
            this.btnSueldo = new System.Windows.Forms.Button();
            this.btnIngreso = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtIngresos = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtExtra = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSueldo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.rdbNocturno = new System.Windows.Forms.RadioButton();
            this.rdbDiurno = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.txtHoras = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtSeguro = new System.Windows.Forms.TextBox();
            this.chbCarga = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtHijos = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtEgreso = new System.Windows.Forms.TextBox();
            this.btnEgreso = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.txtNeto = new System.Windows.Forms.TextBox();
            this.btnNeto = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Trabajador:";
            // 
            // txtTrabajador
            // 
            this.txtTrabajador.Location = new System.Drawing.Point(79, 9);
            this.txtTrabajador.Name = "txtTrabajador";
            this.txtTrabajador.Size = new System.Drawing.Size(309, 20);
            this.txtTrabajador.TabIndex = 1;
            // 
            // btnSueldo
            // 
            this.btnSueldo.Location = new System.Drawing.Point(394, 9);
            this.btnSueldo.Name = "btnSueldo";
            this.btnSueldo.Size = new System.Drawing.Size(109, 23);
            this.btnSueldo.TabIndex = 2;
            this.btnSueldo.Text = "Calcular Sueldo";
            this.btnSueldo.UseVisualStyleBackColor = true;
            this.btnSueldo.Click += new System.EventHandler(this.btnSueldo_Click);
            // 
            // btnIngreso
            // 
            this.btnIngreso.Location = new System.Drawing.Point(523, 9);
            this.btnIngreso.Name = "btnIngreso";
            this.btnIngreso.Size = new System.Drawing.Size(75, 23);
            this.btnIngreso.TabIndex = 3;
            this.btnIngreso.Text = "Ingresos";
            this.btnIngreso.UseVisualStyleBackColor = true;
            this.btnIngreso.Click += new System.EventHandler(this.btnIngreso_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Horas Trabajadas:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtIngresos);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtExtra);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.textBox5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtSueldo);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtValor);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.rdbNocturno);
            this.groupBox1.Controls.Add(this.rdbDiurno);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtHoras);
            this.groupBox1.Location = new System.Drawing.Point(5, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(600, 214);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // txtIngresos
            // 
            this.txtIngresos.Location = new System.Drawing.Point(373, 168);
            this.txtIngresos.Name = "txtIngresos";
            this.txtIngresos.ReadOnly = true;
            this.txtIngresos.Size = new System.Drawing.Size(191, 20);
            this.txtIngresos.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(317, 168);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Ingresos:";
            // 
            // txtExtra
            // 
            this.txtExtra.Location = new System.Drawing.Point(235, 168);
            this.txtExtra.Name = "txtExtra";
            this.txtExtra.ReadOnly = true;
            this.txtExtra.Size = new System.Drawing.Size(63, 20);
            this.txtExtra.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(163, 168);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Total Extras:";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(83, 168);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(63, 20);
            this.textBox5.TabIndex = 13;
            this.textBox5.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 168);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Horas Extras:";
            // 
            // txtSueldo
            // 
            this.txtSueldo.Location = new System.Drawing.Point(74, 128);
            this.txtSueldo.Name = "txtSueldo";
            this.txtSueldo.ReadOnly = true;
            this.txtSueldo.Size = new System.Drawing.Size(276, 20);
            this.txtSueldo.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Sueldo:";
            // 
            // txtValor
            // 
            this.txtValor.BackColor = System.Drawing.Color.Lime;
            this.txtValor.Location = new System.Drawing.Point(107, 90);
            this.txtValor.Name = "txtValor";
            this.txtValor.ReadOnly = true;
            this.txtValor.Size = new System.Drawing.Size(102, 20);
            this.txtValor.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Valor por Hora:";
            // 
            // rdbNocturno
            // 
            this.rdbNocturno.AutoSize = true;
            this.rdbNocturno.Location = new System.Drawing.Point(413, 108);
            this.rdbNocturno.Name = "rdbNocturno";
            this.rdbNocturno.Size = new System.Drawing.Size(69, 17);
            this.rdbNocturno.TabIndex = 8;
            this.rdbNocturno.TabStop = true;
            this.rdbNocturno.Text = "Nocturno";
            this.rdbNocturno.UseVisualStyleBackColor = true;
            this.rdbNocturno.CheckedChanged += new System.EventHandler(this.rdbNocturno_CheckedChanged);
            // 
            // rdbDiurno
            // 
            this.rdbDiurno.AutoSize = true;
            this.rdbDiurno.Location = new System.Drawing.Point(413, 76);
            this.rdbDiurno.Name = "rdbDiurno";
            this.rdbDiurno.Size = new System.Drawing.Size(59, 17);
            this.rdbDiurno.TabIndex = 7;
            this.rdbDiurno.TabStop = true;
            this.rdbDiurno.Text = "Diurno:";
            this.rdbDiurno.UseVisualStyleBackColor = true;
            this.rdbDiurno.CheckedChanged += new System.EventHandler(this.rdbDiurno_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(407, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Turno:";
            // 
            // txtHoras
            // 
            this.txtHoras.Location = new System.Drawing.Point(107, 48);
            this.txtHoras.Name = "txtHoras";
            this.txtHoras.Size = new System.Drawing.Size(276, 20);
            this.txtHoras.TabIndex = 6;
            this.txtHoras.TextChanged += new System.EventHandler(this.txtHoras_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnNeto);
            this.groupBox2.Controls.Add(this.txtNeto);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.btnLimpiar);
            this.groupBox2.Controls.Add(this.btnEgreso);
            this.groupBox2.Controls.Add(this.txtEgreso);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.txtHijos);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.chbCarga);
            this.groupBox2.Controls.Add(this.txtSeguro);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Location = new System.Drawing.Point(5, 222);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(600, 130);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Seguro Social:";
            // 
            // txtSeguro
            // 
            this.txtSeguro.Location = new System.Drawing.Point(89, 16);
            this.txtSeguro.Name = "txtSeguro";
            this.txtSeguro.ReadOnly = true;
            this.txtSeguro.Size = new System.Drawing.Size(80, 20);
            this.txtSeguro.TabIndex = 18;
            // 
            // chbCarga
            // 
            this.chbCarga.AutoSize = true;
            this.chbCarga.Location = new System.Drawing.Point(193, 16);
            this.chbCarga.Name = "chbCarga";
            this.chbCarga.Size = new System.Drawing.Size(92, 17);
            this.chbCarga.TabIndex = 19;
            this.chbCarga.Text = "Carga Familiar";
            this.chbCarga.UseVisualStyleBackColor = true;
            this.chbCarga.CheckedChanged += new System.EventHandler(this.chbCarga_CheckedChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(291, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(88, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "Número de Hijos:";
            // 
            // txtHijos
            // 
            this.txtHijos.BackColor = System.Drawing.Color.Aqua;
            this.txtHijos.Location = new System.Drawing.Point(385, 16);
            this.txtHijos.Name = "txtHijos";
            this.txtHijos.ReadOnly = true;
            this.txtHijos.Size = new System.Drawing.Size(102, 20);
            this.txtHijos.TabIndex = 18;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(7, 54);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(75, 13);
            this.label11.TabIndex = 21;
            this.label11.Text = "Total Egresos:";
            // 
            // txtEgreso
            // 
            this.txtEgreso.Location = new System.Drawing.Point(89, 54);
            this.txtEgreso.Name = "txtEgreso";
            this.txtEgreso.ReadOnly = true;
            this.txtEgreso.Size = new System.Drawing.Size(108, 20);
            this.txtEgreso.TabIndex = 22;
            // 
            // btnEgreso
            // 
            this.btnEgreso.Location = new System.Drawing.Point(222, 54);
            this.btnEgreso.Name = "btnEgreso";
            this.btnEgreso.Size = new System.Drawing.Size(109, 23);
            this.btnEgreso.TabIndex = 7;
            this.btnEgreso.Text = "Calcular Egresos";
            this.btnEgreso.UseVisualStyleBackColor = true;
            this.btnEgreso.Click += new System.EventHandler(this.btnEgreso_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(351, 54);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 7;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(10, 91);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(114, 13);
            this.label12.TabIndex = 23;
            this.label12.Text = "Sueldo Neto a Recibir:";
            // 
            // txtNeto
            // 
            this.txtNeto.Location = new System.Drawing.Point(130, 91);
            this.txtNeto.Name = "txtNeto";
            this.txtNeto.ReadOnly = true;
            this.txtNeto.Size = new System.Drawing.Size(296, 20);
            this.txtNeto.TabIndex = 24;
            // 
            // btnNeto
            // 
            this.btnNeto.Location = new System.Drawing.Point(442, 91);
            this.btnNeto.Name = "btnNeto";
            this.btnNeto.Size = new System.Drawing.Size(109, 23);
            this.btnNeto.TabIndex = 25;
            this.btnNeto.Text = "Calcular Neto";
            this.btnNeto.UseVisualStyleBackColor = true;
            this.btnNeto.Click += new System.EventHandler(this.btnNeto_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 356);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnIngreso);
            this.Controls.Add(this.btnSueldo);
            this.Controls.Add(this.txtTrabajador);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calcular Ingresos y Egresos";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTrabajador;
        private System.Windows.Forms.Button btnSueldo;
        private System.Windows.Forms.Button btnIngreso;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbNocturno;
        private System.Windows.Forms.RadioButton rdbDiurno;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtHoras;
        private System.Windows.Forms.TextBox txtIngresos;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtExtra;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSueldo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtSeguro;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox chbCarga;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtHijos;
        private System.Windows.Forms.TextBox txtEgreso;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnEgreso;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtNeto;
        private System.Windows.Forms.Button btnNeto;
    }
}

