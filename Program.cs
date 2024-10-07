using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();
        (int vowels, int consonants) = CountVowelsAndConsonants(input);

        Console.WriteLine($"Number of vowels: {vowels}");
        Console.WriteLine($"Number of consonants: {consonants}");
    }

    static (int, int) CountVowelsAndConsonants(string s)          //method to countVowelsAndConsanants
    {
        string vowels = "aeiouAEIOU";
        int vowelCount = 0;
        int consonantCount = 0;

        foreach (char c in s)
        {
            if (char.IsLetter(c)) // Check if the character is a letter
            {
                if (vowels.Contains(c))
                {
                    vowelCount++;
                }
                else
                {
                    consonantCount++;
                }
            }
        }

        return (vowelCount, consonantCount);
    }
}
