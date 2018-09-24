using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frei.ProjetoIntegrador.Academia.DB.Funcionario
{
    class FuncionarioDTO
    {
        public int idFuncionario { get; set; }
        public string Nome { get; set; }
        public int cpf { get; set; }
        public int cep { get; set; }
        public string bairro{ get; set; }
        public int logradouro { get; set; }
        public int uf { get; set; }
        public int complemento { get; set; }
        public int celular { get; set; }
        public int telefone { get; set; }
        public int residencia { get; set; }
        public string email { get; set; }
        public DateTime admissao  { get; set; }
        public DateTime demissao { get; set; }
        public DateTime nascimento { get; set; }
        public int fk_Func_Usuario { get; set; }




    }
}
