Counting();

void Counting()
{
    int count = 0;
    while (true)
    {
        Console.Write("Enter number or \"stop\": ");
        string word = Console.ReadLine()!.ToLower();
        if (word == "stop")
        {
            break;
        }
        else
        {
            int number = Convert.ToInt32(word);
            if (number > 0)
            {
                count++;
            }
        }
    }
    Console.WriteLine($"You have entered {count} positive numbers");
}
