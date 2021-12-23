using System;
using station;

namespace nachalo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите площадь района обслуживания: ");
            double po = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите площадь покрытия базовой станции");
            double pbz = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите коэффицент застройки:");
            double kz = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите радиус первой базовой станции: ");
            double r1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите радиус второй базовой станции: ");
            double r2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите радиус третей базовой станции: ");
            double r3 = Convert.ToDouble(Console.ReadLine());
            if (kz == 0)
            {
                Console.WriteLine("Ошибка, коэффицент должен быть не равен 0");
            }
            Station nachalo = new Station();
            int Result = nachalo.name(r1, r2, r3, po, pbz, kz);
        }
    }

}
