using Alura.LeilaoOnline.Core;
using System;

namespace Alura.LeilaoOnline.ConsoleApp
{
    class Program
    {
        static void Main()
        {
            /// Padrão ArrangeActAssert
            /// http://wiki.c2.com/?ArrangeActAssert
            /// 

            // Arranje - Configura Cenário
            var leilao = new Leilao("Van Gogh");
            var fulano = new Interessada("Fulano", leilao);
            var maria = new Interessada("Maria", leilao);

            leilao.RecebeLance(fulano, 800);
            leilao.RecebeLance(maria, 900);
            leilao.RecebeLance(fulano, 1000);
            leilao.RecebeLance(maria, 990);

            //Act - Método sob teste
            leilao.TerminaPregao();

            //Assert
            var valorEsperado = 1000;
            var valorObtido = leilao.Ganhador.Valor;

            if (valorEsperado == valorObtido)
                Console.WriteLine("Teste OK");
            else
                Console.WriteLine($"Teste FALHOU!\nEsperado: {valorEsperado}\nObtido: {valorObtido}");
        }
    }
}
