using Entities.Models;
using MailKit.Net.Smtp;
using MimeKit;
using Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class MailManager : IMailService
    {

        //private MailModel model = new MailModel();
        private int CreateConfirmKey()
        {
            Random random = new Random();
            int key = random.Next(10000, 99999);
            return key;


        }
        public async Task<MailModel> SendPasswordRecoveryCode(MailModel model)
        {
            model = AddBodyForgetPasswordKey(model);
            model.Subject = "Şifre Değişikliği talebi....";
            await SendMailAsync(model);

            return model;
        }

        private MailModel AddBodyForgetPasswordKey(MailModel model)
        {
            var key = CreateConfirmKey();

            model.Body = key + " şifre değiştirme kodunuz";

            return model;

        }

        private async Task<MimeMessage> CreateMail(MailModel model)
        {
            MimeMessage mimeMessage = new MimeMessage();

            MailboxAddress mailboxAddressFrom = new MailboxAddress("KANDAŞDESTEK", model.From);
            mimeMessage.From.Add(mailboxAddressFrom);

            MailboxAddress mailboxAddressTo = new MailboxAddress("Kullanıcı", model.To);
            mimeMessage.To.Add(mailboxAddressTo);

            var bodyBuilder = new BodyBuilder();
            bodyBuilder.TextBody = model.Body;
            mimeMessage.Body = bodyBuilder.ToMessageBody();

            mimeMessage.Subject = model.Subject;
            mimeMessage.Date = model.SendTime;
            return mimeMessage;
        }

        private async Task SendMailAsync(MailModel model)
        {
            var message = await CreateMail(model);
            
            using (var client = new SmtpClient())
            {

                await client.ConnectAsync("smtp.gmail.com", 587, false);
                client.Authenticate("kandasdestek@gmail.com", "fhcv zklw qfwk tsjm");
                await client.SendAsync(message);
                client.Disconnect(true);
            }

        }

       
    }
}
