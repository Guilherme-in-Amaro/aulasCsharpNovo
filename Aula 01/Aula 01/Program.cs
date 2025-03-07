float numero1, numero2;

string operacao; 


Console.WriteLine("digite o primeiro numero");
numero1 = float.Parse(Console.ReadLine());

Console.WriteLine("escreva o segundo numero");
numero2 = float.Parse(Console.ReadLine());

Console.WriteLine("digite a operação");
operacao = Console.ReadLine();

if (operacao == "+")
{
    Console.WriteLine(numero1 + numero2);
}
if (operacao == "-")
{ Console.WriteLine(numero1 - numero2); 
}
if (operacao == "*")
{ Console.WriteLine(numero1 * numero2); }

if (numero2 != 0)
{ Console.WriteLine(numero1/numero2); }

    else
{ Console.WriteLine("O numero indicado nao pode ser dividido por zero"); }