using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frei.ProjetoIntegrador.Academia.DB.Clientes
{
    class ClientesDTO
    {
        public int id_Cliente { get; set; }
        public int nm_Nome { get; set; }
        public int ds_CPF { get; set; }
        public int ds_CEP { get; set; }
        public int ds_Logradouro { get; set; }
        public int ds_Bairro { get; set; }
        public int ds_UF { get; set; }
        public int ds_Complemento { get; set; }
        public int ds_Situacao { get; set; }
        public int num_Telefone { get; set; }
        public int num_Celular { get; set; }
        public int ds_Email { get; set; }
        public int dt_Cadastro { get; set; }
        public int fk_Cliente_Filial { get; set; }
        
    }
}

  
