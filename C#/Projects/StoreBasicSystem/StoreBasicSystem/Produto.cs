namespace Curso {
    class Produto {

        public string nome;
        public double preco;
        public int quantidade;

        public double ValorTotalEmEstoque() {
            return preco * quantidade;
        }

        public void AdicionarProdutos(int increment) {
            quantidade += increment;
        }

        public void RemoverProdutos(int decrement) {
            quantidade -= decrement;
        }
    }
}
