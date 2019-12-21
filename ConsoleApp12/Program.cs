using System;

namespace ConsoleApp12
{
    class Program
    {
        static void Main(string[] args)
        {
            string we;
            int znak, star, hasz = 0;
            Console.WriteLine("Podaj liczbe znakow do wyswietlenia");
            we = Console.ReadLine();
            znak = sprawdz(we);
            x:
            Console.WriteLine("Podaj liczbe *:");
            we = Console.ReadLine();
            star = sprawdz(we);
            if(star>znak)
            {
                Console.WriteLine("Podaj liczbe z zakresu <1,{0}>",znak);
                goto x;
            }
            y:
            Console.WriteLine("Podaj liczbe #:");
            we = Console.ReadLine();
            hasz = sprawdz(we);
            if(hasz>znak)
            {
                Console.WriteLine("Podaj liczbe z zakresu <1,{0}>", znak);
                goto y;
            }
            if(hasz+star>znak)
            {
                Console.WriteLine("Liczba mozliwych znakow do wykorzystania to {0}",znak-star);
                goto y;
            }
            for(int i = 0; i < hasz; i++)
            {
                Console.Write("#");
            }
            for (int i = 0; i < star; i++)
            {
                Console.Write("*");
            }
            if(hasz+star<znak)
            {
                for(int i = hasz+star; i<=znak; i++)
                {
                    Console.Write("#");
                }
            }
            Console.ReadKey();
        }
        static int sprawdz(string a)
        {
            int wynik = 0;
            while(true)
            {      
                try
                {
                    wynik = int.Parse(a);
                    if (wynik > 0 && wynik <= 2147483647) return wynik;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Wprowadzono liczbę w złym formacie");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Liczba przekroczyła zakres dla typu int ");
                }
                catch (ArgumentNullException)
                {
                    Console.WriteLine("Napotkano koniec strumienia");
                }
                Console.WriteLine("Wprowadz wartosc jeszcze raz");
                a = Console.ReadLine();
            }
        }
    }
     /*
        liczba = readInt("\n Podaj liczbe znakow do wyswietlenia: ",1)
        lg = readInt("Podaj liczbe *: ",1, liczba);
        lc = readInt("Podaj liczbe #: ",0,liczba - lg);   
     */
}
