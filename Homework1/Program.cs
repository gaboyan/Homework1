using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork1
{
    class Program
    {
        //public int ardyunq;
        static void Main(string[] args)
        {
            int Tarberak = 0;
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Ընտրեք ֆունկցիան։");
            Console.WriteLine("1. Ֆակտորիալ");
            Console.WriteLine("2. Գումար, կամ գումարի տասնապատիկ");
            Console.WriteLine("3. Գումարը = 27, թե՞ ոչ");
            Console.WriteLine("4. Երեք թվից մեծը");
            Console.WriteLine("5. Երկու թվերի բաժանման մնացորդը");
            Console.WriteLine("6. Թվի Նշերի գումարը");
            Console.WriteLine("7 կամ այլ. Ավարտել");

            try
            { Tarberak = Convert.ToInt32(Console.ReadLine()); }
            catch (FormatException)
            { Console.WriteLine("Թիվ գրեք"); }

            while (Tarberak != 7)
            {
                if (Tarberak == 1)
                {
                    Console.WriteLine("Ո՞ր թվի ֆակտորիալն եք ուզում ստանալ");
                    Factorial();
                };

                if (Tarberak == 2)
                {
                    Console.WriteLine("Ներմուծեք 2 թվերը։");
                    Gumar();
                };

                if (Tarberak == 3)
                {
                    Console.WriteLine("Ներմուծեք 2 թվերը։");
                    Stugum27();
                };

                if (Tarberak == 4)
                {
                    Console.WriteLine("Ներմուծեք 3 թվերը։");
                    Mets();
                };

                if (Tarberak == 5)
                {
                    Console.WriteLine("Ներմուծեք բաժանելին և բաժանարարը։");
                    Console.WriteLine("Մնացորդ` " + Mnacord(0, 0));
                };

                if (Tarberak == 6)
                {
                    Console.WriteLine("Ներմուծեք թիվը։");
                    TveriGumar();
                };
                //Console.WriteLine(Tarberak);


                try
                {
                    Tarberak = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("Թիվ գրեք");
                };
            }

        }

        static public void Factorial()
        {
            int ardyunq = 1;
            int Tiv = 1;
            try
            {
                Tiv = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Թիվ գրեք");
            };

            for (int i = 2; i <= Tiv; i++)
            {
                ardyunq = ardyunq * i;

            }
            Console.WriteLine(Tiv + "!=" + ardyunq);
        }

        static public void Gumar()
        {
            int Tiv1 = 0;
            int Tiv2 = 0;
            int ardyunq = 0;
            try
            {
                Tiv1 = Convert.ToInt32(Console.ReadLine());
                Tiv2 = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Թիվ գրեք");
            };
            ardyunq = Tiv1 + Tiv2;
            if (Tiv1 == Tiv2) { ardyunq = ardyunq * 10; };
            Console.WriteLine("Արդյունք=" + ardyunq);
        }

        static void Stugum27()
        {
            int Tiv1 = 0;
            int Tiv2 = 0;
            Boolean ardyunq = false;

            while (Tiv1 < 1 || Tiv2 < 1)
            {
                try
                {
                    Console.WriteLine("Առաջին թիվը");
                    Tiv1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Երկրորդ թիվը");
                    Tiv2 = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("Թիվ գրեք");
                };
            }
            if (Tiv1 == 27 || Tiv2 == 27 || (Tiv1 + Tiv2) == 27) { ardyunq = true; }
            Console.WriteLine("Արդյունք` " + ardyunq);
        }

        static void Mets()
        {
            int Tiv1 = 0;
            int Tiv2 = 0;
            int Tiv3 = 0;
            int ardyunq = 0;

            while (Tiv1 < 1 || Tiv2 < 1 || Tiv3 < 1)
            {
                try
                {
                    Console.WriteLine("Առաջին թիվը");
                    Tiv1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Երկրորդ թիվը");
                    Tiv2 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Երրորդ թիվը");
                    Tiv3 = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("Թիվ գրեք");
                };
            }
            ardyunq = Tiv1;
            if (Tiv2 > ardyunq) { ardyunq = Tiv2; };
            if (Tiv3 > ardyunq) { ardyunq = Tiv3; };
            Console.WriteLine("Ամենամեծ թիվը` " + ardyunq);
        }

        static int Mnacord(int Tiv1, int Tiv2)
        {
            //int Tiv1 = 0;
            //int Tiv2 = 0;
            int ardyunq = 0;

            while (Tiv1 < 1 || Tiv2 < 1)
            {
                try
                {
                    Console.WriteLine("Բաժանելի");
                    Tiv1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Բաժանիչ");
                    Tiv2 = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("Թիվ գրեք");
                };
            }
            ardyunq = Tiv1 - Tiv2 * Convert.ToInt32(Tiv1 / Tiv2);

            //Console.WriteLine("Մնացորդ` " + ardyunq);
            return ardyunq;
        }

        static void TveriGumar()
        {
            int Tiv1 = 0;
            int ardyunq = 0;
            //string tiv="";
            //ներմուծում
            while (Tiv1 < 1)
            {
                try
                {
                    Console.WriteLine("Թիվ գրեք");
                    Tiv1 = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("Թիվ գրեք");
                };
            }

            // հիմնական կոդ
            while (Tiv1 > 9)
            {
                ardyunq = ardyunq + Mnacord(Tiv1, 10);
                Tiv1 = Convert.ToInt32(Tiv1 / 10);
            }
            ardyunq = ardyunq + Tiv1;
            Console.WriteLine("Թվանշանների գումարը` " + ardyunq);
        }
    }
}