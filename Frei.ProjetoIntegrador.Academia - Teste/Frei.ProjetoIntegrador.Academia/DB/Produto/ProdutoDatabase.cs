using Frei.ProjetoIntegrador.Academia.DB.ProdutoVenda;
using Nsf._2018.Modulo3.App.DB.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frei.ProjetoIntegrador.Academia.DB.Produto
{
    class ProdutoDatabase
  { 
    public int CadastrarProdutoVendas(ProdutoVendasDTO dto)
    {
        string script = @"INSERT tb_Filial(nm_Produto, vl_Compra, vl_Venda, ds_Produto, fk_Produto_Fornecedor, fk_Produto_Filial)
                                        VALUES(@nm_Produto, @vl_Compra, @vl_Venda, @ds_Produto, @fk_Produto_Fornecedor, @fk_Produto_Filial)";

        List<MySqlParameter> parms = new List<MySqlParameter>();
        parms.Add(new MySqlParameter("nm_Produto", dto.nm_Produto));
        parms.Add(new MySqlParameter("vl_Compra", dto.vl_Compra));
        parms.Add(new MySqlParameter("vl_Venda", dto.vl_Venda));
        parms.Add(new MySqlParameter("ds_Produto", dto.ds_Produto));
        parms.Add(new MySqlParameter("fk_Produto_Fornecedor", dto.fk_Produto_Fornecedor));
        parms.Add(new MySqlParameter("fk_Produto_Filial", dto.fk_Produto_Filial));

        Database db = new Database();
        return db.ExecuteInsertScriptWithPk(script, parms);
    }

    public int AlterarProdutoVendas(ProdutoVendasDTO dto)
    {
        string script = @"UPDATE tb_ProdutoVendas SET nm_Produto = @nm_Produto,
                                                vl_Compra = @vl_Compra, 
                                                 vl_Venda = @vl_Venda, 
                                               ds_Produto = @ds_Produto, 
                                    fk_Produto_Fornecedor = @fk_Produto_Fornecedor, 
                                        fk_Produto_Filial = @fk_Produto_Filial

                                           WHERE id_Produto = @id_Produto";

        List<MySqlParameter> parms = new List<MySqlParameter>();
        parms.Add(new MySqlParameter("id_Produto", dto.id_Produto));
        parms.Add(new MySqlParameter("nm_Produto", dto.nm_Produto));
        parms.Add(new MySqlParameter("vl_Compra", dto.vl_Compra));
        parms.Add(new MySqlParameter("vl_Venda", dto.vl_Venda));
        parms.Add(new MySqlParameter("ds_Produto", dto.ds_Produto));
        parms.Add(new MySqlParameter("fk_Produto_Fornecedor", dto.fk_Produto_Fornecedor));
        parms.Add(new MySqlParameter("fk_Produto_Filial", dto.fk_Produto_Filial));

        Database db = new Database();
        return db.ExecuteInsertScriptWithPk(script, parms);
    }

    public int RemoverProdutoVendas(int idProduto)
    {
        string script = @"DELETE FROM tb_Filial WHERE id_Filial = @id_Filial";
        List<MySqlParameter> parms = new List<MySqlParameter>();
        parms.Add(new MySqlParameter("id_Filial", idProduto));

        Database db = new Database();
        return db.ExecuteInsertScriptWithPk(script, parms);
    }

    public List<ProdutoVendasDTO> Consultar()
    {
        string script = @"SELECT * FROM tb_ProdutoVendas";
        List<MySqlParameter> parms = new List<MySqlParameter>();

        Database db = new Database();
        MySqlDataReader reader = db.ExecuteSelectScript(script, parms);

        List<ProdutoVendasDTO> produtovendas = new List<ProdutoVendasDTO>();
        while (reader.Read())
        {
            ProdutoVendasDTO produtovendas = new ProdutoVendasDTO();
            produtovendas.id_Produto = reader.GetInt32("id_Produto");
            produtovendas.nm_Produto = reader.GetString("nm_Produto");
            produtovendas.vl_Compra = reader.GetInt32("vl_Compra");
            produtovendas.vl_Venda = reader.GetInt32("vl_Venda");
            produtovendas.ds_Produto = reader.GetString("ds_Produto");
            produtovendas.fk_Produto_Fornecedor = reader.GetString("fk_Produto_Fornecedor");
            produtovendas.fk_Produto_Filial = reader.GetString("fk_Produto_Filial");

            ProdutoVendas.Add(ProdutoVendas);
        }

        reader.Close();
        return produtovendas;
    }

    public List<ProdutoVendasDTO> ConsultarPorNome(string nome)
    {
        string script = $"SELECT * FROM `tb_Filial` WHERE nm_Nome LIKE '%{nome}%'";

        List<MySqlParameter> parms = new List<MySqlParameter>();

        Database db = new Database();
        MySqlDataReader reader = db.ExecuteSelectScript(script, parms);

        List<ProdutoVendasDTO> Filiais = new List<ProdutoVendasDTO>();
        while (reader.Read())
        {
            ProdutoVendasDTO ProdutoVenda = new ProdutoVendasDTO();
            ProdutoVenda.id_Produto = reader.GetInt32("id_Produto");
            ProdutoVenda.nm_Produto = reader.GetString("nm_Produto");
            ProdutoVenda.vl_Compra = reader.GetInt32("vl_Compra");
            ProdutoVenda.vl_Venda = reader.GetInt32("vl_Venda");
            ProdutoVenda.ds_Produto = reader.GetString("ds_Produto");
            ProdutoVenda.fk_Produto_Fornecedor = reader.GetString("fk_Produto_Fornecedor");
            ProdutoVenda.fk_Produto_Filial = reader.GetString("fk_Produto_Filial");

            ProdutoVendas.Add(ProdutoVendas);
        }

        reader.Close();
        return Filiais;
    }
}
}
