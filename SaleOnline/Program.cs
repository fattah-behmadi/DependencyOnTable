using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaleOnline
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            DevExpress.XtraEditors.WindowsFormsSettings.SetDPIAware();
            DevExpress.XtraEditors.WindowsFormsSettings.EnableFormSkins();
            DevExpress.XtraEditors.WindowsFormsSettings.DefaultLookAndFeel.SetSkinStyle("Office 2016 Colorful");

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var culture = CultureInfo.CreateSpecificCulture("fa-IR");
            culture.NumberFormat.CurrencyPositivePattern = 3;
            clt clt = new clt();
            CultureInfo cul = new CultureInfo("fa-IR");
            clt.SetDefaultCulture(cul);

            Application.ThreadException += new ThreadExceptionEventHandler(ThreadException);
            Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);
            AppDomain.CurrentDomain.UnhandledException += new UnhandledExceptionEventHandler(CurrentDomain_UnhandledException);


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmOnlineSale());
        }

        static void CurrentDomain_UnhandledException(object sender,UnhandledExceptionEventArgs e)
        {
            Exception ex= (Exception)e.ExceptionObject;
            string error = "";
            if (ex.InnerException != null)
                error = ex.InnerException.Message;
            using (System.IO.StreamWriter file = new System.IO.StreamWriter(@".\ErrorLog.log", true, System.Text.Encoding.UTF8))
            {
                file.WriteLine("===================================");
               
                file.WriteLine(Utilities.JulianDateToFarsi(DateTime.Now));

                file.WriteLine(ex.Message);
                if(!string.IsNullOrEmpty(error))
                file.WriteLine(error);
                file.WriteLine("===================================");

            }
        }
        
        static void ThreadException(object sender, ThreadExceptionEventArgs e)
        {
            Exception ex = e.Exception;
            using (System.IO.StreamWriter file = new System.IO.StreamWriter(@".\ErrorLog.log", true, System.Text.Encoding.UTF8))
            {
                file.WriteLine("===================================");
                file.WriteLine(ex.Message);
                file.WriteLine("===================================");

            }

        }
        public class clt
        {
            public void SetDefaultCulture(System.Globalization.CultureInfo culture)
            {
                Type type = typeof(CultureInfo);
                try
                {
                    type.InvokeMember("s_userDefaultCulture", BindingFlags.SetField | BindingFlags.NonPublic | BindingFlags.Static, null, culture, new object[] { culture });
                    type.InvokeMember("s_userDefaultUICulture", BindingFlags.SetField | BindingFlags.NonPublic | BindingFlags.Static, null, culture, new object[] { culture });
                    type.InvokeMember("m_userDefaultCulture", BindingFlags.SetField | BindingFlags.NonPublic | BindingFlags.Static, null, culture, new object[] { culture });
                    type.InvokeMember("m_userDefaultUICulture", BindingFlags.SetField | BindingFlags.NonPublic | BindingFlags.Static, null, culture, new object[] { culture });
                }
                catch
                {
                }
            }

        }


    }
}
