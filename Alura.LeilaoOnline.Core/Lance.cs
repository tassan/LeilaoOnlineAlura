using System;
using System.Collections.Generic;
using System.Text;

namespace Alura.LeilaoOnline.Core
{
    public class Lance
    {
        public Interessada Cliente;
        public double Valor;

        public Lance(Interessada cliente, double valor)
        {
            this.Cliente = cliente;
            this.Valor = valor;
        }
    }
}
