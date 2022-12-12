// For - Loop
// Dry - Principle (Do not repeat yourself!)

// i = 0 / 1 -> Start
// i < 5 -> End
// i++ = i + 1 -> Step

int i = 0;

for (i = 0; i < 10; i++)
{
    Console.WriteLine("We don't need to sleep!");
}

Console.WriteLine(i);

for (i = 0; i < 10; i++)
{
    Console.WriteLine("Go to sleep!");
}

Console.WriteLine(i);