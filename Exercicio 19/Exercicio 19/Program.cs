using System;
using System. Collections.Generic;

public class Exercicio19
{
    public static void Main(string[] args)
    {
        // Create a new dictionary to store names and ages (memories values)
        Dictionary<string, string> conctato = new Dictionary<string, string>();
        //apresentação do menu.
        Console.WriteLine("1.Adicionar contactos\n"+"2.Pesquisar contactos\n"+"3.Remover conctato \n"+"4.sair");
        //escolha da opção
        Console.WriteLine("Escolha uma opção:");
        string nome = Console.ReadLine();
        //opções
        switch (nome)
        {
            case "1":
                Console.WriteLine("Nome:");
                string nome1 = Console.ReadLine();
                Console.WriteLine("Contacto:");
                string contacto = Console.ReadLine();
                Console.WriteLine("contacto adicionado:");
                break;
    
            case "2":
                Console.WriteLine("Pesquisa de conctato:");
                string contacto1 = Console.ReadLine();
                Console.WriteLine("contacto encontrado:");
                break;

            case "3":
                Console.WriteLine("Remover contacto:");
                string contacto2 = Console.ReadLine();
                Console.WriteLine("contacto removido:");
                break;
            case "4":
                Console.WriteLine("Sair");
                break;


        }
    }
}
