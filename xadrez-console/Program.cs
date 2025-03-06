using System;
using tabuleiro;
using xadrez;

namespace xadrez_console {
    class Program {
        static void Main(string[] args) {

            PosicaoXadrez pos = new PosicaoXadrez('b', 1); //coluna e linha
            Console.WriteLine(pos);
            Console.WriteLine(pos.toPosicao());
            Console.ReadLine();

            //try {

            //    Tabuleiro tab = new Tabuleiro(8, 8);

            //    tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(0, 0));
            //    tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(1, 3));
            //    tab.colocarPeca(new Rei(tab, Cor.Preta), new Posicao(0, 2));

            //    Tela.imprimirTabuleiro(tab);

            //    Console.ReadLine();

            //} catch (Exception e) { //caso aconteca algum erro em try, exibi a mensagem de erro.
            //    Console.WriteLine(e.Message);
            //}
        }
    }
}
