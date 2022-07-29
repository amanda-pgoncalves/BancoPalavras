namespace Site01.Library.Mail
{
    public class Constants
    {
        /**
         * POP3, IMPA - Ler mensagem de e-mail
         * SMTP - Enviar e-mail
         */

        // Autenticação - Gmail
        public readonly static string Usuario = "email@email.com.br";
        public readonly static string Senha = "naoexiste";


        // Servidor SMTP
        public readonly static string ServidorSMTP = "smtp.gmail.com";
        public readonly static int PortaSMTP = 587;

    }
}
