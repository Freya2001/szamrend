using System;

namespace szamrend_valt
{
    class Program
    {
        static void Main(string[] args)
        {
            //string dig1 = ((char)('a' + (12 - 10))).tostring();
            //string dig2 = ((char)('0' + (5))).tostring();
            //console.writeline(dig1 + dig2);
            while (true)
            {
                Console.WriteLine("Adj egy egész számot a tizes számrendszerből!");
                string tizes = Console.ReadLine();
                int szam;
                bool tizeses = int.TryParse(tizes, out szam);
                if (tizeses)
                {
                    int szamrend;
                    bool joSzamrend;
                    do
                    {
                        Console.WriteLine("Adj meg egy számrendszert 2 és 16 között, amelyikbe átváltsuk a megadott számot!");
                        string szamr = Console.ReadLine();
                        bool bonyi = int.TryParse(szamr, out szamrend);
                        joSzamrend = bonyi && szamrend > 1 && szamrend < 17;
                    } while (!joSzamrend);
                    if (szamrend == 10)
                    {
                        Console.WriteLine("A megoldás a(z) " + szamrend + "-s számrendszerben " + szam + ".");
                    }
                    string megold = "";
                    int hatvany = 1;
                    while (hatvany < szam)
                    {
                        hatvany *= szamrend;
                    }
                    if (szam == hatvany)
                    {
                        int helyiertek = szam / hatvany;
                        megold += AddCharacterToResult(helyiertek);
                        szam = szam % hatvany;
                        hatvany = hatvany / szamrend;
                    }
                    hatvany = hatvany / szamrend;
                    while (hatvany >= 1)
                    {
                        int helyiertek = szam / hatvany;
                        megold += AddCharacterToResult(helyiertek);
                        szam = szam % hatvany;
                        hatvany = hatvany / szamrend;
                    }
                    Console.WriteLine("A megoldás a(z) " + szamrend + "-s számrendszerben " + megold + ".");
                }
                else
                {
                    Console.WriteLine("Nem jó adatot adott.");
                }
            }
        }
        private static string AddCharacterToResult(int helyiertek)
        {
            switch (helyiertek)
            {
                case 10:
                    return "A";
                case 11:
                    return "B";
                case 12:
                    return "C";
                case 13:
                    return "D";
                case 14:
                    return "E";
                case 15:
                    return "F";
                default:
                    return Convert.ToString(helyiertek);
            }
        }
    }
}
