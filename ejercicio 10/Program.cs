int cantidadProductos;
bool cantidadValida;

do
{
    Console.Clear();
    Console.WriteLine("=== Sistema de Compras ===");
    Console.Write("¿Cuántos productos desea ingresar?: ");

    bool esNumero = int.TryParse(Console.ReadLine(), out cantidadProductos);

    if (esNumero && cantidadProductos > 0)
    {
        cantidadValida = true;
    }
    else
    {
        cantidadValida = false;
        Console.WriteLine("Error: Debe ingresar un número entero mayor a 0.");
        Console.WriteLine("Presione cualquier tecla para intentar de nuevo...");
        Console.ReadKey();
    }

} while (!cantidadValida);

Console.Clear();
Console.WriteLine("Iniciando el ingreso de " + cantidadProductos + " productos...");

for (int i = 1; i <= cantidadProductos; i++)
{
    decimal precio;
    bool precioValido;

    do
    {
        Console.Write("Ingrese el precio del producto #" + i + ": ");
        precioValido = decimal.TryParse(Console.ReadLine(), out precio);

        if (!precioValido || precio < 0)
        {
            Console.WriteLine("Error: Precio inválido. Intente de nuevo.");
            precioValido = false;
        }
    } while (!precioValido);
}

Console.WriteLine("¡Todos los productos han sido registrados con éxito!");
Console.WriteLine("Presione cualquier tecla para salir...");
Console.ReadKey();