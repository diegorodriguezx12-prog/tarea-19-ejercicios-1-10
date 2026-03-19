int edad;
bool correcto;

do
{
    Console.Clear();
    Console.WriteLine("Ingrese su edad: ");
    bool esNumero = int.TryParse(Console.ReadLine(), out edad);

    if (esNumero && edad >= 0 && edad <= 110)
    {
        correcto = true;
    }
    else
    {
        correcto = false;
        Console.WriteLine("Dato inválido o fuera de rango (0-110).");
        Console.WriteLine("Presione cualquier tecla para intentar otra vez...");
        Console.ReadKey();
    }

} while (!correcto);

Console.Clear();
Console.WriteLine("Edad válida: " + edad);
Console.ReadKey();