using Frei.ProjetoIntegrador.Academia.DB.Usuario;
using Nsf._2018.Modulo3.App.DB.Produto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nsf._2018.Modulo3.App
{
    static class UserSession
    {
        public static UsuarioDTO UsuarioLogado { get; set; }
    }
}
