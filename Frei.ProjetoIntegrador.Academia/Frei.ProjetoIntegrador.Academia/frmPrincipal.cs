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
        }

        private void Permissoes()
        {
            UsuarioDTO user = UserSession.UsuarioLogado;
            lblBV.Text = $"Bem vindo, {user.nm_Usuario}";

            if (user.Cod_Perm.Substring(0,1) == "0")
            {
                if (user.Cod_Perm.Substring(1, 1) == "0")
                {
                    pessoalToolStripMenuItem.Enabled = false;
                }
                if (user.Cod_Perm.Substring(2, 1) == "0")
                {
                    serviçosToolStripMenuItem.Enabled = false;
                }
                if (user.Cod_Perm.Substring(3, 1) == "0")
                {
                    produtosToolStripMenuItem.Enabled = false;
                }
                if (user.Cod_Perm.Substring(4, 1) == "0")
                {
                    finançasToolStripMenuItem.Enabled = false;
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
        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Modulos.ControleDeAulas.frmConsultar frm = new Modulos.ControleDeAulas.frmConsultar();
            Hide();
            frm.ShowDialog();
            Show();
        }

        private void adicionarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Modulos.ControleDeAulas.frmNovo frm = new Modulos.ControleDeAulas.frmNovo();
            Hide();
            frm.ShowDialog();
            Show();
        }

        private void cadastrarToolStripMenuItem6_Click(object sender, EventArgs e)
        {
            Modulos.ControleDeCliente.frmNovo frm = new Modulos.ControleDeCliente.frmNovo();
            Hide();
            frm.ShowDialog();
            Show();
        }

        private void novoToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Modulos.ControleDeCliente.frmConsultar frm = new Modulos.ControleDeCliente.frmConsultar();
            Hide();
            frm.ShowDialog();
            Show();
        }

        private void cadastrarToolStripMenuItem7_Click(object sender, EventArgs e)
        {
            Modulos.ControleDeFuncionario.frmNovo frm = new Modulos.ControleDeFuncionario.frmNovo();
            Hide();
            frm.ShowDialog();
            Show();
        }

        private void consultarToolStripMenuItem8_Click(object sender, EventArgs e)
        {
            Modulos.ControleDeFuncionario.frmConsultar frm = new Modulos.ControleDeFuncionario.frmConsultar();
            Hide();
            frm.ShowDialog();
            Show();
        }

        private void cadastarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Modulos.ControleDeUsuario.frmNovo frm = new Modulos.ControleDeUsuario.frmNovo();
            Hide();
            frm.ShowDialog();
            Show();
        }

        private void consultarToolStripMenuItem9_Click(object sender, EventArgs e)
        {
            Modulos.ControleDeUsuario.frmConsultar frm = new Modulos.ControleDeUsuario.frmConsultar();
            Hide();
            frm.ShowDialog();
            Show();
        }

        private void consultarToolStripMenuItem6_Click(object sender, EventArgs e)
        {
            Modulos.ControleDeAulas.frmConsultar frm = new Modulos.ControleDeAulas.frmConsultar();
            Hide();
            frm.ShowDialog();
            Show();
        }

        private void cadastrarToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            Modulos.ControleDeAulas.frmNovo frm = new Modulos.ControleDeAulas.frmNovo();
            Hide();
            frm.ShowDialog();
            Show();
        }

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Modulos.ControleDeProdutos.frmNovo frm = new Modulos.ControleDeProdutos.frmNovo();
            Hide();
            frm.ShowDialog();
            Show();
        }

        private void consultarToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Modulos.ControleDeProdutos.frmConsultar frm = new Modulos.ControleDeProdutos.frmConsultar();
            Hide();
            frm.ShowDialog();
            Show();
        }

        private void cadastrarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Modulos.ControleDeCompra.frmNovo frm = new Modulos.ControleDeCompra.frmNovo();
            Hide();
            frm.ShowDialog();
            Show();
        }

        private void consultarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Modulos.ControleDeCompra.frmConsultar frm = new Modulos.ControleDeCompra.frmConsultar();
            Hide();
            frm.ShowDialog();
            Show();
        }

        private void cadastrarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Modulos.ControleDeVenda.frmNovo frm = new Modulos.ControleDeVenda.frmNovo();
            Hide();
            frm.ShowDialog();
            Show();
        }

        private void consultarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Modulos.ControleDeVenda.frmConsultar frm = new Modulos.ControleDeVenda.frmConsultar();
            Hide();
            frm.ShowDialog();
            Show();
        }

        private void cadastrarToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Modulos.ControleDeEstoque.frmNovo frm = new Modulos.ControleDeEstoque.frmNovo();
            Hide();
            frm.ShowDialog();
            Show();
        }

        private void consultarToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Modulos.ControleDeEstoque.frmConsultar frm = new Modulos.ControleDeEstoque.frmConsultar();
            Hide();
            frm.ShowDialog();
            Show();
        }

        private void cadastrarToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            Modulos.ControleDeFornecedor.frmNovo frm = new Modulos.ControleDeFornecedor.frmNovo();
            Hide();
            frm.ShowDialog();
            Show();
        }

        private void consultarToolStripMenuItem7_Click(object sender, EventArgs e)
        {
            Modulos.ControleDeFornecedor.frmConsultar frm = new Modulos.ControleDeFornecedor.frmConsultar();
            Hide();
            frm.ShowDialog();
            Show();
        }

        private void novoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Modulos.FluxoDeCaixa.frmNovo frm = new Modulos.FluxoDeCaixa.frmNovo();
            Hide();
            frm.ShowDialog();
            Show();
        }

        private void consultarToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            Modulos.FluxoDeCaixa.frmConsultar frm = new Modulos.FluxoDeCaixa.frmConsultar();
            Hide();
            frm.ShowDialog();
            Show();
        }

        private void novoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Modulos.FolhaDePagamento.frmNovo frm = new Modulos.FolhaDePagamento.frmNovo();
            Hide();
            frm.ShowDialog();
            Show();
        }

        private void consultarToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            Modulos.FolhaDePagamento.frmConsultar frm = new Modulos.FolhaDePagamento.frmConsultar();
            Hide();
            frm.ShowDialog();
            Show();
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            Modulos.ControleDeCliente.frmConsultar frm = new Modulos.ControleDeCliente.frmConsultar();
            Hide();
            frm.ShowDialog();
            Show();
        }

        private void btnFornecedores_Click(object sender, EventArgs e)
        {
            Modulos.ControleDeFornecedor.frmConsultar frm = new Modulos.ControleDeFornecedor.frmConsultar();
            Hide();
            frm.ShowDialog();
            Show();
        }

        private void btnFunc_Click(object sender, EventArgs e)
        {
            Modulos.ControleDeFuncionario.frmConsultar frm = new Modulos.ControleDeFuncionario.frmConsultar();
            Hide();
            frm.ShowDialog();
            Show();
        }

        private void btnUsu_Click(object sender, EventArgs e)
        {
            Modulos.ControleDeUsuario.frmConsultar frm = new Modulos.ControleDeUsuario.frmConsultar();
            Hide();
            frm.ShowDialog();
            Show();
        }

        private void btnAula_Click(object sender, EventArgs e)
        {
            Modulos.ControleDeAulas.frmConsultar frm = new Modulos.ControleDeAulas.frmConsultar();
            Hide();
            frm.ShowDialog();
            Show();
        }

        private void btnVender_Click(object sender, EventArgs e)
        {
            Modulos.ControleDeVenda.frmConsultar frm = new Modulos.ControleDeVenda.frmConsultar();
            Hide();
            frm.ShowDialog();
            Show();
        }

        private void btnComprar_Click(object sender, EventArgs e)
        {
            Modulos.ControleDeCompra.frmConsultar frm = new Modulos.ControleDeCompra.frmConsultar();
            Hide();
            frm.ShowDialog();
            Show();
        }
    }
}
