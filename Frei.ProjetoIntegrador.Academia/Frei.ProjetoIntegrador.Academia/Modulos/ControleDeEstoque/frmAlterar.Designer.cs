namespace Frei.ProjetoIntegrador.Academia.Modulos.ControleDeEstoque
{
    partial class frmAlterar
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
            this.btnalvar = new System.Windows.Forms.Button();
            this.txtvalordecompra = new System.Windows.Forms.TextBox();
            this.txtqntproduto = new System.Windows.Forms.TextBox();
            this.txtvalordevenda = new System.Windows.Forms.TextBox();
            this.txtnomeprod = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnalvar
            // 
            this.btnalvar.Location = new System.Drawing.Point(283, 135);
            this.btnalvar.Name = "btnalvar";
            this.btnalvar.Size = new System.Drawing.Size(75, 23);
            this.btnalvar.TabIndex = 11;
            this.btnalvar.Text = "salvar";
            this.btnalvar.UseVisualStyleBackColor = true;
            // 
            // txtvalordecompra
            // 
            this.txtvalordecompra.Location = new System.Drawing.Point(331, 24);
            this.txtvalordecompra.Name = "txtvalordecompra";
            this.txtvalordecompra.Size = new System.Drawing.Size(100, 20);
            this.txtvalordecompra.TabIndex = 7;
            // 
            // txtqntproduto
            // 
            this.txtqntproduto.Location = new System.Drawing.Point(136, 24);
            this.txtqntproduto.Name = "txtqntproduto";
            this.txtqntproduto.Size = new System.Drawing.Size(100, 20);
            this.txtqntproduto.TabIndex = 8;
            // 
            // txtvalordevenda
            // 
            this.txtvalordevenda.Location = new System.Drawing.Point(331, 68);
            this.txtvalordevenda.Name = "txtvalordevenda";
            this.txtvalordevenda.Size = new System.Drawing.Size(100, 20);
            this.txtvalordevenda.TabIndex = 9;
            // 
            // txtnomeprod
            // 
            this.txtnomeprod.Location = new System.Drawing.Point(136, 68);
            this.txtnomeprod.Name = "txtnomeprod";
            this.txtnomeprod.Size = new System.Drawing.Size(100, 20);
            this.txtnomeprod.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(247, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "valor de venda\r\n";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(242, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "valor de compra";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "nome do produto:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "quantidde de produto:";
            // 
            // frmAlterar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnalvar);
            this.Controls.Add(this.txtvalordecompra);
            this.Controls.Add(this.txtqntproduto);
            this.Controls.Add(this.txtvalordevenda);
            this.Controls.Add(this.txtnomeprod);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmAlterar";
            this.Text = "frmAlterar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnalvar;
        private System.Windows.Forms.TextBox txtvalordecompra;
        private System.Windows.Forms.TextBox txtqntproduto;
        private System.Windows.Forms.TextBox txtvalordevenda;
        private System.Windows.Forms.TextBox txtnomeprod;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}