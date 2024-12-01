using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class Mail
    {
        private string sendMailAddress;

        public string SendMailAddress
        {
            get { return sendMailAddress; }
            set { sendMailAddress = value; }
        }

        private string password;

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        private string receiveMailAddress;

        public string ReceiveMailAddress
        {
            get { return receiveMailAddress; }
            set { receiveMailAddress = value; }
        }

        public Mail(string sendMail, string password, string receiveMail)
        {
            this.SendMailAddress = sendMail;
            this.Password = password;
            this.ReceiveMailAddress = receiveMail;
        }

        public void SendMail(string logFile)
        {
            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

                mail.From = new MailAddress(sendMailAddress);
                mail.To.Add(receiveMailAddress);
                mail.Subject = "Báo cáo ngày: " + DateTime.Now.ToShortDateString();

                if (File.Exists(logFile))
                {
                    StreamReader sr = new StreamReader(logFile);

                    mail.Body += sr.ReadToEnd();

                    sr.Close();
                }

                SmtpServer.Port = 587;
                SmtpServer.Credentials = new System.Net.NetworkCredential(sendMailAddress, password);
                SmtpServer.EnableSsl = true;

                SmtpServer.Send(mail);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}