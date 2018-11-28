using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageCleaner
{
    static class Program
    {
        // Главная точка входа для приложения.
	// Entrance point of program
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
	//Are u sure it is a good idea to do your labs this way???
    }
}
