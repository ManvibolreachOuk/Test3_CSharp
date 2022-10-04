using System;

namespace _301224112___Test_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string choice = "Z";
            while (choice[0] != 'X')
            {
                choice = ManvibolreachMenu();
                switch (choice)
                {
                    case "A":
                        DemoQuestion3();
                        break;
                    case "B":
                        DemoQuestion4();
                        break;
                    case "C":
                        DemoQuestion5();
                        break;
                    case "X":
                        Console.WriteLine("Exit the program");
                        break;
                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }
            }
        }
        static string ManvibolreachMenu()
        {
            Console.WriteLine("+---------------------COMP100------------------------+");
            Console.WriteLine("|           a) Working with Newton's Law             |");
            Console.WriteLine("|           b) Height Converter                      |");
            Console.WriteLine("|           c) Sine and Cosine Table                 |");
            Console.WriteLine("|                                                    |");
            Console.WriteLine("|           x) To exit the program                   |");
            Console.WriteLine("+----------------------------------------------------+");
            Console.Write("Press the letter corresponding to your choice-> ");
            string choice = Char.ToString(Console.ReadKey().KeyChar).ToUpper();
            Console.WriteLine();
            return choice;
        }
        static double CalculateGravitationalAttraction(double mass1, double mass2, double distance)
        {
            const double G = 6.673E-11;
            double force = G * mass1 * mass2 / Math.Pow(distance, 2);
            return force;
        }
        static void DemoQuestion3()
        {
            double mass1 = 5.972E24;
            double mass2 = 7.348E22;
            double distance = 384400000;
            double force = CalculateGravitationalAttraction(mass1, mass2, distance);
            Console.WriteLine("\n\n**********Begin Question 3 **********");
            Console.WriteLine($"Force is {force:E2}N");
            Console.WriteLine("\n**********End Question 3 **********\n\n");
        }
        static void HeightConversion(int height)
        {
            double meters = height / 100.0;
            Console.WriteLine($"Height in {height} (cm) Convert to meter is {meters:N2} (m).");
        }
        static void DemoQuestion4()
        {
            Console.WriteLine("\n\n**********Begin Question 4 **********");
            HeightConversion(75);
            HeightConversion(100);
            HeightConversion(290);
            Console.WriteLine("\n**********End Question 4 **********\n\n");
        }
        static void SineCosine(double angle, out double sin, out double cos)
        {
            sin = Math.Sin(angle);
            cos = Math.Cos(angle);
        }
        static void DemoQuestion5()
        {
            Console.WriteLine("\n\n**********Begin Question 5 **********");
            Console.WriteLine("Angle      Sine    Cosine");
            Console.WriteLine("-------------------------");
            for (double angle = 0.500; angle <= 0.509; angle += 0.001)
            {
                double sin, cos;
                SineCosine(angle, out sin, out cos);
                Console.WriteLine($"{angle,5:N3}    {sin,4:N4}    {cos,6:N4}");
            }
            Console.WriteLine("\n**********End Question 5 **********\n\n");
        }
    }
}
// Credited by Manvibolreach Ouk
//ID : 301224112
