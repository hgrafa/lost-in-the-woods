# Motivação para usar Generics

Permite que classes, interfaces e métodos possam ser parametrizados por tipo.

- Reuso
- Type safety
- Performance

Imagine o seguinte serviço:

> 📦 `services` > ➕`PrintService.java`
```java
public class PrintService {

  private List<integer> list = new ArrayList<>();

  public void addValue(Integer value) {
		list.add(value);
	}

}
```

Caso nosso objetivo fosse receber `String` ao invés de `Integer`, seira custoso.

## O problema do tipo Object

Sim, você pensou que seria fácil receber objetos do tipo `Object`, entretanto isto é uma operação perigosa, pois algumas operações não podem ser feitas normalmente.

> 📦 `services` > ➕`PrintService.java`
```java
public class PrintService {

  private List<Object> list = new ArrayList<>();

  public void addValue(Object value) {
		list.add(Object);
	}

}
```

Porém teríamos dificuldade de receber os dados no `Program.java`, afinal seria um `Scanner` para `.nextInt()` ou `.next()`? 

Além disso, a digitação pode permitir que o vetor `[1, 2, "Maria", 3]` exista, já que o tipo Object aceita qualquer classe filha. O nosso objetivo seria determinar o tipo de vetor enquanto as variáveis são inseridas pelo usuário.

## Com Generics

Criaremos um tipo `<T>` qualquer e vamos referenciar nossa classe a ele.

```java
public class PrintService <T> {

	List <T> list = new ArrayList<>();

	public void addValue( T value ){
		list.add(value);
	}

}
```

Desta forma utilizamos um tipo `generics` e tornaremos nossas operações seguras durante todo o programa.

# Genéricos Delimitados

avisando que um método vai trabalhar com um tipo `<T>`:

```java
	public <T> T max (List<T> list){
		//declara a existência do tipo T genérico
		// depois aceita retornar o tipo genérico T
	}
```

Inicialmente um `service` que encontra o maior numa lista de um tipo genérico `<T>`:

```java
public class CalculationService {

	public static <T extends Comparable<T>> T max(List<T> list) {
		if (list.isEmpty()) 
			throw new IllegalStateException("List can't be empty");

		T max = list.get(0);
		for (T item : list) {
			if (item.compareTo(max) > 0) max = item;
		}

		return max;
	}
}
```

Precisamos também implementar a `CompareTo` além de escrever o método para comparar corretamente a propriedade desejada.

Caso não quisessemos ter problemas com superclasses que implementem o `CompareTo`, que são herdados pela classe aplicada ao `generics`, teríamos que fazer da seguinte forma:

```java
public static <T extends Comparable<? super T>> T max(List<T> list) {

}	
```