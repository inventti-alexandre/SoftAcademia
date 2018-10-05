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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                LoginBusiness business = new LoginBusiness();
                UsuarioDTO user = business.Autenticar(txtNome.Text, txtSenha.Text);

                if (user.nm_Usuario != null)
                {
                    UserSession.UsuarioLogado = user;

                    frmPrincipal frm = new frmPrincipal();
                    Hide();
                    frm.ShowDialog();
                    Close();
                }
                else
                {
                    MessageBox.Show("Credenciais inválidas.", "Black Fit LTDA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Black Fit LTDA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro não identificado: " + ex.Message, "Black Fit LTDA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
