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
        /// Recebe o nome do arquivo e concatecna com a configuração inicial de onde deve ser salvo o arquivo
        /// </summary>
        /// <param name="nomeArquivo">
        /// Nomo do arquivo
        /// </param>
        /// <returns>Nome do caminho completo onde devera ser salvo</returns>
        public static string CaminhoArquivoCompleto(this string nomeArquivo)
        {
            return $"{ConfigurationManager.AppSettings["caminhoArquivo"]}\\{nomeArquivo}";
        }

        /// <summary>
        /// Carrega o arquivo com o nome do arquivo especificado e retorna as linhas do arquivo
        /// </summary>
        /// <param name="nome">Nome do arquivo</param>
        /// <returns>Arquivo</returns>
        public static List<string> CarregarArquivo(this string nome)
        {
            if (!File.Exists(nome))
            {
                return new List<string>();
            }

            return File.ReadAllLines(nome).ToList();
        }

        /// <summary>
        /// Pega cada linha do aquivo recebido como parametro e converte para premio
        /// </summary>
        /// <param name="linhas">Linhas do arquivo</param>
        /// <returns>Lista de premios</returns>
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

        /// <summary>
        /// Converte cada linha do arquivo para pessoa
        /// </summary>
        /// <param name="linhas">Linhas do arquivo</param>
        /// <returns>Lista de pessoas</returns>
        public static List<PessoaModelo> ConverterParaPessoaModelo(this List<string> linhas)
        {
            List<PessoaModelo> pessoaSaida = new List<PessoaModelo>();

            foreach (string linha in linhas)
            {
                string[] colunas = linha.Split(',');

                PessoaModelo pessoa = new PessoaModelo();
                pessoa.Id = int.Parse(colunas[0]);
                pessoa.PrimeiroNome = colunas[1];
                pessoa.UltimoNome = colunas[2];
                pessoa.Telefone = colunas[3];
                pessoa.Email = colunas[4];
                pessoa.DataCriacao = DateTime.Parse(colunas[5]);
                pessoaSaida.Add(pessoa);
            }

            return pessoaSaida;
        }

        /// <summary>
        /// Converte cada linha do arquivo para time
        /// </summary>
        /// <param name="lines">linhas do arquivo</param>
        /// <param name="pessoaNomeArquivo">lista de times</param>
        /// <returns></returns>
        public static List<TimeModelo> ConverterParaTimeModelo(this List<string> lines, string pessoaNomeArquivo)
        {
            List<TimeModelo> saidaTimeModelo = new List<TimeModelo>();
            List<PessoaModelo> pessoas = pessoaNomeArquivo.CaminhoArquivoCompleto().CarregarArquivo().ConverterParaPessoaModelo();

            foreach (string line in lines)
            {
                string[] colunas = line.Split(',');

                TimeModelo time = new TimeModelo();
                time.Id = int.Parse(colunas[0]);
                time.NomeTime = colunas[1];

                string[] pessoaIds = colunas[2].Split('|');

                foreach (string id in pessoaIds)
                {
                    time.MembrosTime.Add(pessoas.Where(x => x.Id == int.Parse(id)).First());
                }

                saidaTimeModelo.Add(time);
            }

            return saidaTimeModelo;
        }

        /// <summary>
        /// Salva a lista de premios no caminho especificado
        /// </summary>
        /// <param name="modelos">Lista de premios</param>
        /// <param name="nomeArquivo">Caminho onde o arquivo deve ser salvo</param>
        public static void SalvarParaPremioArquivo(this List<PremioModelo> modelos, string nomeArquivo)
        {
            List<string> linhas = new List<string>();

            foreach (PremioModelo p in modelos)
            {
                linhas.Add($"{p.Id}, {p.NumeroColocacao}, {p.ColocacaoNome}, {p.PremioValor}, {p.PremioPorcentagem}");
            }

            File.WriteAllLines(nomeArquivo.CaminhoArquivoCompleto(), linhas);
        }

        /// <summary>
        /// Salva a lista de pessoas no caminho especificado
        /// </summary>
        /// <param name="modelos">Lista de pessoas</param>
        /// <param name="nomeArquivo">Caminho onde o arquivo deve ser salvo</param>
        public static void SalvarParaPessoaArquivo(this List<PessoaModelo> modelos, string nomeArquivo)
        {
            List<string> linhas = new List<string>();

            foreach (PessoaModelo p in modelos)
            {
                linhas.Add($"{p.Id}, {p.PrimeiroNome}, {p.UltimoNome}, {p.Telefone}, {p.Email}, {p.DataCriacao}");
            }

            File.WriteAllLines(nomeArquivo.CaminhoArquivoCompleto(), linhas);
        }

        public static void SalvarParaTimeArquivo(this List<TimeModelo> modelos, string nomeArquivo)
        {
            List<string> linhas = new List<string>();

            foreach (TimeModelo time in modelos)
            {
                linhas.Add($"{time.Id }, {time.NomeTime}, {ConverterPessoasListaParaString(time.MembrosTime)}");
            }

            File.WriteAllLines(nomeArquivo.CaminhoArquivoCompleto(), linhas);
        }

        /// <summary>
        /// Converte a lista de pessoas para string
        /// </summary>
        /// <param name="pessoas">lista de pessoas</param>
        /// <returns>string (linhas) de pessoas</returns>
        public static string ConverterPessoasListaParaString(List<PessoaModelo> pessoas)
        {
            string pessoasSaida = "";

            if (pessoas.Count == 0)
            {
                return "";
            }

            foreach (PessoaModelo pessoa in pessoas)
            {
                pessoasSaida += $"{pessoa.Id} |";
            }

            pessoasSaida = pessoasSaida.Substring(0, pessoasSaida.Length - 1);

            return pessoasSaida;
        }

    }
}
