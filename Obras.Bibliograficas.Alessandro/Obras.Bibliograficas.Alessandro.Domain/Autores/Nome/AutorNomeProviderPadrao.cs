﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Obras.Bibliograficas.Alessandro.Domain.Autores.Nome
{
	public class AutorNomeProviderPadrao : IAutorNomeProvider
	{
		public AutorNomeProviderPadrao()
		{
		    //IncluirRegra(Activator.CreateInstance(RegraRemocaoPreposicoes))
		 //   .IncluirRegra(Activator.CreateInstance(RegraOrdenacaoPronomeTratamento))
		    IncluirRegra(Activator.CreateInstance<RegraMaiusculasMinusculas>());
		}
	}
}
