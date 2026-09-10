List<string> items = new List<string>();
List<int> price = new List<int>();

while (true)
{
    System.Console.WriteLine("\nVälj ett alternativ");
    System.Console.WriteLine("1. Lägg till vara");
    System.Console.WriteLine("2. Ta bort vara");

    string? menuChoice = Console.ReadLine();

    if (menuChoice == "1")
    {
        // Menyval 1: Lägg till vara
    }
    else if (menuChoice == "2")
    {
        // Menyval 2: Ta bort vara
    }
    else
    {
        // ERROR 404
        System.Console.WriteLine("Felaktig inmatning");
    }
}