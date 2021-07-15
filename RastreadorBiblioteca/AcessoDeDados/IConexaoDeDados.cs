using RastreadorBiblioteca.Modelos;
using System;
using System.Collections.Generic;
using System.Text;

namespace RastreadorBiblioteca.AcessoDeDados
{
    public interface IConexaoDeDados
    {
       PremioModelo CriaPremio(PremioModelo modelo);
    }
}
