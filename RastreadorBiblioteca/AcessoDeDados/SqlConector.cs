using Dapper;
using RastreadorBiblioteca.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace RastreadorBiblioteca.AcessoDeDados
{
    public class SqlConector : IConexaoDeDados
    {
        //  TODO - fazer o metodo CriarPremio salvar no banco de dados
        /// <summary>
        /// Salva um novo prêmio na base de dados
        /// </summary>
        /// <param name="modelo">Informações do prêmio</param>
        /// <returns>As informações do prêmio, incluindo o identificador unico </returns>
        public PremioModelo CriaPremio(PremioModelo modelo)
        {
            using (IDbConnection conexao = new System.Data.SqlClient.SqlConnection(ConfiguracaoGlobal.ConexaoString("Torneio")))
            {
                var p = new DynamicParameters();
                p.Add("@NumeroColocacao", modelo.NumeroColocacao);
                p.Add("@NomeColocacao", modelo.ColocacaoNome);
                p.Add("@PremioValor", modelo.PremioValor);
                p.Add("@PremioPorcentagem", modelo.PremioPorcentagem);
                p.Add("@id", 0,  dbType: DbType.Int32, direction: ParameterDirection.Output);

                conexao.Execute("dbo.spPremios_Insercao", p, commandType: CommandType.StoredProcedure);

                modelo.Id = p.Get<int>("@id");

                return modelo;
            }
        }
    }
}
