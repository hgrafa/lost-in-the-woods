# **Programação Orientada a Objetos em C#**

## **1. O básico da orientação a objetos**

Criar uma classe genérica é como criar um molde para fabricar o mesmo produto várias vezes. Assim como podemos criar inteiros, reais e caracteres, imagine poder iniciar uma variável do tipo triângulo, que automaticamente já consiga lidar com 3 entradas que possam ser consultadas.

Toda classe de modo geral é divida em `instances` e `methods`, ou melhor, *estados* e *métodos*. 

As `instances `são as partes que consultamos e que retornam características do objeto criado pelo molde.

```c#  
  class Complex{

    public double real;
    public double imaginary;

  }
  
  Complex z = new Complex( );
  z.real = 3.0;
  z.imaginary = 4.0;

  Console.WriteLine($"({z.real}) + ({z.imaginary})i");
```

output:
```
  (2.0) + (3.0)i
```

Os `methods` são funções que só uma determinada família de objetos é capaz de executar. Existe, por exemplo, um método para o módulo de um complexo, mas não existe módulo para uma bicicleta.

```c#
  class Complex{
    public double real;
    public double imaginary;


    public double module(){
      return Math.Sqrt( real*real + imaginary*imaginary );
    }

  }

  Complex z = new Complex( );
  z.real = 3;
  z.imaginary = 4;

  Console.WriteLine(z.module());
```

output:
```
  5.0
```

Neste caso em particular nosso método não possui parâmetros pois todos os necessários já estão no escopo da nossa classe, e precisam ser informados para construir o objeto.

----

## **2. vantagens de usar Orientação a Objetos**

<br>

* **Constructors:** Montam o objeto particular do molde(classe).

* **Sobrecarga:**

* **Encapsulamento:** Permite maior praticidade e ordem lógica ao longo do código, e também permite que um objeto seja usado em outra classe, construindo um *objeto maior*.

* **Herança:** Quando uma família do objeto se baseia apenas em métodos e estados adicionais do molde inicial, por exemplo uma bicicleta elétrica herda a construção de uma bicicleta normal, com estados e métodos adicionais.

* **Polimorfismo:**

---

## 3. **Adicionando Classes em C#**

<br>

**Importante:** As classes precisam estar regidas sob um mesmo namespace, seja dentro do mesmo código ou fora do mesmo código. Futuramente poderemos diferenciar namespaces para acessar outras classes.

**Observação:** Assim como em java o jeito tradicional de se instanciar uma classe é usando:
```c#
  CreatedClass object = new CreatedClass();
```
que pode ser simplificado para:
```c#
  CreatedClass object = new();
```

### **3.1 Classes em um mesmo código**

Basta declarar a classe antes da `main`, bem similar aos `structs` do *C/C++*.

Arquivo completo `Consultas.cs`:
```c#
using System;

namespace Resumo{

  class Pessoa {
      public string nome;
      public int idade;
      public double altura, peso;

      public double IMC() {
          return peso / (altura * altura);
      }
  }

  class Consultas {
        static void Main(string[] args) {

            Pessoa pessoa1 = new();
            pessoa1.nome = Console.ReadLine( );
            pessoa1.idade = int.Parse( Console.ReadLine() );
           
            string[] input = Console.ReadLine().Split(' ');
            pessoa1.altura = double.Parse( input[0] );
            pessoa1.peso = double.Parse( input[1] );

            Console.WriteLine($"O(A) {pessoa1.nome} de {pessoa1.idade} anos, possui um imc de valor {pessoa1.IMC():F2}");
        }
    }

  }
```

### **3.2 Colocando as classes como arquivos externos**

  Dessa forma é esperado que o projeto como um todo fique mais organizado.

  Para criar uma nova classe, procure a guia *solution explorer*, clique com o botão direito e escolha as opções: `add -> class` .

  Isto irá gerar um novo `arquivo.cs` cujo nome do arquivo deverá ser o nome da classe em letra maiúscula, e deve estar regido sob o mesmo namespace.

arquivo da classe `Pessoa.cs`:
```c#
namespace Resumo {
    class Pessoa {

        public string nome;
        public int idade;
        public double altura, peso;

        public double IMC() {
            return peso / (altura * altura);
        }
    }
}
``` 

arquivo da classe/função principal `Consultas.cs`:
```c#
using System;

namespace Curso {

    class POO1 {
        static void Main(string[] args) {

            Pessoa pessoa1 = new();
            pessoa1.nome = Console.ReadLine();

            pessoa1.idade = int.Parse( Console.ReadLine() );
            string[] input = Console.ReadLine().Split(' ');
            pessoa1.altura = double.Parse( input[0] );
            pessoa1.peso = double.Parse( input[1] );

            Console.WriteLine($"O(A) {pessoa1.nome} de {pessoa1.idade} anos, possui um imc de valor {pessoa1.IMC():F2}");
        }
    }

}
```

----

## **4. Escrevendo em modelo UML**

<br>

O padrão UML divide uma classe em 3 partes:

```
|---------------|  
|   ClassName   |
|---------------|
| - Instances   |
|---------------|
|  + Methods    |
|---------------|
```

![UML example](./images/UML-Classe-Pessoa.jpeg)

