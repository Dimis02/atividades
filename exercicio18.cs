susing System;

   class Programa{

    static void Main(string[] args)
	{ 
        int comprimento1, comprimento2, comprimento3;
        
        
         Console.Write("Digite um lado do triangulo: \n>> ");
         comprimento1 = int.Parse(Console.ReadLine());

         Console.Write("Digite o outro lado do triangulo: \n>> ");
         comprimento2 = int.Parse(Console.ReadLine());

         Console.Write("Digite o ultimo lado do triangulo: \n>> ");
         comprimento3 = int.Parse(Console.ReadLine());


         if(comprimento1 == comprimento2 && comprimento1 == comprimento3){
            Console.WriteLine("\n\n>> Este triangulo e equilatero.");

            }else if(comprimento1 == comprimento2  && comprimento1 != comprimento3){
                Console.WriteLine("\n\n>> Este triangulo e isoceles.");
            }else{
                Console.WriteLine("\n\n>> Este triangulo e escaleno.");
            }
     

         
         Console.WriteLine("Pressione Enter para sair..");
         Console.ReadLine();
    }
	}