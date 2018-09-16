namespace Frei.ProjetoIntegrador.Academia.Modulos.FluxoDeCaixa
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
            this.dtppedidovenda = new System.Windows.Forms.DateTimePicker();
            this.dtppedidocompra = new System.Windows.Forms.DateTimePicker();
            this.btncad = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "data do pedido de venda:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "data pedido de compra";
            // 
            // dtppedidovenda
            // 
            this.dtppedidovenda.Location = new System.Drawing.Point(176, 48);
            this.dtppedidovenda.Name = "dtppedidovenda";
            this.dtppedidovenda.Size = new System.Drawing.Size(200, 20);
            this.dtppedidovenda.TabIndex = 1;
            // 
            // dtppedidocompra
            // 
            this.dtppedidocompra.Location = new System.Drawing.Point(176, 108);
            this.dtppedidocompra.Name = "dtppedidocompra";
            this.dtppedidocompra.Size = new System.Drawing.Size(200, 20);
            this.dtppedidocompra.TabIndex = 1;
            // 
            // btncad
            // 
            this.btncad.Location = new System.Drawing.Point(442, 146);
            this.btncad.Name = "btncad";
            this.btncad.Size = new System.Drawing.Size(75, 23);
            this.btncad.TabIndex = 2;
            this.btncad.Text = "cadastrar";
            this.btncad.UseVisualStyleBackColor = true;
            // 
            // frmNovo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btncad);
            this.Controls.Add(this.dtppedidocompra);
            this.Controls.Add(this.dtppedidovenda);
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
        private System.Windows.Forms.DateTimePicker dtppedidovenda;
        private System.Windows.Forms.DateTimePicker dtppedidocompra;
        private System.Windows.Forms.Button btncad;
    }
}