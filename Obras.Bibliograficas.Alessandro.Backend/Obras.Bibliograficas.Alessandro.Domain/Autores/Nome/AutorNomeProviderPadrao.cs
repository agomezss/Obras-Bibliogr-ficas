﻿using System;

namespace Obras.Bibliograficas.Alessandro.Domain.Autores.Nome
{
	public class AutorNomeProviderPadrao : AutorNomeProvider
	{
		public AutorNomeProviderPadrao()
		{
			IncluirRegra(Activator.CreateInstance<RegraOrdenacao>());
			IncluirRegra(Activator.CreateInstance<RegraMaiusculasMinusculas>());
		}
	}
}
