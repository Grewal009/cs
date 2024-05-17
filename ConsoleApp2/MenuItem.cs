namespace ConsoleApp2;

public class MenuItem
{
    public Random Spinner = new Random();
    
    // from c#12 we can use collection expression to initialize array
    public string[] Proteins = ["Roast beef", "Salami", "Turkey", "Ham", "Tofu"];
    public string[] Condiments = ["yellow mustard", "brown mustard", "honey mustard", "mayo", "french dressing"];
    public string[] Breads = ["white", "wheat", "korn", "grove", "a roll"];
    public string? Description;
    public string? Price;
    
    public void Generator()
    {
        string randomProtein = Proteins[Spinner.Next(Proteins.Length)];
        string randomCondiment = Condiments[Spinner.Next(Condiments.Length)];
        string randomBread = Breads[Spinner.Next(Breads.Length)];
        Description = $"{randomProtein} with {randomCondiment} on {randomBread}";
        
        if (Description.Length>=40 && Description.Length<47)
        {
            Console.Write($"{Description}\t");
        }
        else if (Description.Length>=32 && Description.Length<=39)
        {
            Console.Write($"{Description}\t\t");
        }
        else if (Description.Length>=24 && Description.Length<=31)
        {
            Console.Write($"{Description}\t\t\t");
        }
        else
        {
            Console.Write($"{Description}\t\t\t\t");

        }








        decimal bucks = Spinner.Next(30, 40);
        decimal cents = Spinner.Next(1, 99);
        decimal price = bucks + (cents * 0.1M);
        Price = price.ToString("C");
        Console.WriteLine(Price);
     
    }

}