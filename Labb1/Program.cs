// Labb 1.
// Av Alfred Handin, NEU25G.


using System.Numerics;
static void HittaSammaNummer()
{

    Console.Write("Vänligen mata in en text: ");
    string userInput = Console.ReadLine();

    ulong totalSum = 0;

    for (int start = 0; start < userInput.Length; start++)
    {
        if (char.IsDigit(userInput[start]))
        {
            for (int end = start + 1; end < userInput.Length; end++)
            {
                if (!char.IsDigit(userInput[end]))
                    break;

                if (userInput[start] == userInput[end])
                {
                    string matchingString = userInput.Substring(start, end - start + 1);

                    bool isValid = true;
                    for (int i = 1; i < matchingString.Length - 1; i++)
                    {
                        if (matchingString[i] == userInput[start])
                        {
                            isValid = false;
                            break;
                        }
                    }
                    if (isValid)
                    {
                        for (int i = 0; i < userInput.Length; i++)
                        {
                            if (i == start)
                            {
                                Console.ForegroundColor = ConsoleColor.Blue;
                                Console.Write(matchingString);
                                Console.ResetColor();
                                i = end;
                            }
                            else
                            {
                                Console.Write(userInput[i]);
                            }
                        }
                        Console.WriteLine();

                        totalSum += ulong.Parse(matchingString);
                    }
                }
            }
        }
    }

    Console.WriteLine();
    Console.WriteLine($"Totalen blir = {totalSum}");

}

HittaSammaNummer();