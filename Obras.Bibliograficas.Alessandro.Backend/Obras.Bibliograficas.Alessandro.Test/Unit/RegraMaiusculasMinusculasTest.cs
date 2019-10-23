using Obras.Bibliograficas.Alessandro.Domain.Autores.Nome;
using System;
using Xunit;

namespace Obras.Bibliograficas.Alessandro.Test
{
	public class RegraMaiusculasMinusculasTest
	{
		[Fact]
		public void TestNomeUnicoSaidaMaiusculo()
		{
			// Arrange
			var entrada = "alessandro";
			var regra = new RegraMaiusculasMinusculas();

			// Act
			var resultado = regra.Aplicar(entrada);

			// Assert
			Assert.Equal("ALESSANDRO", resultado);
		}


		[Fact]
		public void TestNomeSemPreposicao()
		{
			// Arrange
			var entrada = "simões, alessandro";
			var regra = new RegraMaiusculasMinusculas();

			// Act
			var resultado = regra.Aplicar(entrada);

			// Assert
			Assert.Equal("SIMÕES, Alessandro", resultado);
		}

		[Fact]
		public void TestNomeComPreposicaoNaoMaiusculo()
		{
			// Arrange
			var entrada = "simões, alessandro de";
			var regra = new RegraMaiusculasMinusculas();

			// Act
			var resultado = regra.Aplicar(entrada);

			// Assert
			Assert.Equal("SIMÕES, Alessandro de", resultado);
		}
	}
}
