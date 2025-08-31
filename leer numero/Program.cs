﻿Console.WriteLine("Bienvenido a Leer numero");
Console.WriteLine("Favor de ingresar una serie de numeros para determinar el mayor y el menor");
int numero, mayor = int.MinValue, menor = int.MaxValue;
Console.WriteLine("Para finalizar ingrese -99");

do
{
    Console.Write("Digite un número: ");
    numero = Convert.ToInt32(Console.ReadLine());

    if (numero != -99)
    {
        if (numero > mayor)
        {
            mayor = numero;
        }
        if (numero < menor)
        {
            menor = numero;
        }
    }
} while (numero != -99);

Console.WriteLine($"El número mayor es: {mayor} y el numero menor es: {menor}");
Console.WriteLine("Fin del programa");
