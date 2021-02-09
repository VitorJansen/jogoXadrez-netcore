using jogoXadrez_netcore.tabuleiro;
using System;

namespace jogoXadrez_netcore
{
    class Program
    {
        static void Main(string[] args)
        {
            Tabuleiro tab = new Tabuleiro(8, 8);

            Tela.imprimirTabuleiro(tab);
        }
    }
}
