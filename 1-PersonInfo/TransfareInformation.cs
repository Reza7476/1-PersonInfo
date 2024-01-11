namespace _1_PersonInfo;

public abstract class TransfareInformation
{
    static List<Person> persons = new();

    public static void SavePersonInfo(string name, string lastName)
    {
        Person personInfo = new Person(name, lastName);
        personInfo.GenerateFullName();
        persons.Add(personInfo);
    }

    public static string GetFullName(string name, string lastName)
    {
        var personn = persons.Find(x => x.Name == name && x.LastName == lastName);
        if (personn == null)
        {
            throw new Exception();
        }
        return personn.FullName;
    }
   public static string GetString(string message)
    {
        Console.WriteLine(message);
        string value = Console.ReadLine()!;
        return value;
    }


    public static int Run()
    {
        int run;
        Console.WriteLine("\n 1: start\n 0: End");
        run = int.Parse(Console.ReadLine()!);
        return run;
    }

    public static void Error(string message)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"------------\n{message}\n-----------");
        Console.ResetColor();
    }

}

