using System;
using Xamarin.Forms;
using Mundoarkano.Droid;
using MimeKit;
using MailKit.Net.Smtp;

[assembly : Dependency(typeof(EnviarEmail))]

namespace Mundoarkano.Droid
{
	public class EnviarEmail: IEmail
	{
		public void EnviarMail (string remitente, string destinatario, string asunto, string cuerpo)
		{
			var message = new MimeMessage ();
			message.From.Add(new MailboxAddress("Mundo Arkano", remitente));
			message.To.Add(new MailboxAddress(destinatario, destinatario));
			message.Subject = asunto;

			message.Body = new TextPart("plain")
			{
				Text = cuerpo
            };

			using (var client = new SmtpClient())
			{
				client.Connect("smtp.office365.com", 587, false);

				// Note: since we don't have an OAuth2 token, disable
				// the XOAUTH2 authentication mechanism.
				client.AuthenticationMechanisms.Remove("XOAUTH2");

				// Note: only needed if the SMTP server requires authentication
				client.Authenticate("mundoarkano@arkanosoft.com", "Passw0rd!");

				client.Send(message);

				client.Disconnect(true);
			}
		}

		public EnviarEmail ()
		{
		}
	}
}

