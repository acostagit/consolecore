using GameTOP.Interface;

namespace GameTOP.lib
{
     public class Jogador1: IJogador
    {
        public readonly string _Nome;
        
        public Jogador1(string nome = "Adriano")
        {
            this._Nome = nome;
        }

        //chuta
        public string Chuta()
        {
            return ($"{_Nome} está chutando");
        }
        //corre
        public string Corre()
        {
            return ($"{_Nome} está correndo");
        }
        //passa        
        public string Passa()
        {
             return ($"{_Nome} está passando");
        }
    }
}