using System;
using System.Collections.Generic;
using System.Text;

namespace RastreadorBiblioteca.Modelos
{
    public class PremioModelo
    {
        /// <summary>
        /// O indenficador unido do prêmio
        /// </summary>
        public int Id { get; set; }
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

        public PremioModelo()
        {
        }

        public PremioModelo(string numeroColocacao, string colocacaoNome, string premioValor, string premioPorcentagem)
        {
            ColocacaoNome = colocacaoNome;

            int numeroColocacaoValor = 0;
            int.TryParse(numeroColocacao, out numeroColocacaoValor);
            NumeroColocacao = numeroColocacaoValor;

            decimal premioValorValor = 0;
            decimal.TryParse(premioValor, out premioValorValor);
            PremioValor = premioValorValor;

            double premioPorcentagemValor = 0;
            double.TryParse(premioPorcentagem, out premioPorcentagemValor);
            PremioPorcentagem = premioPorcentagemValor;
        }
    }
}
