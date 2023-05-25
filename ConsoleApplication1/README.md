# Exercicio 7

```csharp
using System;

namespace ConsoleApplication1 {
  
  internal class Application {
    
    public static void Main(string[] args)
    {   
      Console.WriteLine("Olá, chamo-me Pedro");
      Console.WriteLine("Pedro é o meu nome");
      Console.WriteLine("Sem dúvida que Pedro é quem está a trabalhar neste código.");

      Console.ReadLine();
    }
  }
}
```

# Exercicio 8
```csharp
using System;

namespace ConsoleApplication1 {
  
  internal class Application {
    
    public static void Main(string[] args)
    {   
      
      name = "Pedro";
      Console.WriteLine("Olá, chamo-me " + name);
      Console.WriteLine(name+ " é o meu nome");
      Console.WriteLine("Sem dúvida que " + name + " é quem está a trabalhar neste código.");

      Console.ReadLine();
    }
  }
}
```

# Exercicio 9

```csharp
using System;

namespace ConsoleApplication1 {
  
  internal class Application {
    
    public static void Main(string[] args)
    {
      
      Console.Write("Qual é o teu nome: ");
      var name = Console.ReadLine();
      
      Console.WriteLine("Olá, chamo-me " + name);
      Console.WriteLine(name+ " é o meu nome");
      Console.WriteLine("Sem dúvida que " + name + " é quem está a trabalhar neste código.");

      Console.ReadLine();
    }
  }
}
```

# Exercise 10

```csharp
string nome;
nome = "Jorge Manuel" <- ;
Console.WriteLine(nome);
Console.ReadLine();
```

```csharp
string nome;
nome = Jorge Manuel"; <- "Jorge Manuel"
Console.WriteLine(nome);
Console.ReadLine();
```

```csharp
string nome;
nome = "Jorge Manuel";
Console.WriteLine(nome);
Console.ReadLine); <- '('
```

```csharp
string nome;
nome "Jorge Manuel"; <- Não está a existir qualquer declaração de varíavel
Console.WriteLine(nome);
Console.ReadLine();
```

```csharp
string nome;
nome "Jorge Manuel"; <- Não está a existir qualquer declaração de varíavel
Console.WriteLine(nome);
Console.ReadLine();
```

```csharp
string nome;
nome = "Jorge Manuel";
Console.WriteLine(name); <- Varíavel não existe
Console.ReadLine(); 
```

# Exercicio 11

````csharp
string nome;
nome "Jorge Manuel";
````

```csharp
Console.WriteLine(nome);
```

```csharp
nome = "Jorge Manuel";
```

# Exercicio 12

```csharp
string a, b;
b = Console.ReadLine();
a = "Olá " + b;
Console.WriteLine(a);
```

1. Declara as varíaveis a e b como string
2. Usa b varíavel b para ler uma possível resposta do utilizador
3. Usa a para construir uma mensagem
4. Escreve em uma nova linha a varíavel a

# Exercício 13

```csharp
using System;

namespace ConsoleApplication1 {
  
  internal class Application {
    
    public static void Main(string[] args)
    {
      Console.WriteLine("Bom dia!");
      Console.ReadLine();
    }
  }
}
```

# Exercicio 14

```csharp
using System;

namespace ConsoleApplication1 {
  
  internal class Application {
    
    public static void Main(string[] args)
    {
      Console.Write("Como te chamas: ");
      var name = Console.ReadLine();
      Console.WriteLine("Olá " + name);
      Console.ReadLine();
    }
  }
}
```

# Exercício 15

```csharp
using System;

namespace ConsoleApplication1 {
  
  internal class Application {
    
    public static void Main(string[] args)
    {
      Console.Write("Qual é o teu nome: "); 
      var name = Console.ReadLine();
      
      Console.Write("Qual é o teu sobrenome: ");
      var surname = Console.ReadLine();
      
      Console.WriteLine("Nome completo: " + name + " " + surname);
      Console.ReadLine();
    }
  }
}
```

# Exercicio 16

```csharp
using System;

namespace ConsoleApplication1
{
    internal class Application
    {
        public static void Main(string[] args)
        {
            Console.Write("Digite um número: ");
            var num = Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine(int.Parse(num));
        }
    }
}
```

# Exercicio 17

```csharp
using System;

namespace ConsoleApplication1 {
  
  internal class Application {
    
    public static void Main(string[] args)
    {
      Console.Write("Escreva um número: ");
      var num = Console.ReadLine();
      
      Console.WriteLine("Número: " + int.Parse(num));
    }
  }
}
```

# Exercicio 18

```csharp
using System;

namespace ConsoleApplication1 {
  
  internal class Application {
    
    public static void Main(string[] args)
    {
      Console.Write("Escreva um número: ");
      var num1 = Console.ReadLine();
      
      Console.Write("Escreva outro número: ");
      var num2 = Console.ReadLine();
      
      Console.WriteLine("Número: " + int.Parse(num1 * num2));
      Console.ReadLine();
    }
  }
}
```

