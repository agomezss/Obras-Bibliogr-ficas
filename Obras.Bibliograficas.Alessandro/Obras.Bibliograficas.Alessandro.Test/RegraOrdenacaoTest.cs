using Obras.Bibliograficas.Alessandro.Domain.Autores.Nome;
using System;
using Xunit;

namespace Obras.Bibliograficas.Alessandro.Test
{
	public class RegraOrdenacaoTest
	{
		[Fact]
		public void TestNomeComSobrenomeUnico()
		{
			// Arrange
			var entrada = "alessandro gomez";
			var regra = new RegraOrdenacao();

			// Act
			var resultado = regra.Aplicar(entrada);

			// Assert
			Assert.Equal("gomez, alessandro", resultado);
		}

		[Fact]
		public void TestNomeComMultiplosSobrenomes()
		{
			// Arrange
			var entrada = "alessandro gomez santiago";
			var regra = new RegraOrdenacao();

			// Act
			var resultado = regra.Aplicar(entrada);

			// Assert
			Assert.Equal("santiago, alessandro gomez", resultado);
		}

		[Fact]
		public void TestNomeComTerminacaoFamiliar()
		{
			// Arrange
			var entrada = "alessandro gomez filho";
			var regra = new RegraOrdenacao();

			// Act
			var resultado = regra.Aplicar(entrada);

			// Assert
			Assert.Equal("gomez filho, alessandro", resultado);
		}
	}
}
