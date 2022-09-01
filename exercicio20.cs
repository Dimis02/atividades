using System;

class Exercicio20
{
    public static void Main(string[] args){

        double pesoKg, altura, IMC;

        Console.WriteLine("---------- CALCULANDO IMC ----------");

        Console.Write("Digite seu peso em Kg: \n>> ");
        pesoKg = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite sua altura em Metros (Com virgula): \n>> ");
        altura = Convert.ToDouble(Console.ReadLine());

        IMC = pesoKg / (altura * altura);

        if ( IMC >= 0 && IMC <= 18.5)
        {
            Console.Write("\n>> Abaixo do peso!");
        }else if ( IMC > 18.5 && IMC <= 25)
        {
            Console.Write("\n>> Peso ideal!");
        }else if ( IMC > 25 && IMC <= 30)
        {
            Console.Write("\n>> Sobrepeso!");
        }else if ( IMC > 30 && IMC <= 40)
        {
            Console.Write("\n>> Obesidade!");
        }

    }
}
