Console.WriteLine("Hello, what is Your name?");

// Get user name
var name = Console.ReadLine();
var date = DateTime.UtcNow;

Console.WriteLine("____________________________________________");
Console.WriteLine($"Hello {name}, today is {date}. What mathematical game would you like to play?\n");
Console.WriteLine($@"
A: Addition
S: Subtraction
M: Multiplication
D: Division
Q: Quit the program");
Console.WriteLine("\n ___________________________________________");

//Get game choice
var gameType = Console.ReadLine().ToLower().Trim();

if (gameType == "a")
{
    AdditionGame();
}
else if (gameType == "s")
{
    SubtractionGame();
}
else if (gameType == "m")
{
    MultiplicationGame();
}
else if (gameType == "d")
{
    DivisionGame();
}
else if (gameType == "q")
{
    Console.WriteLine("Goodbye");
    Environment.Exit(1);
}

void DivisionGame()
{
    Console.WriteLine("DIVIDE");
}

void MultiplicationGame()
{
    Console.WriteLine("MULTIPLY");
}

void SubtractionGame()
{
    Console.WriteLine("SUB");
}

//Addition method
void AdditionGame()
{
    Console.WriteLine("ADD");
}