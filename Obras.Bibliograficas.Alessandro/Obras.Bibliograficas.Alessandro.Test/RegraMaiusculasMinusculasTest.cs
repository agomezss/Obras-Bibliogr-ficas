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
			var entrada = "sim�es, alessandro";
			var regra = new RegraMaiusculasMinusculas();

			// Act
			var resultado = regra.Aplicar(entrada);

			// Assert
			Assert.Equal("SIM�ES, Alessandro", resultado);
		}

		[Fact]
		public void TestNomeComPreposicaoNaoMaiusculo()
		{
			// Arrange
			var entrada = "sim�es, alessandro de";
			var regra = new RegraMaiusculasMinusculas();

			// Act
			var resultado = regra.Aplicar(entrada);

			// Assert
			Assert.Equal("SIM�ES, Alessandro de", resultado);
		}
	}
}
