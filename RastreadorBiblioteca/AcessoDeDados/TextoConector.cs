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

        public void AtualizarConfront(ConfrontoModelo confronto)
        {
            throw new NotImplementedException();
        }

        public void CriaPessoa(PessoaModelo modelo)
        {
            List<PessoaModelo> pessoas = ConfiguracaoGlobal.PessoaArquivo.CaminhoArquivoCompleto().CarregarArquivo().ConverterParaPessoaModelo();

            int idAtual = 1;

            if (pessoas.Count > 0)
            {
                idAtual = pessoas.OrderByDescending(x => x.Id).First().Id + 1;
            }

            modelo.Id = idAtual;

            pessoas.Add(modelo);

            pessoas.SalvarParaPessoaArquivo();
        }

        public void CriaPremio(PremioModelo modelo)
        {
            List<PremioModelo> premios = ConfiguracaoGlobal.PremioArquivo.CaminhoArquivoCompleto().CarregarArquivo().ConverterParaPremioModelo();

            int idAtual = 1;

            if (premios.Count > 0)
            {
                idAtual = premios.OrderByDescending(x => x.Id).First().Id + 1;
            }

            modelo.Id = idAtual;

            premios.Add(modelo);

            premios.SalvarParaPremioArquivo();
        }

        public void CriaTime(TimeModelo modelo)
        {
            List<TimeModelo> times = ConfiguracaoGlobal.TimeArquivo.CaminhoArquivoCompleto().CarregarArquivo().ConverterParaTimeModelo();

            int idAtual = 1;

            if (times.Count > 0)
            {
                idAtual = times.OrderByDescending(x => x.Id).First().Id + 1;
            }

            modelo.Id = idAtual;

            times.Add(modelo);

            times.SalvarParaTimeArquivo();
        }

        public void CriaTorneio(TorneioModelo modelo)
        {
            List<TorneioModelo> torneios = ConfiguracaoGlobal.TorneioArquivo
                .CaminhoArquivoCompleto()
                .CarregarArquivo()
                .ConverterParaTorneioModelo();

            int idAtual = 1;

            if (torneios.Count > 0)
            {
                idAtual = torneios.OrderByDescending(x => x.Id).First().Id + 1;
            }

            modelo.Id = idAtual;

            modelo.SalvarRodadasParaArquivo();

            torneios.Add(modelo);

            torneios.SalvarParaTorneioArquivo();
        }


        public List<PessoaModelo> SelecionarTodasPessoas()
        {
            return ConfiguracaoGlobal.PessoaArquivo.CaminhoArquivoCompleto().CarregarArquivo().ConverterParaPessoaModelo();
        }

        public List<TimeModelo> SelecionarTodosTimes()
        {
            return ConfiguracaoGlobal.TimeArquivo.CaminhoArquivoCompleto().CarregarArquivo().ConverterParaTimeModelo();
        }

        public List<TorneioModelo> SelecionarTodosTorneios()
        {
            throw new NotImplementedException();
        }
    }
}
