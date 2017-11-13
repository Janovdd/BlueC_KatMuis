using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // we hebben een muis nodig
            Muis jerry = new Muis();

            // we hebben ook een kat nodig
            Kat tom = new Kat();

            // de kat moet de muis opeten
            tom.Vang(jerry);

            // dode muis laten zien
            Console.WriteLine(jerry);
            Console.WriteLine(tom);

            Console.Read();
        }
    }
}
