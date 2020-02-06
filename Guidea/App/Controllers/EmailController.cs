using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using App.DTOs;
using App.Exentions;
using Microsoft.AspNetCore.Mvc;

namespace App.Controllers
{
    public class EmailController : Controller
    {
        private const string hostMail = "info.guideia@gmail.com";
        private const string passportMail = "Guideia@001";
         [HttpPost]
        public IActionResult Send(EmailDto emailDto)
        {
            var resultString = "Email Sent Successfully!";
            try
            {
                // Credentials   "info.guideia@gmail.com", "Guideia_001"
                var credentials = new NetworkCredential(hostMail, passportMail);

                // Mail message
                var mail = new MailMessage()
                {
                    From = new MailAddress(emailDto.Email),
                    Subject = "From Site Contact Form",
                    Body = emailDto.Message.Compose(emailDto.Name,emailDto.Phone,emailDto.Email)
                    
                };

                mail.IsBodyHtml = false;
                //mail.To.Add(new MailAddress(emailDto.Email));
                mail.To.Add(new MailAddress(hostMail));


                // Smtp client
                var client = new SmtpClient()
                {
                    Port = 587,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    UseDefaultCredentials = false,
                    Host = "smtp.gmail.com",
                    EnableSsl = true,
                    Credentials = credentials
                };
                client.EnableSsl = true;
                client.Send(mail);
            }
            catch (System.Exception e)
            {
                resultString = e.Message;
            }
            var result = resultString;
            return RedirectToAction("Contact", "Home", resultString);

            
        }
    }
}