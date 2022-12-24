using System;
using System.Diagnostics.CodeAnalysis;
using System.Threading;

namespace Blackjack_21
{
    class Program
    {
        static void Main(string[] args)
        {


            Random slumpkort = new Random();

            Console.WriteLine("Välkommen till blackjack ");
            Console.WriteLine("Välj ett alternativ");
            Console.WriteLine("1: Spela Blackjack/21");
            Console.WriteLine("2: Senaste vinnaren");
            Console.WriteLine("3: Regler");
            Console.WriteLine("4: Avsluta programmet");

            int menyVal = int.Parse(Console.ReadLine());


            while (menyVal != 4)
            {


                switch (menyVal)
                {


                    case 1:
                        {
                            Console.Clear();
                            Console.WriteLine("Välkommen till Blackjack, du och dator kommer få 2 kort. ");
                            Console.WriteLine("");
                            int dittkort1 = slumpkort.Next(1, 11);
                            int dittkort2 = slumpkort.Next(1, 11);
                            int dinaPoäng = dittkort1 + dittkort2;
                            Console.WriteLine("Dina poäng är:" + dinaPoäng);


                            int datorkort1 = slumpkort.Next(1, 11);
                            int datorkort2 = slumpkort.Next(1, 11);
                            int datorpoäng = datorkort1 + datorkort2;
                            Console.WriteLine("dator kort är: " + datorpoäng);

                            while (dinaPoäng <= 21 && datorpoäng <= 21)
                            {
                                Console.WriteLine("vill du dra ett kort till? j/n");
                                string janej = Console.ReadLine();
                                if (janej == "j")
                                {
                                    Console.Clear();
                                    dittkort1 = slumpkort.Next(1, 11);
                                    dinaPoäng = dinaPoäng + dittkort1;
                                    Console.WriteLine("du drog kort: " + dittkort1);
                                    Console.WriteLine("");
                                    Console.WriteLine("summan är: " + dinaPoäng);
                                    Console.WriteLine("dator poäng är: " + datorpoäng);
                                    

                                    if (dinaPoäng > 21)
                                    {
                                    
                                        Console.WriteLine("");
                                        Console.WriteLine("du förlårade");
                                        Console.WriteLine("");
                                        break;
                                    }






                                }
                                else if (janej == "n")
                                {


                                    while (datorpoäng < dinaPoäng)
                                    {
                                        Console.Clear();

                                        Console.WriteLine("dator måste få mer än dig för att kunna vinna ");
                                        datorkort1 = slumpkort.Next(1, 11);
                                        datorpoäng = datorpoäng + datorkort1;
                                        Console.WriteLine("dator nya kort är: " + datorkort1);
                                        Console.WriteLine("dator nya summa är: " + datorpoäng);
                                        Console.WriteLine("din summa " + dinaPoäng);
                                        Thread.Sleep(2000);
                                    }
                                    if (dinaPoäng == datorpoäng)
                                    {
                                        Console.WriteLine("det är lika, ingen vinner ");
                                        break;
                                    }
                                    else if (datorpoäng > 21)
                                    {
                                        Console.WriteLine("du vän eftersom dator summa är över 21");
                                        Console.WriteLine("skriv in ditt namn");
                                        string namn = Console.ReadLine();
                                        break;
                                    }
                                    else if (datorpoäng > dinaPoäng)
                                    {
                                        Console.WriteLine("dator vinner!, försök agien");
                                        break;
                                    }

                                }
                            }
                        }
                        break;


                    case 2:

                        break;

                    case 3:
                        Console.Clear();
                        Console.WriteLine("Du spelar mot en croupier (banken) och det gäller att få en hand som slår bankens hand. Om din poäng är högre än bankens så vinner du dubbla insatsen.");
                        Console.WriteLine("");
                        Console.WriteLine("Om du får exakt 21 på dina första två kort så får du Blackjack vilket ger 2.5 gånger pengarna tillbaka.");
                        Console.WriteLine("");

                        break;
                }
                Console.WriteLine("Välkommen till blackjack ");
                Console.WriteLine("Välj ett alternativ");
                Console.WriteLine("1: Spela Blackjack/21");
                Console.WriteLine("2: Senaste vinnaren");
                Console.WriteLine("3: Regler");
                Console.WriteLine("4: Avsluta programmet");
                menyVal = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("programmet avslutats");



        }
    }
}
