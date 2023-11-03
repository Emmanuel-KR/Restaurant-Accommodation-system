using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RESTAURANT_ACCOMODATION_SYSTEM
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
#pragma warning disable CS0246 // The type or namespace name 'RoomDetails' could not be found (are you missing a using directive or an assembly reference?)
            Application.Run(new loginForm());
#pragma warning restore CS0246 // The type or namespace name 'RoomDetails' could not be found (are you missing a using directive or an assembly reference?)
        }
    }
}
