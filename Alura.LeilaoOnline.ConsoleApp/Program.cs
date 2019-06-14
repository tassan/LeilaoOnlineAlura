using Alura.LeilaoOnline.Core;
using System;

namespace Alura.LeilaoOnline.ConsoleApp
{
    class Program
    {
        static void Main()
        {
            LeilaoComVariosLances();
            LeilaoComApenasUmLance();
        }

        private static void Verifica(double esperado, double obtivo)
        {
            var cor = Console.ForegroundColor;
            if (esperado == obtivo)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Teste OK");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Teste FALHOU! Esperado: {esperado} Obtido: {obtivo}");
            }

            Console.ForegroundColor = cor;
        }

        private static void LeilaoComVariosLances()
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

            Verifica(valorEsperado, valorObtido);
        }

        private static void LeilaoComApenasUmLance()
        {
            // Arranje - Configura Cenário
            var leilao = new Leilao("Van Gogh");
            var fulano = new Interessada("Fulano", leilao);
            var maria = new Interessada("Maria", leilao);

            leilao.RecebeLance(fulano, 800);

            //Act - Método sob teste
            leilao.TerminaPregao();

            //Assert
            var valorEsperado = 800;
            var valorObtido = leilao.Ganhador.Valor;

            Verifica(valorEsperado, valorObtido);
        }
    }
}
