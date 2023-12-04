using System.Runtime.InteropServices;
using SerieFibonacci.entities;

internal class Program
{
    private static void Main(string[] args)
    {
        Fibonacci ejercicios = new Fibonacci();
        // var result = "";
        bool run = true;
        while (run)
        {
            Console.Clear();
            Console.WriteLine("1. Entregar el n-ésimo numero");
            Console.WriteLine("2. Comprobar numero");
            Console.WriteLine("3. Entregar n numeros de fibonacci");
            Console.WriteLine("4. Salir");
            Console.Write("> ");
            byte opc = Convert.ToByte(Console.ReadLine());
            Console.Clear();
            switch (opc)
            {
                case 1:
                    Console.WriteLine($"Digite el numero de entrada para la serie de fibonacci: ");
                    Console.Write("> ");
                    ejercicios.Ejercicio_1(Convert.ToInt32(Console.ReadLine()));
                    break;
                case 2:
                    Console.WriteLine($"Digite el numero a comprobar en la serie de fibonacci: ");
                    Console.Write("> ");
                    ejercicios.Ejercicio_2(Convert.ToInt32(Console.ReadLine()));
                    break;
                case 3:
                    Console.WriteLine($"Digite la cantidad de numeros que desea recibir de la serie de fibonacci: ");
                    Console.Write("> ");
                    ejercicios.Ejercicio_3(Convert.ToInt32(Console.ReadLine()));
                    break;
                default:
                    run = false;
                    break;
            }
            Console.ReadKey();
        }
    }
}