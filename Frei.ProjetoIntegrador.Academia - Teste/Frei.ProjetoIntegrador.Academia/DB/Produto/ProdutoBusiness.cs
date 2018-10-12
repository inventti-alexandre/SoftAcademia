using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frei.ProjetoIntegrador.Academia.DB.Produto
{
    class ProdutoBusiness 
        
           public int CadastrarFilial(FilialDTO dto)
    {
        ProdutoVendasDatabase db = new ProdutoVendasDatabase();
        return db.CadastrarProdutoVendas(dto);
    }

    public int AlterarFilial(FilialDTO dto)
    {
        ProdutoVendasDatabase db = new ProdutoVendasDatabase();
        return db.AlterarProdutoVendas(dto);
    }

    public int RemoverProdutoVendas(int idProduto)
    {
        ProdutoVendasDatabase db = new ProdutoVendasDatabase();
        return db.RemoverProdutoVendas(idProduto);
    }

    public List<ProdutoVendasDTO> Consultar()
    {
        ProdutoVendasDatabase db = new ProdutoVendasDatabase();
        return db.Consultar();
    }


    public List<ProdutoVendasDTO> ConsultarPorNome(string nome)
    {
        ProdutoVendasDatabase db = new ProdutoVendasDatabase();
        return db.ConsultarPorNome(nome);
    }
}
}

