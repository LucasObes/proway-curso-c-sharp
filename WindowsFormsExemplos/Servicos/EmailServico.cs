using MimeKit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MailKit.Net.Smtp;

namespace WindowsFormsExemplos.Servicos
{
    internal class EmailServico
    {
        public void EnviarEmail(string destinatario, string nomeDestinatario, string corpo, string assunto)
        {
            var mensagem = new MimeMessage();
            mensagem.From.Add(new MailboxAddress("Sistema ProWay", "franciscosensaulasexemplos@gmail.com"));
            mensagem.To.Add(new MailboxAddress(nomeDestinatario, destinatario));

            mensagem.Subject = assunto;
            mensagem.Body = new TextPart("plain")
            {
                Text = corpo
            };

            var cliente = new SmtpClient();
            cliente.Connect("smtp.gmail.com", 587, false);
            cliente.Authenticate("franciscosensaulasexemplos@gmail.com", "accjroaraswdlwrz");

            cliente.Send(mensagem);
            cliente.Disconnect(true);
        }
    }
}
