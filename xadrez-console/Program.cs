﻿using System;
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

                    try {

                        Console.Clear();
                        Tela.imprimirPartida(partida);

                        Console.WriteLine();
                        Console.Write("Origem: ");
                        Posicao origem = Tela.lerPosicaoXadrez().toPosicao();
                        partida.validarPosicaoDeOrigem(origem); //verifica se as pecas estao ok

                        bool[,] posicoesPossiveis = partida.tab.peca(origem).movimentosPossiveis();

                        Console.Clear();
                        Tela.imprimirTabuleiro(partida.tab, posicoesPossiveis);
                        Console.WriteLine();

                        Console.WriteLine();
                        Console.Write("Destino: ");
                        Posicao destino = Tela.lerPosicaoXadrez().toPosicao();
                        partida.validarPosicaoDeDestino(origem, destino);

                        partida.realizaJogada(origem, destino);

                    } catch (TabuleiroException e) {
                        Console.WriteLine(e.Message);
                        Console.ReadLine();
                    }
                }

                Console.Clear();
                Tela.imprimirPartida(partida);

            } catch (TabuleiroException e) { //caso aconteca algum erro em try, exibi a mensagem de erro.
                Console.WriteLine(e.Message);
                Console.ReadLine();
            }
        }
    }
}
