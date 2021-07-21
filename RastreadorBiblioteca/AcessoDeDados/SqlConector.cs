using Dapper;
using RastreadorBiblioteca.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace RastreadorBiblioteca.AcessoDeDados
{
    public class SqlConector : IConexaoDeDados
    {

        private const string bd = "Torneio";

        /// <summary>
        /// Salva uma nova pessoa na base de dados
        /// </summary>
        /// <param name="pessoa">Informações de pessoa</param>
        /// <returns>Informações de pessoa, incluindo o identificador unico</returns>
        public PessoaModelo CriaPessoa(PessoaModelo pessoa)
        {
            using (IDbConnection conexao = new System.Data.SqlClient.SqlConnection(ConfiguracaoGlobal.ConexaoString(bd)))
            {
                var p = new DynamicParameters();
                p.Add("@PrimeiroNome", pessoa.PrimeiroNome);
                p.Add("@UltimoNome", pessoa.UltimoNome);
                p.Add("@Telefone", pessoa.Telefone);
                p.Add("@Email", pessoa.Email);
                p.Add("@DataCriacao", pessoa.DataCriacao);
                p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                conexao.Execute("dbo.spPessoas_Insercao", p, commandType: CommandType.StoredProcedure);

                pessoa.Id = p.Get<int>("@id");

                return pessoa;
            }
        }

        //  TODO - fazer o metodo CriarPremio salvar no banco de dados
        /// <summary>
        /// Salva um novo prêmio na base de dados
        /// </summary>
        /// <param name="modelo">Informações do prêmio</param>
        /// <returns>As informações do prêmio, incluindo o identificador unico </returns>
        public PremioModelo CriaPremio(PremioModelo premio)
        {
            using (IDbConnection conexao = new System.Data.SqlClient.SqlConnection(ConfiguracaoGlobal.ConexaoString(bd)))
            {
                var p = new DynamicParameters();
                p.Add("@NumeroColocacao", premio.NumeroColocacao);
                p.Add("@NomeColocacao", premio.ColocacaoNome);
                p.Add("@PremioValor", premio.PremioValor);
                p.Add("@PremioPorcentagem", premio.PremioPorcentagem);
                p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                conexao.Execute("dbo.spPremios_Insercao", p, commandType: CommandType.StoredProcedure);

                premio.Id = p.Get<int>("@id");

                return premio;
            }
        }

        /// <summary>
        /// Cria o time na base de dados
        /// </summary>
        /// <param name="time">Informações do objeto time</param>
        /// <returns>As informações do time incluindo o identificador unico</returns>
        public TimeModelo CriaTime(TimeModelo time)
        {
            using (IDbConnection conexao = new System.Data.SqlClient.SqlConnection(ConfiguracaoGlobal.ConexaoString(bd)))
            {
                var p = new DynamicParameters();
                p.Add("@NomeTime", time.NomeTime);
                p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                conexao.Execute("dbo.spTimes_Insercao", p, commandType: CommandType.StoredProcedure);

                time.Id = p.Get<int>("@id");

                SalvaTimeMembros(conexao, time);

                return time;
            }
        }

        /// <summary>
        /// Cria os membros do time na base de dados
        /// </summary>
        /// <param name="conexao">conexao com o banco de dados</param>
        /// <param name="time">time</param>
        private void SalvaTimeMembros(IDbConnection conexao, TimeModelo time)
        {
            foreach (PessoaModelo membroTime in time.MembrosTime)
            {
                var p = new DynamicParameters();
                p.Add("@TimeId", time.Id);
                p.Add("@PessoaId", membroTime.Id);
                p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                conexao.Execute("dbo.spTimeMembros_Insercao", p, commandType: CommandType.StoredProcedure);
            }
        }

        /// <summary>
        /// Cria o torneio
        /// </summary>
        /// <param name="torneio">Objeto torneio</param>
        /// <returns>Objeto torneio que foi salvo na base de dados incluindo o identificador unico gerado pelo banco de dados</returns>
        public void CriaTorneio(TorneioModelo torneio)
        {
            using (IDbConnection conexao = new System.Data.SqlClient.SqlConnection(ConfiguracaoGlobal.ConexaoString(bd)))
            {
                SalvaTorneio(conexao, torneio);

                SalvaTorneioPremio(conexao, torneio);

                SalvaTorneioEntrada(conexao, torneio);
            }
        }

        /// <summary>
        /// Salva o Torneio no banco de dados
        /// </summary>
        /// <param name="conexao">conexão</param>
        /// <param name="torneio">objeto torneio</param>
        private void SalvaTorneio(IDbConnection conexao, TorneioModelo torneio)
        {
            var p = new DynamicParameters();
            p.Add("@NomeTorneio", torneio.TorneioNome);
            p.Add("@TaxaEntrada", torneio.TaxaEntrada);
            p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

            conexao.Execute("dbo.spTorneios_Insercao", p, commandType: CommandType.StoredProcedure);

            torneio.Id = p.Get<int>("@id");
        }


        /// <summary>
        /// Salva o Os premios do torneio na base de dados
        /// </summary>
        /// <param name="conexao">conexão</param>
        /// <param name="torneio">objeto torneio</param>
        private void SalvaTorneioPremio(IDbConnection conexao, TorneioModelo torneio)
        {
            foreach (PremioModelo premio in torneio.Premios)
            {
                var p = new DynamicParameters();
                p.Add("@TorneioId", torneio.Id);
                p.Add("@PremioId", premio.Id);
                p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                conexao.Execute("dbo.spTorneioPremios_Insercao", p, commandType: CommandType.StoredProcedure);
            }
        }

        /// <summary>
        /// Salva os time que que vão jogar o torneio na base de dados
        /// </summary>
        /// <param name="conexao">conexão</param>
        /// <param name="torneio">objeto torneio</param>
        private void SalvaTorneioEntrada(IDbConnection conexao, TorneioModelo torneio)
        {
            foreach (TimeModelo time in torneio.TimesIncritos)
            {
                var p = new DynamicParameters();
                p.Add("@TorneioId", torneio.Id);
                p.Add("@TimeId", time.Id);
                p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                conexao.Execute("dbo.spTorneioEntradas_Insercao", p, commandType: CommandType.StoredProcedure);
            }
        }


        /// <summary>
        /// Seleciona e retona todos os dados da tebela pessoas do banco de dados
        /// </summary>
        /// <returns>Lista de pessoas</returns>
        public List<PessoaModelo> SelecionarTodasPessoas()
        {
            List<PessoaModelo> saidaPessoa;

            using (IDbConnection conexao = new System.Data.SqlClient.SqlConnection(ConfiguracaoGlobal.ConexaoString(bd)))
            {
                saidaPessoa = conexao.Query<PessoaModelo>("dbo.spPessoas_SelecionarTudo").ToList();
            }

            return saidaPessoa;
        }

        public List<TimeModelo> SelecionarTodosTimes()
        {
            List<TimeModelo> saidaTimes;

            using (IDbConnection conexao = new System.Data.SqlClient.SqlConnection(ConfiguracaoGlobal.ConexaoString(bd)))
            {
                saidaTimes = conexao.Query<TimeModelo>("dbo.spTimes_SelecionarTudo").ToList();

                foreach (TimeModelo time in saidaTimes)
                {
                    var p = new DynamicParameters();
                    p.Add("@TimeId", time.Id);

                    time.MembrosTime = conexao.Query<PessoaModelo>("dbo.spTimeMembros_SelecionarPeloTime", p, commandType: CommandType.StoredProcedure).ToList();
                }
            }

            return saidaTimes;
        }
    }
}
