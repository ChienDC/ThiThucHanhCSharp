// See https://aka.ms/new-console-template for more information

using ThiThucHanhCSharp.Bai1;

class Program
{
    // static void Main(string[] args)
    // {
    //     People person = new People("Marry", true, 25);
    //     person.DisplayDetails();
    //     person.IncrementAge();
    //     person.DisplayDetails();
    // }
    static void Main()
    {
        People person = new People();
        Console.WriteLine("Enter Name:");
        person.Name = Console.ReadLine();
        Console.WriteLine("Enter Gender (true for Male, false for Female):");
        person.Gender = bool.Parse(Console.ReadLine());
        Console.WriteLine("Enter Age:");
        person.Age = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the number of years to increment:");
        int incrementValue = int.Parse(Console.ReadLine());
        Console.WriteLine("\nSimple Properties Demo");
        person.DisplayInfo();
        person.IncrementAge(incrementValue);
        Console.WriteLine("\nAfter incrementing age:");
        person.DisplayInfo();
    }
}