using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()                                          //Punto de entrada de la aplicacion, como el "void setup" de Arduino ;)
        {
            Application.EnableVisualStyles();                       //Habilita los estilos visuales de la aplicacion, en este caso la ventana
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new fMain());
        }
    }
}
