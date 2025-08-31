// See https://aka.ms/new-console-template for more information
int num;
Console.WriteLine("programa para saber si un numero es positivo o negativo");
Console.WriteLine("digita un numero: ");
num = Convert.ToInt32(Console.ReadLine());
if (num == 0)
{
    Console.WriteLine("Numero neutro");
}
else if (num > 0)
{
    Console.WriteLine("Numero positivo");
}

else 
{
    Console.WriteLine("numero negativo");
}


