namespace tabuleiro {
    internal class Tabuleiro {
        public int linhas { get; set; }
        public int colunas { get; set; }

        private Peca[,] pecas; //matriz

        public Tabuleiro(int linhas, int colunas) {
            this.linhas = linhas;
            this.colunas = colunas;
            pecas = new Peca[linhas, colunas]; //Um array bidimensional (Peca[,]) é criado para armazenar as peças do tabuleiro.        
        }
        public Peca peca(int linha, int coluna) {
            return pecas[linha, coluna]; //encapsulamento(metodo de acesso a um elemento da matriz)
        }

        public Peca peca(Posicao pos) { //sobrecarga
            return pecas[pos.linha, pos.coluna]; //matriz
        }

        public bool existePeca(Posicao pos) { //verifica se existe peca na posicao
            validarPosicao(pos); //verifica se posicao existe.
            return peca(pos) != null; //se peca for diferente de null, entao existe peca no local
        }

        public void colocarPeca(Peca p, Posicao pos) {
            if (existePeca(pos)) { //antes de colocar peca, verifica se existe peca no lugar
                throw new TabuleiroException("Já existe uma peça nessa posição!");
            }
            pecas[pos.linha, pos.coluna] = p;
            p.posicao = pos;

        }

        public Peca retirarPeca(Posicao pos) {
            if(peca(pos) == null) {
                return null;
            }
            Peca aux = peca(pos);
            aux.posicao = null;
            pecas[pos.linha, pos.coluna] = null;
            return aux;
        }

        public bool posicaoValida(Posicao pos) { //verifica se a posicao existe no tabuleiro
            if(pos.linha < 0 || pos.linha >= linhas || pos.coluna < 0 || pos.coluna >= colunas) {
                return false;
            }
            return true;
        }

        public void validarPosicao(Posicao pos) { //se nao existir, retorna mensagem de excessao
            if (!posicaoValida(pos)) {
                throw new TabuleiroException("Posição inválida!");
            }
        }
    }
}
