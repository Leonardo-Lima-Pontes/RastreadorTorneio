using RastreadorBiblioteca.Modelos;
using System;
using System.Collections.Generic;
using System.Text;
using RastreadorBiblioteca.AcessoDeDados.ConectorDeTexto;
using System.Linq;

namespace RastreadorBiblioteca.AcessoDeDados
{
    public class TextoConector : IConexaoDeDados
    {

        private const string PremioArquivo = "PremioModelo.csv";


        public PremioModelo CriaPremio(PremioModelo modelo)
        {
            List<PremioModelo> premios =  PremioArquivo.CaminhoArquivoCompleto().CarregarArquivo().ConverterParaPremioModelo();

            int idAtual = 1;

            if (premios.Count > 0)
            {
                idAtual = premios.OrderByDescending(x => x.Id).First().Id + 1;
            }

            modelo.Id = idAtual;

            premios.Add(modelo);

            premios.SalvarParaPremioArquivo(PremioArquivo);

            return modelo;
        }
    }
}
