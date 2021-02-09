using jogoXadrez_netcore.tabuleiro;
using jogoXadrez_netcore.xadrez;
using System;
using tabuleiro;

namespace jogoXadrez_netcore
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Tabuleiro tab = new Tabuleiro(8, 8);

                tab.colocarPecas(new Torre(tab, Cor.Preta), new Posicao(0, 0));
                tab.colocarPecas(new Torre(tab, Cor.Preta), new Posicao(0, 9));
                tab.colocarPecas(new Rei(tab, Cor.Preta), new Posicao(2, 4));

                Tela.imprimirTabuleiro(tab);
            }
            catch (TabuleiroException e)
            {
                Console.WriteLine(e.Message);
            }
            
        }
    }
}
