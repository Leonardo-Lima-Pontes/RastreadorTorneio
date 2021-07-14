using System;
using System.Collections.Generic;
using System.Text;

namespace RastreadorBiblioteca
{
    public interface IConexaoDeDados
    {
       PremioModelo CriaPremio(PremioModelo modelo);
    }
}
