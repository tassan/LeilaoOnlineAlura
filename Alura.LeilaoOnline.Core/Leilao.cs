﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Alura.LeilaoOnline.Core
{
    public class Leilao
    {
        private readonly IList<Lance> _lances;
        public IEnumerable<Lance> Lances => _lances;
        public string Peca { get; set; }

        public Leilao(string peca)
        {
            Peca = peca;
            _lances = new List<Lance>();
        }

        public void RecebeLance(Interessada cliente, double valor) => _lances.Add(new Lance(cliente, valor));

        public void IniciaPregao() { }
        public void TerminaPregao() { }
    }
}
