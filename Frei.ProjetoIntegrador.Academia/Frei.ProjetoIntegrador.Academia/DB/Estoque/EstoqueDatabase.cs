using MySql.Data.MySqlClient;
using Nsf._2018.Modulo3.App.DB.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frei.ProjetoIntegrador.Academia.DB.Estoque
{
    class EstoqueDatabase
    {
        public int CriarEstoque(EstoqueDTO dto)
        {
            string script = @"INSERT tb_estoque(qnt_Produto, num_Est_Min, num_Est_Max, fk_Estoque_Produto)
                                         VALUES(@qnt_Produto, @num_Est_Min, @num_Est_Max, @fk_Estoque_Produto)";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("qnt_Produto", dto.qnt_Produto));
            parms.Add(new MySqlParameter("num_Est_Min", 1));
            parms.Add(new MySqlParameter("num_Est_Max", 1000));
            parms.Add(new MySqlParameter("fk_Estoque_Produto", dto.fk_Estoque_Produto));

            Database db = new Database();
            return db.ExecuteInsertScriptWithPk(script, parms);
        }

        public int AlterarEstoque(EstoqueDTO dto)
        {
            string script = @"UPDATE tb_estoque SET qnt_Produto = @qnt_Produto,
                                                    num_Est_Min = @num_Est_Min,
                                                    num_Est_Max = @num_Est_Max

                                               WHERE id_Estoque = @id_Estoque";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("id_Estoque", dto.id_Estoque));
            parms.Add(new MySqlParameter("qnt_Produto", dto.qnt_Produto));
            parms.Add(new MySqlParameter("num_Est_Min", dto.num_Est_Min));
            parms.Add(new MySqlParameter("num_Est_Max", dto.num_Est_Max));

            Database db = new Database();
            return db.ExecuteInsertScriptWithPk(script, parms);
        }

        public int AdicionarProdutos(EstoqueDTO dto)
        {
            string script = @"UPDATE tb_estoque SET qnt_Produto = @qnt_Produto,
                                             fk_Estoque_Produto = @fk_Estoque_Produto

                                               WHERE id_Estoque = @id_Estoque";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("id_Estoque", dto.id_Estoque));
            parms.Add(new MySqlParameter("qnt_Produto", dto.qnt_Produto));
            parms.Add(new MySqlParameter("fk_Estoque_Produto", dto.fk_Estoque_Produto));

            Database db = new Database();
            return db.ExecuteInsertScriptWithPk(script, parms);
        }

        public int ApagarEstoque(int idEstoque)
        {
            string script = $@"DELETE FROM tb_estoque WHERE id_Estoque = '{idEstoque}'";
            List<MySqlParameter> parms = new List<MySqlParameter>();

            Database db = new Database();
            return db.ExecuteInsertScriptWithPk(script, parms);
        }

        public List<EstoqueDTO> Consultar()
        {
            string script = @"SELECT * FROM tb_estoque";
            List<MySqlParameter> parms = new List<MySqlParameter>();

            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);

            List<EstoqueDTO> estoques = new List<EstoqueDTO>();
            while (reader.Read())
            {
                EstoqueDTO dto = new EstoqueDTO();
                dto.id_Estoque = reader.GetInt32("id_Estoque");
                dto.qnt_Produto = reader.GetInt32("qnt_Produto");
                dto.num_Est_Min = reader.GetInt32("num_Est_Min");
                dto.num_Est_Max = reader.GetInt32("num_Est_Max");
                dto.fk_Estoque_Produto = reader.GetInt32("fk_Estoque_Produto");

                estoques.Add(dto);
            }

            reader.Close();
            return estoques;
        }

        public List<view_Estoque> ConsultarView()
        {
            string script = @"SELECT * FROM view_Estoque";
            List<MySqlParameter> parms = new List<MySqlParameter>();

            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);

            List<view_Estoque> estoques = new List<view_Estoque>();
            while (reader.Read())
            {
                view_Estoque dto = new view_Estoque();
                dto.id_Estoque = reader.GetInt32("id_Estoque");
                dto.qnt_Produto = reader.GetInt32("qnt_Produto");
                dto.num_Est_Min = reader.GetInt32("num_Est_Min");
                dto.num_Est_Max = reader.GetInt32("num_Est_Max");
                dto.fk_Estoque_Produto = reader.GetInt32("fk_Estoque_Produto");
                dto.nm_Produto = reader.GetString("nm_Produto");
                dto.ds_Produto = reader.GetString("ds_Produto");

                estoques.Add(dto);
            }

            reader.Close();
            return estoques;
        }

        public List<view_Estoque> ConsultarViewPorNome(string nome)
        {
            string script = @"SELECT * FROM view_Estoque WHERE nm_Produto = @nm_Produto";
            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("nm_Produto", nome));

            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);

            List<view_Estoque> estoques = new List<view_Estoque>();
            while (reader.Read())
            {
                view_Estoque dto = new view_Estoque();
                dto.id_Estoque = reader.GetInt32("id_Estoque");
                dto.qnt_Produto = reader.GetInt32("qnt_Produto");
                dto.num_Est_Min = reader.GetInt32("num_Est_Min");
                dto.num_Est_Max = reader.GetInt32("num_Est_Max");
                dto.fk_Estoque_Produto = reader.GetInt32("fk_Estoque_Produto");
                dto.nm_Produto = reader.GetString("nm_Produto");
                dto.ds_Produto = reader.GetString("ds_Produto");

                estoques.Add(dto);
            }

            reader.Close();
            return estoques;
        }
    }
}
