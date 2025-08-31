// See https://aka.ms/new-console-template for more information
int i, sumapar = 0, sumaim = 0;
for (i = 1; i <= 200; i++)
{
    if (i % 2 == 0)

    {
        sumapar = sumapar + i;
    }
    else
    {
        sumaim = sumaim + i;
    }

}
Console.WriteLine($"La suma de los pares es :{sumapar}");
Console.WriteLine($"La suma de los impares es :{sumaim}");