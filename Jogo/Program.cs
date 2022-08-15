using System;

namespace Jogo
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculo calculadorHoraMinuto = new Calculo();


            Console.WriteLine("Entre com hora inicio: ");
            calculadorHoraMinuto.HoraInicio = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com minuto inicio: ");
            calculadorHoraMinuto.MinutoInicio = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com hora final: ");
            calculadorHoraMinuto.HoraFim = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com minuto final: ");
            calculadorHoraMinuto.MinutoFim = int.Parse(Console.ReadLine());



            
            Console.WriteLine(calculadorHoraMinuto.Imprimir());
        }
    }
}
