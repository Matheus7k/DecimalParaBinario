internal class Program
{
    private static void Main(string[] args)
    {
        int numero;

        Console.Write("Informe um numero decimal para ser convertido para binario: ");
        numero = int.Parse(Console.ReadLine());

        int[] numerosBinariosParaImprimir = new int[8];
        numerosBinariosParaImprimir = converteBinario(numero);

        for (int i = 0; i < numerosBinariosParaImprimir.Length; i++)
        {
            Console.Write(numerosBinariosParaImprimir[i]);
        }

        int[] converteBinario(int numero)
        {
            int[] numerosBinarios = new int[8];

            while (numero > 0)
            {
                for (int i = 7; i >= 0; i--)
                {
                    numerosBinarios[i] = numero % 2;
                    numero /= 2;
                }
            }

            return numerosBinarios;
        }


    }
}