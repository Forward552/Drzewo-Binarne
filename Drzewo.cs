using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Algorytmy_i_struktury_danych_Lab
{
    class Drzewo
    {

        public static int iPre = 0;
        public static int iIn = 0;
        public static int iPos = 0;
        public static int lisci = 0;
        public Wezel korzen;
        public Drzewo()
        {
            korzen = null;
        }
        public void add(int nowaWartość)
        {
            Wezel nowyWezel = new Wezel(nowaWartość);

            if (korzen != null)
            {
                Wezel tmp = korzen;

                while (true)
                {
                    if (nowaWartość <= tmp.wartosc)
                    {
                        if (tmp.lewy != null)
                            tmp = tmp.lewy;

                        else 
                        {
                            tmp.lewy = nowyWezel;
                            lisci++;
                            break;
                        }
                    }
                    else if (nowaWartość > tmp.wartosc)
                    {
                        if (tmp.prawy != null)
                            tmp = tmp.prawy;
                        else
                        {
                            tmp.prawy = nowyWezel;
                            lisci++;
                            break;
                        }
                    }
                }
            }
            else
            {
                this.korzen = nowyWezel;
                lisci++;
            }
        }
        public void wypiszInOrder(Wezel korzen)
        {
            Wezel tmp;
            tmp = korzen;
            if (tmp == null) return;
            wypiszInOrder(tmp.lewy);
            if (iIn == 0) Console.Write($"\nDrzewo wypisane metodą In-Order:   {tmp.wartosc}");
            else Console.Write(", " + tmp.wartosc);
            iIn++;
            wypiszInOrder(tmp.prawy);
        }
        public void wypiszPreOrder(Wezel korzen)
        {
            //Wezel tmp;
            //tmp = korzen;
            if (korzen == null) return;
            if (iPre == 0) Console.Write($"\nDrzewo wypisane metodą Pre-Order:  {korzen.wartosc}");
            else Console.Write(", " + korzen.wartosc);
            iPre++;
            wypiszPreOrder(korzen.lewy);
            wypiszPreOrder(korzen.prawy);
        }
        public void wypiszPosOrder(Wezel korzen)
        {
            Wezel tmp;
            tmp = korzen;
            if (tmp == null) return;
            wypiszPosOrder(tmp.lewy);
            wypiszPosOrder(tmp.prawy);
            if (iPos == 0) Console.Write($"\nDrzewo wypisane metodą Post-Order: {tmp.wartosc}");
            else Console.Write(", " + tmp.wartosc);
            
            iPos++;
        }
        public void Sprawdz(Wezel korzen, int test)
        {
            Program.istniejeint = test;
            if (korzen == null) return;
            if (korzen.wartosc == test) Program.istnieje = true;
            Sprawdz(korzen.lewy,test);
            Sprawdz(korzen.prawy,test);
        }
    }
    class Wezel
    {
        public int wartosc;
        public Wezel lewy;
        public Wezel prawy;
        public Wezel(int wartosc) //konstruktor
        {
            this.wartosc = wartosc;
            //Console.WriteLine($"Wartość w drzewie {Drzewo.lisci+1}");
            lewy = null;
            prawy = null;
        }
    }
}
