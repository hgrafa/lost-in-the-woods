# **Java Bootcamp**

## 1. **Saida de dados**

saída padrão pulando linha:
```java
  System.out.println("Olá Mundo");
```

saída sem pular linha:
```
  System.out.print(var);
```

saída controlando casas decimais de precisão:
```
  System.out.printf("%.2f \n", x);
```

## 2. **Entrada de dados**

precisa importar:
```java
import java.util.Scanner;
```

```java
  // cria um objeto para ler entrada do teclado
  Scanner input = new Scanner(System.in);

  // libera esse objeto quando não precisar mais
  input.close();
```

Lendo uma `string` considerando os espaços:

```java
  Scanner input = new Scanner(System.in);

  String phrase = input.next();

  input.close();
```

Lendo outras entradas:
```java
  int x = input.nextInt();
  double y = input.nextDouble();
```

Fazendo a entrada ler uma linha completa:

```java
  input.nextLine();
```

cuidado com o **buffer**: ao ler uma variável antes de ler uma linha, precisa criar um `ìnput.nextLine()` para limpar o enter que ficou preso no bufffer.

## 3. **Matemática em java**

 ```java
  Math.sqrt();
  Math.pow();
  Math.abs();
  ...
 ```

 ## 4. **Estruturas condicionais**

 Tudo a mesma coisa, com adição do operador ternário.


 ### **Operador Ternário**

  ```
    (condition) ? ifTrue : ifFalse;
  ```

  ``` java
    String older = ( ageJhon > ageMary ) "Jhon" : "Mary" ;
  ```

## **5. Operadores Bitwise**

Realizam as operações lógicas bit a bit.

```
  | -> or
  & -> and
  ^ -> xor
```