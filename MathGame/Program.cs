using static System.Formats.Asn1.AsnWriter;

var date = DateTime.UtcNow;

string name = GetName();

//History of games
var games = new List<string>();

Menu(name);

//Get user name
string GetName()
{
    Console.WriteLine("Type your name please");
    string name = Console.ReadLine();
    return name;
}

void Menu(string name)
{
    //Greet user
    Console.WriteLine("------------------------------------");
    Console.WriteLine($"Hello {name}, today is {date}.");

    var isGameOn = true;

    //Display game menu while isGameOn
    do
    {
        Console.Clear();

        Console.WriteLine($@"What game would you like to play:
                            V - view previous games
                            A - addition
                            S - subtraction
                            M - multiplication
                            D - division
                            Q - quit the program");

        Console.WriteLine("------------------------------------");
        
        //Get user input
        var selectedGame = Console.ReadLine().Trim().ToLower();

        switch (selectedGame)
        {
            case ("v"):
                GetGames();
                break;
            case ("a"):
                AdditionGame("Addition game");
                break;
            case ("s"):
                SubstractionGame("Subtraction game");
                break;
            case ("m"):
                MultiplicationGame("Multiplication game");
                break;
            case ("d"):
                DivisionGame("Division game");
                break;
            case ("q"):
                Console.WriteLine("Goodbye");
                //Break loop
                isGameOn = false;
                break;
            default:
                Console.WriteLine("Wrong input");
                break;
        }
    }
    while (isGameOn);
}

//Display games history
void GetGames()
{
    Console.Clear();
    Console.WriteLine("Games history");
    Console.WriteLine("______________________________");

    foreach (var game in games)
    { 
        Console.WriteLine(game); 
    }
    Console.WriteLine("___________________________\n");
    Console.WriteLine("press any key to return");
    Console.ReadLine();
}

void AdditionGame(string message)
{
    //Display game name
    Console.WriteLine(message);

    var random = new Random();
    int firstNumber;
    int secondNumber;
    int score = 0;

    //4 iterations
    for (int i = 0; i < 5; i++)
    {
        Console.Clear();
        Console.WriteLine(message);

        firstNumber = random.Next(1, 9);
        secondNumber = random.Next(1, 9);

        //Get answer
        Console.WriteLine($"{firstNumber} + {secondNumber} = ");

        //Check answer
        var result = Console.ReadLine();
        if (int.Parse(result) == firstNumber + secondNumber)
        {
            Console.WriteLine("Correct, press any key to continue");
            score++;
            Console.ReadLine();
        }
        else
        {
            Console.WriteLine("Incorrrect, press any key to continue");
            Console.ReadLine();
        }

        //Display final score
        if (i == 4)
        {
            Console.WriteLine($"Your score is {score}. Press any key to go to the menu");
            Console.ReadLine();
        }
    }

    //Update games list
    games.Add($"{DateTime.Now} - Addition score = {score}");
}

void SubstractionGame(string message)
{
    Console.WriteLine(message);

    var random = new Random();
    int firstNumber;
    int secondNumber;
    int score = 0;

    for (int i = 0; i < 5; i++)
    {
        Console.Clear();
        Console.WriteLine(message);

        firstNumber = random.Next(1, 9);
        secondNumber = random.Next(1, 9);

        Console.WriteLine($"{firstNumber} - {secondNumber} = ");

        var result = Console.ReadLine();
        if (int.Parse(result) == firstNumber - secondNumber)
        {
            Console.WriteLine("Correct, press any key to continue");
            score++;
            Console.ReadLine();
        }
        else
        {
            Console.WriteLine("Incorrrect, press any key to continue");
            Console.ReadLine();
        }

        //Display final score
        if (i == 4)
        {
            Console.WriteLine($"Your score is {score}. Press any key to go to the menu");
            Console.ReadLine();
        }
    }
}

void MultiplicationGame(string message)
{
    Console.WriteLine(message);

    var random = new Random();
    int firstNumber;
    int secondNumber;
    int score = 0;

    for (int i = 0; i < 5; i++)
    {
        Console.Clear();
        Console.WriteLine(message);

        firstNumber = random.Next(1, 9);
        secondNumber = random.Next(1, 9);

        Console.WriteLine($"{firstNumber} * {secondNumber} = ");

        var result = Console.ReadLine();
        if (int.Parse(result) == firstNumber * secondNumber)
        {
            Console.WriteLine("Correct, press any key to continue");
            score++;
            Console.ReadLine();
        }
        else
        {
            Console.WriteLine("Incorrrect, press any key to continue");
            Console.ReadLine();
        }

        //Display final score
        if (i == 4)
        {
            Console.WriteLine($"Your score is {score}. Press any key to go to the menu");
            Console.ReadLine();
        }
    }
}

void DivisionGame(string message)
{
    int score = 0;

    for (int i = 0; i < 5; i++)
    {
        Console.Clear();
        Console.WriteLine(message);

        var divisionNumbers = GetDivisionNumbers();
        var firstNumber = divisionNumbers[0];
        var secondNumber = divisionNumbers[1];
        Console.WriteLine($"{firstNumber} / {secondNumber}");

        var result = Console.ReadLine();
        if (int.Parse(result) == firstNumber / secondNumber)
        {
            Console.WriteLine("Correct, press any key to continue");
            score++;
            Console.ReadLine();
        }
        else
        {
            Console.WriteLine("Incorrrect, press any key to continue");
            Console.ReadLine();
        }

        //Display final score
        if (i == 4)
        {
            Console.WriteLine($"Your score is {score}. Press any key to go to the menu");
            Console.ReadLine();
        }
    }
}

int[] GetDivisionNumbers ()
{
    var random = new Random();
    int firstNumber = random.Next(0,99);
    int secondNumber = random.Next(1, 99);

    var result = new int[2];

    //Look for no remainder solution
    while (firstNumber % secondNumber != 0)
    {
        firstNumber = random.Next(0, 99);
        secondNumber = random.Next(1, 99);
    }

    result[0] = firstNumber;
    result[1] = secondNumber;

    return result;
}