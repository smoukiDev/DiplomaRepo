using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using System.Threading;
using System.Runtime.InteropServices;

namespace DiplomaClient
{
    static class Program
    {
        //static login form provides access to itself in any part of applocation
        internal static LoginForm loginform;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            
            try
            {
               //!!! Add Auto Setting Size of Image, which send to DB
               //!!! ProcedureRegisterImageBufSize = 1000000000
                
            }
            catch
            {

            }
            //Prevent running app twice or more
            bool isAppRun;
            string guid = Marshal.GetTypeLibGuidForAssembly(Assembly.GetExecutingAssembly()).ToString();
            Mutex muobj = new Mutex(true, guid, out isAppRun);
            if (!isAppRun)
                return;
            //Application Start Up
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(loginform = new LoginForm());           
            
        }
    }
    
}
