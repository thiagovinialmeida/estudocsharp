using System;

namespace Exercicio03{
    
class Program{
    static void Main(){
        Console.WriteLine("Escreva dois números!");
        string a = Console.ReadLine();
        var b = Console.ReadLine();

        if(Convert.ToInt32(a) > Convert.ToInt32(b)){
            Console.Write(a+" é maior do que "+b);
        } else {
            Console.Write(b+" é maior do que "+a);
        }
    }
}
}