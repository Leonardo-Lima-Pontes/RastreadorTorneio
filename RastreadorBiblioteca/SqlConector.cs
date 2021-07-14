using System;
using System.Collections.Generic;
using System.Text;

namespace RastreadorBiblioteca
{
    public class SqlConector : IConexaoDeDados
    {
        // TODO - fazer o metodo CriarPremio salvar no banco de dados
        /// <summary>
        /// Salva um novo prêmio na base de dados
        /// </summary>
        /// <param name="modelo">Informações do prêmio</param>
        /// <returns>As informações do prêmio, incluindo o identificador unico </returns>
        public PremioModelo CriaPremio(PremioModelo modelo)
        {
            modelo.Id = 1;
            return modelo;
        }
    }
}
