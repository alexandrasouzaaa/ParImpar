int numero;

Console.WriteLine();

Console.Write("Digite um número: ");
numero = Convert.ToInt32(Console.ReadLine());

if (numero % 2 == 0)
{ 
    Console.WriteLine($"O número {numero} é par!");
}
else
{
        Console.WriteLine($"O número {numero} é ímpar!");
}

Console.WriteLine();