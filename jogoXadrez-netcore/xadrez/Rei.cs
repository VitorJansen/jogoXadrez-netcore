using jogoXadrez_netcore.tabuleiro;

namespace jogoXadrez_netcore.xadrez
{
    class Rei : Peca
    {
        public Rei(Tabuleiro tab, Cor cor) : base(cor, tab) { }

        public override string ToString()
        {
            return "R";
        }
    }
}
