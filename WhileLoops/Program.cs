Random r = new Random();
int random;

// bool - true / false

bool loopActive = true;

while (loopActive)
{
    random = r.Next(1, 6);
   
    // Console.WriteLine($"CPU generated this number: {random}.");
    
    Console.WriteLine("Guess a number (1-5) and enter it here:");
    int userNum = Int32.Parse(Console.ReadLine());

    if (userNum == random)
    {
        Console.WriteLine("Congratulations, you won!");
        loopActive = false;

        // Or break;
    }
    
    else
    {
        Console.WriteLine("Haha, too bad... Try again!");
    }
}
Console.WriteLine("Bye, bye!");