using CampusApS.Modelo.Logica;
using CampusApS.Modelo.Querys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CampusApS {
    static class Program {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main() {
            Console.WriteLine("\n\n\n\n\n");
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new PantallaBienvenido());
            Console.WriteLine("\n\n\n\n\n");
            
           }
    }
}
