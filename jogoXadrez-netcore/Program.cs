﻿using jogoXadrez_netcore.tabuleiro;
using System;

namespace jogoXadrez_netcore
{
    class Program
    {
        static void Main(string[] args)
        {
            Posicao p = new Posicao(3, 4);
            Console.WriteLine("Posição: " + p);
        }
    }
}