# Exercicio 19

```csharp
using System;

namespace ConsoleApplication1 {
  
  internal class Application {
    
    public static void Main(string[] args)
    {
      Console.Write("Escreva um número: ");
      var num1 = Console.ReadLine();
      
      Console.Write("Escreva outro número: ");
      var num2 = Console.ReadLine();
      
      Console.WriteLine("Multiplicação: " + (int.Parse(num1) * int.Parse(num2)));
      Console.WriteLine("Divisão: " + (int.Parse(num1) / int.Parse(num2)));
      Console.WriteLine("Subtração: " + (int.Parse(num1) - int.Parse(num2)));
      Console.WriteLine("Soma: " + (int.Parse(num1) + int.Parse(num2)));
      Console.ReadLine();
    }
  }
}
```

# Exercicio 20

```csharp
using System;

namespace ConsoleApplication1 {
  
  internal class Application {
    
    public static void Main(string[] args)
    {
      var a = 1;
      var b = 2;

      var cached = a;

      a = b;
      b = cached;
    }
  }
}
```

# Exercicio 21

```csharp
using System;

namespace ConsoleApplication1 {
  
    internal class Application {
    
        public static void Main(string[] args)
        {

            Console.Write("Digita um numero: ");
            var num1 = Console.ReadLine();
      
            Console.Write("Digita outro numero: ");
            var num2 = Console.ReadLine();
      
            Console.WriteLine(int.Parse(num1) == int.Parse(num2) ? "É igual" : "Não é igual");
        }
    }
}
```

# Exercicio 22

```csharp
using System;

namespace ConsoleApplication1 {
  
    internal class Application {
    
        public static void Main(string[] args)
        {

            Console.Write("Digita um numero: ");
            var num1 = Console.ReadLine();
      
            Console.Write("Digita outro numero: ");
            var num2 = Console.ReadLine();
      
            Console.WriteLine(int.Parse(num1) == int.Parse(num2) ? "É igual" : "Não é igual");
        }
    }
}
```

# Exercicio 23

```csharp
using System;

namespace ConsoleApplication1 {
  
    internal class Application {
    
        public static void Main(string[] args)
        {

            Console.Write("Digita um numero: ");
            var num1 = Console.ReadLine();
      
            Console.Write("Digita outro numero: ");
            var num2 = Console.ReadLine();
      
            Console.WriteLine(int.Parse(num1) == int.Parse(num2) ? "É igual" : "Não é igual");
            Console.WriteLine(int.Parse(num1) > int.Parse(num2) ? "num1 é superior" : "num2 é superior");
        }
    }
}
```

# Exercicio 24

```csharp
using System;

namespace ConsoleApplication1 {
  
  internal class Application {
    
    public static void Main(string[] args)
    {
      Console.Write("Digita um numero: ");
      var num1 = Console.ReadLine();

      Console.WriteLine(int.Parse(num1) > 0 ? "É positivo" : "É negativo");
    }
  }
}
```

# Exercicio 25

```csharp
using System;

namespace ConsoleApplication1 {
  
  internal class Application {
    
    public static void Main(string[] args)
    {
      Console.Write("Digita um numero: ");
      var num1 = Console.ReadLine();

      Console.WriteLine(int.Parse(num1) % 2 == 0 ? "É par" : "É impar");
    }
  }
}
```

# Exercicio 26

```csharp
using System;

namespace ConsoleApplication1 {
  
  internal class Application {
    
    public static void Main(string[] args)
    {
    
      Console.Write("Digita um numero: ");
      var num1 = Console.ReadLine();
      Console.WriteLine(int.Parse(num1) % 2 == 0 ? "É par" : "É impar");
      
      Console.Write("Digita um numero: ");
      var num2 = Console.ReadLine();
      Console.WriteLine(int.Parse(num2) % 2 == 0 ? "É par" : "É impar");
    }
  }
}
```

# Exercicio 27

```csharp
using System;

namespace ConsoleApplication1 {
  
  internal class Application {
    
    public static void Main(string[] args)
    {

      for (int i = 1; i < 4; i++)
      {
        Console.WriteLine(i);
      }
    }
  }
}
```

# Exercicio 28

```csharp
using System;

namespace ConsoleApplication1 {
  
    internal class Application {
    
        public static void Main(string[] args)
        {
            Console.Write("Escreva um numero: ");
            var num1 = int.Parse(Console.ReadLine());
            
            for (var i = num1 - 1; i > 0; i--)
            {
                Console.WriteLine("O numero antrior a " + (i+1) + " é " + i);
            }
        }
    }
}
```

# Exercicio 29

