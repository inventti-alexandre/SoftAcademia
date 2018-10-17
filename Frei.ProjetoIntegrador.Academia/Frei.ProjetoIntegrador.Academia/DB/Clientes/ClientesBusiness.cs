using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frei.ProjetoIntegrador.Academia.DB.Clientes
{
    class ClientesBusiness
    {
        public int CadastrarCliente(ClientesDTO dto)
        {
            ClientesDatabase db = new ClientesDatabase();
            return db.CadastrarCliente(dto);
        }

        public int AlterarCliente(ClientesDTO dto)
        {
            ClientesDatabase db = new ClientesDatabase();
            return db.AlterarCliente(dto);
        }

        public int RemoverCliente(int idCliente)
        {
            ClientesDatabase db = new ClientesDatabase();
            return db.RemoverCliente(idCliente);
        }

        public List<ClientesDTO> Consultar()
        {
            ClientesDatabase db = new ClientesDatabase();
            return db.Consultar();
        }

        public ClientesDTO ConsultarPorId(int idCliente)
        {
            ClientesDatabase db = new ClientesDatabase();
            return db.ConsultarPorId(idCliente);
        }
    }
}
