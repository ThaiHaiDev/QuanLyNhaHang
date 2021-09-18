using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace CK_QLNH
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login_Form());
            //Login floginQL = new Login();
            //Login floginNV = new Login();
            //if (floginQL.ShowDialog() == DialogResult.OK)
            //{
            //    Application.Run(new QuanLyForm());
            //}
            //else if(floginNV.ShowDialog() == DialogResult.OK)
            //{
            //    Application.Run(new NhanVienForm());
            //}    
            //else
            //{
            //    Application.Exit();
            //}
        }
    }
}
