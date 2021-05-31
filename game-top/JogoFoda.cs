using System;
using game_top.Interface;

namespace game_top
{
    public class JogoFoda
    {
        private readonly IJogador _jogadorUm;
        private readonly IJogador _jogadorDois;

        public JogoFoda(IJogador jogadorUm, IJogador jogadorDois)
        {
            _jogadorUm = jogadorUm;
            _jogadorDois = jogadorDois;
        }
        public void IniciarJogo()
        {
            Console.Write(_jogadorUm.Passar());
            Console.Write(_jogadorUm.Correr());
            Console.Write(_jogadorUm.Chutar());

            Console.Write("\n");

            Console.Write(_jogadorDois.Passar());
            Console.Write(_jogadorDois.Correr());
            Console.Write(_jogadorDois.Chutar());
        }
    }


}