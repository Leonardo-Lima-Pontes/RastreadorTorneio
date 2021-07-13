using System;
using System.Collections.Generic;
using System.Text;

namespace RastreadorBiblioteca
{
    class ConfrontoModelo
    {
        public List<EntradaConfrontoModelo> Entrada { get; set; } = new List<EntradaConfrontoModelo>();
        public TimeModelo Vencedor { get; set; }
        public int RodadaConfronto { get; set; }
    }
}
