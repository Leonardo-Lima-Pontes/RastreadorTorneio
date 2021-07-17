using RastreadorBiblioteca;
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

            //Inicia as conenexões com as respectivas bases de dados, no caso sql server e arquivo de texto
            RastreadorBiblioteca.ConfiguracaoGlobal.IniciarConexoes(TipoBaseDeDados.ArquivoTexto);
            Application.Run(new FormularioCriarPremio());
            //Application.Run(new FormularioInicial());
        }
    }
}
