using System;
using System.Collections.Generic;
using System.Text;

namespace RastreadorBiblioteca
{
    class TorneioModelo
    {
        /// <summary>
        /// Nome do torneio
        /// </summary>
        public string TorneioNome { get; set; }
        /// <summary>
        /// Taxa de entrada a ser paga para participar do torneio
        /// </summary>
        public decimal TaxaEntrada { get; set; }
        /// <summary>
        /// Quais são os times inscritos que fazem parte deste torneio
        /// </summary>
        public List<TimeModelo> TimesIncritos { get; set; } = new List<TimeModelo>();
        /// <summary>
        /// Quais são os premios que os ganhadores do torneio irão receber
        /// </summary>
        public List<PremioModelo> Premios { get; set; } = new List<PremioModelo>();
        /// <summary>
        /// Partidas do torneio
        /// </summary>
        public List<List<ConfrontoModelo>> Partidas { get; set; } = new List<List<ConfrontoModelo>>();

    }
}
