using System;
using tabuleiro;

namespace xadrez {
    internal class Torre : Peca { //herenca
        public Torre(Tabuleiro tab, Cor cor)
            : base(tab, cor) { //repaca a informacao para a classe peca
        }

        public override string ToString() {
            return "T";
        }
    }
}
