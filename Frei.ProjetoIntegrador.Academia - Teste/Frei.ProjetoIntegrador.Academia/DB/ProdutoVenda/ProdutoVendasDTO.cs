using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frei.ProjetoIntegrador.Academia.DB.ProdutoVenda
{
    class ProdutoVendasDTO
    {
        public string nm_Produto { get; set; }
        public string vl_Venda { get; set; }
        public decimal ds_Produto { get; set; }
        public DateTime dt_Validade { get; set; }
        public int fk_ProdutoCompra_Fornecedor { get; set; }
        public int fk_produtoCompra_Filial { get; set; }
    }


}
}
}
}
