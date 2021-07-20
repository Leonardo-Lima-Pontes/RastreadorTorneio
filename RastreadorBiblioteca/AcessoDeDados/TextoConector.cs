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
        private const string PessoaArquivo = "PessoaModelo.csv";
        private const string TimeArquivo = "TimeModelo.csv";

        public PessoaModelo CriaPessoa(PessoaModelo modelo)
        {
            List<PessoaModelo> pessoas = PessoaArquivo.CaminhoArquivoCompleto().CarregarArquivo().ConverterParaPessoaModelo();

            int idAtual = 1;

            if (pessoas.Count > 0)
            {
                idAtual = pessoas.OrderByDescending(x => x.Id).First().Id + 1;
            }

            modelo.Id = idAtual;

            pessoas.Add(modelo);

            pessoas.SalvarParaPessoaArquivo(PessoaArquivo);

            return modelo;
        }

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

        public TimeModelo CriaTime(TimeModelo modelo)
        {
            List<TimeModelo> times = TimeArquivo.CaminhoArquivoCompleto().CarregarArquivo().ConverterParaTimeModelo(PessoaArquivo);

            int idAtual = 1;

            if (times.Count > 0)
            {
                idAtual = times.OrderByDescending(x => x.Id).First().Id + 1;
            }

            modelo.Id = idAtual;

            times.Add(modelo);

            times.SalvarParaTimeArquivo(TimeArquivo);

            return modelo;
        }

        public List<PessoaModelo> SelecionarTodasPessoas()
        {
            return PessoaArquivo.CaminhoArquivoCompleto().CarregarArquivo().ConverterParaPessoaModelo();
        }

        public List<TimeModelo> SelecionarTodosTimes()
        {
            return TimeArquivo.CaminhoArquivoCompleto().CarregarArquivo().ConverterParaTimeModelo(PessoaArquivo);
        }
    }
}
