using Frei.ProjetoIntegrador.Academia.DB.ProdutoCompra;
using Frei.ProjetoIntegrador.Academia.DB.Usuario;
using Nsf._2018.Modulo3.App;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Frei.ProjetoIntegrador.Academia.Modulos.ControleDeProdutos
{
    public partial class frmConsultar : Form
    {
        public frmConsultar()
        {
            InitializeComponent();
            CarregarGrid();
        }

        public void CarregarGrid()
        {
            ProdutoCompraBusiness business = new ProdutoCompraBusiness();
            List<view_produtoCompra_Forn_Filial> produtos = business.Consultar();

            dgvProdutos.AutoGenerateColumns = false;
            dgvProdutos.DataSource = produtos;
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            frmNovo frm = new frmNovo();
            Hide();
            frm.ShowDialog();
            CarregarGrid();
            Show();
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            try
            {
                UsuarioDTO user = UserSession.UsuarioLogado;

                UsuarioPermissoes chamar = new UsuarioPermissoes();
                UsuarioPermissoes permissoes = chamar.Permissoes(user.Cod_Perm);

                if (permissoes.Produto.Substring(0, 1) == "0")
                {
                    if (permissoes.Produto.Substring(4, 1) == "0")
                        throw new ArgumentException("Você não tem autorização para fazer isto!");
                }

                view_produtoCompra_Forn_Filial data = dgvProdutos.CurrentRow.DataBoundItem as view_produtoCompra_Forn_Filial;

                ProdutoCompraBusiness business = new ProdutoCompraBusiness();
                business.RemoverProduto(data.id_Produto);

                MessageBox.Show("Produto Removido com Sucesso!", "Black Fit LTDA", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Black Fit LTDA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro não identificado.", "Black Fit LTDA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
