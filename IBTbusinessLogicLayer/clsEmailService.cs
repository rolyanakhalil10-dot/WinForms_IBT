using System;
using System.Net;
using System.Net.Mail;

namespace IBTbusinessLogicLayer
{
    public class clsEmailService
    {
        public static void SendEmail(string toEmail, string subject, string body)
        {
            // Your Gmail address and App Password (NOT your normal password)
            string fromEmail = "rolyanakhalil10@gmail.com";
            string appPassword = "yoiesyurvqncihca";

            using (SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587))
            {
                smtpClient.Credentials = new NetworkCredential(fromEmail, appPassword);
                smtpClient.EnableSsl = true;
                smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtpClient.UseDefaultCredentials = false;

                MailMessage mail = new MailMessage();
                mail.From = new MailAddress(fromEmail);
                mail.To.Add(toEmail);
                mail.Subject = subject;
                mail.Body = body;
                mail.IsBodyHtml = false; // Set to true if you're sending HTML content

                try
                {
                    smtpClient.Send(mail);
                }
                catch (Exception ex)
                {
                    // Handle or log the exception here
                    throw new ApplicationException("Failed to send email: " + ex.Message);
                }
            }
        }
    }
}
