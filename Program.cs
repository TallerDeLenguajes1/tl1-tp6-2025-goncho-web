using System;

class Program
{
    static void Main()
    {
        string num1, num2;
        int n1, n2;

        Console.WriteLine("Ingrese un número:");
        num1 = Console.ReadLine();

        Console.WriteLine("Ingrese otro número:");
        num2 = Console.ReadLine();

        int.TryParse(num1, out n1);  
        int.TryParse(num2, out n2);
        
        string eleccion;

        do
        {
            Console.WriteLine("\nIngresa qué operación deseas realizar:");
            Console.WriteLine("1 -- Suma");
            Console.WriteLine("2 -- Resta");
            Console.WriteLine("3 -- Multiplicación");
            Console.WriteLine("4 -- División");
            Console.WriteLine("5 -- Salir");
            eleccion = Console.ReadLine();

            int opcion;
            int.TryParse(eleccion, out opcion);
            
            switch (opcion)
            {
                case 1:
                    Console.WriteLine($"Resultado: {n1 + n2}");
                    break;
                case 2:
                    Console.WriteLine($"Resultado: {n1 - n2}");
                    break;
                case 3:
                    Console.WriteLine($"Resultado: {n1 * n2}");
                    break;
                case 4:
                    if (n2 != 0)
                        Console.WriteLine($"Resultado: {n1 / n2}");
                    else
                        Console.WriteLine("Error: No se puede dividir entre 0.");
                    break;
                case 5:
                    Console.WriteLine("Saliendo...");
                    break;
                default:
                    Console.WriteLine("Opción no válida.");
                    break;
            }
        } while (eleccion != "5");
    }
}