using System;

namespace Exercicio04{
    class Program{
        static void Main(){
            Console.WriteLine("Descubra o fatorial de um número! Digite-o:");
            int num = Convert.ToInt32(Console.ReadLine());
            int numStart = 1; 
            while (num > numStart){
                numStart++;
                Console.WriteLine(num * numStart);
            }
        }
    }
}