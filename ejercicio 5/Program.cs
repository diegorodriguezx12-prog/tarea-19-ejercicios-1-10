DateTime fechaIngresada;
bool esValido;

do
{
    Console.Clear();
    Console.WriteLine("=== Validador de Fechas ===");
    Console.Write("Ingrese una fecha (día/mes/año): ");
    string entrada = Console.ReadLine();

    esValido = DateTime.TryParse(entrada, out fechaIngresada);

    if (!esValido)
    {
        Console.WriteLine("\nError: La fecha no es válida o el formato es incorrecto.");
        Console.WriteLine("Asegúrese de usar el formato DD/MM/AAAA.");
        Console.WriteLine("Presione cualquier tecla para intentar de nuevo...");
        Console.ReadKey();
    }

} while (!esValido);

Console.Clear();
Console.WriteLine("¡Fecha correcta!");

Console.WriteLine("La fecha ingresada es: " + fechaIngresada.ToShortDateString());

Console.WriteLine("\nPresione cualquier tecla para finalizar...");
Console.ReadKey();