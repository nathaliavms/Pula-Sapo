using System;

namespace JogoSapo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a altura do pulo do sapo e o número de canos (na mesma linha):");
            string[] dados = Console.ReadLine().Split(' ');
            int alturaDoPulo = int.Parse(dados[0]);
            int canos = int.Parse(dados[1]);

            Console.WriteLine("Digite as alturas dos " + dados[1] + " canos: ");
            string[] vetor = Console.ReadLine().Split(' ');
            int[] alturaEntreCanos = new int[canos];
            int diferenca;

            int resultado = 0;
            for (int i = 0; i < canos; i++)
            {
                alturaEntreCanos[i] = int.Parse(vetor[i]);
            }
            for (int i = 1; i < canos; i++)
            {
                if (alturaEntreCanos[i] > alturaEntreCanos[i - 1])
                {
                    diferenca = (alturaEntreCanos[i] - alturaEntreCanos[i - 1]);
                }
                else
                {
                    diferenca = (alturaEntreCanos[i - 1] - alturaEntreCanos[i]);
                }
                if (diferenca <= alturaDoPulo)
                {
                    resultado++;
                }
            }
            if (resultado == canos - 1)
            {
                Console.WriteLine("YOU WIN");
            }
            else
            {
                Console.WriteLine("GAME OVER");
            }
        }
    }
}