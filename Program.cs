using Calculadora;
using System;

Console.WriteLine("Qual operação deseja realizar? ");
Console.WriteLine("Soma - 1 ");
Console.WriteLine("Subtração - 2 ");
Console.WriteLine("Multiplicação - 3 ");
Console.WriteLine("Divisão - 4 ");
int operacao = int.Parse(Console.ReadLine());

Console.WriteLine("Digite o primeiro número: ");
int num1 = int.Parse(Console.ReadLine());
Console.WriteLine("Digite o segundo número: ");
int num2 = int.Parse(Console.ReadLine());

Calcular c = new Calcular();
c.setN1(num1);
c.setN2(num2);

int soma = c.somar();
int subtracao = c.subtrair();
int multiplicacao = c.multiplicar();
double divisao = c.dividir();

int numero1 = c.getN1();
int numero2 = c.getN2();

switch (operacao)
{
    case 1:
        Console.WriteLine("O resultado da soma entre " + numero1 + " e " + numero2 + " é: " + soma);
        break;
    case 2:
        Console.WriteLine("O resultado da subtração entre " + numero1 + " e " + numero2 + " é: " + subtracao);
        break;
    case 3:
        Console.WriteLine("O resultado da subtração entre " + numero1 + " e " + numero2 + " é: " + multiplicacao);
        break;
    case 4:
        Console.WriteLine("O resultado da subtração entre " + numero1 + " e " + numero2 + " é: " + divisao);
        break;
    default:
        Console.WriteLine("Operação Invalida");
        break;
}
Console.ReadKey();