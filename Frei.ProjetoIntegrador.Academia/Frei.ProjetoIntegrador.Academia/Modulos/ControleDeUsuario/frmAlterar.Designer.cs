namespace Frei.ProjetoIntegrador.Academia.Modulos.ControleDeUsuario
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnAlter = new System.Windows.Forms.Button();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.txtCod = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Frei.ProjetoIntegrador.Academia.Properties.Resources.logoAcademia;
            this.pictureBox1.Location = new System.Drawing.Point(32, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(175, 104);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 69;
            this.pictureBox1.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Impact", 14F, System.Drawing.FontStyle.Italic);
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(52, 119);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(128, 23);
            this.label11.TabIndex = 68;
            this.label11.Text = "Alterar Usuário";
            // 
            // btnAlter
            // 
            this.btnAlter.Font = new System.Drawing.Font("Impact", 14F, System.Drawing.FontStyle.Italic);
            this.btnAlter.ForeColor = System.Drawing.Color.Black;
            this.btnAlter.Location = new System.Drawing.Point(145, 284);
            this.btnAlter.Name = "btnAlter";
            this.btnAlter.Size = new System.Drawing.Size(92, 30);
            this.btnAlter.TabIndex = 67;
            this.btnAlter.Text = "Salvar";
            this.btnAlter.UseVisualStyleBackColor = true;
            // 
            // txtSenha
            // 
            this.txtSenha.Font = new System.Drawing.Font("High Tower Text", 14.25F);
            this.txtSenha.Location = new System.Drawing.Point(75, 191);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(162, 30);
            this.txtSenha.TabIndex = 66;
            this.txtSenha.UseSystemPasswordChar = true;
            // 
            // txtCod
            // 
            this.txtCod.Font = new System.Drawing.Font("High Tower Text", 14.25F);
            this.txtCod.Location = new System.Drawing.Point(14, 248);
            this.txtCod.Name = "txtCod";
            this.txtCod.Size = new System.Drawing.Size(223, 30);
            this.txtCod.TabIndex = 64;
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("High Tower Text", 14.25F);
            this.txtNome.Location = new System.Drawing.Point(75, 155);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(162, 30);
            this.txtNome.TabIndex = 65;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Impact", 14F, System.Drawing.FontStyle.Italic);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(10, 225);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(181, 23);
            this.label3.TabIndex = 61;
            this.label3.Text = "Código de Permissão:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Impact", 14F, System.Drawing.FontStyle.Italic);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(5, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 23);
            this.label2.TabIndex = 63;
            this.label2.Text = "Senha:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Impact", 14F, System.Drawing.FontStyle.Italic);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(10, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 23);
            this.label1.TabIndex = 62;
            this.label1.Text = "Nome:";
            // 
            // frmAlterar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Frei.ProjetoIntegrador.Academia.Properties.Resources.images__2_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(250, 334);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnAlter);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtCod);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmAlterar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Black Fit LTDA";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnAlter;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.TextBox txtCod;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}