using System;

class Aula03{
    static void Main(){
        byte n1 = 10; //Bytes de 0 a 255
        int numero = 10; //Números inteiros
        float valor = 1.5f; //Números reais(Com virgula)
        char caracter= 'a'; //Somente para Caracteres, comportando somente uma unica letra

        string palavra = "Hello";// Uma sequencia de caracteres que formam palavras

        var aux = 40; //"Var" é uma variavel não especifica, que herda o tipo do dado que for guardado nela

        Console.WriteLine(aux + numero);
    }
}