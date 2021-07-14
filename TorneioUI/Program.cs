using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TorneioUI
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            RastreadorBiblioteca.ConfiguracaoGlobal.IniciarConexoes(true, true);
            Application.Run(new FormularioCriarPremio());
            //Application.Run(new FormularioInicial());
        }
    }
}
