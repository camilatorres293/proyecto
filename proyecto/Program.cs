using System;

class Program
{
    static void Main(string[] args)
    {
        bool salir = false;
        while (!salir)
        {
            Console.Clear();
            Console.WriteLine("=== Sistema de Ventas ===");
            Console.WriteLine("1. Categoría A");
            Console.WriteLine("2. Categoría B");
            Console.WriteLine("3. Salir");
            Console.Write("Seleccione una opción: ");
            string opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    MenuCategoriaA();
                    break;
                case "2":
                    MenuCategoriaB();
                    break;
                case "3":
                    salir = true;
                    break;
                default:
                    Console.WriteLine("Opción no válida, intente de nuevo.");
                    break;
            }
        }
    }

    static void MenuCategoriaA()
    {
        Console.Clear();
        Console.WriteLine("=== Categoría A ===");
        Console.WriteLine("1. Producto A1 - $10.00");
        Console.WriteLine("2. Producto A2 - $20.00");
        Console.WriteLine("3. Regresar al menú principal");
        Console.Write("Seleccione un producto: ");
        string opcion = Console.ReadLine();

        switch (opcion)
        {
            case "1":
                CalcularPrecio(10.00, "Producto A1");
                break;
            case "2":
                CalcularPrecio(20.00, "Producto A2");
                break;
            case "3":
                return;
            default:
                Console.WriteLine("Opción no válida, intente de nuevo.");
                break;
        }
    }

    static void MenuCategoriaB()
    {
        Console.Clear();
        Console.WriteLine("=== Categoría B ===");
        Console.WriteLine("1. Producto B1 - $15.00");
        Console.WriteLine("2. Producto B2 - $25.00");
        Console.WriteLine("3. Regresar al menú principal");
        Console.Write("Seleccione un producto: ");
        string opcion = Console.ReadLine();

        switch (opcion)
        {
            case "1":
                CalcularPrecio(15.00, "Producto B1");
                break;
            case "2":
                CalcularPrecio(25.00, "Producto B2");
                break;
            case "3":
                return;
            default:
                Console.WriteLine("Opción no válida, intente de nuevo.");
                break;
        }
    }

    static void CalcularPrecio(double precioBase, string nombreProducto)
    {
        Console.Write("Ingrese la cantidad (máximo 100): ");
        int cantidad = int.Parse(Console.ReadLine());
        if (cantidad > 100)
        {
            Console.WriteLine("Cantidad no válida. Máximo 100 productos.");
            return;
        }

        double impuesto = 0.0;
        if (nombreProducto.Contains("A"))
        {
            impuesto = precioBase * 0.10; // Impuesto para productos de Categoría A
        }
        else if (nombreProducto.Contains("B"))
        {
            impuesto = precioBase * 0.15; // Impuesto para productos de Categoría B
        }

        double precioTotal = (precioBase + impuesto) * cantidad;
        Console.WriteLine($"El precio total para {cantidad} unidades de {nombreProducto} es: ${precioTotal:F2}");
        Console.Write("¿Desea seguir comprando? (s/n): ");
        string seguirComprando = Console.ReadLine();
        if (seguirComprando.ToLower() == "s")
        {
            return; // Regresa al menú de categorías
        }
        else
        {
            Environment.Exit(0); // Finaliza el programa
        }
    }
}
