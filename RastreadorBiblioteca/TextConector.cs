using System;
using System.Collections.Generic;
using System.Text;

namespace RastreadorBiblioteca
{
    public class TextConector : IConexaoDeDados
    {
        // TODO - criar o médotdo CriarPremio para arquivo de texto
        public PremioModelo CriaPremio(PremioModelo modelo)
        {
            modelo.Id = 1;
            return modelo;
        }
    }
}
