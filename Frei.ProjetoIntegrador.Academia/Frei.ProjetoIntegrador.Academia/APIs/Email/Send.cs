using Frei.ProjetoIntegrador.Academia.Criptografia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Frei.ProjetoIntegrador.Academia.APIs.Email
{
    class Send
    {
        public void EnviarEmail(EmailDTO dto)
        {
            MailMessage mail = new MailMessage();

            //mail.Sender = new MailAddress(dto.ReceptorEmail, EmailDTO.remetente);
            mail.From = new MailAddress(EmailDTO.email, EmailDTO.remetente);
            mail.To.Add(new MailAddress(dto.ReceptorEmail, dto.ReceptorNome));
            mail.Subject = dto.Assunto;
            mail.Body = bodyEmail(dto.CodVerificacao, dto.ReceptorNome);
            mail.IsBodyHtml = true;
            mail.Priority = MailPriority.High;

            try
            {
                var smtp = new SmtpClient("smtp.gmail.com");

                smtp.EnableSsl = true; // GMail requer SSL
                smtp.Port = 587;       // porta para SSL
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network; // modo de envio
                smtp.UseDefaultCredentials = false; // vamos utilizar credencias especificas

                // seu usuário e senha para autenticação
                smtp.Credentials = new NetworkCredential(EmailDTO.email, SenhaCripto());

                // envia o e-mail
                smtp.Send(mail);
            }
            catch (Exception erro)
            {
                MessageBox.Show($"Ocorreu um erro: {erro.Message}");
            }
            finally
            {
                mail = null;
            }
        }

        private string SenhaCripto()
        {
            DESCripto cripto = new DESCripto();
            string chave = "camaleao";

            string senha = cripto.Descriptografar(chave, "qZ3ITTGVzu0kdIPfsbDJWQ==");
            return senha;
        }

        private string bodyEmail(int cod, string nome)
        {
            string body = $"<CENTER><h1>PB Technology ©<h1></CENTER><font><br><p>Olá {nome}, Você está cadastrando-se em nosso sistema, para finalizar seu cadastro informe o código abaixo.</p><p>Seu código de verificação é: {cod}.</p><p>Caso não tenha feito isso, desconsidere este email!</p><br><p>Cordialmente,</p><p>CEO - Pedro Henrique Moreira Martins da Silva</p><p>Program Boys Technology LTDA</p></font>";
            return body;
        }
    }
}
