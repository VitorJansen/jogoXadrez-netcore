using jogoXadrez_netcore.tabuleiro;

namespace jogoXadrez_netcore.xadrez
{
    class Torre : Peca
    {
        public Torre(Tabuleiro tab, Cor cor) : base(cor, tab) { }

        public override string ToString()
        {
            return "T";
        }
    }
}
