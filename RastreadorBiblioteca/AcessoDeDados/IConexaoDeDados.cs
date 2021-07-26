using RastreadorBiblioteca.Modelos;
using System;
using System.Collections.Generic;
using System.Text;

namespace RastreadorBiblioteca.AcessoDeDados
{
    public interface IConexaoDeDados
    {
        PremioModelo CriaPremio(PremioModelo modelo);

        PessoaModelo CriaPessoa(PessoaModelo pessoa);

        TimeModelo CriaTime(TimeModelo time);

        void CriaTorneio(TorneioModelo torneio);

        void AtualizarConfront(ConfrontoModelo confronto);

        List<TimeModelo> SelecionarTodosTimes();

        List<PessoaModelo> SelecionarTodasPessoas();

        List<TorneioModelo> SelecionarTodosTorneios();
    }
}
