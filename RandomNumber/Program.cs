Random r = new Random();
int RNum;
int RSum = 0;

//RNum = r.Next(0, 101);
//Console.WriteLine($"Probability that I am stupid is {RNum}%!");
// 0, 100 -> 0 - 99

for (int i = 0; i < 10; i++)
{
    RNum = r.Next(0, 101);
    RSum = RSum + RNum;
    Console.WriteLine($"Probability that I am stupid is {RNum}%!");
}

Console.WriteLine($"Random average of my stupidity is {RSum / 10}%.");