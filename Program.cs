using System;
public class HighItem
{
    public string Name;
    public int Points;
    public HighItem(string name, int points)
    {
        Name = name;
        Points = points;
    }
}

public class HighScore
{
    public List<HighItem> Persons = new List<HighItem>();
    public HighScore(int MaxInList)
    {
        Persons = new List<HighItem>(MaxInList);
    }
    public void Add(string name, int points)
    {
        Persons.Add(new HighItem(name, points));
    }
    
}
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Write the maximum number of players");
        int number = Convert.ToInt32(Console.ReadLine());
        HighScore hs = new HighScore(number);
        for (int i = 0; i < number; i++)
        {
            Console.WriteLine("Write your name and points");
            string n = Console.ReadLine();
            int p = Convert.ToInt32(Console.ReadLine());
            hs.Add(n, p);
        }
        Bubblesort(hs.Persons);
        foreach (var person in hs.Persons)
        {
            Console.WriteLine($"Name: {person.Name}, Points: {person.Points}");
        }
    }

    static void Bubblesort(List<HighItem> list)
    {
        int nl = list.Count;
        for (int i = 0; i < nl - 1; i++)
        {
            for (int j = 0; j < nl - i - 1; j++)
            {
                if (list[j].Points > list[j + 1].Points)
                {
                    HighItem Temp = list[j];
                    list[j] = list[j + 1];
                    list[j + 1] = Temp;
                }
            }
        }
    }
}