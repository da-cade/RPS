
bool playing = true;
string[] choices = new string[] { "rock", "paper", "scissors" };


Console.WriteLine("\nHello and welcome to RPS");
while (playing)
{
  int rnd = new Random().Next(choices.Length);
  string compChoice = choices[rnd];
  Console.WriteLine("Make a selection \n");

  Thread.Sleep(1000);
  Console.WriteLine("Type (r) for rock, (p) for paper, and (s) for scissors. You can also type (n) to quit.");
  // Game Logic ...
  char userInput = Console.ReadKey().KeyChar;
  Console.WriteLine("");

  switch (userInput)
  {
    case 'n':
      Console.WriteLine("Thanks for playing");
      playing = false;
      break;
    case 'r':
      Console.WriteLine($"\nThe computer chose {compChoice}\n");
      if (compChoice == choices[1])
      {
        Console.WriteLine("Sorry, you lost");
      }
      if (compChoice == choices[2])
      {
        Console.WriteLine("You win!");
      }
      Thread.Sleep(3000);
      break;
    case 's':
      Console.WriteLine($"The computer chose {compChoice}\n");
      if (compChoice == choices[0])
      {
        Console.WriteLine("Sorry, you lost");
      }
      if (compChoice == choices[1])
      {
        Console.WriteLine("You win!");
      }
      Thread.Sleep(3000);
      break;
    case 'p':
      Console.WriteLine($"The computer chose {compChoice}");
      if (compChoice == choices[2])
      {
        Console.WriteLine("Sorry, you lost");
      }
      if (compChoice == choices[0])
      {
        Console.WriteLine("You win!");
      }
      Thread.Sleep(3000);
      break;
    default:
      Console.WriteLine("Please enter a valid input");
      break;
  }
}

