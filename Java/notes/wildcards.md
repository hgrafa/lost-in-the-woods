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

De forma mais segura: