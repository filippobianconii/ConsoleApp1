using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vett = new int[10] { 10, 11, 12, 13, 14, 15, 16, 17, 18, 19 };

            Ordina(vett);
            int mi = Minimo(vett);
            Console.WriteLine("il valore m inimo è;" + mi);

        }

        static void Ordina(int [] vett)
        {
            Array.Sort(vett);
        }

        static int Minimo(int[] vett)
        {
            return vett[0];
        }
    }
}
