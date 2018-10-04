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
        public List<FilialDTO> Consultar()
        {
            string script = @"SELECT * FROM `tb_Filial`";

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
