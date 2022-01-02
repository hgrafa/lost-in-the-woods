namespace Curso {

    class Pessoa {

        public string nome;
        public int idade;
        public double altura, peso;

        public double IMC() {
            return peso / (altura * altura);
        }

    }

}