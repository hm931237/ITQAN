using MailKit.Security;
using MimeKit;
using MimeKit.Text;
using SQLProvider.Interfaces;
using SQLProvider.Results;
using System;
using System.Collections.Generic;
using MailKit.Net.Smtp;
using MimeKit;
using MimeKit.Text;
using MailKit.Security;
using SQLProvider.Enums;

namespace SQLProvider.Repositories
{
    public class Mail : IMail
    {
        public Result Send()
        {
			try
			{
                var email = new MimeMessage();
                email.From.Add(MailboxAddress.Parse("Test@gmail.com"));
                email.To.Add(MailboxAddress.Parse("Test123@gmail.com"));
                email.Subject = "Test Email Subject";
                email.Body = new TextPart(TextFormat.Html) { Text = "<h1>Example HTML Message Body</h1>" };

                // send email
                using var smtp = new SmtpClient();
                smtp.Connect("smtp.gmail.com", 587, SecureSocketOptions.StartTls);
                smtp.Authenticate("Test@gmail.com", "Password");
                smtp.Send(email);
                smtp.Disconnect(true);

                return new Result { StatusCode = (int)Status.Success, Message = "Mail Sent Sucssesfully" };
            }
			catch (Exception)
			{

                return new Result { StatusCode = (int)Status.Fail, Message = "Faild" };
            }
        }
    }
}
