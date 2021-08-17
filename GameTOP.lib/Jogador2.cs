using GameTOP.Interface;

namespace GameTOP.lib
{
    public class Jogador2 : IJogador
    {
        public readonly string _Nome;
        public Jogador2(string nome = "Messi")
        {
            this._Nome = nome;
        }
        public string Chuta()
        {
            return ($"{_Nome} está apoteando");
        }

        public string Corre()
        {
            return ($"{_Nome} está coriendo");
        }

        public string Passa()
        {
            return ($"{_Nome} está pasando");
        }
    }
}