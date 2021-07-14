using System;
using System.Collections.Generic;
using System.Text;

namespace RastreadorBiblioteca
{
    public class ConfiguracaoGlobal
    {
        public static List<IConexaoDeDados> Conexoes { get; private set; } = new List<IConexaoDeDados>();

        public static void IniciarConexoes(bool basededados, bool arquivodetexto)
        {
            if (basededados)
            {
                //TODO - criar a propriedade de conexão com sql conector
                SqlConector sql = new SqlConector();
                Conexoes.Add(sql);
            }

            if (arquivodetexto)
            {
                //TODO - criar a propriedade de conexão com texto conector
                TextConector txt = new TextConector();
                Conexoes.Add(txt);
            }
        }
    }
}

