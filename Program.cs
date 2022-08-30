using Microsoft.VisualBasic;
using System;

namespace Algorytmy_i_struktury_danych_Lab
{
    class Program
    {
        public static int wartoscPobrana, istniejeint, tes;
        public static bool istnieje = false;
        static void Main(string[] args)
        {
            tes = 1;
            Drzewo d = new Drzewo();
            Console.WriteLine(" (Wprowadzająć wartość 890098 wprowadzi się wartości z przykładu z zajęć na moodle): ");
            Console.Write("Wprowadz korzeń do drzewa: ");
            wartoscPobrana = int.Parse(Console.ReadLine());
            if (wartoscPobrana == 890098)
            {
                d.add(53);
                d.add(28);
                d.add(20);
                d.add(19);
                d.add(21);
                d.add(34);
                d.add(32);
                d.add(38);
                d.add(42);
                d.add(76);
                d.add(71);
                d.add(73);
                d.add(86);
                tes = 0;
            }
            while (true)
            {
                if (wartoscPobrana == 0 || tes == 0)
                {
                    Console.Clear();
                    Console.WriteLine("Zakończono wprowadzanie drzewa.\n");
                    break;
                }
                else
                {
                    Console.Write("Wprowadz liść do drzewa: ");
                    d.add(wartoscPobrana);
                }
                wartoscPobrana = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Wypisanie drzewa metodami:");
            d.wypiszPreOrder(d.korzen);
            d.wypiszInOrder(d.korzen);
            d.wypiszPosOrder(d.korzen);
            Console.WriteLine($"\nWprowadzono {Drzewo.lisci} wartości.\n");
            while (true) { 
            Console.Write("\npodaj liczbę jaką chcesz sprawdzić czy znajduje się w drzewie: ");
                Sprawdz(d, int.Parse(Console.ReadLine()));
            }
            //Console.ReadKey();
        }

        private static void Sprawdz(Drzewo d,int test)
        {
            d.Sprawdz(d.korzen, test);
            if (istnieje == true)
            {
                Console.Write($"\nWartość: {istniejeint}. Istnieje w drzewie\n");
                istnieje = false;
            }
            else Console.Write($"\nWartość {istniejeint}. Nie istnieje w drzewie\n");
        }
    }  
}