using System.Numerics;

namespace SerieFibonacci.Class
{
    public class Fibonacci
    {
        public void SerieNormal()
        {
            BigInteger num_1 = 0;
            BigInteger num_2 = 1;
            for (int i = 0; i < 19; i++)
            {
                Console.WriteLine($"{num_1}");
                BigInteger aux = num_1;
                num_1 = num_1 + num_2;
                num_2 = aux;
            }
        }
        public void Ejercicio_1(int n)
        {
            BigInteger num_1 = 0;
            BigInteger num_2 = 1;
            for (int i = 0; i < n; i++)
            {
                BigInteger aux = num_1;
                num_1 = num_1 + num_2;
                num_2 = aux;
            }
            Console.WriteLine($"el numero {n} correspondiente en la serie de fibonacci es: {num_1}");
        }
        public void Ejercicio_2(int n)
        {
            BigInteger num_1 = 0;
            BigInteger num_2 = 1;
            bool verificar = true;
            bool run = true;
            while (run)
            {
                if (num_1 == n)
                {
                    break;
                }
                else if (n < num_1)
                {
                    verificar = false;
                    break;
                }
                BigInteger aux = num_1;
                num_1 = num_1 + num_2;
                num_2 = aux;
            }
            if (verificar)
            {
                Console.WriteLine($"{n} es un numero de Fibonacci");
            }
            else
            {
                Console.WriteLine($"{n} NO es un numero de Fibonacci");
            }
        }
        public void Ejercicio_3(int n)
        {
            BigInteger num_1 = 0;
            BigInteger num_2 = 1;
            Console.WriteLine($"los {n} primeros numeros de Fibonacci son:");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"{num_1}  ");
                BigInteger aux = num_1;
                num_1 = num_1 + num_2;
                num_2 = aux;
            }
        }
    }
}