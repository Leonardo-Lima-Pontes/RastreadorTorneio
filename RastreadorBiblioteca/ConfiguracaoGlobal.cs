using RastreadorBiblioteca.AcessoDeDados;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;

namespace RastreadorBiblioteca
{
    public static class ConfiguracaoGlobal
    {
        public const string PremioArquivo = "PremioModelo.csv";
        public const string PessoaArquivo = "PessoaModelo.csv";
        public const string TimeArquivo = "TimeModelo.csv";
        public const string TorneioArquivo = "TorneioModelo.csv";
        public const string ConfrontoArquivo = "ConfrontoModelo.csv";
        public const string TimeConfrontoArquivo = "TimeConfrontoModelo.csv";

        public static IConexaoDeDados Conexao { get; private set; }

        public static void IniciarConexoes(TipoBaseDeDados bd)
        {

            if (bd == TipoBaseDeDados.Sql)
            {
                //TODO - criar a propriedade de conexão com sql conector
                SqlConector sql = new SqlConector();
                Conexao = sql;
            }

            if (bd == TipoBaseDeDados.ArquivoTexto)
            {
                //TODO - criar a propriedade de conexão com texto conector
                TextoConector txt = new TextoConector();
                Conexao = txt;
            }
        }

        public static string ConexaoString(string nome)
        {
            return ConfigurationManager.ConnectionStrings[nome].ConnectionString;
        }
    }
}

