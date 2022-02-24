# Git e Github

## **Iniciando uma pasta para o git**
<br>

Crie um arquvivo chamado `git.txt` na pasta e abra o terminal naquela pasta.

no terminal:
```bsh
 > git.txt ren .gitignore
```

Isto vai criar o arquivo gitignore que serve para não versionar todos os programas da sua pasta. Procure no google algo como "gitignore visual studio 2022" e copie e cole.

Feito isso, clique com botão direito e selecione `git bash here`. Logo em seguida de o comando:

```bsh
 $ git init
```

---

## **Salvando versões**

<br>

  verificando se há informações não rastreadas no repositório:
  ```
    $ git status
  ```

 - **Commit:** Ação de salvar uma versão do seu código.

  > vermelho: Arquivos não rastreados (untracked)

  > verde: Arquivos prontos para serem commitados ("stage")

  adicionando arquivos ao "stage":
  ```
    $ git add .
  ```

  > o ponto serve para adicionar todos os arquivos na zona de stage

  commitando os arquivos:
  ```
    $ git commit -m "mensagem"
  ```

  verificando se o commit foi feito:
  ```
    $ git log
  ```

  jeito simplificado de ver os commits:
  ```
    $ git log --oneline
  ```

---

## **Aplicando os commits**
<br>

### **Caso você se perca no programa e queira retornar**

Estes comandos retornam o programa para o estado do ultimo commit
```
  $ git clean -df
  $ git checkout -- .
```

### **Caso eu queira desfazer o ultimo commit**

**1. soft reset:** Remove o commit mantendo as alterações nos arquivos

```
  $ git reset --soft HEAD~1  
```

**2. hard reset:** Remove o commit removendo as alterações nos arquivos

```
  $ git reset --hard HEAD~1  
```
