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
    }
}
