using RastreadorBiblioteca.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RastreadorBiblioteca
{
    /// <summary>
    /// Onde toda logica do torneio esta concentrada na criação das partidas
    /// </summary>
    public class TorneioLogica
    {
        /// <summary>
        /// Cria as partidas do torneio
        /// </summary>
        /// <param name="modelo">Objeto torneio</param>
        public static void CriarRodadas(TorneioModelo modelo)
        {
            List<TimeModelo> timesAleatorios = AleatorizarTimes(modelo.TimesIncritos);
            int rodadas = EncontrarNumeroDeRodadas(timesAleatorios.Count);
            int quantidadePasses = NumeroDePasseLivre(rodadas, timesAleatorios.Count);

            modelo.Rodadas.Add(CriaPrimeiraRodada(quantidadePasses, timesAleatorios));

            CriarAsRodadasRestantes(modelo, rodadas);
        }

        /// <summary>
        /// Cria todas as partidas restantes do torneio
        /// </summary>
        /// <param name="torneio">Objeto torneio</param>
        /// <param name="rodadas">Quantas rodadas o toneio tem</param>
        private static void CriarAsRodadasRestantes(TorneioModelo torneio, int rodadas)
        {
            int rodada = 2;
            List<ConfrontoModelo> rodadaAnterior = torneio.Rodadas[0];
            List<ConfrontoModelo> rodadaAtual = new List<ConfrontoModelo>();
            ConfrontoModelo confrontoAtual = new ConfrontoModelo();

            while (rodada <= rodadas)
            {
                foreach (ConfrontoModelo confronto in rodadaAnterior)
                {
                    confrontoAtual.TimeCompetindo.Add(new TimeConfrontoModelo { ConfrontoPai = confronto });

                    if (confrontoAtual.TimeCompetindo.Count > 1)
                    {
                        confrontoAtual.RodadaConfronto = rodada;
                        rodadaAtual.Add(confrontoAtual);
                        confrontoAtual = new ConfrontoModelo();
                    }
                }

                torneio.Rodadas.Add(rodadaAtual);
                rodadaAnterior = rodadaAtual;

                rodadaAtual = new List<ConfrontoModelo>();
                rodada += 1;
            }

        }

        /// <summary>
        /// Cria a primeira rodada do torneio já com o times que utilizarão os passes livres
        /// </summary>
        /// <param name="quantidadePasses">Quantidade de passes livres para a próxima fases</param>
        /// <param name="times">times que irão compor a primeira partida do torneio</param>
        /// <returns></returns>
        private static List<ConfrontoModelo> CriaPrimeiraRodada(int quantidadePasses, List<TimeModelo> times)
        {
            List<ConfrontoModelo> saidaConfrontosDaPrimeiraRodada = new List<ConfrontoModelo>();
            ConfrontoModelo confronto = new ConfrontoModelo();

            foreach (TimeModelo time in times)
            {
                confronto.TimeCompetindo.Add(new TimeConfrontoModelo { TimeCompetindo = time });

                if (quantidadePasses > 0 || confronto.TimeCompetindo.Count > 1) 
                {
                    confronto.RodadaConfronto = 1;
                    saidaConfrontosDaPrimeiraRodada.Add(confronto);
                    confronto = new ConfrontoModelo();

                    if (quantidadePasses > 0)
                    {
                        quantidadePasses -= 1;
                    }
                }
            }

            return saidaConfrontosDaPrimeiraRodada;
        }

        /// <summary>
        /// Numero de passes livres que times que não vão ter oponentes na primeira fase
        /// o torneio deve possui para que o mesmo aconteça 
        /// </summary>
        /// <param name="partidas"></param>
        /// <param name="quantidadeTimes"></param>
        /// <returns></returns>
        private static int NumeroDePasseLivre(int partidas, int quantidadeTimes)
        {
            int saidaQuantidadePasses = 0;

            // total de times que o campeonato deve ter para que o mesmo aconteça
            int totalTimes = 1;

            for (int i = 1; i <= partidas; i++)
            {
                totalTimes *= 2;
            }

            saidaQuantidadePasses = totalTimes - quantidadeTimes;

            return saidaQuantidadePasses;
        }

        /// <summary>
        /// Realiza o calculo para saber quantas partidas o torneio irá ter
        /// com base no numero de times participantes do torneio
        /// </summary>
        /// <param name="quantidadeTimes">Quantidade de times que o torneio possui</param>
        /// <returns>Quantidade de partidas que o torneio irá ter</returns>
        private static int EncontrarNumeroDeRodadas(int quantidadeTimes)
        {
            int saidaQuantidadePartidas = 1;
            int val = 2;

            while (val < quantidadeTimes)
            {
                saidaQuantidadePartidas += 1;
                val *= 2;
            }

            return saidaQuantidadePartidas;
        }

        /// <summary>
        /// Aleatoriza a lista de time
        /// </summary>
        /// <param name="times">Lista de times</param>
        /// <returns>Lista de times já aleatorizados</returns>
        private static List<TimeModelo> AleatorizarTimes(List<TimeModelo> times)
        {
            return times.OrderBy(x => Guid.NewGuid()).ToList();
        }
    }
}
