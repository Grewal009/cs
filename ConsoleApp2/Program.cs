namespace ConsoleApp2;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Student s1 = new Student(){ Name = "Sam",Grade = 5 };
        Student s2 = new Student() { Name = "Tom", Grade = 7 };
        Student s3 = new Student() { Name = "Jas", Grade = 4 };
        Console.Write("s1 => ");
        s1.WhoAmI();
        Console.Write("s2 => ");
        s2.WhoAmI();
        Console.Write("s3 => ");
        s3.WhoAmI();
        
        s1.HearMessage("Hello!",s2);
        s1.SpeakTo(s2,"Hei!");
        
        Random random = new Random();
        int num = random.Next(100,150);
        Console.WriteLine($"random number between 100-150 is {num}");

        int num1 = random.Next(10);
        Console.WriteLine($"random number betwen 0-9 is {num1}");

        double num2 = random.NextDouble();
        Console.WriteLine($"random number between 0.0-1.0 is {num2}");

        int flip = random.Next(2);
        Console.WriteLine(Convert.ToBoolean(flip)+" "+flip);
        Console.WriteLine(Convert.ToBoolean(100)); //if 0 then False else True
        Console.WriteLine();
        Console.WriteLine("\t\t\tMENU");
        Console.WriteLine("------------------------------------------------------------");
        Console.WriteLine("Item\t\t\t\t\t\tprice");
        MenuItem item1 = new MenuItem();
        item1.Generator();
        MenuItem item2= new MenuItem();
        item2.Generator();
        MenuItem item3 = new MenuItem();
        item3.Generator();
        MenuItem item4 = new MenuItem();
        item4.Generator();
        MenuItem item5 = new MenuItem();
        item5.Generator();
    }
}