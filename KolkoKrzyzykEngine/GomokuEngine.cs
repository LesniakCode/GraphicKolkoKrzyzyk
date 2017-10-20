using System;

//typ pola (kolko - circle lub krzyzyk - cross)
public enum FieldType { ftCircle = 1, ftCross = 10 };

//struktura opisujaca gracza
public struct Player
{
    // nazwa gracza
    public string Name;
    // ilosc zwyciestw
    public int Winnings;
    //reprezentujacy go symbol
    public FieldType Type;

}

class GomokuEngine
{
    //tablica 3x3 reprezentujaca pole gry
    private FieldType[,] FField = new FieldType[3, 3];
    //zmienna okreslajaca zwyciestwo ktoregos gracza (true)
    private bool FWinner;
    //ID gracza, ktory teraz wykonuje ruch
    private int FActive;
    //tablica graczy(tylko dwoch)
    private Player[] FPlayer = new Player[2];

    /*Metody prywatne*/
    private string GetPlayer1()
    {
        return FPlayer[0].Name;
    }
    private void SetPlayer1(string Name)
    {
        FPlayer[0].Name = Name;
    }
    private string GetPlayer2()
    {
        return FPlayer[1].Name;
    }
    private void SetPlayer2(string Name)
    {
        FPlayer[1].Name = Name;
    }
    private Player GetActive()
    {
        return FPlayer[this.FActive];
    }
    //wlasciwosc ile zwyciestt
    public int WinningsP1
    {
        get
        {
            return FPlayer[0].Winnings;
        }
    }
    //wlasciwosc ile zwyciestt
    public int WinningsP2
    {
        get
        {
            return FPlayer[1].Winnings;
        }
    }
    //wlasciwosc Winner
    public bool Winner
    {
        get
        {
            return FWinner;
        }
    }
    //wlasnosc zwraca aktywnego gracza
    public Player Active
    {
        get
        {
            return GetActive();
        }
    }
    // zwraca informacje o graczu nr 1
    public string Player1
    {
        get
        {
            return GetPlayer1();
        }
        set
        {
            SetPlayer1(value);
        }
    }
    //zwraca informacje o graczu nr 2
    public string Player2
    {
        get
        {
            return GetPlayer2();
        }
        set
        {
            SetPlayer2(value);
        }
    }
    //wlasciwosc tylko do odczytu, zwraca informacje o polu bitwy
    public FieldType[,] Field
    {
        get
        {
            return FField;
        }
    }
    //metoda sprawdza, czy gracz nr 1 lub 2 wygral gre
    private void Sum(int Value)
    {
        if (Value == 3 || Value == 30)
        {
            FPlayer[FActive].Winnings++;
            FWinner = true;
        }
    }
    //algorytm sprawdza, czy ktorys z graczy wygral gre
    private void CheckWinner()
    {
        for (int i = 0; i < 3; i++)
        {
            Sum((int)FField[i, 0] + (int)FField[i, 1] + (int)FField[i, 2]);
            Sum((int)FField[0, i] + (int)FField[1, i] + (int)FField[2, i]);
        }
        Sum((int)FField[0, 0] + (int)FField[1, 1] + (int)FField[2, 2]);
        Sum((int)FField[0, 2] + (int)FField[1, 1] + (int)FField[2, 0]);
    }
    //rozpoczyna wlasciwa gre
    public void Start()
    {
        //przyporzadkowanie symbolu danemu graczowi
        FPlayer[0].Type = FieldType.ftCircle;
        FPlayer[1].Type = FieldType.ftCross;

        FWinner = false;
        //czyszczenie tablicy
        System.Array.Clear(FField, 0, FField.Length);
    }
    //nowa gra - ilosc zwyciestw zostaje wyzerowana
    public void NewGame()
    {
        FPlayer[0].Winnings = 0;
        FPlayer[1].Winnings = 0;
    }
    //Metoda slyzy do ustawiania symbolu na danym polu 
    public bool Set(int X, int Y)
    {
        //poniewaz indeks tablic rozpoczyna sie od zera, nalezy 
        //zmniejszyc wartosc wspolrzednych, bo user podaje wspolrzedne
        //numerowane od 1
        --X;
        --Y;
        //sprawdzamy, czy uzytkownik podal prawidlowe wspolrzedne
        if ((X > 2) || (Y > 2) || (X < 0) || (Y < 0))
        {
            Console.WriteLine("Nieprawidlowe wartosci X lub/i Y");
            return false;
        }
        //sprawdzenie, czy pole nie jest zajete
        if (FField[X, Y] > 0)
        {
            Console.WriteLine("To pole nie jest puste");
            return false;
        }
        //ustawienie znaku na danym polu
        FField[X, Y] = GetActive().Type;
        //sprawdzenie, czy mozna zakonczyc gre
       CheckWinner();

        //jezeli nikt nie wygral - zamiana graczy
        if(!Winner)
        {
            FActive = (FActive == 0 ? 1 : 0);
        }
        return true;
    }
    //metoda sluzy do wystartowania gry
    public void Newgame()
    {

    }
    //FField[1, 1] = FieldType.ftCircle;
}
