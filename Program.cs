using System.Runtime.InteropServices;
using SerieFibonacci.Class;
internal class Program
{
    private static void Main(string[] args)
    {
        Fibonacci ejercicios = new Fibonacci();
        bool run = true;
        byte opc = 0;
        while (run)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();
            Console.WriteLine("1. Entregar el n-ésimo numero");
            Console.WriteLine("2. Comprobar numero");
            Console.WriteLine("3. Entregar n numeros de fibonacci");
            Console.WriteLine("4. Salir");
            Console.Write("> ");
            try
            {
                opc = Convert.ToByte(Console.ReadLine());
                Console.Clear();

                try
                {


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
                }
                catch (OverflowException e)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"El numero de entrada o salida es demasiado grande \n Mensaje: {e.Message}");
                }
            }
            catch (FormatException e)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"Error: {e.StackTrace}\n\nMensaje: {e.Message}");
            }
            Console.ReadKey();
        }
    }
}