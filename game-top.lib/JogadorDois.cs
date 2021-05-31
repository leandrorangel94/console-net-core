using game_top.Interface;

namespace game_top.Lib
{
    public class JogadorDois : IJogador
    {

        private readonly string _Nome;

        public JogadorDois(string nome)
        {
            _Nome = nome;
        }
        public string Chutar()
        {
            return $"O {_Nome} está chutando \n";
        }

        public string Correr()
        {
            return $"O {_Nome} está correndo \n";
        }

        public string Passar()
        {
            return $"O {_Nome} está passando \n";
        }
    }
}