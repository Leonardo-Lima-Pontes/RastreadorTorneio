using System;
using System.Collections.Generic;
using System.Text;

namespace RastreadorBiblioteca
{
    class PremioModelo
    {
        /// <summary>
        /// Qual é a colocação do membro do time
        /// </summary>
        public int NumeroColocacao { get; set; }
        /// <summary>
        /// Qual é o nome deste colocação
        /// </summary>
        public string ColocacaoNome { get; set; }
        /// <summary>
        /// Qual é o valor do premio
        /// </summary>
        public decimal PremioValor { get; set; }
        /// <summary>
        /// Qual é a porcentagem do preio
        /// </summary>
        public double PremioPorcentagem { get; set; }
    }
}
