namespace Frei.ProjetoIntegrador.Academia.Modulos.ControleDeProdutosVenda
{
    partial class frmVisualisar
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
            this.dtpValidade = new System.Windows.Forms.DateTimePicker();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtFilial = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // dtpValidade
            // 
            this.dtpValidade.Location = new System.Drawing.Point(100, 138);
            this.dtpValidade.Name = "dtpValidade";
            this.dtpValidade.Size = new System.Drawing.Size(226, 20);
            this.dtpValidade.TabIndex = 12;
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(100, 112);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(226, 20);
            this.txtValor.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(2, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Data de Validade:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Valor:";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(100, 86);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(226, 20);
            this.txtDescricao.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Descrição:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(100, 60);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(226, 20);
            this.txtNome.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nome:";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(244, 217);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(82, 29);
            this.btnSalvar.TabIndex = 4;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(273, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Id:";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(298, 44);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(13, 13);
            this.lblId.TabIndex = 8;
            this.lblId.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(56, 194);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Filial:";
            // 
            // txtFilial
            // 
            this.txtFilial.Enabled = false;
            this.txtFilial.Location = new System.Drawing.Point(100, 191);
            this.txtFilial.Name = "txtFilial";
            this.txtFilial.Size = new System.Drawing.Size(226, 20);
            this.txtFilial.TabIndex = 11;
            // 
            // frmVisualisar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 258);
            this.Controls.Add(this.dtpValidade);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtFilial);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSalvar);
            this.Name = "frmVisualisar";
            this.Text = "frmVisualisar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpValidade;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtFilial;
    }
}