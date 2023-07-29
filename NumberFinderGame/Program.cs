Console.WriteLine("guess a number between 0 and 10000");
int min = 0;
int max = 10000;
int guess = (min+max)/2;

for (int i = 0; i < guess; i++)
{
    Console.WriteLine($"is your answer bigger than {guess}");
    string answer = Console.ReadLine();

    if (answer == "Y")
    {
        min = guess;
        guess = (min+max)/2;
    }
    else if (answer == "N")
    {
        Console.WriteLine($"is your answer lower than {guess}?");
        answer = Console.ReadLine();
        if (max==min||max == guess||min == guess|| answer == "N")
        {
            Console.WriteLine($"your number is {guess}");
            break;
        }
        else
        {
            max = guess;
            guess = (max + min) / 2;
        }
        
    }
}