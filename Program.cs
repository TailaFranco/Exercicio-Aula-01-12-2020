using System;

namespace Aula_01_12_2020
{
    class Program
    {
        static void Main(string[] args)
        {   Console.Clear();
           Personagem objetoPersonagem1 = new Personagem();

           objetoPersonagem1.nome = "Castor Guerreiro";
           objetoPersonagem1.atk = 1200;
           objetoPersonagem1.def = 1500;
           objetoPersonagem1.poderEspecial = "Não tem poder especial";
           objetoPersonagem1.hp = 4000;

           Personagem objetoPersonagem2 = new Personagem();

           objetoPersonagem2.nome = "Mago Negro";
           objetoPersonagem2.atk = 2500;
           objetoPersonagem2.def = 2100;
           objetoPersonagem2.poderEspecial = "Não tem poder especial";
           objetoPersonagem1.hp = 4000;


           Console.WriteLine($"Personagem 1 = {objetoPersonagem1.nome} - {objetoPersonagem1.Atacar()}");
           Console.WriteLine($" Personagem 2 = {objetoPersonagem2.nome} - {objetoPersonagem2.Defender()}");
           Dano(objetoPersonagem1.atk, objetoPersonagem2.def);
           
           
           
           if(objetoPersonagem1.atk > objetoPersonagem2.def)
           {
               Console.WriteLine("Monstro 2 destruído");
           }
           else if (objetoPersonagem1.atk < objetoPersonagem2.def)
           {
               Console.WriteLine("Monstro 1 destruído \n  Os pontos de defesa do Monstro 2 são maiores");
           }
           else
           {
               Console.WriteLine("Os dois monstros são destruídos");
           }

            static void Dano(int atk, int def)
            {
               
                Console.WriteLine(atk - def);
               
            }


        }

    }
}
