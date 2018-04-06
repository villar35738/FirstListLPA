namespace Calculadora
{
    partial class Calculator
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
            this.txtNumero1 = new System.Windows.Forms.TextBox();
            this.btnSomar = new System.Windows.Forms.Button();
            this.txtNumero2 = new System.Windows.Forms.TextBox();
            this.btnSubtrair = new System.Windows.Forms.Button();
            this.btnDividir = new System.Windows.Forms.Button();
            this.btnMultiplicar = new System.Windows.Forms.Button();
            this.labelResultado = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textB = new System.Windows.Forms.TextBox();
            this.btnBask = new System.Windows.Forms.Button();
            this.textA = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textC = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labelX1 = new System.Windows.Forms.Label();
            this.labelX2 = new System.Windows.Forms.Label();
            this.btnPotencia = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNumero1
            // 
            this.txtNumero1.Location = new System.Drawing.Point(70, 24);
            this.txtNumero1.Margin = new System.Windows.Forms.Padding(2);
            this.txtNumero1.Name = "txtNumero1";
            this.txtNumero1.Size = new System.Drawing.Size(96, 20);
            this.txtNumero1.TabIndex = 0;
            // 
            // btnSomar
            // 
            this.btnSomar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSomar.Location = new System.Drawing.Point(13, 80);
            this.btnSomar.Margin = new System.Windows.Forms.Padding(2);
            this.btnSomar.Name = "btnSomar";
            this.btnSomar.Size = new System.Drawing.Size(48, 32);
            this.btnSomar.TabIndex = 2;
            this.btnSomar.Text = "+";
            this.btnSomar.UseVisualStyleBackColor = true;
            this.btnSomar.Click += new System.EventHandler(this.btnSomar_Click);
            // 
            // txtNumero2
            // 
            this.txtNumero2.Location = new System.Drawing.Point(70, 47);
            this.txtNumero2.Margin = new System.Windows.Forms.Padding(2);
            this.txtNumero2.Name = "txtNumero2";
            this.txtNumero2.Size = new System.Drawing.Size(96, 20);
            this.txtNumero2.TabIndex = 1;
            // 
            // btnSubtrair
            // 
            this.btnSubtrair.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubtrair.Location = new System.Drawing.Point(65, 80);
            this.btnSubtrair.Margin = new System.Windows.Forms.Padding(2);
            this.btnSubtrair.Name = "btnSubtrair";
            this.btnSubtrair.Size = new System.Drawing.Size(45, 32);
            this.btnSubtrair.TabIndex = 3;
            this.btnSubtrair.Text = "-";
            this.btnSubtrair.UseVisualStyleBackColor = true;
            this.btnSubtrair.Click += new System.EventHandler(this.btnSubtrair_Click);
            // 
            // btnDividir
            // 
            this.btnDividir.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDividir.Location = new System.Drawing.Point(114, 80);
            this.btnDividir.Margin = new System.Windows.Forms.Padding(2);
            this.btnDividir.Name = "btnDividir";
            this.btnDividir.Size = new System.Drawing.Size(45, 32);
            this.btnDividir.TabIndex = 4;
            this.btnDividir.Text = "/";
            this.btnDividir.UseVisualStyleBackColor = true;
            this.btnDividir.Click += new System.EventHandler(this.btnDividir_Click);
            // 
            // btnMultiplicar
            // 
            this.btnMultiplicar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMultiplicar.Location = new System.Drawing.Point(163, 80);
            this.btnMultiplicar.Margin = new System.Windows.Forms.Padding(2);
            this.btnMultiplicar.Name = "btnMultiplicar";
            this.btnMultiplicar.Size = new System.Drawing.Size(45, 32);
            this.btnMultiplicar.TabIndex = 5;
            this.btnMultiplicar.Text = "*";
            this.btnMultiplicar.UseVisualStyleBackColor = true;
            this.btnMultiplicar.Click += new System.EventHandler(this.btnMultiplicar_Click);
            // 
            // labelResultado
            // 
            this.labelResultado.AutoSize = true;
            this.labelResultado.ForeColor = System.Drawing.Color.Red;
            this.labelResultado.Location = new System.Drawing.Point(243, 37);
            this.labelResultado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelResultado.Name = "labelResultado";
            this.labelResultado.Size = new System.Drawing.Size(14, 13);
            this.labelResultado.TabIndex = 6;
            this.labelResultado.Text = "A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 24);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Número 1:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 45);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Número 2:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(181, 37);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Resultado:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(181, 33);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "x1:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 52);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Número \"B\":";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 26);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Número \"A\":";
            // 
            // textB
            // 
            this.textB.Location = new System.Drawing.Point(76, 49);
            this.textB.Margin = new System.Windows.Forms.Padding(2);
            this.textB.Name = "textB";
            this.textB.Size = new System.Drawing.Size(90, 20);
            this.textB.TabIndex = 7;
            // 
            // btnBask
            // 
            this.btnBask.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBask.Location = new System.Drawing.Point(13, 102);
            this.btnBask.Margin = new System.Windows.Forms.Padding(2);
            this.btnBask.Name = "btnBask";
            this.btnBask.Size = new System.Drawing.Size(244, 32);
            this.btnBask.TabIndex = 9;
            this.btnBask.Text = "Baskara";
            this.btnBask.UseVisualStyleBackColor = true;
            this.btnBask.Click += new System.EventHandler(this.btnBask_Click);
            // 
            // textA
            // 
            this.textA.Location = new System.Drawing.Point(76, 26);
            this.textA.Margin = new System.Windows.Forms.Padding(2);
            this.textA.Name = "textA";
            this.textA.Size = new System.Drawing.Size(90, 20);
            this.textA.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(5, 76);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "Número \"C\":";
            // 
            // textC
            // 
            this.textC.Location = new System.Drawing.Point(76, 73);
            this.textC.Margin = new System.Windows.Forms.Padding(2);
            this.textC.Name = "textC";
            this.textC.Size = new System.Drawing.Size(90, 20);
            this.textC.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(181, 73);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "x2:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnPotencia);
            this.groupBox1.Controls.Add(this.txtNumero2);
            this.groupBox1.Controls.Add(this.txtNumero1);
            this.groupBox1.Controls.Add(this.labelResultado);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btnSomar);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnSubtrair);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnDividir);
            this.groupBox1.Controls.Add(this.btnMultiplicar);
            this.groupBox1.Location = new System.Drawing.Point(6, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(271, 126);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Calculadora Comum";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.labelX1);
            this.groupBox2.Controls.Add(this.labelX2);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.btnBask);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.textB);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.textA);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.textC);
            this.groupBox2.Location = new System.Drawing.Point(6, 149);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(271, 134);
            this.groupBox2.TabIndex = 27;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Calculadora de Baskara";
            // 
            // labelX1
            // 
            this.labelX1.AutoSize = true;
            this.labelX1.ForeColor = System.Drawing.Color.Red;
            this.labelX1.Location = new System.Drawing.Point(206, 33);
            this.labelX1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(14, 13);
            this.labelX1.TabIndex = 26;
            this.labelX1.Text = "A";
            // 
            // labelX2
            // 
            this.labelX2.AutoSize = true;
            this.labelX2.ForeColor = System.Drawing.Color.Red;
            this.labelX2.Location = new System.Drawing.Point(206, 73);
            this.labelX2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(14, 13);
            this.labelX2.TabIndex = 25;
            this.labelX2.Text = "A";
            // 
            // btnPotencia
            // 
            this.btnPotencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPotencia.Location = new System.Drawing.Point(212, 80);
            this.btnPotencia.Margin = new System.Windows.Forms.Padding(2);
            this.btnPotencia.Name = "btnPotencia";
            this.btnPotencia.Size = new System.Drawing.Size(45, 32);
            this.btnPotencia.TabIndex = 10;
            this.btnPotencia.Text = "x*";
            this.btnPotencia.UseVisualStyleBackColor = true;
            this.btnPotencia.Click += new System.EventHandler(this.btnPotencia_Click);
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 290);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Calculator";
            this.Text = "Calculadora ";
            this.Load += new System.EventHandler(this.Calculator_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtNumero1;
        private System.Windows.Forms.Button btnSomar;
        private System.Windows.Forms.TextBox txtNumero2;
        private System.Windows.Forms.Button btnSubtrair;
        private System.Windows.Forms.Button btnDividir;
        private System.Windows.Forms.Button btnMultiplicar;
        private System.Windows.Forms.Label labelResultado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textB;
        private System.Windows.Forms.Button btnBask;
        private System.Windows.Forms.TextBox textA;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label labelX1;
        private System.Windows.Forms.Label labelX2;
        private System.Windows.Forms.Button btnPotencia;
    }
}