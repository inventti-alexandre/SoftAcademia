namespace Frei.ProjetoIntegrador.Academia.Modulos.ControleDeEstoque
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtnomeprod = new System.Windows.Forms.TextBox();
            this.txtvalorvenda = new System.Windows.Forms.TextBox();
            this.txtvlcompra = new System.Windows.Forms.TextBox();
            this.txtqntprod = new System.Windows.Forms.TextBox();
            this.btncadastrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "quantidde de produto:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "nome do produto:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(231, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "valor de compra";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(236, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "valor de venda\r\n";
            // 
            // txtnomeprod
            // 
            this.txtnomeprod.Location = new System.Drawing.Point(125, 78);
            this.txtnomeprod.Name = "txtnomeprod";
            this.txtnomeprod.Size = new System.Drawing.Size(100, 20);
            this.txtnomeprod.TabIndex = 1;
            // 
            // txtvalorvenda
            // 
            this.txtvalorvenda.Location = new System.Drawing.Point(320, 78);
            this.txtvalorvenda.Name = "txtvalorvenda";
            this.txtvalorvenda.Size = new System.Drawing.Size(100, 20);
            this.txtvalorvenda.TabIndex = 1;
            // 
            // txtvlcompra
            // 
            this.txtvlcompra.Location = new System.Drawing.Point(320, 34);
            this.txtvlcompra.Name = "txtvlcompra";
            this.txtvlcompra.Size = new System.Drawing.Size(100, 20);
            this.txtvlcompra.TabIndex = 1;
            // 
            // txtqntprod
            // 
            this.txtqntprod.Location = new System.Drawing.Point(125, 34);
            this.txtqntprod.Name = "txtqntprod";
            this.txtqntprod.Size = new System.Drawing.Size(100, 20);
            this.txtqntprod.TabIndex = 1;
            // 
            // btncadastrar
            // 
            this.btncadastrar.Location = new System.Drawing.Point(272, 145);
            this.btncadastrar.Name = "btncadastrar";
            this.btncadastrar.Size = new System.Drawing.Size(75, 23);
            this.btncadastrar.TabIndex = 2;
            this.btncadastrar.Text = "cadastrar";
            this.btncadastrar.UseVisualStyleBackColor = true;
            // 
            // frmNovo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btncadastrar);
            this.Controls.Add(this.txtvlcompra);
            this.Controls.Add(this.txtqntprod);
            this.Controls.Add(this.txtvalorvenda);
            this.Controls.Add(this.txtnomeprod);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmNovo";
            this.Text = "frmNovo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtnomeprod;
        private System.Windows.Forms.TextBox txtvalorvenda;
        private System.Windows.Forms.TextBox txtvlcompra;
        private System.Windows.Forms.TextBox txtqntprod;
        private System.Windows.Forms.Button btncadastrar;
    }
}