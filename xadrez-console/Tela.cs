using System;
using tabuleiro;

namespace xadrez_console {
    /*Um método static é um método que pertence à classe, e não a uma instância dela.*/
    internal class Tela {
        public static void imprimirTabuleiro(Tabuleiro tab) { //elemenstos staticos
            for (int i = 0; i < tab.linhas; i++) {
                for (int j = 0; j < tab.colunas; j++) {
                    if (tab.peca(i, j) == null) {
                        Console.Write("- ");
                    } else {
                        Console.Write(tab.peca(i, j) + " ");//colunas
                    }
                }
                Console.WriteLine(); //quebra a linha
            }
        }
    }
}
