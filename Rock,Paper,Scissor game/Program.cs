
using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Rock_Paper_Scissor_game
{
    internal class Program
    {
        static void Main(string[] args)
        {

            bool Playing = true;
            do
            {
                Console.Write("Choose Rock/Paper/Scissors: ");
                String userChoice = Console.ReadLine().ToUpper();

                String[] ComChoice = { "ROCK", "PAPER", "SCISSORS" };
                Random random = new Random();
                int Comrand = random.Next(ComChoice.Length);
                String Com = ComChoice[Comrand];
                

                Console.WriteLine(CalculateResult(userChoice, Com));
                Playing = false;
                Console.WriteLine("Do you want to play again?(Yes/No)");
                String replay=Console.ReadLine();
                if (replay == "Yes" || replay == "yes") { Playing = true; }
                else { Playing = false; Environment.Exit(0); }
            } while (Playing == true);

            Console.ReadKey();  
        }static public String CalculateResult(String userChoice,String CompChoice)
        {
            String result ="Error";
            if (userChoice =="ROCK"&& CompChoice=="ROCK"|| userChoice == "PAPER" && CompChoice == "PAPER" || userChoice == "SCISSORS" && CompChoice == "SCISSORS")
            {
                result = "Draw";
                
            }
            if (userChoice == "ROCK" && CompChoice == "SCISSORS" || userChoice == "PAPER" && CompChoice == "ROCK" || userChoice == "SCISSORS" && CompChoice == "PAPER")
            {
                result = "User Wins!";
               

            }
            if (userChoice == "SCISSORS" && CompChoice == "ROCK" || userChoice == "ROCK" && CompChoice == "PAPER" || userChoice == "PAPER" && CompChoice == "SCISSORS")
            {
                result = "COM Wins!You loose";
                

            }
            return result;
        }
    }
}
