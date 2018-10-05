using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frei.ProjetoIntegrador.Academia.DB.FolhaPgmt
{
    class FolhaPgmtBusiness
    {
        public int SalvarFolha(FolhaPgmtDTO dto)
        {
            FolhaPgmtDatabase db = new FolhaPgmtDatabase();
            return db.SalvarFolha(dto);
        }

        public int AlterarFolha(FolhaPgmtDTO dto)
        {
            FolhaPgmtDatabase db = new FolhaPgmtDatabase();
            return db.AlterarFolha(dto);
        }

        public int RemoverFolha(int idFolha)
        {
            FolhaPgmtDatabase db = new FolhaPgmtDatabase();
            return db.RemoverFolha(idFolha);
        }

        public List<view_func_folha> Consultar()
        {
            FolhaPgmtDatabase db = new FolhaPgmtDatabase();
            return db.Consultar();
        }

        public view_func_folha ConsultarPorId(string id)
        {
            FolhaPgmtDatabase db = new FolhaPgmtDatabase();
            return db.ConsultarPorId(id);
        }
    }
}
