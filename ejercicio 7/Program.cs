decimal salario;
bool correcto;

do
{
    Console.Clear();
    Console.WriteLine("=== Registro de Salarios ===");
    Console.Write("Ingrese el salario del empleado (ejemplo: 3500.50): ");

    bool esDecimal = decimal.TryParse(Console.ReadLine(), out salario);

    if (esDecimal && salario >= 0)
    {
        correcto = true;
    }
    else
    {
        correcto = false;
        Console.WriteLine("Error: Ingrese un monto decimal válido y mayor o igual a 0.");
        Console.WriteLine("Presione cualquier tecla para intentar de nuevo...");
        Console.ReadKey();
    }

} while (!correcto);

Console.Clear();
Console.WriteLine("Salario registrado exitosamente.");
Console.WriteLine("Monto: Q" + salario);

Console.WriteLine("Presione cualquier tecla para salir...");
Console.ReadKey();