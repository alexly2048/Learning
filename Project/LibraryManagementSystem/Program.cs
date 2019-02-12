using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryManagementSystem.UI;

namespace LibraryManagementSystem
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            frmLogin login = new frmLogin();
          bool? result =   login.ShowDialog();
            if(result == true)
            {
                frmMain main = new frmMain();
                App app = new App();
                app.Run(main);
            }
            else
            {
                Environment.Exit(0);
            }

        }
    }

}
