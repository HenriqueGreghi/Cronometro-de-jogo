using System;

namespace Jogo
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculo h = new Calculo();


            Console.WriteLine("Entre com hora inicio: ");
            h.HoraInicio = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com minuto inicio: ");
            h.MinutoInicio = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com hora final: ");
            h.HoraFim = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com minuto final: ");
            h.MinutoFim = int.Parse(Console.ReadLine());
            Console.WriteLine(h);
        }
    }
}
