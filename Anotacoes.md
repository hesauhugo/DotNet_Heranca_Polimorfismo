## Herança

* A herança nos permite reutilizar atributos, métodos e comportamentos de uma classe em outras classes.
* Serve para agrupar objetos que são do mesmo tipo, porém com características diferentes
* Evitar usar muitas heranças pois aumenta a complexidade, essa complexidade deve ter uma justificativa muito boa para usá-la.
* Não existe herança multipla, uma classe tem apenas uma herança

### Classe Pessoa

```csharp

    public class Pessoa
    {
        public string Nome {get;set;}
        public int Idade {get; set;}

        public void Apresentar(){
            Console.WriteLine($"Olá, meu nome é {Nome} e tenho {Idade} anos");
        }

    }

```

### Classe Aluno
```csharp
    public class Aluno:Pessoa
    {
        public double Nota {get;set;}
        
    }
```

### Classe Professor
```csharp
    public class Professor
    {
        public decimal Salario {get; set;}
    }
```
### Program

```csharp
    var aluno  = new Aluno();
    aluno.Nome = "Enzo";
    aluno.Idade = 1;
    aluno.Nota = 10;

    aluno.Apresentar();
```

## Polimorfmismo
* O polimorfismo vem do grego e significa "muitas formas".
* Com o polimorfismo, podemos sobrescrever métodos das classes filhas para que se comportem de maneira diferente e ter sua própria implementação.

* virtual: o método da classe pai pode ser sobrescrito
* override: sobrescreve o método da classe pai

### Polimorsfimo em tempo de compilação 
* Polimorfismo em tempo de compilação( overload/Early binding)
* Não depende de herança

```csharp
    public class Calculadora{
        public int Somar(int num, int num2){
            return num1 + num2;
        }

        public int Somar(int num, int num2, int num3){
            return num1 + num2 + num3;
        }

    }
```

### Polimorfismo em tempo de execução ( override/late binding)
* Depende de herança
* sobrescrevendo o método

## Construtor por herança
* Se na classe pai houver um construtor, as classes filhas devem implementa-lo
```csharp
        public Professor(string nome):base(nome){
            
        }
```
