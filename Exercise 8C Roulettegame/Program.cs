using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_8C_Roulettegame
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Random ran = new Random();
            var r = new Random();
            string[] color = { "Red", "Black" };
            string player;
            int input = 0;
            int bet;
            int money = 500;
            while (money != 0)

            {
                Console.WriteLine("Welcome to Roulette!");
                Console.WriteLine("Money:$" + money + "            Attemts:" + input);
                Console.WriteLine("Choose your odds and place your bets!");
                Console.WriteLine("A.Even  B.Odd  C.1 to 18  D.19 to 36");
                Console.WriteLine("E. Red  F.Black  G.1st 12 H.2nd 12 I.3rd 12");
                player = (Console.ReadLine());
                player.ToLower();
                bool[] conditiond = { player == "a", player == "b", player == "c", player == "d", player == "e", player == "f", player == "g", player == "h", player == "i" };
                int check = Array.IndexOf(conditiond, true);
                if (check == -1)
                {
                    Console.WriteLine("You did not choose from the list above try again.");
                    Console.ReadKey();
                    Console.Clear();
                    continue;
                }

                else
                {
                bet:
                    Console.WriteLine("Enter your amount!");
                    while (!Int32.TryParse(Console.ReadLine(),out bet))
                    {
                        Console.WriteLine("Please try again.");
                    }
                    if (bet > money )
                    {
                        Console.WriteLine("You don't have the cash for that bet!");
                        Console.WriteLine("Try again.");
                        Console.ReadKey();
                        goto bet;

                    }
                                       
                    //Need to fix
                    else
                    {
                        money -= bet;
                        int spin = ran.Next(0, 37);
                        string ranColor = color[r.Next(color.Length)];
                        bool even = spin % 2 == 0;
                        if((((player =="a") && (even == true))) || (((player == "b") && (even == false))) || ((player == "e") && (ranColor == "Red") || (player == "f") && (ranColor == "Black")))
                        {
                            Console.WriteLine("The wheel spin is:"+ranColor+""+spin);
                            Console.WriteLine("Winner!+$" +bet * 2 + "!");
                            Console.WriteLine("<Press enter to continue>");
                            money += bet * 2;
                            input += 1;
                            Console.ReadKey();
                        }
                        else if ((player == "c") &&((spin >0) && (spin<19)))
                        {
                            Console.WriteLine("The wheel spin is:" + ranColor + "" + spin);
                            Console.WriteLine("Winner!+$" + bet * 2 + "!");
                            Console.WriteLine("<Press enter to continue>");
                            money += bet * 2;
                            input += 1;
                            Console.ReadKey();
                        }
                        else if ((player == "d") && ((spin > 0) && (spin < 19)))
                        {
                            Console.WriteLine("The wheel spin is:" + ranColor + "" + spin);
                            Console.WriteLine("Winner!+$" + bet * 2 + "!");
                            Console.WriteLine("<Press enter to continue>");
                            money += bet * 2;
                            input += 1;
                            Console.ReadKey();
                        }
                        else if ((player == "g") && ((spin > 0) && (spin < 19)))
                        {
                            Console.WriteLine("The wheel spin is:" + ranColor + "" + spin);
                            Console.WriteLine("Winner!+$" + bet * 2 + "!");
                            Console.WriteLine("<Press enter to continue>");
                            money += bet * 2;
                            input += 1;
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine("The wheel spin is:" + ranColor + "" + spin);
                            Console.WriteLine("Loser!-$" + bet + "!");
                            Console.WriteLine("<Press enter to continue>");
                            money += bet * 2;
                            input += 1;
                            Console.ReadKey();
                            if(money==0)
                            {
                                Console.WriteLine("You are out of money the atm is by the front door.");
                                Console.WriteLine("<Press entere to continue>");
                                Console.ReadLine();
                            }
                        }

                    }
                }

            }


        }
    }
}
