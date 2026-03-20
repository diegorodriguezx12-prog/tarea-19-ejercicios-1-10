int estudiantes;
bool correcto;

do
{
    Console.Clear();
    Console.WriteLine("Ingrese el número de estudiantes: ");
    bool esNumero = int.TryParse(Console.ReadLine(), out estudiantes);

    if (esNumero && estudiantes > 0)
    {
        correcto = true;
    }
    else
    {
        correcto = false;
        Console.WriteLine("Número inválido o Contiene letras.");
        Console.WriteLine("Presione cualquier tecla para intentar otra vez...");
        Console.ReadKey();
    }
} while (!correcto) ;
Console.Clear();
Console.WriteLine("Cantidad de estudiantes correcta");
Console.WriteLine("Pesione cualquier tecla para salir");
Console.ReadKey();