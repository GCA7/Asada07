using Asada2015.Entidades;
using Asada2015.GUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Asada2015
{
    static class Program
    {        
        /// <summary>
        /// Formulario principal de la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Usuario usu = new Usuario();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Principal(usu));
        }
    }
}
