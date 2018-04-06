namespace Elevador
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.labelAndarAtual = new System.Windows.Forms.Label();
            this.labelTotalAndares = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numericAndar = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSubir = new System.Windows.Forms.Button();
            this.btnDescer = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnEntrar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.numericPessoa = new System.Windows.Forms.NumericUpDown();
            this.btnDeslocar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDeslocar = new System.Windows.Forms.TextBox();
            this.labelCapacidade = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.labelPessoasAtual = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericAndar)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericPessoa)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Andar atual:";
            // 
            // labelAndarAtual
            // 
            this.labelAndarAtual.AutoSize = true;
            this.labelAndarAtual.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAndarAtual.ForeColor = System.Drawing.Color.Red;
            this.labelAndarAtual.Location = new System.Drawing.Point(94, 9);
            this.labelAndarAtual.Name = "labelAndarAtual";
            this.labelAndarAtual.Size = new System.Drawing.Size(14, 13);
            this.labelAndarAtual.TabIndex = 1;
            this.labelAndarAtual.Text = "A";
            // 
            // labelTotalAndares
            // 
            this.labelTotalAndares.AutoSize = true;
            this.labelTotalAndares.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalAndares.Location = new System.Drawing.Point(258, 9);
            this.labelTotalAndares.Name = "labelTotalAndares";
            this.labelTotalAndares.Size = new System.Drawing.Size(15, 13);
            this.labelTotalAndares.TabIndex = 3;
            this.labelTotalAndares.Text = "A";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(152, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Total de andares:";
            // 
            // numericAndar
            // 
            this.numericAndar.Location = new System.Drawing.Point(154, 72);
            this.numericAndar.Name = "numericAndar";
            this.numericAndar.Size = new System.Drawing.Size(80, 20);
            this.numericAndar.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Número de andares:";
            // 
            // btnSubir
            // 
            this.btnSubir.Location = new System.Drawing.Point(85, 98);
            this.btnSubir.Name = "btnSubir";
            this.btnSubir.Size = new System.Drawing.Size(122, 22);
            this.btnSubir.TabIndex = 6;
            this.btnSubir.Text = "Subir";
            this.btnSubir.UseVisualStyleBackColor = true;
            this.btnSubir.Click += new System.EventHandler(this.btnSubir_Click);
            // 
            // btnDescer
            // 
            this.btnDescer.Location = new System.Drawing.Point(85, 126);
            this.btnDescer.Name = "btnDescer";
            this.btnDescer.Size = new System.Drawing.Size(122, 22);
            this.btnDescer.TabIndex = 7;
            this.btnDescer.Text = "Descer";
            this.btnDescer.UseVisualStyleBackColor = true;
            this.btnDescer.Click += new System.EventHandler(this.btnDescer_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSair);
            this.groupBox1.Controls.Add(this.btnEntrar);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.numericPessoa);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(8, 221);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(264, 122);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Adicionar Pessoas";
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(78, 95);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(122, 22);
            this.btnSair.TabIndex = 11;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnEntrar
            // 
            this.btnEntrar.Location = new System.Drawing.Point(78, 67);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(122, 22);
            this.btnEntrar.TabIndex = 10;
            this.btnEntrar.Text = "Entrar";
            this.btnEntrar.UseVisualStyleBackColor = true;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Número de pessoas:";
            // 
            // numericPessoa
            // 
            this.numericPessoa.Location = new System.Drawing.Point(147, 32);
            this.numericPessoa.Name = "numericPessoa";
            this.numericPessoa.Size = new System.Drawing.Size(80, 20);
            this.numericPessoa.TabIndex = 8;
            // 
            // btnDeslocar
            // 
            this.btnDeslocar.Location = new System.Drawing.Point(85, 188);
            this.btnDeslocar.Name = "btnDeslocar";
            this.btnDeslocar.Size = new System.Drawing.Size(122, 22);
            this.btnDeslocar.TabIndex = 10;
            this.btnDeslocar.Text = "Deslocar";
            this.btnDeslocar.UseVisualStyleBackColor = true;
            this.btnDeslocar.Click += new System.EventHandler(this.btnDeslocar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Deslocar para andar:";
            // 
            // txtDeslocar
            // 
            this.txtDeslocar.Location = new System.Drawing.Point(154, 161);
            this.txtDeslocar.Name = "txtDeslocar";
            this.txtDeslocar.Size = new System.Drawing.Size(80, 20);
            this.txtDeslocar.TabIndex = 11;
            // 
            // labelCapacidade
            // 
            this.labelCapacidade.AutoSize = true;
            this.labelCapacidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCapacidade.Location = new System.Drawing.Point(258, 39);
            this.labelCapacidade.Name = "labelCapacidade";
            this.labelCapacidade.Size = new System.Drawing.Size(15, 13);
            this.labelCapacidade.TabIndex = 15;
            this.labelCapacidade.Text = "A";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(152, 39);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Capacidade total:";
            // 
            // labelPessoasAtual
            // 
            this.labelPessoasAtual.AutoSize = true;
            this.labelPessoasAtual.ForeColor = System.Drawing.Color.Red;
            this.labelPessoasAtual.Location = new System.Drawing.Point(94, 39);
            this.labelPessoasAtual.Name = "labelPessoasAtual";
            this.labelPessoasAtual.Size = new System.Drawing.Size(14, 13);
            this.labelPessoasAtual.TabIndex = 13;
            this.labelPessoasAtual.Text = "A";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, 39);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "Pessoas:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 350);
            this.Controls.Add(this.labelCapacidade);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.labelPessoasAtual);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtDeslocar);
            this.Controls.Add(this.btnDeslocar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnDescer);
            this.Controls.Add(this.btnSubir);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numericAndar);
            this.Controls.Add(this.labelTotalAndares);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelAndarAtual);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Elevador";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericAndar)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericPessoa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelAndarAtual;
        private System.Windows.Forms.Label labelTotalAndares;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericAndar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSubir;
        private System.Windows.Forms.Button btnDescer;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnEntrar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericPessoa;
        private System.Windows.Forms.Button btnDeslocar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDeslocar;
        private System.Windows.Forms.Label labelCapacidade;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelPessoasAtual;
        private System.Windows.Forms.Label label9;
    }
}

