using Blibioteca.Developers.APIs.Email;
using Frei.ProjetoIntegrador.Academia.Modulos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frei.ProjetoIntegrador.Academia.Validacoes
{
    class Email
    {
        public void Validar(string e_mail, string nome)
        {
            EmailDTO email = new EmailDTO();
            email.DestinatarioEmail = e_mail;
            email.DestinatarioNome = nome;

            EmailSend send = new EmailSend();
            int cod = send.CodEmailVerificar(email);

            frmVerificarEmail frm = new frmVerificarEmail();
            frm.Codigo(cod);
            frm.ShowDialog();

            if (frm.Verificado == false)
                throw new ArgumentException("O email não foi verificado!");
        }
    }
}
