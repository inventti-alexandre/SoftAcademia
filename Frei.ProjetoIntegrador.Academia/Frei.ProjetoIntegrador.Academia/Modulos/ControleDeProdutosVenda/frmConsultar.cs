using Frei.ProjetoIntegrador.Academia.DB.ProdutoVenda;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Frei.ProjetoIntegrador.Academia.Modulos.ControleDeProdutosVenda
{
    public partial class frmConsultar : Form
    {
        public frmConsultar()
        {
            InitializeComponent();
            CarregarGrid();
        }

        private void CarregarGrid()
        {
            ProdutoVendaBusiness business = new ProdutoVendaBusiness();
            List<ProdutoVendaDTO> produtos = business.Consultar();

            dgvProdutos.AutoGenerateColumns = false;
            dgvProdutos.DataSource = produtos;
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            frmCadastrar frm = new frmCadastrar();
            Hide();
            frm.ShowDialog();
            Show();
            CarregarGrid();
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            ProdutoVendaDTO dto = dgvProdutos.CurrentRow.DataBoundItem as ProdutoVendaDTO;

            ProdutoVendaBusiness business = new ProdutoVendaBusiness();
            business.RemoverProduto(dto.id_produtoVenda);

            MessageBox.Show("Produto Removido");
            CarregarGrid();
        }

        private void btnVisualisar_Click(object sender, EventArgs e)
        {
            ProdutoVendaDTO dto = dgvProdutos.CurrentRow.DataBoundItem as ProdutoVendaDTO;

            frmVisualisar frm = new frmVisualisar();
            Hide();
            frm.CarregarCampos(dto.id_produtoVenda);
            frm.ShowDialog();
            Show();
            CarregarGrid();
        }
    }
}
