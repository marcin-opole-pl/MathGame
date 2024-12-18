var date = DateTime.UtcNow;
string name = GetName();
Menu(name);


string GetName()
{
    Console.WriteLine("Type your name please");
    string name = Console.ReadLine();
    return name;
}

void Menu(string name)
{
    Console.WriteLine("------------------------------------");
    Console.WriteLine($"Hello {name}, today is {date}.");
    Console.WriteLine($@"What game would you like to play:
A - addition
S - subtraction
M - multiplication
D - division
Q - quit the program");

    Console.WriteLine("------------------------------------");

    var selectedGame = Console.ReadLine().Trim().ToLower();

    switch (selectedGame)
    {
        case ("a"):
            AdditionGame("Addition selected");
            break;
        case ("s"):
            SubstractionGame("Subtraction selected");
            break;
        case ("m"):
            MultiplicationGame("Multiplication selected");
            break;
        case ("d"):
            DivisionGame("Division selected");
            break;
        case ("q"):
            Console.WriteLine("Goodbye");
            Environment.Exit(0);
            break;
        default:
            Console.WriteLine("Wrong input");
            Environment.Exit(0);
            break;
    }
}

void AdditionGame(string message)
{ 
    Console.WriteLine(message);

    var random = new Random();
    int firstNumber = random.Next(1, 9);
    int secondNumber = random.Next(1, 9);

    Console.WriteLine($"{firstNumber} + {secondNumber} = ");

    var result = Console.ReadLine();
    if (int.Parse(result) == firstNumber + secondNumber)
    {
        Console.WriteLine("Correct");
    }
    else
    {
        Console.WriteLine("Incorrrect");
    }
}

void SubstractionGame(string message)
{
    Console.WriteLine(message);
}

void MultiplicationGame(string message)
{
    Console.WriteLine(message);
}

void DivisionGame(string message)
{
    Console.WriteLine(message);
}

