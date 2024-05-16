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
      
    }
}