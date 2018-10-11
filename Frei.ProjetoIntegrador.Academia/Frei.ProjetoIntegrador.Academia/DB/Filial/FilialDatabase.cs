using MySql.Data.MySqlClient;
using Nsf._2018.Modulo3.App.DB.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frei.ProjetoIntegrador.Academia.DB.Filial
{
    class FilialDatabase
    {
        public int CadastrarFilial(FilialDTO dto)
        {
            string script = @"INSERT tb_Filial(nm_Nome, ds_CEP, ds_Logradouro, ds_Bairro, ds_UF, ds_Complemento)
                                        VALUES(@nm_Nome, @ds_CEP, @ds_Logradouro, @ds_Bairro, @ds_UF, @ds_Complemento)";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("nm_Nome", dto.nm_Nome));
            parms.Add(new MySqlParameter("ds_CEP", dto.ds_CEP));
            parms.Add(new MySqlParameter("ds_Logradouro", dto.ds_Logradouro));
            parms.Add(new MySqlParameter("ds_Bairro", dto.ds_Bairro));
            parms.Add(new MySqlParameter("ds_UF", dto.ds_UF));
            parms.Add(new MySqlParameter("ds_Complemento", dto.ds_Complemento));

            Database db = new Database();
            return db.ExecuteInsertScriptWithPk(script, parms);
        }

        public int AlterarFilial(FilialDTO dto)
        {
            string script = @"UPDATE tb_Filial SET nm_Nome = @nm_Nome,
                                                    ds_CEP = @ds_CEP, 
                                             ds_Logradouro = @ds_Logradouro, 
                                                 ds_Bairro = @ds_Bairro, 
                                                     ds_UF = @ds_UF, 
                                            ds_Complemento = @ds_Complemento

                                           WHERE id_Filial = @id_Filial";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("nm_Nome", dto.nm_Nome));
            parms.Add(new MySqlParameter("id_Filial", dto.id_Filial));
            parms.Add(new MySqlParameter("ds_CEP", dto.ds_CEP));
            parms.Add(new MySqlParameter("ds_Logradouro", dto.ds_Logradouro));
            parms.Add(new MySqlParameter("ds_Bairro", dto.ds_Bairro));
            parms.Add(new MySqlParameter("ds_UF", dto.ds_UF));
            parms.Add(new MySqlParameter("ds_Complemento", dto.ds_Complemento));

            Database db = new Database();
            return db.ExecuteInsertScriptWithPk(script, parms);
        }

        public int RemoverFilial(int idFilial)
        {
            string script = @"DELETE FROM tb_Filial WHERE id_Filial = @id_Filial";
            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("id_Filial", idFilial));

            Database db = new Database();
            return db.ExecuteInsertScriptWithPk(script, parms);
        }

        public List<FilialDTO> Consultar()
        {
            string script = @"SELECT * FROM tb_Filial";
            List<MySqlParameter> parms = new List<MySqlParameter>();

            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);

            List<FilialDTO> filiais = new List<FilialDTO>();
            while (reader.Read())
            {
                FilialDTO filial = new FilialDTO();
                filial.id_Filial = reader.GetInt32("id_Filial");
                filial.nm_Nome = reader.GetString("nm_Nome");
                filial.ds_CEP = reader.GetString("ds_CEP");
                filial.ds_Logradouro = reader.GetString("ds_Logradouro");
                filial.ds_Bairro = reader.GetString("ds_Bairro");
                filial.ds_UF = reader.GetString("ds_UF");
                filial.ds_Complemento = reader.GetString("ds_Complemento");

                filiais.Add(filial);
            }

            reader.Close();
            return filiais;
        }

        public List<FilialDTO> ConsultarPorNome(string nome)
        {
            string script = $"SELECT * FROM `tb_Filial` WHERE nm_Nome LIKE '%{nome}%'";

            List<MySqlParameter> parms = new List<MySqlParameter>();

            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);

            List<FilialDTO> Filiais = new List<FilialDTO>();
            while (reader.Read())
            {
                FilialDTO Filial = new FilialDTO();
                Filial.id_Filial = reader.GetInt32("id_Filial");
                Filial.nm_Nome = reader.GetString("nm_Nome");
                Filial.ds_CEP = reader.GetString("ds_CEP");
                Filial.ds_Logradouro = reader.GetString("ds_Logradouro");
                Filial.ds_Bairro = reader.GetString("ds_Bairro");
                Filial.ds_UF = reader.GetString("ds_UF");
                Filial.ds_Complemento = reader.GetString("ds_Complemento");

                Filiais.Add(Filial);
            }

            reader.Close();
            return Filiais;
        }
    }
}
