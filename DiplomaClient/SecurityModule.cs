using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Net.Mail;
using System.Net;
using System.Configuration;

namespace DiplomaClient
{
    class SecurityModule
    {
        /// <summary>
        /// Salt Generation Method
        /// </summary>
        /// <param name="size">Lenght of resultant salt string</param>
        /// <returns>Salt string with specified size</returns>
       public string GenerateSalt(int size)
       {
            var rng = new RNGCryptoServiceProvider();
            var buff = new byte[size];
            rng.GetBytes(buff);
            return Convert.ToBase64String(buff);
       }
       /// <summary>
       /// Generate Hash String Method
       /// </summary>
       /// <param name="input">string to hash</param>
       /// <param name="salt">salt string</param>
       /// <returns>Hash String joining input and salt</returns>
       public string GenerateSHA256Hash(string input, string salt)
       {
            var bytes = Encoding.UTF8.GetBytes(input + salt);
            SHA256Managed obj = new SHA256Managed();
            var hash = obj.ComputeHash(bytes);
            return Convert.ToBase64String(hash);
       }
        /// <summary>
        /// Generate Hash String Method
        /// </summary>
        /// <param name="input">string to hash</param>
        /// <returns>Hash String of input</returns>
        public string GenerateSHA256Hash(string input)
       {
            var bytes = Encoding.UTF8.GetBytes(input);
            SHA256Managed obj = new SHA256Managed();
            var hash = obj.ComputeHash(bytes);
            return Convert.ToBase64String(hash);
       }
        
       //Service Email Parameters 
       const string supportName = "DM Analytics Service";
       const string supportEmail = "smakdealcase@gmail.com";
       //Using projroot/Image/EmailSupport.jpg located in web
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
            //gmail special password for application is used
            //!!!disable special pass in order of no using app
            smtp_server.Credentials = new NetworkCredential(supportEmail, "fsodgumrrohkccmp");
            smtp_server.EnableSsl = true;
            smtp_server.Send(m);
            return  GenerateSHA256Hash(code);
       }
       
       //Lenght of confirmation code  
       const int codeLenth = 6;
        /// <summary>
        /// Generate digital confirmation code
        /// </summary>
        /// <returns>digital confirmation code</returns>
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

        //connection strings
        string SalesHistotyConnectionSrting = Properties.Settings.Default.cnSalesHistory;
        public string SalesHistotyConnectionSrtingProp { get { return SalesHistotyConnectionSrting; } }

    }
}

