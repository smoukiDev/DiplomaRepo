using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Net.Mail;
using System.Net;

namespace DiplomaClient
{
    class SecurityModule
    {
        /// <summary>
        /// Salt Generation Method
        /// </summary>
        /// <param name="size">Salt String Lenth</param>
        /// <returns>Salt String of Input Lenth value generated randomly</returns>
       public string GenerateSalt(int size)
       {
            var rng = new RNGCryptoServiceProvider();
            var buff = new byte[size];
            rng.GetBytes(buff);
            return Convert.ToBase64String(buff);
       }
       /// <summary>
       /// Hash String Method
       /// </summary>
       /// <param name="input">string to hash</param>
       /// <param name="salt">salt string</param>
       /// <returns>Hash String</returns>
       public string GenerateSHA256Hash(string input, string salt)
       {
            var bytes = Encoding.UTF8.GetBytes(input + salt);
            SHA256Managed obj = new SHA256Managed();
            var hash = obj.ComputeHash(bytes);
            return Convert.ToBase64String(hash);
       }
       public string GenerateSHA256Hash(string input)
       {
            var bytes = Encoding.UTF8.GetBytes(input);
            SHA256Managed obj = new SHA256Managed();
            var hash = obj.ComputeHash(bytes);
            return Convert.ToBase64String(hash);
       }

       const string supportName = "DM Analytics Service";
       const string supportEmail = "smakdealcase@gmail.com";
       const string supportImageLink = @"https://www.techfunnel.com/wp-content/uploads/2018/04/Top-Business-Intelligence-Tools-List-for-Comparison.jpg";
       const string supportImageTitle = "supportImage";
       const string supportSmtpServer = "smtp.gmail.com";
       const int supportPort = 587;
       
        /// <summary>
        /// Method send confirm code on user Email & Return Protected Hash in Program Code
        /// </summary>
        /// <param name="email">user email</param>
        /// <param name="code">generated confirm code</param>
        /// <returns>confirm code hash</returns>
       public string ForgotPasswordConfirmCode(string email, string code)
       {

            MailAddress from = new MailAddress(supportEmail, supportName);
            MailAddress to = new MailAddress(email);
            MailMessage m = new MailMessage(from, to);
            m.Subject = "Password Reset Confirmation Code";            
            m.Body = $"<h2>Code enables access to password reset: {code}</h2><br/><img src = {supportImageLink}  alt={supportImageTitle} />";
            m.IsBodyHtml = true;
            SmtpClient smtp_server = new SmtpClient(supportSmtpServer, supportPort);
            smtp_server.UseDefaultCredentials = false;
            //gmail special password for application is required
            //make security for GMAIL Pass
            smtp_server.Credentials = new NetworkCredential(supportEmail, "fsodgumrrohkccmp");
            smtp_server.EnableSsl = true;
            smtp_server.Send(m);
            return  GenerateSHA256Hash(code);
       }
        const int codeLenth = 6;
       public string GenerateForgotPasswordConfirmCode()
        {
            Random random = new Random();
            string res = null;
            for (int i = 0; i < codeLenth; i++)
            {
                res += random.Next(0, 9);
            }
            return res;
        }

       
    }
}




//Gmail port 587 works very well
//MailAddress from = new MailAddress("smakdealcase@gmail.com", "Sergii");

//MailAddress to = new MailAddress("smakdealcase@gmail.com");

//MailMessage m = new MailMessage(from, to);

//m.Subject = "Recall Password";

//            m.Body = "<h2>Your New Password sdijfos</h2>";

//            m.IsBodyHtml = true;
            
//            SmtpClient smtp_server = new SmtpClient("smtp.gmail.com", 587);
//smtp_server.UseDefaultCredentials = false;
//            //gmail special password for application is required
//            smtp_server.Credentials = new NetworkCredential("smakdealcase@gmail.com", "fsodgumrrohkccmp");


//smtp_server.EnableSsl = true;

//            smtp_server.Send(m);

            
            

//           MessageBox.Show("Letter has been sent on your Email", "@info", MessageBoxButtons.OK, MessageBoxIcon.Information); 