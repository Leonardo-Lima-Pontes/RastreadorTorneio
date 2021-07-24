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
        private const string TorneioArquivo = "TorneioModelo.csv";
        private const string ConfrontoArquivo = "ConfrontoModelo.csv";
        private const string TimeConfrontoArquivo = "TimeConfrontoModelo.csv";

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

        public void CriaTorneio(TorneioModelo modelo)
        {
            List<TorneioModelo> torneios = TorneioArquivo
                .CaminhoArquivoCompleto()
                .CarregarArquivo()
                .ConverterParaTorneioModelo(TimeArquivo, PessoaArquivo, PremioArquivo);

            int idAtual = 1;

            if (torneios.Count > 0)
            {
                idAtual = torneios.OrderByDescending(x => x.Id).First().Id + 1;
            }

            modelo.Id = idAtual;

            modelo.SalvarRodadasParaArquivo(ConfrontoArquivo, TimeConfrontoArquivo);

            torneios.Add(modelo);

            torneios.SalvarParaTorneioArquivo(TorneioArquivo);
        }


        public List<PessoaModelo> SelecionarTodasPessoas()
        {
            return PessoaArquivo.CaminhoArquivoCompleto().CarregarArquivo().ConverterParaPessoaModelo();
        }

        public List<TimeModelo> SelecionarTodosTimes()
        {
            return TimeArquivo.CaminhoArquivoCompleto().CarregarArquivo().ConverterParaTimeModelo(PessoaArquivo);
        }

        public List<TorneioModelo> SelecionarTodosTorneios()
        {
            throw new NotImplementedException();
        }
    }
}
