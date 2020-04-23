namespace Exercicio_24
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
            this.txtQtdDinheiro = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtlibraEstelina = new System.Windows.Forms.RadioButton();
            this.rbtmarcoAlemao = new System.Windows.Forms.RadioButton();
            this.rbtDolar = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.lblValorConvertido = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Digite a quantidade de dinheiro para viagen RS";
            // 
            // txtQtdDinheiro
            // 
            this.txtQtdDinheiro.Location = new System.Drawing.Point(246, 16);
            this.txtQtdDinheiro.Name = "txtQtdDinheiro";
            this.txtQtdDinheiro.Size = new System.Drawing.Size(63, 20);
            this.txtQtdDinheiro.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtlibraEstelina);
            this.groupBox1.Controls.Add(this.rbtmarcoAlemao);
            this.groupBox1.Controls.Add(this.rbtDolar);
            this.groupBox1.Location = new System.Drawing.Point(15, 69);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(218, 104);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // rbtlibraEstelina
            // 
            this.rbtlibraEstelina.AutoSize = true;
            this.rbtlibraEstelina.Location = new System.Drawing.Point(17, 65);
            this.rbtlibraEstelina.Name = "rbtlibraEstelina";
            this.rbtlibraEstelina.Size = new System.Drawing.Size(91, 17);
            this.rbtlibraEstelina.TabIndex = 2;
            this.rbtlibraEstelina.TabStop = true;
            this.rbtlibraEstelina.Text = "Libra Esterlina";
            this.rbtlibraEstelina.UseVisualStyleBackColor = true;
            this.rbtlibraEstelina.CheckedChanged += new System.EventHandler(this.rbtlibraEstelina_CheckedChanged);
            // 
            // rbtmarcoAlemao
            // 
            this.rbtmarcoAlemao.AutoSize = true;
            this.rbtmarcoAlemao.Location = new System.Drawing.Point(17, 42);
            this.rbtmarcoAlemao.Name = "rbtmarcoAlemao";
            this.rbtmarcoAlemao.Size = new System.Drawing.Size(93, 17);
            this.rbtmarcoAlemao.TabIndex = 1;
            this.rbtmarcoAlemao.TabStop = true;
            this.rbtmarcoAlemao.Text = "Marco Alemão";
            this.rbtmarcoAlemao.UseVisualStyleBackColor = true;
            this.rbtmarcoAlemao.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // rbtDolar
            // 
            this.rbtDolar.AutoSize = true;
            this.rbtDolar.Location = new System.Drawing.Point(17, 19);
            this.rbtDolar.Name = "rbtDolar";
            this.rbtDolar.Size = new System.Drawing.Size(50, 17);
            this.rbtDolar.TabIndex = 0;
            this.rbtDolar.TabStop = true;
            this.rbtDolar.Text = "Dolar";
            this.rbtDolar.UseVisualStyleBackColor = true;
            this.rbtDolar.CheckedChanged += new System.EventHandler(this.rbtDolar_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(298, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Selecione  o tipo de dinheiro para conversão";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(234, 220);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Sair";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblValorConvertido
            // 
            this.lblValorConvertido.AutoSize = true;
            this.lblValorConvertido.Font = new System.Drawing.Font("MV Boli", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorConvertido.ForeColor = System.Drawing.Color.Lime;
            this.lblValorConvertido.Location = new System.Drawing.Point(158, 176);
            this.lblValorConvertido.Name = "lblValorConvertido";
            this.lblValorConvertido.Size = new System.Drawing.Size(72, 31);
            this.lblValorConvertido.TabIndex = 6;
            this.lblValorConvertido.Text = "valor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Total   já convertido R$";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(32, 220);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Converter";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 292);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblValorConvertido);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtQtdDinheiro);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtQtdDinheiro;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtlibraEstelina;
        private System.Windows.Forms.RadioButton rbtmarcoAlemao;
        private System.Windows.Forms.RadioButton rbtDolar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblValorConvertido;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
    }
}

