using Frei.ProjetoIntegrador.Academia.DB.Estoque;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Frei.ProjetoIntegrador.Academia.Modulos.ControleDeEstoque
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
            EstoqueBusiness business = new EstoqueBusiness();
            List<view_Estoque> estoque = business.ConsultarView();

            dgvEstoque.AutoGenerateColumns = false;
            dgvEstoque.DataSource = estoque;
        }
    }
}
