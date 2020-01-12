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

            Application.ThreadException +=new ThreadExceptionEventHandler(ThreadException);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmOnlineSale());
        }

        static void ThreadException(object sender, ThreadExceptionEventArgs e)
        {
            Exception ex = e.Exception;
            using (System.IO.StreamWriter file =
           new System.IO.StreamWriter(@".\ErrorLog.log"))
            {
                file.WriteLine(ex.Message);
            }
            MessageBox.Show(ex.Message);
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
