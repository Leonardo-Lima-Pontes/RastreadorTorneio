using RastreadorBiblioteca.Modelos;
using System;
using System.Collections.Generic;
using System.Text;

namespace RastreadorBiblioteca.AcessoDeDados
{
    public interface IConexaoDeDados
    {
        void CriaPremio(PremioModelo modelo);

        void CriaPessoa(PessoaModelo pessoa);

        void CriaTime(TimeModelo time);

        void CriaTorneio(TorneioModelo torneio);

        void AtualizarConfront(ConfrontoModelo confronto);

        List<TimeModelo> SelecionarTodosTimes();

        List<PessoaModelo> SelecionarTodasPessoas();

        List<TorneioModelo> SelecionarTodosTorneios();
    }
}
