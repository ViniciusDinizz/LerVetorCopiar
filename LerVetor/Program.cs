internal class Program
{
    private static void Main(string[] args)
    {
        int[] vetorA = new int[5];
        int[] vetorB = new int[5];
        int[] vetorC = new int[10];

        lerVetor(vetorA);
        lerVetor(vetorB);

        copVetor(vetorA, vetorB, vetorC);


        imprimirVetor(vetorA);
        Console.WriteLine();
        imprimirVetor(vetorB);
        Console.WriteLine();
        imprimirVetor(vetorC);

        //Função para imprimir valores
        void imprimirVetor(int[] vet)
        {
            for(int i =0;i < vet.Length; i++)
            {
                Console.Write($" {vet[i]}");
            }
        }

        //Copiar valores de A e B para o vetor C
        int[] copVetor(int[] vetA, int[] vetB, int[] vetC)
        {
            for(int i = 0; i < vetA.Length; i++)
            {
                vetC[i] = vetorA[i];
            }
            for(int i = 0;i < vetB.Length; i++)
            {
                vetC[vetB.Length+i] = vetorB[i];
            }

            return vetC;
        }

        //Ler dados para o vetor
        int[] lerVetor(int[] vet)
        {
            for (int i = 0; i < vet.Length; i++)
            {
                Console.Clear();
                Console.Write($"Informe a posição{i + 1}: ");
                vet[i] = int.Parse(Console.ReadLine());
            }
            return vet;
        }
    }
}