using tabuleiro;

namespace xadrez {
    internal class PosicaoXadrez {
        public char coluna { get; set; }
        public int linha { get; set; }

        public PosicaoXadrez(char coluna, int linha) {
            this.coluna = coluna;
            this.linha = linha;        
        }

        /*
         Formato do xadrez: 'e', 4
         Índices de matriz: (4, 4)
         */

        public Posicao toPosicao() {
            return new Posicao(8 - linha, coluna - 'a'); //os índices começam em 0 (a=0, b=1, ..., h=7).
        }

        public override string ToString() {
            return "" + coluna + linha;
        }
    }
}
