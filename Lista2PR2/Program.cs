using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista2PR2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //exercicio 1

            //float num, res;

            //Console.WriteLine("Quantas laranjas voce deseja? ");
            //num=float.Parse(Console.ReadLine());

            //if (num <= 11){ 

            //    res= num*0.35f;
            //    Console.WriteLine(" o valor sera de: "+res);

            //}
            //else
            //{
            //    res = num * 0.28f;
            //    Console.WriteLine("o valor sera de: " + res);
            //}
            //Console.ReadKey();

            //exercicio 2

            //int ida, res;

            //Console.WriteLine("que ano voce nasceu? ");
            //ida=int.Parse(Console.ReadLine());

            //res = 2026 - ida;
            //if (res >= 16)
            //{
            //    Console.WriteLine("voce pode votar ");
            //}
            //else
            //{
            //    Console.WriteLine("voce nao pode votar");
            //}
            //Console.ReadKey();


            //exercicio 3

            //int a, b, c;

            //Console.WriteLine("qual o valor do lado a? ");
            //a=int.Parse(Console.ReadLine());
            //Console.WriteLine("qual o valor do lado b? ");
            //b=int.Parse(Console.ReadLine());
            //Console.WriteLine("qual o valor do lado c? ");
            //c=int.Parse(Console.ReadLine());

            //if (a == b && b == c)
            //{
            //    Console.WriteLine("o triangulo é equilatero");
            //}
            //else {
            //    if (a == c && b != c || c==b && a!=b || a==b && c != b)
            //    {
            //        Console.WriteLine("o triangulo é isoceles");
            //    }
            //    else {
            //        Console.WriteLine("o triangulo é escaleno ");
            //    }
            //}
            //Console.ReadKey();

            //exercicio 4
            //double a, b, c, delta;
            //Console.Write("Digite o valor de A: ");
            //a = double.Parse(Console.ReadLine());
            //Console.Write("Digite o valor de B: ");
            //b = double.Parse(Console.ReadLine());
            //Console.Write("Digite o valor de C: ");
            //c = double.Parse(Console.ReadLine());


            //delta = Math.Pow(b, 2) - 4 * a * c;


            //if (delta < 0)
            //{
            //    Console.WriteLine("A equação não possui raízes reais");
            //}
            //else
            //{
            //    // Calcula as raízes
            //    double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
            //    double x2 = (-b - Math.Sqrt(delta)) / (2 * a);


            //    Console.WriteLine("As raízes da equação são: x1 = " + x1 + ", x2 = " + x2);
            //}


            // exercicio 5

            //float num;

            //Console.WriteLine("qual o numero? ");
            //num = float.Parse(Console.ReadLine());

            //if (num % 3 == 0 && num % 5 == 0)
            //{
            //    Console.WriteLine("o numero é divisivel por 5 e 3 ");
            //}
            //else
            //{
            //    if (num % 5 == 0)
            //    {
            //        Console.WriteLine("o numero é divisivel por 5");
            //    }
            //    else
            //    {
            //        Console.WriteLine("o numero é divisivel por 3");
            //    }
            //}
            //Console.ReadKey();


            //exercicio 6

            //float ang1, ang2, ang3;

            //Console.WriteLine("qual o valor do 1 angulo? ");
            //ang1 = float.Parse(Console.ReadLine());
            //Console.WriteLine("qual o valor do 2 angulo? ");
            //ang2 = float.Parse(Console.ReadLine());
            //Console.WriteLine("qual o valor do 3 angulo? ");
            //ang3 = float.Parse(Console.ReadLine());

            //if (ang1 == 90 || ang2 == 90 || ang3 == 90)
            //{
            //    Console.WriteLine("é um triangulo retangulo");
            //}
            //else
            //{
            //    if(ang1 <90 && ang2<90 && ang3 < 90)
            //    {
            //        Console.WriteLine("é um triangulo acutangulo");
            //    }
            //    else
            //    {
            //        Console.WriteLine("é um triangulo obtusangulo");
            //    }
            //}
            //Console.ReadKey();

            //exercicio 7
            //int valor1, valor2, valor3;

            //Console.Write("Digite o primeiro valor: ");
            //valor1 = int.Parse(Console.ReadLine());
            //Console.Write("Digite o segundo valor: ");
            //valor2 = int.Parse(Console.ReadLine());
            //Console.Write("Digite o terceiro valor: ");
            //valor3 = int.Parse(Console.ReadLine());


            //if (valor1 > valor2)
            //{
            //    valor1 = valor1 + valor2;
            //    valor2 = valor1 - valor2;
            //    valor1 = valor1 - valor2;
            //}
            //if (valor1 > valor3)
            //{
            //    valor1 = valor1 + valor3;
            //    valor3 = valor1 - valor3;
            //    valor1 = valor1 - valor3;
            //}


            //if (valor2 > valor3)
            //{
            //    valor2 = valor2 + valor3;
            //    valor3 = valor2 - valor3;
            //    valor2 = valor2 - valor3;
            //}


            //Console.WriteLine("Valores em ordem crescente: " + valor1 + ", " + valor2 + ", " + valor3);

            //Console.ReadKey();


            //exercicio 8


            //int ano;
            //Console.Write("Digite um ano: ");
            //ano = int.Parse(Console.ReadLine());


            //if ((ano % 4 == 0 && ano % 100 != 0) || (ano % 400 == 0))
            //{
            //    Console.WriteLine(ano + " é um ano bissexto");
            //}
            //else
            //{
            //    Console.WriteLine(ano + " não é um ano bissexto");
            //}

            //Console.ReadKey();


            //exercicio 9
            //char operador;
            //double num1, num2;
            //Console.Write("Digite o primeiro número: ");
            //num1 = double.Parse(Console.ReadLine());
            //Console.Write("Digite o segundo número: ");
            //num2 = double.Parse(Console.ReadLine());


            //Console.Write("Digite o caractere da operação (+, -, *, /): ");
            //operador = char.Parse(Console.ReadLine());


            //double resultado = 0;
            //if (operador == '+')
            //{
            //    resultado = num1 + num2;
            //}
            //if (operador == '-')
            //{
            //    resultado = num1 - num2;
            //}
            //if (operador == '*')
            //{
            //    resultado = num1 * num2;
            //}
            //if (operador == '/')
            //{
            //    resultado = num1 / num2;
            //}
            //if (operador != '+' && operador != '-' && operador != '*' && operador != '/')
            //{
            //    Console.WriteLine("Operador inválido!");
            //}
            //else
            //{
            //    Console.WriteLine("Resultado da operação: " + resultado);
            //}
            //Console.ReadKey();


            //exercicio 10

            //Na linguagem C#, números inteiros e reais aleatórios podem ser gerados utilizando a classe Random. O método Next é usado para gerar números inteiros aleatórios dentro de um intervalo, enquanto NextDouble é usado para gerar números reais aleatórios entre 0 e 1. Para gerar um número real aleatório dentro de um intervalo específico, basta multiplicar o número gerado pelo tamanho do intervalo desejado e somar o valor mínimo do intervalo. Lembre-se de que os números gerados são pseudorandomicos e que é recomendado usar uma única instância de Random em todo o programa.
        }
    }
}
