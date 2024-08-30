using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Net;

//<%-- [6.Registro Trainee - output SQL - MailTrap]--%
namespace Service
{
    public class EmailService
    {
        private MailMessage email;
        private SmtpClient server;

        public EmailService()
        {
            server = new SmtpClient();

            //<%-- [7.Registro Trainee - output SQL - MailTrap]--%
            //Debemos ingresar a este url https:/mailtrap.io/inboxes/3092330/messages, para actulizar
            //el correo y la constraneia
            server.Credentials = new NetworkCredential("825a27e7347de5", "fc482bdd72f001");
            server.EnableSsl = true;
            server.Port = 2525;
            server.Host = "sandbox.smtp.mailtrap.io";
        }

        public void ArmarCorreo(string emailDestino, string asunto, string cuerpo)
        {
            email = new MailMessage();
            email.From = new MailAddress("noresponder@pokedexweb.com");
            email.To.Add(emailDestino);
            email.Subject = asunto;
            email.IsBodyHtml = true;
            //email.Body = "<h1> Que joraca es esto</h1>";
            email.Body = cuerpo;
        }
        public void enviarEmail()
        {
            try
            {
                server.Send(email);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

    }

}
