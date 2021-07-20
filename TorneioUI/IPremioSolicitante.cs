using RastreadorBiblioteca.Modelos;
using System;
using System.Collections.Generic;
using System.Text;

namespace TorneioUI
{
    public interface IPremioSolicitante
    {
        void PremioCompleto(PremioModelo premio);
    }
}
