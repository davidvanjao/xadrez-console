using System;
using tabuleiro;

namespace xadrez {
    internal class Rei : Peca { //herenca
        public Rei(Tabuleiro tab, Cor cor) 
            : base(tab, cor) { //repaca a informacao para a classe peca
        }

        public override string ToString() {
            return "R";
        }
    }
}
