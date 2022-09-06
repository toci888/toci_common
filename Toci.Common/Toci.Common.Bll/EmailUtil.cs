using MailKit.Security;
using MimeKit;
using System;
using System.Collections.Generic;
using System.Linq;
using MailKit.Net.Smtp;
using System.Text;
using System.Threading.Tasks;
using Toci.Common.Bll.Interfaces;

namespace Toci.Common.Bll
{
    public class EmailUtil : IEmailUtil
    {
        protected EmailSettings Settings;

        public EmailUtil(EmailSettings settings)
        {
            Settings = settings;
        }

        public virtual bool SendEmail(EmailContent content)
        {
            foreach (string emailTo in content.EmailTo)
            {
                MimeMessage message = new MimeMessage();
                message.From.Add(new MailboxAddress(content.From, Settings.AdminLoginAddress)); //content.EmailFrom
                message.To.Add(MailboxAddress.Parse(emailTo));
                message.Subject = content.Subject;
                message.Body = new TextPart(MimeKit.Text.TextFormat.Text)
                {
                    Text = content.Body
                };

                SmtpClient client = new SmtpClient();
                try
                {
                    client.Connect(Settings.SmtpAddress, Settings.Port, SecureSocketOptions.StartTls);
                    //authenticate client
                    client.Authenticate(Settings.AdminLoginAddress, Settings.AdminPassword);
                    client.Send(message);
                }
                catch (Exception ex)
                {
                    return false;
                }
                finally
                {
                    client.Disconnect(true);
                    client.Dispose();
                }
            }

            return true;
        }
    }
}
