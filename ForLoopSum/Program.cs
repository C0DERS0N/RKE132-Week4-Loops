// Ascending loop
// i++ -> i + 1

Console.WriteLine("Ascending loop:");

for (int i = 0; i < 10; i++)
{
    Console.WriteLine($"i = {i + 1}");
}

// Decending loop
// i-- -> i - 1

Console.WriteLine("Decending loop:");

for (int i = 10; i > 0; i--)
{
    Console.WriteLine($"i = {i}");
}

// Loop ssum

Console.WriteLine("Loop sum:");

int sum = 0;

for (int i = 0; i < 10; i++)
{
    Console.WriteLine($"i = {i}");
    Console.WriteLine($"Current total: {sum}");
    sum = sum + i;
    // sum += i;
}

Console.WriteLine($"Final total: {sum}");