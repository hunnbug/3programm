void start()
{
    try
    {
        Console.WriteLine("выберите программу, написав соответствующую цифру:\n1. Угадай число\n2. Таблица умножения\n3. Вывод делителей числа\n4. Выход  из программы");
        string vibor = Console.ReadLine();
        if (Convert.ToInt32(vibor) == 1)
        {
            ugadai();
        }
        if (Convert.ToInt32(vibor) == 2)
        {
            umnoj();
        }
        if (Convert.ToInt32(vibor) == 3)
        {
            deliteli();
        }
        if (Convert.ToInt32(vibor) == 4)
        {
            Console.Clear();
        }
    }
    catch
    {
        Console.WriteLine("так нельзя\n");
        start();
    }
}
void ugadai()
{
    Console.WriteLine(" угадай число от 1 до 100\nпри вводе чего угодно кроме числа вы перейдете в меню");
    Random random = new Random();
    int a = random.Next(0, 100);

    exec();
    void exec()
    {
        try
        {
            string b = Console.ReadLine();
            if (Convert.ToInt32(b) < a)
            {
                Console.WriteLine("надо больше");
                exec();
            }
            else if (Convert.ToInt32(b) > a)
            {
                Console.WriteLine("надо меньше");
                exec();
            }
            else if (Convert.ToInt32(b) == a)
            {
                Console.WriteLine("угадал!\n");
                ugadai();
            }
        }
        catch
        {
            start();
        }
    }
}
void umnoj()
{
    int[,] tabl = new int[10,10];
    for (int i = 1; i < 10; i++)
    {
        for (int j = 1; j < 10; j++)
        {
            tabl[i,j] = i * j;
        }
        Console.WriteLine(" ");
    }
    for (int i = 1; i < 10; i++)
    {
        for (int j = 1; j < 10; j++)
        {
            Console.Write(tabl[i,j] + "\t");
        }
        Console.WriteLine(" ");
    }
    Console.WriteLine(" ");
    start();

}

void deliteli()
{
    execute();
    void execute()
    {
        try
        {
            Console.WriteLine("введите число:\n при вводе чего угодно кроме числа вы перейдете в меню");
            string a = Console.ReadLine();

            for (int i = 1; i <= Convert.ToInt32(a); i++)
            {
                if (Convert.ToInt32(a) % i == 0)
                {
                    Console.Write(i + " ");
                }
            }
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            execute();
        }

        catch
        {
            start();
        }
    }
}
start();