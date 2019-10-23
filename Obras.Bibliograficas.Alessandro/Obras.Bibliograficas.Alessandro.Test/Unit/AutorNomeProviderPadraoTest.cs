using Obras.Bibliograficas.Alessandro.Domain.Autores.Nome;
using System;
using Xunit;

namespace Obras.Bibliograficas.Alessandro.Test
{
	public class AutorNomeProviderPadraoTest
	{
		[Fact]
		public void TestStringVaziaNaoCausaException()
		{
			// Arrange
			var entrada = "";
			var regra = new AutorNomeProviderPadrao();

			// Act
			var resultado = regra.AplicarRegrasNome(entrada);

			// Assert
			Assert.Equal("", resultado);
		}

		[Fact]
		public void TestNomeUnico()
		{
			// Arrange
			var entrada = "gomez";
			var regra = new AutorNomeProviderPadrao();

			// Act
			var resultado = regra.AplicarRegrasNome(entrada);

			// Assert
			Assert.Equal("GOMEZ", resultado);
		}

		[Fact]
		public void TestNomeComSobrenomeUnico()
		{
			// Arrange
			var entrada = "alessandro gomez";
			var regra = new AutorNomeProviderPadrao();

			// Act
			var resultado = regra.AplicarRegrasNome(entrada);

			// Assert
			Assert.Equal("GOMEZ, Alessandro", resultado);
		}

		[Fact]
		public void TestNomeComMultiplosSobrenomes()
		{
			// Arrange
			var entrada = "alessandro gomez santiago";
			var regra = new AutorNomeProviderPadrao();

			// Act
			var resultado = regra.AplicarRegrasNome(entrada);

			// Assert
			Assert.Equal("SANTIAGO, Alessandro Gomez", resultado);
		}

		[Fact]
		public void TestNomeComTerminacaoFamiliar()
		{
			// Arrange
			var entrada = "alessandro gomez filho";
			var regra = new AutorNomeProviderPadrao();

			// Act
			var resultado = regra.AplicarRegrasNome(entrada);

			// Assert
			Assert.Equal("GOMEZ FILHO, Alessandro", resultado);
		}

		[Fact]
		public void TestNomeComSobrenomeFamiliar()
		{
			// Arrange
			var entrada = "alessandro filho";
			var regra = new AutorNomeProviderPadrao();

			// Act
			var resultado = regra.AplicarRegrasNome(entrada);

			// Assert
			Assert.Equal("FILHO, Alessandro", resultado);
		}
	}
}
