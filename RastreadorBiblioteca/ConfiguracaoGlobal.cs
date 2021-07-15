using RastreadorBiblioteca.AcessoDeDados;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;

namespace RastreadorBiblioteca
{
    public class ConfiguracaoGlobal
    {
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

