using System;

namespace billetes
{
    class Program
    {
        static void Main(string[] args)
        {
            int repeat = 0;
            do
            {
                try
                {
                    Console.WriteLine("Billetes de 100: ");
                    int billetes100 = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("Billetes de 50: ");
                    int billetes50 = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("Billetes de 20: ");
                    int billetes20 = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("Billetes de 10: ");
                    int billetes10 = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("Billetes de 5: ");
                    int billetes5 = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("Billetes de 1: ");
                    int billetes1 = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("Valor del artículo a comprar: ");
                    float article = Single.Parse(Console.ReadLine());
                    float total = (billetes100*100) + (billetes50*50) + (billetes20*10) + (billetes10*10) + (billetes5*5) + billetes1;
                    if (total >= article)
                    {
                        Console.WriteLine("Dinero suficiente para realizar la compra, su cambio es: " + (total-article) + " dólares");
                    } else
                    {
                        Console.WriteLine("Dinero insuficiente para realizar la compra, le faltan: " + (article-total) + " dólares");
                    }
                }
                catch (System.Exception)
                {
                    repeat = 1;
                    Console.WriteLine("Ingreso no válido, intente nuevamente");
                }
            } while (repeat == 1);
        }
    }
}
