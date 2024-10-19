namespace Cwiczenia2Gr2
{
    class Program
    {
        static void Main()
        {
            CzlonekZespolu cz1 = new("Joanna", "Brodzik", EnumPlec.K,
                "12-06-2023", "grafik");
            CzlonekZespolu cz2 = new("Kazimierz", "Jabłoński", EnumPlec.M,
                "01-12-2021", "programista");
            KierownikZespolu k = new("Beata", "Nowak", EnumPlec.K,
                9, 567099123);
            Console.WriteLine(cz1);
            Console.WriteLine(cz2);
            Console.WriteLine(k);
            Zespol z = new("ZespolIT", k);
            z.DodajCzlonkaZespolu(cz1);
            z.DodajCzlonkaZespolu(cz2);
        }
    }
}
