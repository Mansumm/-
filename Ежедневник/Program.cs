using Ежедневник;

internal class Program
{
    
    public static int BorderAll = 0;
    public static int BorderFirst = 3;
    public static int BorderThird = 2;
    public static int BorderMinusSecond = 1;
    public static List<Zametka> zametki = new List<Zametka>();
    public static DateTime mydate = new DateTime(2022, 10, 4);
    public static int WhichDay = 0;
    public static int WhereStrelka = 0;
    
    public static Zametka FirstFirst = new Zametka()
    {
        name = "Посмотеть футбол",
        data = new DateTime(2022, 10, 4),
        description = "Включить телевизор и открыть матч тв"
    };
    public static Zametka SecondFirst = new Zametka()
    {
        name = "Сделать дз",
        data = new DateTime(2022, 10, 5),
        description = "Открыть классрум, посмотреть что надо сделать"
    };
    public static Zametka ThirdFirst = new Zametka()
    {
        name = "Пойти в МПТ",
        data = new DateTime(2022, 10, 6),
        description = "Проснуться рано "
    };
    public static Zametka FirstThird = new Zametka()
    {
        name = "Покушать",
        data = new DateTime(2022, 10, 7),
        description = " открыть холодильник, взять покушать"
    };

    public static Zametka FirstMinusSecond = new Zametka()
    {
        name = "Выучить ААС",
        data = new DateTime(2022, 10, 7),
        description = "Открыть ноут, и выучить."
    };
    static void Main()
    {
        Start();
    }
    static void Start()
    {
        zametki.Add(FirstFirst);
        zametki.Add(SecondFirst);
        zametki.Add(ThirdFirst);
        zametki.Add(FirstThird);
        zametki.Add(FirstMinusSecond);
        while (true)
        {
            Menu();
            ConsoleKeyInfo Choice = Console.ReadKey();
            switch (Choice.Key)
            {
                case ConsoleKey.RightArrow:
                    IzmData("Вправо");
                    break;
                case ConsoleKey.LeftArrow:
                    IzmData("Влево");
                    break;
                case ConsoleKey.DownArrow:
                    Strelochki("Вниз");
                    break;
                case ConsoleKey.UpArrow:
                    Strelochki("Вверх");
                    break;
     
                case ConsoleKey.Escape:
                    Environment.Exit(0);
                    break;
                case ConsoleKey.Spacebar:
                    
                    break;
            }
        }
    }
    static void Strelochki(string WhichSide)
    {
        Console.Clear();
        if (WhichSide == "Вверх")
        {
            if (WhereStrelka != 0)
            {
                WhereStrelka--;
            }
            if (WhereStrelka != 0)
            {
                Console.SetCursorPosition(0, WhereStrelka);
                Console.Write("->");
            }
        }
        if (WhichSide == "Вниз")
        {
            if (WhichDay == 0 && WhereStrelka != BorderFirst)
            {
                WhereStrelka++;
                Console.SetCursorPosition(0, WhereStrelka);
                Console.Write("->");
            }
            else if (WhichDay == -1 && WhereStrelka != BorderMinusSecond)
            {
                WhereStrelka++;
                Console.SetCursorPosition(0, WhereStrelka);
                Console.Write("->");
            }
            else if (WhichDay == 2 && WhereStrelka != BorderThird)
            {
                WhereStrelka++;
                Console.SetCursorPosition(0, WhereStrelka);
                Console.Write("->");
            }
            else if (WhichDay != 2 && WhichDay != -1 && WhichDay != 0 && BorderAll != 0)
            {
                WhereStrelka++;
                Console.SetCursorPosition(0, WhereStrelka);
                Console.Write("->");
            }
            else
            {
                Console.SetCursorPosition(0, WhereStrelka);
                Console.Write("->");
            }
        }
    }
    static void IzmData(string WhichStrelochka)
    {
        Console.Clear();
        if (WhichStrelochka == "Влево")
        {
            mydate = mydate.AddDays(-1);
            WhichDay--;
            WhereStrelka = 0;
        }
        else if (WhichStrelochka == "Вправо")
        {
            mydate = mydate.AddDays(1);
            WhichDay++;
            WhereStrelka = 0;
        }
    }
  
    
    static void Menu()
    {
        Console.SetCursorPosition(0, 0);
        Console.Write($"Выбрана дата {mydate}");
        int i = 0;
        foreach (Zametka note in zametki)
        {
            if (note.data == mydate)
            {
                i++;
                Console.SetCursorPosition(2, i);
                Console.Write($"{i}.{note.name}");
            }
        }
    }
}
