namespace tabuleiro {
    internal abstract class Peca {
        
        public Posicao posicao { get; set; }
        public Cor cor { get; protected set; } //encapsulamento com protected
        public int qtdMovimentos { get; protected set; }
        public Tabuleiro tab { get; protected set; } //associacao. Uma classe usa outra

        public Peca(Tabuleiro tab, Cor cor) {
            this.posicao = null;
            this.tab = tab;
            this.cor = cor;
            this.qtdMovimentos = 0;
        }

        public void incrementarQteMovimentos() {
            qtdMovimentos++;
        }

        public abstract bool[,] movimentosPossiveis(); //e preciso implementar metodo nas subclasses



    }
}
