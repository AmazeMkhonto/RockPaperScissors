using System;

public class RockPaperScissors
{
    public static string Rps(string p1, string p2)
    {
        if (p1 == p2)
        {
            return "Draw!";
        }
        else if ((p1 == "rock" && p2 == "scissors") ||
                 (p1 == "scissors" && p2 == "paper") ||
                 (p1 == "paper" && p2 == "rock"))
        {
            return "Player 1 won!";
        }
        else
        {
            return "Player 2 won!";
        }
    }

    public static void Main(string[] args)
    {
        string[] plays = { "scissors", "rock", "paper" };
        string p1 = "";
        string p2 = ""; 

        
        Console.WriteLine();

        Console.WriteLine("Player 1, what do you want to play?");
        p1 = Console.ReadLine().ToLower();

        while (!plays.Contains(p1))
        {
            Console.WriteLine("Player 1, your move is not valid. Please try again.");
            Console.WriteLine();
            Console.WriteLine("Player 1, what do you want to play?");
            p1 = Console.ReadLine().ToLower();
        }

        Console.WriteLine();

        Console.WriteLine("Player 2, what do you want to play?");
        p2 = Console.ReadLine().ToLower();

        while (!plays.Contains(p2))
        {
            Console.WriteLine("Player 2, your move is not valid. Please try again.");
            Console.WriteLine();
            Console.WriteLine("Player 2, what do you want to play?");
            p2 = Console.ReadLine().ToLower();
        }

        System.Console.WriteLine();
        string answer = Rps(p1, p2);
        Console.WriteLine(answer);
    }
}
