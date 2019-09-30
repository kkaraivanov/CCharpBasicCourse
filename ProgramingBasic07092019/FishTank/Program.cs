using System;

namespace FishTank
{
    class Program
    {
        static void Main(string[] args)
        {
            // дължина, широчина и височина в сантиметри
            double lenghtAqwarium = double.Parse(Console.ReadLine());
            double widthAqwarium = double.Parse(Console.ReadLine());
            double heighAqwarium = double.Parse(Console.ReadLine());
            // процент заето място от пясък и разтения
            double readProtsent = double.Parse(Console.ReadLine());

            double volumeAqwarium = lenghtAqwarium * widthAqwarium * heighAqwarium;
            readProtsent = volumeAqwarium *(readProtsent / 100);
            volumeAqwarium -= readProtsent;
            double volumeInLiter = 0.001;

            double needLiterWater = volumeAqwarium * volumeInLiter; // необходимите литри вода за напълване

            Console.WriteLine(needLiterWater.ToString("0.000"));
        }
    }
}
