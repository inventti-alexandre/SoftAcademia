﻿namespace Frei.ProjetoIntegrador.Academia.Modulos.ControleDeCompra
{
    partial class frmNovo
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
            this.dtpdatadecompra = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtnomeusu = new System.Windows.Forms.TextBox();
            this.txtsenhausu = new System.Windows.Forms.TextBox();
            this.btncadastro = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "data da compra:";
            // 
            // dtpdatadecompra
            // 
            this.dtpdatadecompra.Location = new System.Drawing.Point(133, 25);
            this.dtpdatadecompra.Name = "dtpdatadecompra";
            this.dtpdatadecompra.Size = new System.Drawing.Size(200, 20);
            this.dtpdatadecompra.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "senha do usuário:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "nome do usário:";
            this.label3.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtnomeusu
            // 
            this.txtnomeusu.Location = new System.Drawing.Point(133, 67);
            this.txtnomeusu.Name = "txtnomeusu";
            this.txtnomeusu.Size = new System.Drawing.Size(100, 20);
            this.txtnomeusu.TabIndex = 2;
            // 
            // txtsenhausu
            // 
            this.txtsenhausu.Location = new System.Drawing.Point(133, 110);
            this.txtsenhausu.Name = "txtsenhausu";
            this.txtsenhausu.Size = new System.Drawing.Size(100, 20);
            this.txtsenhausu.TabIndex = 2;
            // 
            // btncadastro
            // 
            this.btncadastro.Location = new System.Drawing.Point(271, 154);
            this.btncadastro.Name = "btncadastro";
            this.btncadastro.Size = new System.Drawing.Size(75, 23);
            this.btncadastro.TabIndex = 3;
            this.btncadastro.Text = "cadastrar";
            this.btncadastro.UseVisualStyleBackColor = true;
            // 
            // frmNovo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btncadastro);
            this.Controls.Add(this.txtsenhausu);
            this.Controls.Add(this.txtnomeusu);
            this.Controls.Add(this.dtpdatadecompra);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmNovo";
            this.Text = "cadastrar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpdatadecompra;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtnomeusu;
        private System.Windows.Forms.TextBox txtsenhausu;
        private System.Windows.Forms.Button btncadastro;
    }
}