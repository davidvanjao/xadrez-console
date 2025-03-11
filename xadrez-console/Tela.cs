using System;
using tabuleiro;
using xadrez;

namespace xadrez_console {
    /*Um método static é um método que pertence à classe, e não a uma instância dela.*/
    internal class Tela {
        public static void imprimirTabuleiro(Tabuleiro tab) { //elemenstos staticos
            for (int i = 0; i < tab.linhas; i++) {
                Console.Write(8 - i + " ");
                for (int j = 0; j < tab.colunas; j++) {
                    imprimirPeca(tab.peca(i, j));
                }
                Console.WriteLine(); //quebra a linha
            }
            Console.Write("  " + "a " + "b " + "c " + "d " + "e " + "f " + "g " + "h ");
        }

        public static void imprimirTabuleiro(Tabuleiro tab, bool[,] posicoesPossiveis) { //sobrecarga

            ConsoleColor fundoOriginal = Console.BackgroundColor;
            ConsoleColor fundoAlterado = ConsoleColor.DarkGray;

            for (int i = 0; i < tab.linhas; i++) {
                Console.Write(8 - i + " ");
                for (int j = 0; j < tab.colunas; j++) {
                    if (posicoesPossiveis[i, j]) { //se a posicao for de possivel movimento, marcar o caminho
                        Console.BackgroundColor = fundoAlterado;
                    } else {
                        Console.BackgroundColor = fundoOriginal;
                    }

                    imprimirPeca(tab.peca(i, j));
                    Console.BackgroundColor = fundoOriginal;
                }
                Console.WriteLine();
            }
            Console.Write("  " + "a " + "b " + "c " + "d " + "e " + "f " + "g " + "h ");
            Console.BackgroundColor = fundoOriginal;
        }

        public static PosicaoXadrez lerPosicaoXadrez() {
            string s = Console.ReadLine();
            char coluna = s[0];
            int linha = int.Parse(s[1] + "");
            return new PosicaoXadrez(coluna, linha);
        }

        public static void imprimirPeca(Peca peca) {

            if (peca == null) {
                Console.Write("- ");
            } else {

                if (peca.cor == Cor.Branca) {
                    Console.Write(peca);
                } else {
                    ConsoleColor aux = Console.ForegroundColor; //Salva a cor atual do console
                    Console.ForegroundColor = ConsoleColor.Yellow; //Muda a cor do texto para amarelo
                    Console.Write(peca); //Imprime a peça no console em amarelo
                    Console.ForegroundColor = aux; //Restaura a cor original do console
                }
                Console.Write(" ");
            }
        }
    }
}
