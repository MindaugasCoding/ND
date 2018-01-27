using System;
using System.Linq;
namespace ND_5_uzduotis
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Prekių sąrašas:");
            Console.WriteLine("1. Kefyras ");
            Console.WriteLine("2. Daktaro dešra ");
            Console.WriteLine("3. Kaimiškas batonas ");
            Console.WriteLine("4. Alus bealkoholinis ");
            Console.WriteLine("5. Premjero kava ");
            Console.WriteLine("6. Mineralinis vanduo ");
            Console.WriteLine("7. Viščiukas broileris ");
            int pirkiniai;
            double k1 = 2.33;
            double k2 = 0.99;
            double k3 = 2.50;
            double k4 = 1.99;
            double k5 = 9.50;
            double k6 = 1.30;
            double k7 = 5.72;
            double suma = 0;
            do
            {
                Console.WriteLine("Pasirinkite prekes iš sąrašo nurodydami prekės eilės numerį. Kai baigsite pasirinkimą paspauskite 0");
                pirkiniai = Convert.ToInt32(Console.ReadLine());
                switch (pirkiniai)
                {
                    case 0:
                        Console.WriteLine("Jūsų pirkinių suma: " + suma);
                        break;
                    case 1:
                        Console.WriteLine("Kefyras " + k1);
                        break;
                    case 2:
                        Console.WriteLine("Daktaro dešra " + k2);
                        break;
                    case 3:
                        Console.WriteLine("Kaimiškas batonas " + k3);
                        break;
                    case 4:
                        Console.WriteLine("Alus bealkoholinis " + k4);
                        break;
                    case 5:
                        Console.WriteLine("Premjero kava " + k5);
                        break;
                    case 6:
                        Console.WriteLine("Mineralinis vanduo " + k6);
                        break;
                    case 7:
                        Console.WriteLine("Viščiukas broileris " + k7);
                        break;
                    default:
                        Console.WriteLine("Neteisingai įvesta prekė");
                        break;
                }
                if (pirkiniai == 1)
                {
                    suma += k1;
                }
                else if (pirkiniai == 2)
                {
                    suma += k2;
                }
                else if (pirkiniai == 3)
                {
                    suma += k3;
                }
                else if (pirkiniai == 4)
                {
                    suma += k4;
                }
                else if (pirkiniai == 5)
                {
                    suma += k5;
                }
                else if (pirkiniai == 6)
                {
                    suma += k6;
                }
                else if (pirkiniai == 7)
                {
                    suma += k7;
                }
            } while (pirkiniai != 0);
            Console.ReadLine();
        }
    }
}
