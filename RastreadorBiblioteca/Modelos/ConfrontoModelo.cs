using System;
using System.Collections.Generic;
using System.Text;

namespace RastreadorBiblioteca.Modelos
{
    public class ConfrontoModelo
    {
        /// <summary>
        /// Identificador unico para o confront (gerado automaticamente pelo banco de dados)
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// O id do banco de dados que vai ser usado apra identificar o vencedor
        /// </summary>
        public int VendedorId { get; set; }

        /// <summary>
        /// Lista de times (dois times) que irão compor o confronto
        /// </summary>
        public List<TimeConfrontoModelo> TimeCompetindo { get; set; } = new List<TimeConfrontoModelo>();

        /// <summary>
        /// Qual é o vencedor da rodada
        /// </summary>
        public TimeModelo Vencedor { get; set; }

        /// <summary>
        /// Numero da rodada do confronto
        /// </summary>
        public int RodadaConfronto { get; set; }

        /// <summary>
        /// Realiza a juntas dos nomes dos times que estão competindo neste
        /// confronto com VS (time a VS time b)
        /// </summary>
        public string NomeTimesConfronto
        {
            get
            {
                string saida = "";

                foreach (TimeConfrontoModelo timeConfronto in TimeCompetindo)
                {
                    if (timeConfronto.TimeCompetindo != null)
                    {
                        if (saida.Length == 0)
                        {
                            saida = timeConfronto.TimeCompetindo.NomeTime;
                        }
                        else
                        {
                            saida += $" VS {timeConfronto.TimeCompetindo.NomeTime}";
                        }
                    }
                    else
                    {
                        saida = "Partida ainda não aconteceu";
                        break;
                    }
                }

                return saida;
            }
        }
    }
}
