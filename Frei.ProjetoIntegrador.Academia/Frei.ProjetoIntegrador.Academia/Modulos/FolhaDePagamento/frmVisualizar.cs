using Frei.ProjetoIntegrador.Academia.DB.FolhaPgmt;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Frei.ProjetoIntegrador.Academia.Modulos.FolhaDePagamento
{
    public partial class frmVisualizar : Form
    {
        public frmVisualizar()
        {
            InitializeComponent();
        }

        public void CarregarCampos(string id)
        {
            lblCod.Text = id;

            FolhaPgmtBusiness business = new FolhaPgmtBusiness();
            view_func_folha folha = business.ConsultarPorId(id);

            lblNome.Text = folha.nm_NomeFunc;
            lblFuncao.Text = folha.ds_Cargo;
            lblMensagem.Text = folha.ds_Mensagem;

            lblDiasTrabalhados.Text = $"R$ {folha.ds_DiasTrabalhados}";
            lblSalario.Text         = $"R$ {folha.vl_mesSalario}";
            lblVencimentos.Text     = $"R$ {folha.vl_Proventos}";
            lblDescontos.Text       = $"R$ {folha.vl_Descontos}";
            lblReceber.Text         = $"R$ {folha.vl_Liquido}";

            lblValeTransporte.Text  = $"R$ {folha.vl_VT}";
            lblValeRefeicao.Text    = $"R$ {folha.vl_VR}";
            lblINSS.Text            = $"R$ {folha.vl_INSS}";
            lblHoraE50.Text         = $"R$ {folha.vl_HoraE50}";
            lblHoraE100.Text        = $"R$ {folha.vl_HoraE100}";
            lblDedIR.Text           = $"R$ {folha.vl_DedIR}";
            lblIR.Text              = $"R$ {folha.vl_IR}";
            lblValorIR.Text         = $"R$ {folha.vl_ValorIR}";
            lblValorFGTS.Text       = $"R$ {folha.vl_ValorFGTS}";            

            lblSalarioBase.Text     = $"R$ {folha.vl_SalarioBruto}";
            lblINSSBase.Text        = $"R$ {folha.vl_BaseINSS}";
            lblFGTSBase.Text        = $"R$ {folha.vl_BaseFGTS}";
            lblFGTSMes.Text         = $"R$ {folha.vl_FGTSmes}";
            lblBaseIRRF.Text        = $"R$ {folha.vl_BaseIRRF}";
            lblFaixaIRRF.Text       = $"R$ {folha.vl_FaixaIRRF}";
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmVisualizar_Load(object sender, EventArgs e)
        {

        }
    }
}