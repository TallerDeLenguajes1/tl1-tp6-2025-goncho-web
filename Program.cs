using System;

class Program
{
    static void Main()
    {
        string num1;
        float n1;
        string num2;
        float n2;
        Console.WriteLine("Ingrese un número:");
        num1 = Console.ReadLine();
        float.TryParse(num1, out n1); 
        
        
        string eleccion;

        do
        {
            Console.WriteLine("\nIngresa qué operación deseas realizar:");
            Console.WriteLine("1 -- Valor absoluto");
            Console.WriteLine("2 -- Cuadrado");
            Console.WriteLine("3 -- Raiz Cuadrada");
            Console.WriteLine("4 -- Seno");
            Console.WriteLine("5 -- Coseno");
            Console.WriteLine("6 -- Parte entera");
            Console.WriteLine("7 -- Comparar Maximo");
            Console.WriteLine("8 -- Comparar Minimo");
            Console.WriteLine("9 -- Salir");
            eleccion = Console.ReadLine();

            int opcion;
            int.TryParse(eleccion, out opcion);
        
             switch (opcion)
            {
                case 1:
                    Console.WriteLine($"Resultado: {Math.Abs(n1)}");
                    break;
                case 2:
                    Console.WriteLine($"Resultado: {Math.Pow(n1, 2)}");
                    break;
                case 3:
                    if (n1 >= 0)
                        Console.WriteLine($"Resultado: {Math.Sqrt(n1)}");
                    else
                        Console.WriteLine("Error: No se puede sacar raíz cuadrada de un número negativo.");
                    break;
                case 4:
                    Console.WriteLine($"Resultado (seno en radianes): {Math.Sin(n1)}");
                    break;
                case 5:
                    Console.WriteLine($"Resultado (coseno en radianes): {Math.Cos(n1)}");
                    break;
                case 6:
                    Console.WriteLine($"Resultado (parte entera): {Math.Floor(n1)}");
                    break;
                case 7:
                    Console.WriteLine("Ingrese otro número:");
                    num2 = Console.ReadLine();

                    float.TryParse(num2, out n2);

                    float max = Math.Max(n1,n2);
                    
                    Console.WriteLine($"El número mayor es: {max}");
                    break;
                case 8:
                    Console.WriteLine("Ingrese otro número:");
                    num2 = Console.ReadLine();

                    float.TryParse(num2, out n2);

                    float min = Math.Min(n1,n2);
                    Console.WriteLine($"El menor es: {min}");
                    break;
                case 9:
                     Console.WriteLine("Saliendo...");
                    break;    
                default:
                    Console.WriteLine("Opción no válida.");
                    break;
            }
        } while (eleccion != "9");
    }
}

