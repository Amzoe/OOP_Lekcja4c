/* 
 * losujemy do pojemników 9.000.000 kulek (obiektów): 
 * Czerwone małe 1 (gram)
 * Czerwone duże 2 (gramy)
 * Białe małe 1 (gram)
 * Białe duże 2 (gramy)
 * Każda 100.000 (stu tysięczna) kula w pojemniku wyświetla komunikat "np. Jest nas już X tysięcy - Czerwone duże"
 * Ile ważą wszystkie wylosowane kule?
 * Menu: 1. Wyczyść ekran / 2. Losuj / 3. Zakończ
 */

class Game_01
{


    static void Main(string[] args)
    {
        Menu();
    }

    static void MakeBoxes()
    {
        string[] Names = { "CD", "CM", "BD", "BM" };
        for (int i = 0; i < 4; i++)
        {
            Box box = new Box(Names[i]);
        }

    }

    static void DropToBox()
    {
        for (int i = 0;i < 9000000;i++)
        {
            for (int j = 0;j <4;j++)
                switch (i)
                {
                    case 0: break; //zwieksz ilość kul w pudełku CD  
                    case 1: break; //zwieksz ilość kul w pudełku CM
                    case 2: break; //zwieksz ilość kul w pudełku BD
                    case 3: break; //zwieksz ilość kul w pudełku CM  
                }
        }
    }

    static void Menu()
    {
        Console.WriteLine("1. Wyczyść ekran. Pokaż menu.");
        Console.WriteLine("2. Losuj kule");
        Console.WriteLine("3. Zakończ grę");
        int Choice = Convert.ToInt32(Console.ReadLine());
        switch (Choice)
        {
            case 1: Console.Clear();  Menu(); break; 
            case 2: MakeBoxes(); DropToBox(); break;
            default: Console.WriteLine("Dziękuję za grę... "); Console.ReadKey(); break;
        }
    }

    public class Ball
    {
        string Color;
        int Weight;

        public void MakeBall(string color, int weight)
        {
            Color = color;
            Weight = weight;
        }

    }

    public class Box
    {
        int InsideBox = 0;
        string NameBox;
        public Box(string nameBox)
        {
            NameBox = nameBox;
            Console.WriteLine("Utworzono puste pudełko: " + NameBox);
        }
        public void AddBall()
        {
            InsideBox++;
        }
        public int HowMany()
        { 
            //zwraca informację ile danych kulek jest w pudełku
            return InsideBox;
        }

    }

}