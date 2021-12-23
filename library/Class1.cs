using System;
namespace station
{
    public class Station
    {
        public int name(double rad1, double rad2, double rad3, double ploshad_pbz, double ploshad_r, double koef)
        {

            if (ploshad_r > 0 & ploshad_pbz > 0 & koef > 0.47 & rad1 > 0 & rad2 > 0 & rad3 > 0)
            {
                double R = Math.Sqrt(ploshad_pbz / Math.PI);
                double R0 = Math.Sqrt(ploshad_r / Math.PI); 
                double C = Math.Pow(rad1 * 2, 2.5) + Math.Pow(rad2 * 2, 1.5) + Math.Pow(rad3 * 2, 0.5);
                double L = koef * Math.Pow(R0 / R, 2); 
                int N = Convert.ToInt32(L / C);
                Console.WriteLine("Кол-во базовых станций: ");
                Console.WriteLine(N);
                return N;
            }
            return 10;
        }
    }
}