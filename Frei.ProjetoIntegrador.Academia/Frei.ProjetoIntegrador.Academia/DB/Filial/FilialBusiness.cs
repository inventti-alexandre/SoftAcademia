using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frei.ProjetoIntegrador.Academia.DB.Filial
{
    class FilialBusiness
    {
        public int CadastrarFilial(FilialDTO dto)
        {
            FilialDatabase db = new FilialDatabase();
            return db.CadastrarFilial(dto);
        }

        public int AlterarFilial(FilialDTO dto)
        {
            FilialDatabase db = new FilialDatabase();
            return db.AlterarFilial(dto);
        }

        public int RemoverFilial(int idFilial)
        {
            FilialDatabase db = new FilialDatabase();
            return db.RemoverFilial(idFilial);
        }

        public List<FilialDTO> Consultar()
        {
            FilialDatabase db = new FilialDatabase();
            return db.Consultar();
        }


        public List<FilialDTO> ConsultarPorNome(string nome)
        {
            FilialDatabase db = new FilialDatabase();
            return db.ConsultarPorNome(nome);
        }
    }
}
