using System;
using System.Collections.Generic;
using System.Text;

namespace RastreadorBiblioteca
{
    class PessoaModelo
    {
        /// <summary>
        /// Nome do membro do time
        /// </summary>
        public string PrimeiroNome { get; set; }
        /// <summary>
        /// Ultimo nome do membro do time
        /// </summary>
        public string UltimoNome { get; set; }
        /// <summary>
        /// Email do membro do time
        /// </summary>
        public string Email { get; set; }
        /// <summary>
        /// Telefone do mebro do time
        /// </summary>
        public string Telefone { get; set; }
    }
}
