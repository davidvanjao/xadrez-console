using System;
using tabuleiro;

namespace xadrez {
    internal class Torre : Peca { //herenca
        public Torre(Tabuleiro tab, Cor cor) //construtor / base
            : base(tab, cor) { //repaca a informacao para a classe peca
        }

        public override string ToString() {
            return "T";
        }

        private bool podeMover(Posicao pos) {
            Peca p = tab.peca(pos);
            return p == null || p.cor != cor; //verifica se a posicao esta nula ou possui cor diferent
        }

        public override bool[,] movimentosPossiveis() { //movimentos da peca
            bool[,] mat = new bool[tab.linhas, tab.colunas];

            Posicao pos = new Posicao(0, 0);

            //acima
            pos.definirValores(posicao.linha - 1, posicao.coluna);
            while (tab.posicaoValida(pos) && podeMover(pos)) {
                mat[pos.linha, pos.coluna] = true;
                if(tab.peca(pos) != null && tab.peca(pos).cor != cor) {
                    break;
                }
                pos.linha = pos.linha - 1;
            }

            //abaixo
            pos.definirValores(posicao.linha + 1, posicao.coluna);
            while (tab.posicaoValida(pos) && podeMover(pos)) {
                mat[pos.linha, pos.coluna] = true;
                if (tab.peca(pos) != null && tab.peca(pos).cor != cor) {
                    break;
                }
                pos.linha = pos.linha + 1;
            }

            //direita
            pos.definirValores(posicao.linha, posicao.coluna + 1);
            while (tab.posicaoValida(pos) && podeMover(pos)) {
                mat[pos.linha, pos.coluna] = true;
                if (tab.peca(pos) != null && tab.peca(pos).cor != cor) {
                    break;
                }
                pos.coluna = pos.coluna + 1;
            }

            //esquerda
            pos.definirValores(posicao.linha, posicao.coluna - 1);
            while (tab.posicaoValida(pos) && podeMover(pos)) {
                mat[pos.linha, pos.coluna] = true;
                if (tab.peca(pos) != null && tab.peca(pos).cor != cor) {
                    break;
                }
                pos.coluna = pos.coluna - 1;
            }

            return mat;

        }
    }
}
