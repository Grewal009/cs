namespace ConsoleApp2;

public class Student
{
    public string Name;
    public int Grade;

    public void WhoAmI()
    {
        Console.Write($"My name is {Name}. ");
        Console.WriteLine($"I am Studying in {Grade} grade.");
    }

    public void HearMessage(string message, Student whoSaidIt)
    {
        Console.Write($"{Name} heard a message. ");
        Console.WriteLine($"{whoSaidIt.Name} said this: {message}");
    }

    public void SpeakTo(Student whoToTalkTo, string message)
    {
        whoToTalkTo.HearMessage(message,this);
    }

}