double n1 = 0;
double n2 = 0;
double n3 = 0;

Console.Write("Digite o primeiro valor: ");
n1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Digite o segundo valor: ");
n2 = Convert.ToDouble(Console.ReadLine());

Console.Write("Digite o terceiro valor: ");
n3 = Convert.ToDouble(Console.ReadLine());


if (n1 > n2 && n1 > n3)
{
    Console.WriteLine(n1);
}

else if (n2 > n1 && n2 > n3)
{
    Console.WriteLine(n2);
}

else 
{
    Console.WriteLine(n3);
}