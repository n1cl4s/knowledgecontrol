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
    // Användaren får mata in varan och priset
    System.Console.WriteLine("Vad heter varan?");
    string Item = Console.ReadLine();
    System.Console.WriteLine("Vad kostar varan?");
    string priceInput = Console.ReadLine();

    // Kollar så det är rätt inmatning
    bool success = int.TryParse(priceInput, out int Price);

    if (success)
    {
    // Lägger till varan i listan OM matningen är rätt
   items.Add(Item);
   price.Add(Price);
    }
    else
    {
    // Annars om det är fel inmatning så får användaren en ny chans
    System.Console.WriteLine("Felaktig inmatning, använd heltal");
    }

    }
    else if (menuChoice == "2")
    {
    // Ta bort en vara
    System.Console.WriteLine("Vilket nummer har varan du vill ta bort?");
    string removeInput = Console.ReadLine();
    // Läser in vilken vara som ska tas bort (nummer)
    bool removeSuccess = int.TryParse(removeInput, out int removeNumber);
    // Identifierar varan
    int index = removeNumber -1;
    
    // Om numret är ogiltligt eller finns inte
    // får man chans till ny inmatning
    if (!removeSuccess || index < 0 || index >= items.Count)
        {
            System.Console.WriteLine("Ogilitigt nummer.");
            continue;
        }
        // Varan tas bort från listan
        items.RemoveAt(index);
        price.RemoveAt(index);
    }
    else
    {
        // ERROR 404
        System.Console.WriteLine("Felaktig inmatning");
    }
}