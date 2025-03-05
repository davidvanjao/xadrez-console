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

        public void colocarPeca(Peca p, Posicao pos) {
            pecas[pos.linha, pos.coluna] = p;
            p.posicao = pos;

        }
    }
}
