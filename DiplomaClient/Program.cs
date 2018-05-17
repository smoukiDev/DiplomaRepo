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
        internal static LoginForm loginform;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            
            //Prevent running app twice or more
            bool isAppRun;
            string guid = Marshal.GetTypeLibGuidForAssembly(Assembly.GetExecutingAssembly()).ToString();
            Mutex muobj = new Mutex(true, guid, out isAppRun);
            if (!isAppRun)
                return;
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(loginform = new LoginForm());
            //Application.Run(new HashTest());
        }
    }
    
}
