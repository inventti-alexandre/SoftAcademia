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
    }
}
