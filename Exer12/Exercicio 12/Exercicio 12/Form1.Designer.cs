﻿namespace Exercicio_12
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtsalMinimo = new System.Windows.Forms.TextBox();
            this.txtsalFuncionario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblQtdSalariominimo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 120);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Valor do Salario Minimo R$";
            // 
            // txtsalMinimo
            // 
            this.txtsalMinimo.Location = new System.Drawing.Point(152, 12);
            this.txtsalMinimo.Name = "txtsalMinimo";
            this.txtsalMinimo.Size = new System.Drawing.Size(63, 20);
            this.txtsalMinimo.TabIndex = 2;
            this.txtsalMinimo.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtsalFuncionario
            // 
            this.txtsalFuncionario.Location = new System.Drawing.Point(151, 45);
            this.txtsalFuncionario.Name = "txtsalFuncionario";
            this.txtsalFuncionario.Size = new System.Drawing.Size(63, 20);
            this.txtsalFuncionario.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Salario do  Funcionario R$";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Qtd de salario Minimo";
            // 
            // lblQtdSalariominimo
            // 
            this.lblQtdSalariominimo.AutoSize = true;
            this.lblQtdSalariominimo.Location = new System.Drawing.Point(149, 85);
            this.lblQtdSalariominimo.Name = "lblQtdSalariominimo";
            this.lblQtdSalariominimo.Size = new System.Drawing.Size(0, 13);
            this.lblQtdSalariominimo.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(248, 153);
            this.Controls.Add(this.lblQtdSalariominimo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtsalFuncionario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtsalMinimo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Exercicio12";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtsalMinimo;
        private System.Windows.Forms.TextBox txtsalFuncionario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblQtdSalariominimo;
    }
}

