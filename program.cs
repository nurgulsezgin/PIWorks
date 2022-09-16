// C# implementation

int input = Int32.Parse(Console.ReadLine());

Console.WriteLine(isDivisible(input));


// Function to check if the given number is divisible by sum of its digits

static bool isDivisible(int input)
{
    int number = input;

    // Find sum of digits
    int sum = 0;

    while (input != 0)
    {
        int d = (int)input % 10;
        sum += d;
        input /= d;
    }

    // Check if sum of digits divides number
    if (number % sum == 0)
        return true;

    return false;
}
