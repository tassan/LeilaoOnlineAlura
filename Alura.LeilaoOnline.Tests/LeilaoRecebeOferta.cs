﻿using Xunit;
using Alura.LeilaoOnline.Core;
using System.Linq;

namespace Alura.LeilaoOnline.Tests
{
    public class LeilaoRecebeOferta
    {
        [Theory]
        [InlineData(4, new double[] { 1000, 1200, 1400, 1300 })]
        [InlineData(2, new double[] { 800, 900 })]
        public void NaoPermiteNovosLancesDadoLeilaoFinalizado(int qtdeEsperada, double[] ofertas)
        {
            // Arrange - Configura Cenário
            var leilao = new Leilao("Van Gogh");
            var fulano = new Interessada("Fulano", leilao);

            foreach (var valor in ofertas)
                leilao.RecebeLance(fulano, valor);

            leilao.TerminaPregao();

            // Act - Método sob teste
            leilao.RecebeLance(fulano, 1000);

            // Assert
            var qtdeObtido = leilao.Lances.Count();

            Assert.Equal(qtdeEsperada, qtdeObtido);
        }
    }
}
