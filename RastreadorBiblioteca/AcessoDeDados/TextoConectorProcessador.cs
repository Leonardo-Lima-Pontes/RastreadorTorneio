using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;
using System.IO;
using System.Linq;
using RastreadorBiblioteca.Modelos;

namespace RastreadorBiblioteca.AcessoDeDados.ConectorDeTexto
{
    public static class TextoConectorProcessador
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="nomeArquivo"></param>
        /// <returns></returns>
        public static string CaminhoArquivoCompleto(this string nomeArquivo)
        {
            return $"{ConfigurationManager.AppSettings["caminhoArquivo"]}\\{nomeArquivo}";
        }

        public static List<string> CarregarArquivo(this string nome)
        {
            if (!File.Exists(nome))
            {
                return new List<string>();
            }

            return File.ReadAllLines(nome).ToList();
        }

        public static List<PremioModelo> ConverterParaPremioModelo(this List<string> linhas)
        {
            List<PremioModelo> premioSaida = new List<PremioModelo>();

            foreach (var linha in linhas)
            {
                string[] colunas = linha.Split(',');

                PremioModelo premio = new PremioModelo();

                premio.Id = int.Parse(colunas[0]);
                premio.NumeroColocacao = int.Parse(colunas[1]);
                premio.ColocacaoNome = colunas[2];
                premio.PremioValor = decimal.Parse(colunas[3]);
                premio.PremioPorcentagem = double.Parse(colunas[4]);

                premioSaida.Add(premio);
            }

            return premioSaida;
        }

        public static void SalvarParaPremioArquivo(this List<PremioModelo> modelos, string nomeArquivo)
        {
            List<string> linhas = new List<string>();

            foreach (PremioModelo p in modelos)
            {
                linhas.Add($"{p.Id}, {p.NumeroColocacao}, {p.ColocacaoNome}, {p.PremioValor}, {p.PremioPorcentagem}");
            }

            File.WriteAllLines(nomeArquivo.CaminhoArquivoCompleto(), linhas);
        }
    }
}
