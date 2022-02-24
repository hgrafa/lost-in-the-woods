# **C# bootcamp**

## **1. Conversão implícita funciona em c#**

code:
```c#
  double a = 5.1;
  int b = (int)a;

  Console.WriteLine(a);
  Console.WriteLine(b);
```
output:
```
  5.1
  5 
```

---
## **2. Ajustando saídas de precisão**

<br>

code:
```c#
  double var = 3.141592;

  Console.WriteLine(var.ToString("F2"));
```
output:
```
  3.14
```
> Caso o local de saida esteja em outras linguagens a saída pode sair na forma `3,14` e não `3.14`. Para fazer com que a saída ignore a linguagem do sistema e utilize o padrão internacional:

Adicione a header:
```c#
  using System.Globalization;
```
e adapte o comando da seguinte forma:
```c#
  Console.WriteLine(var.ToString("F2", CultureInfo.InvariantCulture));
```
---
## **3. Saída: placeholders, concatenação e interpolação**

<br>

**Detalhe:**  O comando `Console.WriteLine()` é uma versão *melhorada* do comando `Console.Write()` que apenas escreve na linha sem pular para a próxima(`\n`).

<br>

### **3.1 método por concatenação**

```c#
  Console.WriteLine(nome + " tem " + idade + " anos");
```

### **3.2 método por placeholders**

```c#
  Console.WriteLine("{0} tem {1} anos", nome, idade);
```

### **3.3 método por interpolação**

```c#
  Console.WriteLine($"{nome} tem {idade} anos");
```
----
## **4. Métodos e limitações das entradas**

<br>

### **4.1 Recebendo Strings**

Toda entrada em **C#** é interpretada em forma de string.

code:
``` c#
  string x = Console.Readline();
```

**Note que** desta forma, apenas é possível lidar com entradas que sejam inseridas uma a uma através do *enter*. 

Para receber entradas que estejam em uma mesma linha usamos o `.split(char)` que separa uma string em substrings todas as vezes em que `char` for lido.

code:
```c#
  string input = console.ReadLine();
  string[] nomes = input.split(' ');

  Console.WriteLine(nomes[2]);
```

input:
```
  João Maria Pedro Marcelo
```

output:
```
  Pedro
```



de forma mais compacta:

code:
```c#
  string[] nomes = Console.ReadLine().split(' ');
```

<br>

### **4.2 Convertendo para outros tipos de variáveis**

Usamos o método `.Parse()` para trocar o tipo de uma variável:

```c#
  string[] input = Console.ReadLine().Split(' ');
  string nome = input[0];
  int idade = int.Parse(input[1]);
  double altura = double.Parse(input[2], CultureInfo.InvariantCulture);
  // InvariantCulture para que a máquina leia sempre com ponto e não espere ler com vírgula

  Console.WriteLine(nome + " possui " + idade + " anos e tem " + altura.ToString("F2", CultureInfo.InvariantCulture) + " de altura");
```
----
## **5. Estruturas Condicionais e de Repetição**

Mesma coisa de sempre.

---

## **6. Debbugging no Visual Studio**

Motivação: rodar o programa passo a passo e analisar como a máquina está tratando os dados e as funções do código.

<br>

> ***Breakpoint:*** momento em que se deixa de ter certeza se o código realmente está funcionando.

<br>

```
  F9 -> Marcar/Desmarcar o Breakpoint
  F5 -> Iniciar/Continuar o Debug
  SHIFT + F5 -> Parar Debug
```

<br>

> ***Steps:*** passos de um código são as ações tomadas uma a uma ao longo do programa.

<br>

```
  F10 -> Executa um passo (pulando escopos de função)
  F11 -> Executa um passo (adentrando escopos de função)
  SHIFT + F11 -> Sair da função em execução
```

----