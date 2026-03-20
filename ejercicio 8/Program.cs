double numero;
bool esValido;

do
{
    Console.Clear();
    Console.WriteLine("=== Calculadora de Raíz Cuadrada ===");
    Console.Write("Ingrese un número positivo: ");

    bool esNumero = double.TryParse(Console.ReadLine(), out numero);

    if (esNumero && numero >= 0)
    {
        esValido = true;
    }
    else
    {
        esValido = false;
        Console.WriteLine("\nError: Debe ingresar un número válido y que no sea negativo.");
        Console.WriteLine("Presione cualquier tecla para intentar de nuevo...");
        Console.ReadKey();
    }

} while (!esValido);

double resultado = Math.Sqrt(numero);

Console.Clear();
Console.WriteLine("Número ingresado: " + numero);
Console.WriteLine("La raíz cuadrada es: " + resultado);

Console.WriteLine("\nPresione cualquier tecla para finalizar...");
Console.ReadKey();