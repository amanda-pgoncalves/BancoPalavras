using Site01.Models;
using System.Net.Mail;
using System.Net;

namespace Site01.Library.Mail
{
    public class EnviarEmail
    {
        public static void EnviarMensagemContato(Contato contato)
        {
            string conteudo = string.Format("Nome: {0}<br /> E-mail: {1}<br /> Assunto: {2}<br /> Mensagem: {3}", contato.Nome, contato.Email, contato.Assunto, contato.Mensagem);
            // Configurar Servidor SMTP

            SmtpClient smtp = new SmtpClient(Constants.ServidorSMTP, Constants.PortaSMTP);
            smtp.EnableSsl = true;
            smtp.UseDefaultCredentials = false;
            smtp.Credentials = new NetworkCredential(Constants.Usuario, Constants.Senha);

            //Mensagem Email
            MailMessage mensagem = new MailMessage();
            mensagem.From = new MailAddress("email@email.com.br");
            mensagem.To.Add("email@email.com.br");
            mensagem.Subject = "Formulário de contato";

            mensagem.IsBodyHtml = true;
            mensagem.Body = "<h1>Formulário de contato</h1>" + conteudo;

            smtp.Send(mensagem);
        }
    }
}
