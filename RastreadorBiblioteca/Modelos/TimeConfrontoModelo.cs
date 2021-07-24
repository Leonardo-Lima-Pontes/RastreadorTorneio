using System;
using System.Collections.Generic;
using System.Text;

namespace RastreadorBiblioteca.Modelos
{
    public class TimeConfrontoModelo
    {
        /// <summary>
        /// Identificador unico para a entrada de confronto (gerado automaticamente pelo banco de dados)
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// O identificador unico para o time
        /// </summary>
        public int IdTimeCompetindo { get; set; }

        /// <summary>
        /// Representa um time no confronto
        /// </summary>
        public TimeModelo TimeCompetindo { get; set; }

        /// <summary>
        /// Representa a pontuação deste time
        /// </summary>
        public double Pontuacao { get; set; }

        /// <summary>
        /// O identificador unico para o confronto pai
        /// </summary>
        public int idConfrontoPai { get; set; }

        /// <summary>
        /// Representa o confronto do qual este time veio vencedor
        /// </summary>
        public ConfrontoModelo ConfrontoPai { get; set; }
    }
}
