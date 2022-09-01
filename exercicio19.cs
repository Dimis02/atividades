using System;

class Exercicio19
{
    static void Main(string[] args)
	{ 
        double valorImovel, salario, prestacao;
        
        
         Console.WriteLine("Digite o valor do imovel desejado:");
         valorImovel = int.Parse(Console.ReadLine());

         Console.WriteLine("\nDigite quanto voce ganha:");
         salario = int.Parse(Console.ReadLine());

         Console.WriteLine("\nDigite em quantas prestacoes voce quer pagar:");
         prestacao = int.Parse(Console.ReadLine());

         salario = salario * 0.70;
         prestacao = valorImovel / prestacao;
        
        if (prestacao > salario)
        {
            Console.WriteLine("\nNao sera possivel comprar.\n");
        }else{
            Console.WriteLine("\nSera possivel.\n");
        }

     
      Console.WriteLine("Digite Enter para sair..");
      Console.ReadLine();
    }
}