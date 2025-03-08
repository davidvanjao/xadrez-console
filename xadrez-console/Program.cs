using System;
using tabuleiro;
using xadrez;

namespace xadrez_console {
    class Program {
        static void Main(string[] args) {

            //PosicaoXadrez pos = new PosicaoXadrez('c', 3); //coluna e linha
            //Console.WriteLine(pos);
            //Console.WriteLine(pos.toPosicao());
            //Console.ReadLine();

            try {

                PartidaDeXadrez partida = new PartidaDeXadrez();

                while (!partida.terminada) {

                    Console.Clear();
                    Tela.imprimirTabuleiro(partida.tab);
                    Console.WriteLine();

                    Console.WriteLine();
                    Console.Write("Origem: ");
                    Posicao origem = Tela.lerPosicaoXadrez().toPosicao();
                    Console.Write("Destino: ");
                    Posicao destino = Tela.lerPosicaoXadrez().toPosicao();

                    partida.executaMovimento(origem, destino);

                }

            } catch (Exception e) { //caso aconteca algum erro em try, exibi a mensagem de erro.
                Console.WriteLine(e.Message);
            }

            Console.ReadLine();
        }
    }
}
