namespace Frei.ProjetoIntegrador.Academia.Modulos.ControleDeProdutos
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
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtnmproduto = new System.Windows.Forms.TextBox();
            this.txtnmfornecedor = new System.Windows.Forms.TextBox();
            this.txtcnpjfornecedor = new System.Windows.Forms.TextBox();
            this.txtqntprod = new System.Windows.Forms.TextBox();
            this.txtnumfornecedor = new System.Windows.Forms.TextBox();
            this.txtemailfornecedor = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "nome do produto:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "nome do fornecedor:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(296, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "quantidade de produto:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(296, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(170, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "número do telefone do fornecedor:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(55, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "CNPJ do fornecedor:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(296, 190);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "email do forneccedor:";
            // 
            // txtnmproduto
            // 
            this.txtnmproduto.Location = new System.Drawing.Point(168, 77);
            this.txtnmproduto.Name = "txtnmproduto";
            this.txtnmproduto.Size = new System.Drawing.Size(100, 20);
            this.txtnmproduto.TabIndex = 1;
            // 
            // txtnmfornecedor
            // 
            this.txtnmfornecedor.Location = new System.Drawing.Point(166, 122);
            this.txtnmfornecedor.Name = "txtnmfornecedor";
            this.txtnmfornecedor.Size = new System.Drawing.Size(100, 20);
            this.txtnmfornecedor.TabIndex = 1;
            // 
            // txtcnpjfornecedor
            // 
            this.txtcnpjfornecedor.Location = new System.Drawing.Point(168, 174);
            this.txtcnpjfornecedor.Name = "txtcnpjfornecedor";
            this.txtcnpjfornecedor.Size = new System.Drawing.Size(100, 20);
            this.txtcnpjfornecedor.TabIndex = 1;
            // 
            // txtqntprod
            // 
            this.txtqntprod.Location = new System.Drawing.Point(472, 87);
            this.txtqntprod.Name = "txtqntprod";
            this.txtqntprod.Size = new System.Drawing.Size(100, 20);
            this.txtqntprod.TabIndex = 1;
            // 
            // txtnumfornecedor
            // 
            this.txtnumfornecedor.Location = new System.Drawing.Point(472, 131);
            this.txtnumfornecedor.Name = "txtnumfornecedor";
            this.txtnumfornecedor.Size = new System.Drawing.Size(100, 20);
            this.txtnumfornecedor.TabIndex = 1;
            // 
            // txtemailfornecedor
            // 
            this.txtemailfornecedor.Location = new System.Drawing.Point(472, 183);
            this.txtemailfornecedor.Name = "txtemailfornecedor";
            this.txtemailfornecedor.Size = new System.Drawing.Size(100, 20);
            this.txtemailfornecedor.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(618, 253);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "cadastrar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // frmNovo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtemailfornecedor);
            this.Controls.Add(this.txtnumfornecedor);
            this.Controls.Add(this.txtqntprod);
            this.Controls.Add(this.txtcnpjfornecedor);
            this.Controls.Add(this.txtnmfornecedor);
            this.Controls.Add(this.txtnmproduto);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
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
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtnmproduto;
        private System.Windows.Forms.TextBox txtnmfornecedor;
        private System.Windows.Forms.TextBox txtcnpjfornecedor;
        private System.Windows.Forms.TextBox txtqntprod;
        private System.Windows.Forms.TextBox txtnumfornecedor;
        private System.Windows.Forms.TextBox txtemailfornecedor;
        private System.Windows.Forms.Button button1;
    }
}