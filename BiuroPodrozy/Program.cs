using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiuroPodrozy
{
    class Program
    {
        static void Main(string[] args)
        {
            string wybor;
            Podroz podroz = new Podroz();
            podroz.stworzPlan();


            Console.WriteLine("Zaplanuj swoja podroz!\n[A] - dodaj autobus\n[P] - dodaj samolot");
            Console.WriteLine("[U] - usun ostatnia pozycje z planu podrozy\n[Z] - pokaz plan podrozy\n[D] - sprawdz date podrozy");
            Console.WriteLine("[E] - Wyjdz");
            wybor = Console.ReadLine();
            while(wybor!="E")
            {
                switch(wybor)
                {
                    case "A": 
                        {
                            Console.WriteLine("\nDodawanie autobusu\nPodaj ilosc miejsc: ");
                            int miejsca=0;
                            miejsca= Console.Read();
                            podroz.DodajAutobus(miejsca);
                            Console.WriteLine("\nDodano autobus!");
                            break;
                        }
                    case "P":
                        {
                            Console.WriteLine("\nDodawanie samolotu\nPodaj ilosc miejsc: ");
                            int miejsca=0;
                            int odleglosc=0;
                            miejsca= Console.Read();
                            Console.WriteLine("Podaj odleglosc: ");
                            odleglosc = Console.Read();
                            podroz.DodajSamolot(miejsca,odleglosc);
                            Console.WriteLine("\nDodano samolot!");
                            break;
                        }
                    case "U":
                        {
                            podroz.UsunOstatni();
                            Console.WriteLine("Usunieto ostatnia pozycje");
                            break;
                        }
                    case "Z":
                        {
                            Console.WriteLine("Plan podrozy:");
                           Console.WriteLine(podroz.ToString());
                            break;
                        }
                    case "D":
                        {
                            Console.WriteLine("data podrozy to: ");
                            if (podroz.SprawdzDate() == true) Console.WriteLine("Data jest poprawna"); else Console.WriteLine("Data jest bledna");
                            break;
                        }
                    case "T" :
                        {
                            Console.WriteLine("Ustaw date: podaj yyyy/mm/dd");
                            
                            
                            break;
                        }
                    
                    
                    default:
                        {
                            Console.WriteLine("Brak wybranej opcji");
                            break;
                        }
                }



                wybor = Console.ReadLine();


            }

            Console.ReadKey();
        }
    }
}
