using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frei.ProjetoIntegrador.Academia.DB.PedidoVenda
{
    class PedidoVendaDatabase
    {
        public void RegistrarVenda(PedidoVendaDTO dto)
        {
            string script = @"INSERT tb_pedido_venda(dt_Pedido, fk_PedidoVenda_Usuario, fk_PedidoVenda_Cliente, fk_PedidoVenda_Filial)
                                              VALUES(@dt_Pedido, @fk_PedidoVenda_Usuario, @fk_PedidoVenda_Cliente, @fk_PedidoVenda_Filial)";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("dt_Pedido", dto.dt_Pedido));
        }
    }
}
