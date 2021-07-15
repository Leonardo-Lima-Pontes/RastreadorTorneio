using System;
using System.Collections.Generic;
using System.Text;

namespace RastreadorBiblioteca.Modelos
{
    public class TimeModelo
    {
        /// <summary>
        /// Lista dos membros que irão compor o time
        /// </summary>
        public List<PessoaModelo> MembrosTime { get; set; } = new List<PessoaModelo>();
        /// <summary>
        /// Nome do time dentro do torneio
        /// </summary>
        public string NomeTime { get; set; }
    }
}
