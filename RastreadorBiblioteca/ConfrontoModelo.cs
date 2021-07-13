using System;
using System.Collections.Generic;
using System.Text;

namespace RastreadorBiblioteca
{
    class ConfrontoModelo
    {
        /// <summary>
        /// 
        /// </summary>
        public List<EntradaConfrontoModelo> Entrada { get; set; } = new List<EntradaConfrontoModelo>();
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
