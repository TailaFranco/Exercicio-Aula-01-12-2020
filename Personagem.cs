namespace Aula_01_12_2020
{
    public class Personagem
    {
        public string nome;
        public string poderEspecial;
        public int hp;
        public int atk;
        public int def;

        public string Atacar()
        {
            return "Ao ataque";
        }
        public string Defender()
        {
            return "Defender";
        }
        public int Dano(int atk, int def)
            {
                int resultado;
                resultado = atk - def;
                return resultado;
            }
    }
}