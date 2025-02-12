public class execercio18
{
    public static void Main(String[] args)
    {
        // cria um array da lista de cidades
        String[] cidades = { "lisboa", "porto", "coimbra", "faro", "braga" };

        //cria um array da lista de polucao
        int[] populacao = { 545000, 237000, 143000, 118000, 193000 };
        Console.WriteLine("cidades e as suas populacao");
        Console.WriteLine();


        for (int contador = 0; contador < cidades.Length; contador++)
        {
            Console.WriteLine(cidades[contador] + " - " + populacao[contador] + " Habitantes");

        }




    }

}

