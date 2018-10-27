using MySql.Data.MySqlClient;
using Nsf._2018.Modulo3.App.DB.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frei.ProjetoIntegrador.Academia.DB.FluxoDeCaixa
{
    class FluxoDeCaixaDatabase
    {
        public decimal Ganho(string data)
        {
            string script = @"SELECT * FROM view_Ganhos WHERE dt_referencia = @dt_referencia";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("dt_referencia", data));

            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);

            decimal ganhos = 0;
            if (reader.Read())
            {
                ganhos = reader.GetDecimal("vl_total");
            }

            return ganhos;
        }

        public decimal DespesaCompra(string data)
        {
            string script = @"SELECT * FROM view_DespesasCompra WHERE dt_referencia = @dt_referencia";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("dt_referencia", data));

            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);

            decimal despesa = 0;
            if (reader.Read())
            {
                despesa = reader.GetDecimal("vl_total");
            }

            return despesa;
        }

        public decimal DespesaFolha(string data)
        {
            string script = @"SELECT * FROM view_DespesasFolha WHERE dt_referencia = @dt_referencia";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("dt_referencia", data));

            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);

            decimal despesa = 0;
            if (reader.Read())
            {
                despesa = reader.GetDecimal("vl_total");
            }

            return despesa;
        }

        public decimal DespesaGerais(string data)
        {
            string script = @"SELECT * FROM view_DespesasGerais WHERE dt_referencia = @dt_referencia";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("dt_referencia", data));

            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);

            decimal despesa = 0;
            if (reader.Read())
            {
                despesa = reader.GetDecimal("vl_total");
            }

            return despesa;
        }
    }
}
