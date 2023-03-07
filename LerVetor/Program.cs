internal class Program
{
    private static void Main(string[] args)
    {
        int[] vetorA = new int[5];
        int[] vetorB = new int[5];
        int[] vetorC = new int[10];

        LerVetor(vetorA, "VetorA");
        LerVetor(vetorB, "VetorB");

        vetorC = CopVetor(vetorA, vetorB);

        ImprimirVetor(vetorA, "VetorA");
        Console.WriteLine();
        ImprimirVetor(vetorB, "VetorB");
        Console.WriteLine();
        ImprimirVetor(vetorC, "VetorC");

        Ordenar(vetorC);
        Console.WriteLine();
        ImprimirVetor(vetorC, "VetorC ordenado");

        //Ordenar vetor em ordem crescente
        void Ordenar(int[] vetC)
        {
            int i, j;
            for (i = 0; i < vetC.Length - 1; i++)
            {
                for (j = i + 1; j < vetC.Length; j++)
                {
                    if (vetC[i] > vetC[j])
                    {
                        int aux = vetC[i];
                        vetC[i] = vetC[j];
                        vetC[j] = aux;
                    }
                }
            }
        }

        //Função para imprimir valores
        void ImprimirVetor(int[] vet, string texto)
        {
            Console.Write($"{texto}: ");
            for (int i = 0; i < vet.Length; i++)
            {
                Console.Write($" {vet[i]}");
            }
        }

        //Copiar valores de A e B para o vetor C
        int[] CopVetor(int[] vetA, int[] vetB)
        {
            int[] aux = new int[10];
            for (int i = 0; i < vetA.Length; i++)
            {
                aux[i] = vetorA[i];
            }
            for (int i = 0; i < vetB.Length; i++)
            {
                aux[vetA.Length + i] = vetorB[i];
            }

            return aux;
        }

        //Ler dados para o vetor
        int[] LerVetor(int[] vet, string texto)
        {
            for (int i = 0; i < vet.Length; i++)
            {
                Console.Clear();
                Console.Write($"Informe a posição {i + 1}, {texto}: ");
                vet[i] = int.Parse(Console.ReadLine());
            }
            return vet;
        }
    }
}