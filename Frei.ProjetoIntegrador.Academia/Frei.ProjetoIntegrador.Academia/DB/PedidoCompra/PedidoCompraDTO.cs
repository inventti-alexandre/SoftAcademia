﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frei.ProjetoIntegrador.Academia.DB.PedidoCompra
{
    class PedidoCompraDTO
    {
        public int id_Pedido_Compra { get; set; }
        public DateTime dt_Pedido { get; set; }
        public int fk_PedidoCompra_Usuario { get; set; }
        public int fk_PedidoCompra_Filial { get; set; }

        public int id_Pedido_Item_Compra { get; set; }
        public int fk_PedidoItemCompra_Produto { get; set; }
        public int fk_PedidoItemCompra_PedidoCompra { get; set; }
    }
}
