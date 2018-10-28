using Blibioteca.Developers.APIs.Clima;
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

namespace Frei.ProjetoIntegrador.Academia
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
            Permissoes();
            Clima();
        }

        private void Permissoes()
        {
            UsuarioDTO user = UserSession.UsuarioLogado;
            lblBV.Text = $"Bem vindo, {user.nm_Usuario}.";

            UsuarioPermissoes chamar = new UsuarioPermissoes();
            UsuarioPermissoes permissoes = chamar.Permissoes(user.Cod_Perm);

            if (permissoes.Cliente.Substring(0, 1) == "0")
            {
                if (permissoes.Cliente.Substring(1, 1) == "0")
                {
                    cadastrarToolStripMenuItem6.Enabled = false;
                }

                if (permissoes.Cliente.Substring(2, 1) == "0")
                {
                    novoToolStripMenuItem2.Enabled = false;
                    btnCliente.Enabled = false;
                }
            }

            if (permissoes.Funcionario.Substring(0, 1) == "0")
            {
                if (permissoes.Funcionario.Substring(1, 1) == "0")
                {
                    cadastrarToolStripMenuItem7.Enabled = false;
                }

                if (permissoes.Funcionario.Substring(2, 1) == "0")
                {
                    consultarToolStripMenuItem8.Enabled = false;
                    btnFunc.Enabled = false;
                }
            }

            if (permissoes.Usuario.Substring(0, 1) == "0")
            {
                if (permissoes.Usuario.Substring(1, 1) == "0")
                {
                    cadastarToolStripMenuItem.Enabled = false;
                }

                if (permissoes.Usuario.Substring(2, 1) == "0")
                {
                    consultarToolStripMenuItem9.Enabled = false;
                    btnUsu.Enabled = false;
                }
            }

            if (permissoes.Aulas.Substring(0, 1) == "0")
            {

                if (permissoes.Aulas.Substring(1, 1) == "0")
                {
                    cadastrarToolStripMenuItem4.Enabled = false;
                }

                if (permissoes.Aulas.Substring(2, 1) == "0")
                {
                    consultarToolStripMenuItem6.Enabled = false;
                    btnAula.Enabled = false;
                }
            }

            if (permissoes.Produto.Substring(0, 1) == "0")
            {
                if (permissoes.Produto.Substring(1, 1) == "0")
                {
                    cadastrarToolStripMenuItem9.Enabled = false;
                }

                if (permissoes.Produto.Substring(2, 1) == "0")
                {
                    consultarToolStripMenuItem11.Enabled = false;
                }
            }

            if (permissoes.Compra.Substring(0, 1) == "0")
            {
                if (permissoes.Compra.Substring(1, 1) == "0")
                {
                    cadastrarToolStripMenuItem1.Enabled = false;
                }

                if (permissoes.Compra.Substring(2, 1) == "0")
                {
                    consultarToolStripMenuItem1.Enabled = false;
                    btnComprar.Enabled = false;
                }
            }

            if (permissoes.Venda.Substring(0, 1) == "0")
            {
                if (permissoes.Venda.Substring(1, 1) == "0")
                {
                    cadastrarToolStripMenuItem2.Enabled = false;
                }

                if (permissoes.Venda.Substring(2, 1) == "0")
                {
                    consultarToolStripMenuItem2.Enabled = false;
                    btnVender.Enabled = false;
                }
            }

            if (permissoes.Estoque.Substring(0, 1) == "0")
            {
                if (permissoes.Estoque.Substring(2, 1) == "0")
                {
                    estoqueToolStripMenuItem.Enabled = false;
                }
            }

            if (permissoes.Fornecedor.Substring(0, 1) == "0")
            {
                if (permissoes.Fornecedor.Substring(1, 1) == "0")
                {
                    cadastrarToolStripMenuItem5.Enabled = false;
                }

                if (permissoes.Fornecedor.Substring(2, 1) == "0")
                {
                    consultarToolStripMenuItem7.Enabled = false;
                    btnFornecedores.Enabled = false;
                }
            }

            if (permissoes.FluxoDeCaixa.Substring(0, 1) == "0")
            {
                if (permissoes.FluxoDeCaixa.Substring(2, 1) == "0")
                {
                    consultarToolStripMenuItem4.Enabled = false;
                }
            }

            if (permissoes.FolhaDePgmt.Substring(0, 1) == "0")
            {
                if (permissoes.FolhaDePgmt.Substring(1, 1) == "0")
                {
                    novoToolStripMenuItem1.Enabled = false;
                }

                if (permissoes.FolhaDePgmt.Substring(2, 1) == "0")
                {
                    consultarToolStripMenuItem5.Enabled = false;
                }
            }
        } 

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void btnAulas_Click(object sender, EventArgs e)
        {
            Modulos.ControleDeAulas.frmConsultar frm = new Modulos.ControleDeAulas.frmConsultar();
            Hide();
            frm.ShowDialog();
            Show();
            Permissoes();
        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Modulos.ControleDeAulas.frmConsultar frm = new Modulos.ControleDeAulas.frmConsultar();
            Hide();
            frm.ShowDialog();
            Show();
            Permissoes();
        }

        private void adicionarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Modulos.ControleDeAulas.frmNovo frm = new Modulos.ControleDeAulas.frmNovo();
            Hide();
            frm.ShowDialog();
            Show();
            Permissoes();
        }

        private void cadastrarToolStripMenuItem6_Click(object sender, EventArgs e)
        {
            Modulos.ControleDeCliente.frmNovo frm = new Modulos.ControleDeCliente.frmNovo();
            Hide();
            frm.ShowDialog();
            Show();
            Permissoes();
        }

        private void novoToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Modulos.ControleDeCliente.frmConsultar frm = new Modulos.ControleDeCliente.frmConsultar();
            Hide();
            frm.ShowDialog();
            Show();
            Permissoes();
        }

        private void cadastrarToolStripMenuItem7_Click(object sender, EventArgs e)
        {
            Modulos.ControleDeFuncionario.frmNovo frm = new Modulos.ControleDeFuncionario.frmNovo();
            Hide();
            frm.ShowDialog();
            Show();
            Permissoes();
        }

        private void consultarToolStripMenuItem8_Click(object sender, EventArgs e)
        {
            Modulos.ControleDeFuncionario.frmConsultar frm = new Modulos.ControleDeFuncionario.frmConsultar();
            Hide();
            frm.ShowDialog();
            Show();
            Permissoes();
        }

        private void cadastarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Modulos.ControleDeUsuario.frmNovo frm = new Modulos.ControleDeUsuario.frmNovo();
            Hide();
            frm.ShowDialog();
            Show();
            Permissoes();
        }

        private void consultarToolStripMenuItem9_Click(object sender, EventArgs e)
        {
            Modulos.ControleDeUsuario.frmConsultar frm = new Modulos.ControleDeUsuario.frmConsultar();
            Hide();
            frm.ShowDialog();
            Show();
            Permissoes();
        }

        private void consultarToolStripMenuItem6_Click(object sender, EventArgs e)
        {
            Modulos.ControleDeAulas.frmConsultar frm = new Modulos.ControleDeAulas.frmConsultar();
            Hide();
            frm.ShowDialog();
            Show();
            Permissoes();
        }

        private void cadastrarToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            Modulos.ControleDeAulas.frmNovo frm = new Modulos.ControleDeAulas.frmNovo();
            Hide();
            frm.ShowDialog();
            Show();
            Permissoes();
        }

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Modulos.ControleDeProdutos.frmNovo frm = new Modulos.ControleDeProdutos.frmNovo();
            Hide();
            frm.ShowDialog();
            Show();
            Permissoes();
        }

        private void consultarToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Modulos.ControleDeProdutos.frmConsultar frm = new Modulos.ControleDeProdutos.frmConsultar();
            Hide();
            frm.ShowDialog();
            Show();
            Permissoes();
        }

        private void cadastrarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Modulos.ControleDeCompra.frmNovo frm = new Modulos.ControleDeCompra.frmNovo();
            Hide();
            frm.ShowDialog();
            Show();
            Permissoes();
        }

        private void consultarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Modulos.ControleDeCompra.frmConsultar frm = new Modulos.ControleDeCompra.frmConsultar();
            Hide();
            frm.ShowDialog();
            Show();
            Permissoes();
        }

        private void cadastrarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Modulos.ControleDeVenda.frmNovo frm = new Modulos.ControleDeVenda.frmNovo();
            Hide();
            frm.ShowDialog();
            Show();
            Permissoes();
        }

        private void consultarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Modulos.ControleDeVenda.frmConsultar frm = new Modulos.ControleDeVenda.frmConsultar();
            Hide();
            frm.ShowDialog();
            Show();
            Permissoes();
        }

        private void consultarToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Modulos.ControleDeEstoque.frmConsultar frm = new Modulos.ControleDeEstoque.frmConsultar();
            Hide();
            frm.ShowDialog();
            Show();
            Permissoes();
        }

        private void cadastrarToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            Modulos.ControleDeFornecedor.frmNovo frm = new Modulos.ControleDeFornecedor.frmNovo();
            Hide();
            frm.ShowDialog();
            Show();
            Permissoes();
        }

        private void consultarToolStripMenuItem7_Click(object sender, EventArgs e)
        {
            Modulos.ControleDeFornecedor.frmConsultar frm = new Modulos.ControleDeFornecedor.frmConsultar();
            Hide();
            frm.ShowDialog();
            Show();
            Permissoes();
        }

        private void consultarToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            Modulos.FluxoDeCaixa.frmConsultar frm = new Modulos.FluxoDeCaixa.frmConsultar();
            Hide();
            frm.ShowDialog();
            Show();
            Permissoes();
        }

        private void novoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Modulos.FolhaDePagamento.frmNovo frm = new Modulos.FolhaDePagamento.frmNovo();
            Hide();
            frm.ShowDialog();
            Show();
            Permissoes();
        }

        private void consultarToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            Modulos.FolhaDePagamento.frmConsultar frm = new Modulos.FolhaDePagamento.frmConsultar();
            Hide();
            frm.ShowDialog();
            Show();
            Permissoes();
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            Modulos.ControleDeCliente.frmConsultar frm = new Modulos.ControleDeCliente.frmConsultar();
            Hide();
            frm.ShowDialog();
            Show();
            Permissoes();
        }

        private void btnFornecedores_Click(object sender, EventArgs e)
        {
            Modulos.ControleDeFornecedor.frmConsultar frm = new Modulos.ControleDeFornecedor.frmConsultar();
            Hide();
            frm.ShowDialog();
            Show();
            Permissoes();
        }

        private void btnFunc_Click(object sender, EventArgs e)
        {
            Modulos.ControleDeFuncionario.frmConsultar frm = new Modulos.ControleDeFuncionario.frmConsultar();
            Hide();
            frm.ShowDialog();
            Show();
            Permissoes();
        }

        private void btnUsu_Click(object sender, EventArgs e)
        {
            Modulos.ControleDeUsuario.frmConsultar frm = new Modulos.ControleDeUsuario.frmConsultar();
            Hide();
            frm.ShowDialog();
            Show();
            Permissoes();
        }

        private void btnAula_Click(object sender, EventArgs e)
        {
            Modulos.ControleDeEstoque.frmConsultar frm = new Modulos.ControleDeEstoque.frmConsultar();
            Hide();
            frm.ShowDialog();
            Show();
            Permissoes();
        }

        private void btnVender_Click(object sender, EventArgs e)
        {
            Modulos.ControleDeVenda.frmConsultar frm = new Modulos.ControleDeVenda.frmConsultar();
            Hide();
            frm.ShowDialog();
            Show();
            Permissoes();
        }

        private void btnComprar_Click(object sender, EventArgs e)
        {
            Modulos.ControleDeCompra.frmConsultar frm = new Modulos.ControleDeCompra.frmConsultar();
            Hide();
            frm.ShowDialog();
            Show();
            Permissoes();
        }

        private void consultarToolStripMenuItem10_Click(object sender, EventArgs e)
        {
            Modulos.ControleDeProdutosVenda.frmConsultar frm = new Modulos.ControleDeProdutosVenda.frmConsultar();
            Hide();
            frm.ShowDialog();
            Show();
            Permissoes();
        }

        private void cadastrarToolStripMenuItem8_Click(object sender, EventArgs e)
        {
            Modulos.ControleDeProdutosVenda.frmCadastrar frm = new Modulos.ControleDeProdutosVenda.frmCadastrar();
            Hide();
            frm.ShowDialog();
            Show();
            Permissoes();
        }

        private void estoqueDeVendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Modulos.ControleDeEstoqueVenda.frmConsultar frm = new Modulos.ControleDeEstoqueVenda.frmConsultar();
            Hide();
            frm.ShowDialog();
            Show();
            Permissoes();
        }

        private void hora_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("hh:mm:ss");
        }

        private void tempo_Tick(object sender, EventArgs e)
        {
            Clima();
        }

        private void Clima()
        {
            ClimaModel clima = new ClimaModel();
            TempoResponse tempo = clima.AdivisorTempo("São Paulo");
            lblClima.Text = $"{tempo.name},  {tempo.state}     Umidade: {tempo.data.humidity}    {tempo.data.temperature.ToString()}°";
        }
    }
}
