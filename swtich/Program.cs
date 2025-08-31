// See https://aka.ms/new-console-template for more information
Console.WriteLine("Evaluar la calificación de un estudiante");

int calificación;
Console.WriteLine("Dime tu nota: ");
calificación = Convert.ToInt32(Console.ReadLine());

string estadoAcademico;

switch (calificación)
{
    case 100:
    case 90:
    case 70:
         estadoAcademico = "Aprobo"; break;

    case 69:
    case 60:
    case 50:
         estadoAcademico = "Recuperacion"; break;

    default:
         estadoAcademico = "Reprobo"; break;
        
}

Console.WriteLine(estadoAcademico);
