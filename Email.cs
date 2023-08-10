using System.Net;
using System.Net.Mail;

namespace MVCProjectPractice
{
    public class Email : IMail
    {
        public static string Send(string Subject, string Body, string AttachmentPath)
        {
            try
            {
                string GmailAccount = "liamsanctus30@gmail.com";
                string GmailPassword = "Uriel@8899";
                string ToEmail = "IfeanyiEze8899@gmail.com";

                MailMessage myMail = new MailMessage(GmailAccount, ToEmail);
                myMail.Subject = Subject;
                myMail.Body = Body;
                myMail.IsBodyHtml = true;

                if (!string.IsNullOrEmpty(AttachmentPath))
                {
                    Attachment attachment = new Attachment(AttachmentPath);
                    myMail.Attachments.Add(attachment);
                    myMail.Priority = MailPriority.High;
                }
                SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587);
                smtpClient.EnableSsl = true;
                smtpClient.UseDefaultCredentials = false;
                smtpClient.Credentials = new NetworkCredential(GmailAccount, GmailPassword);
                smtpClient.Send(myMail);

                return "";
            }
            catch (Exception e)
            {
                return "error: " + e.Message;
            }
        }
    }
}
