int anioNacimiento;
bool correcto;

do
{
    Console.Clear();
    Console.WriteLine("Ingrese su año de nacimiento (1900 - 2026): ");

    bool esNumero = int.TryParse(Console.ReadLine(), out anioNacimiento);

    if (esNumero && anioNacimiento >= 1900 && anioNacimiento <= 2026)
    {
        correcto = true;
    }
    else
    {
        correcto = false;
        Console.WriteLine("Error: El año debe ser un número entre 1900 y 2026.");
        Console.WriteLine("Presione cualquier tecla para intentar otra vez...");
        Console.ReadKey();
    }

} while (!correcto);

Console.Clear();
Console.WriteLine("Año de nacimiento registrado: " + anioNacimiento);

int edadCalculada = 2026 - anioNacimiento;
Console.WriteLine("Su edad aproximada es: " + edadCalculada + " años.");

Console.WriteLine("Presione cualquier tecla para salir...");
Console.ReadKey();