```csharp
using System;

namespace ConsoleApplication1 {
  
  internal class Application {
    
    public static void Main(string[] args)
    {
      Console.Write("Introduza o número inicial: ");
      var num1 = int.Parse(Console.Read());
      
      Console.Write("Introduza o número final: ");
      var num2 = int.Parse(Console.Read());
      
      for (var i = num1; i < num2; i++)
      {
        Console.WriteLine(i);
      }
    }
  }
}
```

# Exercicio 30

```csharp
    using System;

namespace ConsoleApplication1 {
  
  internal class Application {
    
    public static void Main(string[] args)
    {
      
      while (true)
      {

        Console.Write("Introduza um número: ");
        var num1 = Console.ReadLine();

        if (num1 == 0)
        {
          break;
        }
        
        Console.WriteLine(int.Parse(num1) % 2 == 0 ? int.Parse(num1) + " é par" : int.Parse(num1) + " é impar");
      }
    }
  }
}
```

# Exercicio 31

```csharp
using System;

namespace ConsoleApplication1 {
  
    internal class Application {
    
        public static void Main(string[] args)
        {

            Console.Write("Digite o numero mais baixo: ");
            var num1 = int.Parse(Console.ReadLine());
     
            Console.Write("Digite o numero mais alto: ");
            var num2 = int.Parse(Console.ReadLine());
            
            Console.WriteLine("");

            for (var i = num1; i < num2; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i + " é par");
                }
            } 
        }
    }
}
```

# Exercicio 32

```csharp
using System;

namespace ConsoleApplication1 {
  
    internal class Application {
    
        public static void Main(string[] args)
        {

            Console.Write("Digite o numero mais pequeno: ");
            var num1 = int.Parse(Console.ReadLine());
            
            Console.Write("Digite o numero mais alto: ");
            var num2 = int.Parse(Console.ReadLine());

            var size = 0;

            for (var i = num1; i < num2; i++)
            {
                if (i % 2 == 0)
                {
                    size++;
                }
            }
      
            Console.WriteLine("Existem " + size + " pares.");
        }
    }
}
```

# Exercicio 33

```csharp
using System;

namespace ConsoleApplication1
{
    internal class Application
    {
        public static void Main(string[] args)
        {
            Console.Write("Digite o valor mais baixo: ");
            var num1 = int.Parse(Console.ReadLine());
            
            Console.Write("Digite o valor mais alto: ");
            var num2 = int.Parse(Console.ReadLine());

            var pairs = 0;
            var odds = 0;

            for (var i = num1; i < num2; i++)
            {
                if (i % 2 == 0) pairs++;
                if (i % 2 != 0) odds++;
            }

            Console.WriteLine("Existem " + pairs + " numeros pares");
            Console.WriteLine("Existem " + odds + " numeros impares");
        }
    }
}
```

# Exercicio 34

```csharp
using System;

namespace ConsoleApplication1
{
    internal class Application
    {
        public static void Main(string[] args)
        {
            Console.Write("Escreva um numero: ");
            var num1 = int.Parse(Console.ReadLine());

            for (var i = 1; i < 11; i++)
            {
                Console.WriteLine(i + ": " + num1 * i);
            }
        }
    }
}
```

# Exercicio 35

```csharp
using System;

namespace ConsoleApplication1
{
    internal class Application
    {
        public static void Main(string[] args)
        {

            Console.Write("Digite um numero: ");
            var num1 = int.Parse(Console.ReadLine());

            Console.WriteLine((num1 % 2 != 0 && num1 % 3 != 0) ? "É primo" : "Não é primo");
        }
    }
}
```

# Exercicio 36

```csharp
using System;
using System.Collections.Generic;

namespace ConsoleApplication1
{
    internal class Application
    {
        public static void Main(string[] args)
        {

            Console.Write("Digite um numero: ");
            var num1 = int.Parse(Console.ReadLine());

            Console.Write("Digite outro número: ");
            var num2 = int.Parse(Console.ReadLine());
            
            Console.WriteLine("");

            var pairs = new List<int>();
            var odds = new List<int>();
            var primes = new List<int>();

            for (var i = num1; i <= num2; i++)
            {
                if (i % 2 == 0)
                {
                    pairs.Add(i);
                }

                if (i % 2 != 0)
                {
                    odds.Add(i);
                }

                if (i % 2 != 0 && i % 3 != 0)
                {
                    primes.Add(i);
                }
            }

            Console.WriteLine("Existem {0} entre eles".Replace("{0}", (num2 - num1).ToString()));
            Console.WriteLine("Existem {0} numeros pares".Replace("{0}", pairs.Count.ToString()));
            Console.WriteLine("Existem {0} numeros impares".Replace("{0}", odds.Count.ToString()));
            Console.WriteLine("Existem {0} numeros primos".Replace("{0}", primes.Count.ToString()));
        }
    }
}
```
