int numero;
bool correcto;

do
{
    Console.Clear();
    Console.WriteLine("=== Detector de Par o Impar ===");
    Console.Write("Ingrese un número entero: ");

    correcto = int.TryParse(Console.ReadLine(), out numero);

    if (!correcto)
    {
        Console.WriteLine("\nError: Debe ingresar un número entero (sin letras ni decimales).");
        Console.WriteLine("Presione cualquier tecla para intentar de nuevo...");
        Console.ReadKey();
    }

} while (!correcto);

if (numero % 2 == 0)
{
    Console.WriteLine("\nEl número " + numero + " es PAR.");
}
else
{
    Console.WriteLine("\nEl número " + numero + " es IMPAR.");
}

Console.WriteLine("\nPresione cualquier tecla para salir...");
Console.ReadKey();