namespace AcademiaAtos_ConteudoAula
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Matrizes;

            // Boas praticas... consultar primeiro a Microsoft...

            // Tipos estruturados...
            // MATRIZES
            // - 1 Dimenção = int {1,  2,  3,  4}
            // - 1 Dimenção = string {"Ana",  "Paulo", "Leandro"}
            // - 1 Dimenção = double {1.0,  2.0,  3.0}

            // Declaração = int[] vetor = int[3];
            // vetor[0] = 15; 

            // Percorrer...
            // for(int i = 0; i < 3; i++)
            //    {
            //             Console.WriteLine("Escrever todos itens na tela");
            //    }

            // while (i < vetor.Length)
            // {
            //    Console.WriteLine("Escrever todos os itens!");
            //    i++;
            // }

            // foreach (string i in vetor)
            // {
            //     Console.WriteLine(i);
            // }

            Random gerador = new Random();
            int[] vetor = new int[5];

            for (int i = 0; i < 5; i++)
            {
                vetor[i] = gerador.Next(20, 50); // Numeros randomicos de 20 a 50;
            }

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(vetor[i]);
            }

            double[] vetorDouble = new double[5];
            for (int i = 0; i < 5; i++)
            {
                vetorDouble[i] = gerador.NextDouble();
            }

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(vetorDouble[i]);
            }


            // 2 Dimensões = comumente chamado de MATRIZ;

            // Declaração = int[,] matriz = new int[3,3];
            // Relação de linhas com colunas;

            // Matriz:
            //  1  2  3
            //  1  2  4
            //  1  2  4
            Random random = new Random();
            int[,] matriz = new int[5, 5];
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    matriz[i, j] = gerador.Next();
                }
            }

        }
    }
}