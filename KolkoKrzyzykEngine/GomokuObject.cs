using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KolkoKrzyzykEngine
{
    class GomokuObject
    {
        //instancja klasy 
        static global::GomokuEngine GomokuObj;

        //metoda wyswietlania informacji o autorze
        static void About()
        {
            Console.WriteLine(
                "   Kółko i Krzyżyk v. 1.0          \n" +
                "   Copyrigh (c) Adam Boduch 2006   \n" +
                 "   E-mail: adam@boduch.net         \n");
            Console.ReadLine();
        }

        //metoda wyswietlania menu 
        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("------- Kółko i krzyżyk ------");
            Console.WriteLine("------------------------------");
            Console.WriteLine(" 1 -- Start gry               ");
            Console.WriteLine(" 2 -- Opcje                   ");
            Console.WriteLine(" 3 -- O programie             ");
            Console.WriteLine(" 4 -- Reset gry               ");
            Console.WriteLine(" Esc -- Zakończenie           ");
            Console.WriteLine(" Gracz 1: {0} Wygranych: {1}",GomokuObj.Player1, GomokuObj.WinningsP1);
            Console.WriteLine(" Gracz 1: {0} Wygranych: {1}", GomokuObj.Player2, GomokuObj.WinningsP2);
            Console.WriteLine("------------------------------");
        }

        //glowna metoda rozpoczecie gry
        static void Start()
        {
            //inicjalizacja gry
            
            //jezeli uzytkowniknie podal imion, przekierowujemy go do metoty Option
            if (GomokuObj.Player1 == null || GomokuObj.Player2 == null)
            {
                Option();
            }

            GomokuObj.Start();
            //licznik tur
            int Counter = 1;
            Console.WriteLine();

            int X, Y;
            char C;

            //gra bedzie kontynuowana, dopoki ktos nie wygra
            //jednym z warunkow zakonczenia jest rozniez remis
            while(GomokuObj.Winner == false)
            {
                Console.WriteLine("Podaj wspolrzedna X: ");
                X = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Podaj wspolrzedna Y: ");
                Y = Convert.ToInt32(Console.ReadLine());
                //jezeli nie mozna umiescic znaku na polu, nie wykonyjemy dalszego kodu
                //przechodzimy do kolejnej iteracji
                if(!GomokuObj.Set(X,Y))
                {
                    continue;
                }

                Counter++;

                //jezeli jest to 9 ruch, widocznie jest remis - przerywamy petle
                if(Counter == 9)
                {
                    break;
                }
                // ponizsze petle maja za zadanie rysowanie pola naszej gry
                for(int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        switch(GomokuObj.Field[i,j])
                        {
                            case FieldType.ftCross:
                                C = 'X';
                                break;
                            case FieldType.ftCircle:
                                C = 'O';
                                break;
                            default:
                                C = '_';
                                break;
                        }
                        Console.Write(" {0} |", C);
                    }
                    Console.WriteLine();
                }
            }
            if(GomokuObj.Winner)
            {
                Console.WriteLine("Gratulacje, wygral gracz " + GomokuObj.Active.Name);
            }
            else
            {
                Console.WriteLine("Remis!");
            }
            Console.WriteLine("Nacisnij Enter, aby powrocic do menu");
            Console.ReadLine();
        }
        //wyswietlanie opcji do gry, czyli mozliwosci wpisania imion
        static void Option()
        {
            Console.WriteLine("Podaj imie pierwszego gracza: ");
            GomokuObj.Player1 = Console.ReadLine();

            Console.WriteLine("Podaj imie drugiego gracza: ");
            GomokuObj.Player2 = Console.ReadLine();
        }

        static void Main(string[] args)
        {
            GomokuObj = new global::GomokuEngine();

            ConsoleKeyInfo Key;

            do
            {
                Menu();
                Key = Console.ReadKey();

                switch (Key.KeyChar)
                {
                    case '1':
                        Start();
                        break;

                    case '2':
                        Option();
                        break;

                    case '3':
                        About();
                        break;

                    case '4':
                        GomokuObj.NewGame();
                        break;
                }
            } while (Key.Key != ConsoleKey.Escape);
        }
    }
}
