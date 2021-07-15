using RastreadorBiblioteca.Modelos;
using System;
using System.Collections.Generic;
using System.Text;

namespace RastreadorBiblioteca.AcessoDeDados
{
    public class TextoConector : IConexaoDeDados
    {
        // TODO - criar o médotdo CriarPremio para arquivo de texto
        public PremioModelo CriaPremio(PremioModelo modelo)
        {
            modelo.Id = 1;
            return modelo;
        }
    }
}
