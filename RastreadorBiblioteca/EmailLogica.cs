using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Mail;

namespace RastreadorBiblioteca
{
    class EmailLogica
    {
        internal static void EnviarEmail(string para, string assunt, string corpo)
        {
            MailAddress paraEnderecoEmail = new MailAddress(ConfiguracaoGlobal.AppKey("enviarEmail"), ConfiguracaoGlobal.AppKey("enviarMostrarEmail"));

            MailMessage email = new MailMessage();
            email.To.Add(para);
            email.From = paraEnderecoEmail;
            email.Subject = assunt;
            email.Body = corpo;
            email.IsBodyHtml = true;

            SmtpClient client = new SmtpClient();

            client.Send(email);

        }
    }
}
