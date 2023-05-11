using System;
using System.Collections.Generic;

public class BattleShip
{
    static string userInput;
    static int shipsDestroyed;
    static int botShipsDestroyed;
   
    public static void Main()
    {
        Console.WriteLine("Choose your ship positions. Example, A: 1");
        CheckSpace(userInput);
        //Player.shipPositions.Add("A: 1");
        //Player.shipPositions.Add("B: 2");
        //Player.shipPositions.Add("C: 3");
        userInput = Console.ReadLine();
        CheckInput(userInput);
        if (Player.shipPositions.Count < 2)
        {
            Main();
            return;
        }
        if (Bot.shipPositions.Count < 2)
        {
            Random rnd = new Random();
            int num = rnd.Next(1, 3);
            Bot.shipPositions.Add($"A: {num}");
            num = rnd.Next(1, 3);
            Bot.shipPositions.Add($"B: {num}");
            num = rnd.Next(1, 3);
            Bot.shipPositions.Add($"C: {num}");
            Main();
            return;
        }
        CheckSpace(userInput);
        Game();
    }
   
    public static void CheckInput(string input)
    {
        if (Player.shipPositions.Contains(input))
        {
            Console.WriteLine("Ship already placed at position");
            return;
        }
       
        if (input.Contains("A: 1"))
        {
            Console.WriteLine("Placed ship at A: 1");
            Player.shipPositions.Add("A: 1");
        }
       
        if (input.Contains("A: 2"))
        {
            Console.WriteLine("Placed ship at A: 2");
            Player.shipPositions.Add("A: 2");
        }
       
        if (input.Contains("A: 3"))
        {
            Console.WriteLine("Placed ship at A: 3");
            Player.shipPositions.Add("A: 3");
        }
        //BBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBB
        if (input.Contains("B: 1"))
        {
            Console.WriteLine("Placed ship at B: 1");
            Player.shipPositions.Add("B: 1");
        }
       
        if (input.Contains("B: 2"))
        {
            Console.WriteLine("Placed ship at B: 2");
            Player.shipPositions.Add("B: 2");
        }
       
        if (input.Contains("B: 3"))
        {
            Console.WriteLine("Placed ship at B: 3");
            Player.shipPositions.Add("B: 3");
        }
        ///CCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCccc
        if (input.Contains("C: 1"))
        {
            Console.WriteLine("Placed ship at C: 1");
            Player.shipPositions.Add("C: 1");
        }
       
        if (input.Contains("C: 2"))
        {
            Console.WriteLine("Placed ship at C: 2");
            Player.shipPositions.Add("C: 2");
        }
       
        if (input.Contains("C: 3"))
        {
            Console.WriteLine("Placed ship at C: 3");
            Player.shipPositions.Add("C: 3");
        }
    }
   
    public static void CheckSpace(string input)
    {
        //Console.Clear();
        Console.WriteLine(" ");
        Console.Write("A: ");
       
        if (Player.shipPositions.Contains("A: 1"))
        {
            Console.Write("0 ");
        }
        else
        {
            Console.Write("1 ");
        }
       
        if (Player.shipPositions.Contains("A: 2"))
        {
            Console.Write("0 ");
        }
        else
        {
            Console.Write("2 ");
        }
       
        if (Player.shipPositions.Contains("A: 3"))
        {
            Console.Write("0");
        }
        else
        {
            Console.Write("3");
        }
        // BBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBB
        Console.WriteLine(" ");
        Console.Write("B: ");
       
        if (Player.shipPositions.Contains("B: 1"))
        {
            Console.Write("0 ");
        }
        else
        {
            Console.Write("1 ");
        }
       
        if (Player.shipPositions.Contains("B: 2"))
        {
            Console.Write("0 ");
        }
        else
        {
            Console.Write("2 ");
        }
       
        if (Player.shipPositions.Contains("B: 3"))
        {
            Console.Write("0");
        }
        else
        {
            Console.Write("3");
        }
        //CCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCC
        Console.WriteLine(" ");
        Console.Write("C: ");
       
        if (Player.shipPositions.Contains("C: 1"))
        {
            Console.Write("0 ");
        }
        else
        {
            Console.Write("1 ");
        }
       
        if (Player.shipPositions.Contains("C: 2"))
        {
            Console.Write("0 ");
        }
        else
        {
            Console.Write("2 ");
        }
       
        if (Player.shipPositions.Contains("C: 3"))
        {
            Console.Write("0");
        }
        else
        {
            Console.Write("3");
        }
       
        Console.WriteLine(" ");
    }
   
