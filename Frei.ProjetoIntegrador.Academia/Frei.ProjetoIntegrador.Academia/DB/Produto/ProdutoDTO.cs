using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frei.ProjetoIntegrador.Academia.DB.Produto
{
    class ProdutoDTO
    {
        public int idproduto { get; set; }
        public string Nomepreoduto { get; set; }
        public int valorcompra { get; set; }
        public int valorvenda { get; set; }
        public string descricaoproduto { get; set; }
        public string fk_Produto_Fornecedor { get; set; }

    }
}
