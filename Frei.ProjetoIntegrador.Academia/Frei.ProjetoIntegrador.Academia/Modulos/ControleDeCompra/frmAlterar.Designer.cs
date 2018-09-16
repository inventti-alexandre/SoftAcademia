namespace Frei.ProjetoIntegrador.Academia.Modulos.ControleDeCompra
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
            this.txtsenhausu = new System.Windows.Forms.TextBox();
            this.txtnomeusu = new System.Windows.Forms.TextBox();
            this.dtpdatadecompra = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnsalvar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtsenhausu
            // 
            this.txtsenhausu.Location = new System.Drawing.Point(154, 126);
            this.txtsenhausu.Name = "txtsenhausu";
            this.txtsenhausu.Size = new System.Drawing.Size(100, 20);
            this.txtsenhausu.TabIndex = 7;
            // 
            // txtnomeusu
            // 
            this.txtnomeusu.Location = new System.Drawing.Point(154, 83);
            this.txtnomeusu.Name = "txtnomeusu";
            this.txtnomeusu.Size = new System.Drawing.Size(100, 20);
            this.txtnomeusu.TabIndex = 8;
            // 
            // dtpdatadecompra
            // 
            this.dtpdatadecompra.Location = new System.Drawing.Point(154, 41);
            this.dtpdatadecompra.Name = "dtpdatadecompra";
            this.dtpdatadecompra.Size = new System.Drawing.Size(200, 20);
            this.dtpdatadecompra.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "nome do usário:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "senha do usuário:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "data da compra:";
            // 
            // btnsalvar
            // 
            this.btnsalvar.Location = new System.Drawing.Point(292, 144);
            this.btnsalvar.Name = "btnsalvar";
            this.btnsalvar.Size = new System.Drawing.Size(75, 23);
            this.btnsalvar.TabIndex = 9;
            this.btnsalvar.Text = "salvar\r\n";
            this.btnsalvar.UseVisualStyleBackColor = true;
            // 
            // frmAlterar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnsalvar);
            this.Controls.Add(this.txtsenhausu);
            this.Controls.Add(this.txtnomeusu);
            this.Controls.Add(this.dtpdatadecompra);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmAlterar";
            this.Text = "frmAlterar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtsenhausu;
        private System.Windows.Forms.TextBox txtnomeusu;
        private System.Windows.Forms.DateTimePicker dtpdatadecompra;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnsalvar;
    }
}