    public static void BotControls()
    {
        Random rnd = new Random();
        int num = rnd.Next(1, 3);
        if (num == 1)
        {
            num = rnd.Next(1, 3);
            string hitString = "A: " + num.ToString();
            Console.WriteLine($"Bot hit {hitString}");
            if (Player.shipPositions.Contains(hitString))
            {
                Console.WriteLine("Bot was correct!");
                Player.shipPositions.Remove(hitString);
                botShipsDestroyed++;
            }
            else
            {
                Console.WriteLine("Bot missed!");
            }
        }
        else if (num == 2)
        {
            num = rnd.Next(1, 3);
            string hitString = "B: " + num.ToString();
            Console.WriteLine($"Bot hit {hitString}");
            if (Player.shipPositions.Contains(hitString))
            {
                Console.WriteLine("Bot was correct!");
                Player.shipPositions.Remove(hitString);
                botShipsDestroyed++;
            }
            else
            {
                Console.WriteLine("Bot missed!");
            }
        }
        else if (num == 3)
        {
            num = rnd.Next(1, 3);
            string hitString = "C: " + num.ToString();
            Console.WriteLine($"Bot hit {hitString}");
            if (Player.shipPositions.Contains(hitString))
            {
                Console.WriteLine("Bot was correct!");
                Player.shipPositions.Remove(hitString);
                botShipsDestroyed++;
               
            }
            else
            {
                Console.WriteLine("Bot missed!");
            }
        }
    }
   
    public static void Game()
    {
        Console.WriteLine("Choose your first code.");
       
        userInput = Console.ReadLine();
       
        if (userInput.Contains("ReRead Plain"))
        {
            CheckSpace(userInput);
        }
       
        if (userInput.Contains("Read to Cheat to 3"))
        {
            Console.WriteLine(Bot.shipPositions[0]);
            Console.WriteLine(Bot.shipPositions[1]);
            Console.WriteLine(Bot.shipPositions[2]);
        }
       
        if (userInput.Contains("Positions"))
        {
            Console.WriteLine(Player.shipPositions[0]);
            Console.WriteLine(Player.shipPositions[1]);
            Console.WriteLine(Player.shipPositions[2]);
        }
       
        if (userInput.Contains("A: 1") && Bot.shipPositions.Contains("A: 1"))
        {
            Console.WriteLine("Correct!");
            shipsDestroyed++;
        }
        else if (userInput.Contains("A: 1") && !Bot.shipPositions.Contains("A: 1"))
        {
            Console.WriteLine("Incorrect!");
        }
       
        if (userInput.Contains("A: 2") && Bot.shipPositions.Contains("A: 2"))
        {
            Console.WriteLine("Correct!");
            shipsDestroyed++;
        }
        else if (userInput.Contains("A: 2") && !Bot.shipPositions.Contains("A: 2"))
        {
            Console.WriteLine("Incorrect!");
        }
       
        if (userInput.Contains("A: 3") && Bot.shipPositions.Contains("A: 3"))
        {
            Console.WriteLine("Correct!");
            shipsDestroyed++;
        }
        else if (userInput.Contains("A: 3") && !Bot.shipPositions.Contains("A: 3"))
        {
            Console.WriteLine("Incorrect!");
        }
       
        if (userInput.Contains("B: 1") && Bot.shipPositions.Contains("B: 1"))
        {
            Console.WriteLine("Correct!");
            shipsDestroyed++;
        }
        else if (userInput.Contains("B: 1") && !Bot.shipPositions.Contains("B: 1"))
        {
            Console.WriteLine("Incorrect!");
        }
       
        if (userInput.Contains("B: 2") && Bot.shipPositions.Contains("B: 2"))
        {
            Console.WriteLine("Correct!");
            shipsDestroyed++;
        }
        else if (userInput.Contains("B: 2") && !Bot.shipPositions.Contains("B: 2"))
        {
            Console.WriteLine("Incorrect!");
        }
       
        if (userInput.Contains("B: 3") && Bot.shipPositions.Contains("B: 3"))
        {
            shipsDestroyed++;
            Console.WriteLine("Correct!");
        }
        else if (userInput.Contains("B: 3") && !Bot.shipPositions.Contains("B: 3"))
        {
            Console.WriteLine("Incorrect!");
        }
       
        if (userInput.Contains("C: 1") && Bot.shipPositions.Contains("C: 1"))
        {
            Console.WriteLine("Correct!");
            shipsDestroyed++;
        }
        else if (userInput.Contains("C: 1") && !Bot.shipPositions.Contains("C: 1"))
        {
            Console.WriteLine("Incorrect!");
        }
       
        if (userInput.Contains("C: 2") && Bot.shipPositions.Contains("C: 2"))
        {
            Console.WriteLine("Correct!");
            shipsDestroyed++;
        }
        else if (userInput.Contains("C: 2") && !Bot.shipPositions.Contains("C: 2"))
        {
            Console.WriteLine("Incorrect!");
        }
       
        if (userInput.Contains("C: 3") && Bot.shipPositions.Contains("C: 3"))
        {
            Console.WriteLine("Correct!");
            shipsDestroyed++;
        }
        else if (userInput.Contains("C: 3") && !Bot.shipPositions.Contains("C: 3"))
        {
            Console.WriteLine("Incorrect!");
        }
       
        BotControls();
       
        if (botShipsDestroyed > 2)
        {
            Console.WriteLine("You LOST...");
            return;
        }
       
        if (shipsDestroyed > 2)
        {
            Console.WriteLine("You WON!");
            return;
        }
       
        CheckSpace(userInput);
       
        Game();
    }
}

public class Player
{
    public static List<string> shipPositions = new List<string>();
}

public class Bot
{
    public static List<string> shipPositions = new List<string>();
}