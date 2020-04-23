namespace Exercicio20
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
            this.button1 = new System.Windows.Forms.Button();
            this.txtDistancia = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtAngulo30 = new System.Windows.Forms.RadioButton();
            this.rbtAngulo45 = new System.Windows.Forms.RadioButton();
            this.rbtAngulo60 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(259, 128);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtDistancia
            // 
            this.txtDistancia.Location = new System.Drawing.Point(390, 13);
            this.txtDistancia.Name = "txtDistancia";
            this.txtDistancia.Size = new System.Drawing.Size(100, 20);
            this.txtDistancia.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(171, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(216, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Inforne a Distancia entre a escade a Parede";
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(391, 81);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(55, 13);
            this.lblResultado.TabIndex = 5;
            this.lblResultado.Text = "Resultado";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(173, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Medida da escada em M:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtAngulo60);
            this.groupBox1.Controls.Add(this.rbtAngulo45);
            this.groupBox1.Controls.Add(this.rbtAngulo30);
            this.groupBox1.Location = new System.Drawing.Point(6, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(144, 107);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // rbtAngulo30
            // 
            this.rbtAngulo30.AutoSize = true;
            this.rbtAngulo30.Location = new System.Drawing.Point(7, 13);
            this.rbtAngulo30.Name = "rbtAngulo30";
            this.rbtAngulo30.Size = new System.Drawing.Size(102, 17);
            this.rbtAngulo30.TabIndex = 0;
            this.rbtAngulo30.TabStop = true;
            this.rbtAngulo30.Text = "Ângulo 30 graus";
            this.rbtAngulo30.UseVisualStyleBackColor = true;
            // 
            // rbtAngulo45
            // 
            this.rbtAngulo45.AutoSize = true;
            this.rbtAngulo45.Location = new System.Drawing.Point(7, 39);
            this.rbtAngulo45.Name = "rbtAngulo45";
            this.rbtAngulo45.Size = new System.Drawing.Size(102, 17);
            this.rbtAngulo45.TabIndex = 1;
            this.rbtAngulo45.TabStop = true;
            this.rbtAngulo45.Text = "Ângulo 45 graus";
            this.rbtAngulo45.UseVisualStyleBackColor = true;
            // 
            // rbtAngulo60
            // 
            this.rbtAngulo60.AutoSize = true;
            this.rbtAngulo60.Location = new System.Drawing.Point(7, 66);
            this.rbtAngulo60.Name = "rbtAngulo60";
            this.rbtAngulo60.Size = new System.Drawing.Size(102, 17);
            this.rbtAngulo60.TabIndex = 2;
            this.rbtAngulo60.TabStop = true;
            this.rbtAngulo60.Text = "Ângulo 60 graus";
            this.rbtAngulo60.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Selecione o Ângulo Desejado";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(415, 128);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "Sair";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 164);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.txtDistancia);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtDistancia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtAngulo60;
        private System.Windows.Forms.RadioButton rbtAngulo45;
        private System.Windows.Forms.RadioButton rbtAngulo30;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
    }
}

