using System;

namespace Curso {
    class StoreBasicSystem {
        static void Main(string[] args) {

            Produto item = new();
            int querys;

            Console.WriteLine("Entre os dados do produto:");

            Console.Write("Nome: ");
            item.nome = Console.ReadLine();

            Console.Write("Preço: ");
            item.preco = double.Parse(Console.ReadLine());

            Console.Write("Quantidade no estoque: ");
            item.quantidade = int.Parse(Console.ReadLine());

            Console.Write("Digite quantas operações pretende fazer: ");
            querys = int.Parse(Console.ReadLine());

            Console.WriteLine($"Dados do produto: {item.nome}, R${item.preco}, Total = R${item.ValorTotalEmEstoque()}");
            Console.WriteLine("Digite (a) para acrescentar produtos ao estoque.");
            Console.WriteLine("Digite (r) para remover produtos do estoque");
            Console.WriteLine("Digite (c) para consultar o valor em estoque");

            for (int i = 0; i < querys; i++) {

                char option = char.Parse(Console.ReadLine());

                if (option == 'a') {
                    Console.Write("Digite o número de produtos a ser adicionado no estoque: ");
                    item.AdicionarProdutos( int.Parse(Console.ReadLine()) );
                    Console.WriteLine($"Dados Atualizados: {item.nome}, R${item.preco}, Total = R${item.ValorTotalEmEstoque()}");
                else if (option == 'r') {
                    Console.Write("Digite o número de produtos a ser removido do estoque: ");
                    item.RemoverProdutos( int.Parse(Console.ReadLine()) );
                    Console.WriteLine($"Dados Atualizados: {item.nome}, R${item.preco}, Total = R${item.ValorTotalEmEstoque()}");
                } else {
                    Console.WriteLine("A operação solicitada é inválida");
                }
            
            }
            

            Console.WriteLine("Operações Finalizadas!");
        }
    }
}