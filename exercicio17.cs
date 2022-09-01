using System;

class Programa{

        public static void Main(string[] args){
             string nome;
             double salario, anosDeEmpresa;

            Console.Write(">> Digite seu nome: \n>> ");
            nome = Console.ReadLine();

            Console.Write("\n>> Digite a quantos anos voce trabalha na empresa: \n>> ");
            anosDeEmpresa = Convert.ToDouble(Console.ReadLine());

            Console.Write("\n>> Digite seu salario para calcularmos o aumento: \n>> ");
            salario = Convert.ToDouble(Console.ReadLine());

            if (anosDeEmpresa <= 3 && anosDeEmpresa > 0)
            {
                salario = salario * 1.03;
                Console.WriteLine("\nSeu salario com aumento sera de: R$" + salario + ".00");
            }else if (anosDeEmpresa > 3 && anosDeEmpresa <= 10)
            {
                salario = salario * 1.125;
                Console.WriteLine("\nSeu salario com aumento sera de: R$" + salario + ".00");
            }else if (anosDeEmpresa > 10)
            {
                salario = salario * 1.20;
                Console.WriteLine("\nSeu salario com aumento sera de: R$" + salario + ".00");
            }

            Console.WriteLine("\n>> Pressione Enter para sair... ");
            Console.ReadLine();

        }
}

