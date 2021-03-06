﻿using System.Data;

namespace RepositorioGenerico.Pattern
{

	public interface IConexao
	{

		IDbConnection CriarConexaoSemTransacao();

		IDbConnection CriarConexaoTransacionada();

		IDbCommand CriarComando();

		void DefinirConexao(IDbCommand comando);

	}

}
