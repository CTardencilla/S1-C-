// See https://aka.ms/new-console-template for more information
int calificacion;
console.WriteLine("evaluar ña calificacion de un estudiante");
console.WriteLine("digite tu nota: ");
calificacion = Convert.ToInt32(console.ReadLine());

if (calificacion >= 70 && calificacion <= 100)
{
    Console.WriteLine("Aprobó");
}
else if (calificacion > 50 && calificacion < 69)
{
    Console.WriteLine("Recuperacion");
}
else if (calificacion < 50 && calificacion >= 0)
{
    Console.WriteLine("Reprobo");
}
else
{
    Console.WriteLine("Valor invalido");
}
