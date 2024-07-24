// See https://aka.ms/new-console-template for more information

using static Program;
// Console.Write("Enter a string: ");
// string inputString = Console.ReadLine();
class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a String:");
        string inputString = Console.ReadLine();
        
        Console.WriteLine("Enter a word to search:");
        string searchWord = Console.ReadLine();
        
        int count = CountWordOccurrences(inputString, searchWord);
        
        Console.WriteLine($"Word found {count} times in the string");
    }

    static int CountWordOccurrences(string str, string word)
    {
        // int count = 0;
        // int index = 0;
        int count = 0;
        int position = 0;
        // while ((index = str.IndexOf(word, index)) != -1)
        while ((position = str.IndexOf(word, position)) != -1)
        {
            count++;
            position += word.Length;
        }

        return count;
    }
}
