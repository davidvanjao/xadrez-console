namespace tabuleiro
{
    internal class Posicao
    {
        public int linha { get; private set; } //encapsulamento
        public int coluna { get; private set; }

        public Posicao(int linha, int coluna) { //construtores
            this.linha = linha; //autoreferencia
            this.coluna = coluna;
        }

        public override string ToString() { //sobreposicao
            return linha
                + ", "
                + coluna;
        }
    }
}
