using System;
using game_top.Lib;

namespace game_top
{
    class Program
    {
        static void Main(string[] args)
        {
            var jogo = new JogoFoda(new JogadorUm("Leandro"), new JogadorDois("Maradona"));
            jogo.IniciarJogo();
        }
    }
}
