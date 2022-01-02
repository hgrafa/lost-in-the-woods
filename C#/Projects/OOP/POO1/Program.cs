using System;
using System.Globalization;

namespace Curso {

    class POO1 {
        static void Main(string[] args) {

            Pessoa pessoa1 = new();

            Console.Write("Escreva seu nome: ");
            pessoa1.nome = Console.ReadLine();

            Console.Write("Escreva a sua idade: ");
            pessoa1.idade = int.Parse( Console.ReadLine() );
            
            Console.Write("Escreva sua altura e peso: ");
            string[] input = Console.ReadLine().Split(' ');
            pessoa1.altura = double.Parse( input[0] );
            pessoa1.peso = double.Parse( input[1] );

            Console.WriteLine($"O(A) {pessoa1.nome} de {pessoa1.idade} anos, possui um imc de valor {pessoa1.IMC():F2}");
        }
    }

}