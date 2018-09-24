using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frei.ProjetoIntegrador.Academia.DB.PedidoCompra
{
    class PedidoCompraDTO
    {
        public int idPedidoCompra { get; set; }
        public DateTime datapedido { get; set; }
        public int _Usuarfk_PedidoCompra { get; set; }

    }
}
