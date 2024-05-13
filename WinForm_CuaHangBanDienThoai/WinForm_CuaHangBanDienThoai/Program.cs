using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm_CuaHangBanDienThoai
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 
        public static frmLogin loginForm = null;
        public static frmMain mainForm = null;
        public static frmStaffs staffsForm = null;
        public static frmCategories categoriesForm = null;
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmLogin ());
        }
    }
}
