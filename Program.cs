using System;

Console.Write("Would You Like to play a game? (Y/N): ");
string answer = Console.ReadLine().ToLower();

while (answer != "y" && answer != "n")
{
    Console.Write("Would You Like to play a game? (Y/N): ");
    answer = Console.ReadLine().ToLower();
}

if (answer == "y")
{
    Console.WriteLine("------------------------");
    Game();
}
else
{
    Console.WriteLine("Goodbye!");
}


void Game()
{
    Console.WriteLine("In this game the goal is to guess the secret number!");
    Console.Write("What's your guess?   >");
    string input = Console.ReadLine();
    int parsedInput = int.Parse(input);
    Console.Write(parsedInput);
}