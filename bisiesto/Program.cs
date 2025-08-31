// See https://aka.ms/new-console-template for more information
int Dias;
Console.WriteLine("Identificar año bisiesto");
Console.WriteLine("Ingrese cuantos dias tiene el año elegido: ");
Dias = Convert.ToInt32(Console.ReadLine());

if (Dias > 365 && Dias < 367) 
{
    Console.WriteLine("Es un año bisiesto");
}
else if (Dias == 365) 
{
    Console.WriteLine("Es un año normal");
}
else
{
    Console.WriteLine("Valor no valido");
}
