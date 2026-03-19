double precio;
bool correcto;

do
{
    Console.Clear();
        Console.WriteLine("Ingrese el precio del producto: ");
    bool esNumero= double.TryParse(Console.ReadLine(), out precio);

    if (precio > 0 && esNumero)
    {
        correcto = true;
    }
    else
    {
        correcto = false;   
        Console.WriteLine("Precio inválido o fuera de rango.");
        Console.WriteLine("Presione cualquier tecla para intentar otra vez...");
    Console.ReadKey();
    }
}while (!correcto);
Console.Clear();
Console.WriteLine("Precio válido: Q" + precio);
Console.ReadKey();