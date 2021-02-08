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
                    Console.WriteLine("Melyik számrendszerbe váltson át (16-os a max)?");
                    string szamr = Console.ReadLine();
                    int szamrend;
                    bool bonyi = int.TryParse(szamr, out szamrend);
                    if (bonyi)
                    {
                        if (szamrend <= 10)
                        {
                            string megold = "";
                            int hatvany = 1;
                            while (hatvany < szam)
                            {
                                hatvany *= szamrend;
                            }
                            if (szam == hatvany)
                            {
                                megold = megold + (szam / hatvany);
                                szam = szam % hatvany;
                                hatvany = hatvany / szamrend;
                            }
                            hatvany = hatvany / szamrend;
                            while (hatvany > 1)
                            {
                                megold = megold + (szam / hatvany);
                                szam = szam % hatvany;
                                hatvany = hatvany / szamrend;

                            }
                            Console.WriteLine("A megoldás a(z) " + szamrend + "-s számrendszerben " + megold + ".");
                        }
                        if (11 <= szamrend && szamrend <= 16)
                        {
                            string megold = "";
                            int hatvany = 1;
                            while (hatvany < szam)
                            {
                                hatvany *= szamrend;
                            }
                            if (szam == hatvany)
                            {
                                megold = megold + (szam / hatvany);
                                szam = szam % hatvany;
                                hatvany = hatvany / szamrend;
                            }
                            hatvany = hatvany / szamrend;
                            while (hatvany > 1)
                            {
                                megold = megold + (szam / hatvany);
                                szam = szam % hatvany;
                                hatvany = hatvany / szamrend;

                            }
                            Console.WriteLine("A megoldás a(z) " + szamrend + "-s számrendszerben " + megold + ".");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Nem jó adatot adott.");
                    }
                }
                else
                {
                    Console.WriteLine("Nem jó adatot adott.");
                }
            }


        }
    }
}
