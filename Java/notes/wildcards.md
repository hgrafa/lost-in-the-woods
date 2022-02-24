# Wildcard Types (Tipos Curinga)

```java
List <Object> myObjects = new ArrayList<Object>();
```

Uma lista de objetos não é o supertipo de todas as listas, ainda que a Object seja supertipo de todas as Classes.

Caso seja usado dessa forma, haverá erro de compilação.

o supertipo neste caso é uma lista do tipo Curinga:

```java
List<?> muObjects = new ArrayList<Object>();
```

## Podemos fazer métodos genéricos para qualquer tipo:

```java
public class Program{

	public static void main(String[] args){
		List<Integer> myInts = Arrays.asList(5, 2, 10);
		printList(myInts);
	}

	public static void printList( List<?> list){
		for (Object obj : list){
			System.out.println(obj);
		}
	}

}
```

**Observação:** Não é possível adicionar elementos ao tipo curinga, o compilador no estado atual não consegue interpretar se o tipo da lista é o tipo do número a ser inserido.

# Bounded wildcards (Tipos Curinga delimitados)

São delimitações para superclasses ou subclasses de um tipo qualquer. Por exemplo, imagine uma lista que aceita qualquer elemento do tipo Shape e subclasses de shape. Se criado como tipo curinga:

- A operação que cria uma `List<Circle>` e passa para uma `List<? extends shape>` é segura, pois eu estou passando uma lista do mesmo homogênea para uma lista genérica qualquer.

- A operação `.add()` não é segura, pois eu sei que o tipo a entrar na lista é subclasse de shape, entretanto, pode ser um tipo `rectangle` entrando numa `List<? extends shape>` que já recebeu uma `List <Circle>`. É um problema similar ao *type safety*

```java
public class Program {

	public static void main(String[] args) {
		
		List<Shape> myShapes = new ArrayList<>();
		myShapes.add(new Rectangle(3.0, 2.0));
		myShapes.add(new Circle(2.0));
		
		List<Circle> myCircles = new ArrayList<>();
		myCircles.add(new Circle(2.0));
		myCircles.add(new Circle(3.0));
		
		System.out.println("Total area: " + totalArea(myCircles));
	}
	
	public static double totalArea(List<? extends Shape> list) {
		double sum = 0.0;
		for (Shape s : list) {
			sum += s.area();
		}
		return sum;
	}
}
```

# Princípios Get/Put

Vamos fazer métodos que copiam elementos de uma lista para outra que pode ser mais genérica que a primeira.

```java
List <Integer> myInts = Arrays.asList(1, 2, 3, 4);
List <Double> myDoubles = Arrays.asList(3.14, 6.28);
List <Object> myObjs = new ArrayList<Object>();
```

## 1. Princípio da Covariância

A Wrapper `Number` é uma classe intermediária entre a `Object` e todos os outros tipos numéricos.

Desta forma, se fizermos:

```java
List <Integer> intList = Arrays.asList(1, 2, 3);
List < ? extends Number > list = intList;
```

| get | put |
| :-: | :-:|
| OK | ERROR|

```java
Number x = list.get(0); // ok
list.add(10); // erro de compilação
```

Neste caso vamos da classe para as subclasses, e sendo assim, podemos ter operações menos seguras durante as inserções, basta lembrar das relações *é um/ é uma*.

> Shape não é um rectangle

> Shape não é um Circle

Isto justifica as inserções não serem seguras.

## 2. Princípio da Contravarância

Aqui faremos uma referência as superclasses de uma classe, 

```java
List <object> myObjs = Array.asList("Maria", "Alex");
List < ? super Number > myNums = myObjs;
```

| get | put |
| :-: | :-:|
| ERROR | OK |

```java
list.add(10); // é um number e com certeza é um objeto
// operação segura

list.add(3.14); // é um number e com certeza é um objeto
// operação segura

Number x = myNums.get(0);
// A lista pode ter elementos de uma superclasse
// por exemplo do tipo object ou string
// desta forma, passa o valor para Number não é seguro

```

## Retornando ao método copy

```java
public class Program {
  public static void main(String[] args) {

    List<Integer> myInts = Arrays.asList(1, 2, 3, 4);
    List<Double> myDoubles = Arrays.asList(3.14, 6.28);
    List<Object> myObjs = new ArrayList<Object>();
    
    copy(myInts, myObjs);
    printList(myObjs);
    copy(myDoubles, myObjs);
    printList(myObjs);
  
  }
  
  public static void copy(List<? extends Number> source, List<? super Number> destiny) {
    for(Number number : source) {
      destiny.add(number);
    }
  }
  
  public static void printList(List<?> list) {
    for (Object obj : list) {
      System.out.print(obj + " ");
    }
    
    System.out.println();
  }
}
```