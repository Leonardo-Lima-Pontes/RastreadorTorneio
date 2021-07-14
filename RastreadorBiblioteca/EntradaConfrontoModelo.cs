using System;
using System.Collections.Generic;
using System.Text;

namespace RastreadorBiblioteca
{
    public class EntradaConfrontoModelo
    {
        /// <summary>
        /// Representa um time no confronto
        /// </summary>
        public TimeModelo TimeCompetindo { get; set; }
        /// <summary>
        /// Representa a pontuação deste time
        /// </summary>
        public double Pontuacao { get; set; }
        /// <summary>
        /// Representa o confronto do qual este time veio vencedor
        /// </summary>
        public ConfrontoModelo ConfrontoPai { get; set; }
    }
}
