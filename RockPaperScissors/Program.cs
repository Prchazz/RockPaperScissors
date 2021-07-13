using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputplayer;
            string inputCPU;
            int randomnum;
            
            Random rnd = new Random((int)DateTime.Now.Ticks);
            randomnum = rnd.Next(1, 3);
            bool playAgain = true;

            while (playAgain)
            {
                int scoreplayer = 0;
                int scoreCPU = 0;

                while (scoreplayer < 3 && scoreCPU < 3)
                {

                    
                    Console.Write("Choose between Rock, Paper, Scissors:    ");
                    inputplayer = Console.ReadLine();
                    inputplayer = inputplayer.ToUpper();



                    switch (randomnum)
                    {
                        case 1:
                            inputCPU = "ROCK";
                            Console.WriteLine("Boom! computer chose ROCK");
                            if (inputplayer == "ROCK" || inputplayer == "R")
                            {
                                Console.WriteLine("We have a Draw!!\n\n");
                            }
                            else if (inputplayer == "PAPER"|| inputplayer == "P")
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("You win!\n\n");
                                scoreplayer++;
                            }
                            else if (inputplayer == "SCISSORS" || inputplayer == "S")
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("The computer wins!\n\n");
                                scoreCPU++;
                            }
                            break;
                        case 2:
                            inputCPU = "PAPER";
                            Console.WriteLine("Pop! computer chose PAPER");
                            if (inputplayer == "PAPER" || inputplayer == "P")
                            {
                                Console.WriteLine("We have a Draw!!\n\n");
                            }
                            else if (inputplayer == "SCISSORS" || inputplayer == "S")
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("You win!\n\n");
                                scoreplayer++;
                            }
                            else if (inputplayer == "ROCK" || inputplayer == "R")
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("The computer wins!\n\n");
                                scoreCPU++;
                            }
                            break;
                        case 3:
                            inputCPU = "SCISSORS";
                            Console.WriteLine("Buya! computer chose SCISSORS");
                            if (inputplayer == "SCISSORS" || inputplayer == "S")
                            {
                                Console.WriteLine("We have a Draw!!\n\n");
                            }
                            else if (inputplayer == "ROCK" || inputplayer == "R")
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("You win!\n\n");
                                scoreplayer++;
                            }
                            else if (inputplayer == "PAPER" || inputplayer == "P")
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("The computer wins!\n\n");
                                scoreCPU++;
                            }
                            break;
                        default:
                            Console.WriteLine("Invalid input!");
                            break;
                    }
                    Console.ResetColor();
                    Console.WriteLine("\n\nSCORES:\tPLAYER:\t{0}\tComputer:\t{1}", scoreplayer, scoreCPU);
                }
                if (scoreplayer == 3)

                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("You won!");
                }
                else if (scoreCPU == 3)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("The computer beat you!");
                }
                else
                {

                }
                Console.ResetColor();
                Console.WriteLine("Would you like to try again, y or n?");
                string loop = Console.ReadLine();
                if(loop == "y")
                {
                    playAgain = true;
                    Console.Clear();
                }
                else if (loop == "n")
                {
                    playAgain = false;
                }
                else

                {

                }
            }
        }
    }
}