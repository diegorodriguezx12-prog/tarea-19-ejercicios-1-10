double nota;
bool correcto;

do
{
    Console.Clear();
    Console.WriteLine("=== Sistema de Registro de Notas ===");
    Console.Write("Ingrese la nota final (0 - 100): ");

    bool esNumero = double.TryParse(Console.ReadLine(), out nota);

    if (esNumero && nota >= 0 && nota <= 100)
    {
        correcto = true;
    }
    else
    {
        correcto = false;
        Console.WriteLine("Error: Ingrese una nota válida entre 0 y 100.");
        Console.WriteLine("Presione cualquier tecla para intentar de nuevo...");
        Console.ReadKey();
    }

} while (!correcto);

Console.Clear();
Console.WriteLine("Nota registrada: " + nota);

if (nota >= 61)
{
    Console.WriteLine("Resultado: ¡APROBADO!");
}
else
{
    Console.WriteLine("Resultado: REPROBADO");
}

Console.WriteLine("Presione cualquier tecla para salir...");
Console.ReadKey();