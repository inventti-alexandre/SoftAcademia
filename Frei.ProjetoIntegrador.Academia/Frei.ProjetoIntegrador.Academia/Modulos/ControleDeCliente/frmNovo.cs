using Frei.ProjetoIntegrador.Academia.APIs.Correio;
using Frei.ProjetoIntegrador.Academia.DB.Clientes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Frei.ProjetoIntegrador.Academia.Modulos.ControleDeCliente
{
    public partial class frmNovo : Form
    {
        public frmNovo()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                ClientesDTO dto = new ClientesDTO();
                dto.nm_Nome = txtNome.Text;
                dto.ds_CPF = txtCPF.Text;
                dto.ds_CEP = txtCEP.Text;
                dto.ds_Logradouro = txtLogradouro.Text;
                dto.ds_Bairro = txtBairro.Text;
                dto.ds_UF = txtUF.Text;
                dto.ds_Complemento = txtComplemento.Text;
                dto.ds_Email = txtEmail.Text;
                dto.num_Celular = txtNCelular.Text;
                dto.num_Telefone = txtNTelefone.Text;

                ClientesBusiness business = new ClientesBusiness();
                business.CadastrarCliente(dto);

                MessageBox.Show("Cliente cadastrado com sucesso!", "Black Fit LTDA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Black Fit LTDA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                if(ex.Message.Contains("'ds_CPF'"))
                    MessageBox.Show("Este CPF já está cadastrado.", "Black Fit LTDA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else if (ex.Message.Contains("'ds_Email'"))
                    MessageBox.Show("Este Email já está cadastrado.", "Black Fit LTDA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show($"Ocorreu um erro não identificado: {ex.Message}", "Black Fit LTDA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSearchCEP_Click(object sender, EventArgs e)
        {
            try
            {
                CorreioModel correio = new CorreioModel();
                CorreioResponse response = correio.Endereco(txtCEP.Text);

                txtLogradouro.Text = response.Logradouro;
                txtComplemento.Text = response.Complemento;
                txtBairro.Text = response.Bairro;
                txtUF.Text = response.UF;
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
