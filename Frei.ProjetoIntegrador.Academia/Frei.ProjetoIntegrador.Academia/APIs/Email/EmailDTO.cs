using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frei.ProjetoIntegrador.Academia.APIs.Email
{
    class EmailDTO
    {
        static public string email = "pb.technology.ltda@gmail.com";
        static public string remetente = "PB Technology";

        public string Assunto { get; set; }
        public string ReceptorNome { get; set; }
        public string ReceptorEmail { get; set; }

        public int CodVerificacao { get; set; }
    }
}
