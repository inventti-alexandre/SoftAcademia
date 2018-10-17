namespace Frei.ProjetoIntegrador.Academia.Modulos.ControleDeProdutosVenda
{
    partial class frmConsultar
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
            this.dgvProdutos = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnVisualisar = new System.Windows.Forms.Button();
            this.btnRemover = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvProdutos
            // 
            this.dgvProdutos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dgvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvProdutos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dgvProdutos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvProdutos.Location = new System.Drawing.Point(12, 136);
            this.dgvProdutos.Name = "dgvProdutos";
            this.dgvProdutos.RowHeadersVisible = false;
            this.dgvProdutos.Size = new System.Drawing.Size(524, 284);
            this.dgvProdutos.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.DataPropertyName = "nm_Produto";
            this.Column1.HeaderText = "Produto";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "vl_Venda";
            this.Column2.HeaderText = "Valor";
            this.Column2.Name = "Column2";
            // 
            // btnVisualisar
            // 
            this.btnVisualisar.Location = new System.Drawing.Point(12, 426);
            this.btnVisualisar.Name = "btnVisualisar";
            this.btnVisualisar.Size = new System.Drawing.Size(75, 23);
            this.btnVisualisar.TabIndex = 1;
            this.btnVisualisar.Text = "Visualisar";
            this.btnVisualisar.UseVisualStyleBackColor = true;
            this.btnVisualisar.Click += new System.EventHandler(this.btnVisualisar_Click);
            // 
            // btnRemover
            // 
            this.btnRemover.Location = new System.Drawing.Point(93, 426);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(75, 23);
            this.btnRemover.TabIndex = 1;
            this.btnRemover.Text = "Remover";
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(461, 426);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(75, 23);
            this.btnNovo.TabIndex = 1;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // frmConsultar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 463);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.btnVisualisar);
            this.Controls.Add(this.dgvProdutos);
            this.Name = "frmConsultar";
            this.Text = "frmConsultar";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProdutos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Button btnVisualisar;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.Button btnNovo;
    }
}