using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("How many entries? ");
        var lines = int.Parse(Console.ReadLine());

        var team = new Team("Team lexicon");
        for (int i = 0; i < lines; i++)
        {
            Console.WriteLine("Enter First name and age: ");
            var cmdArgs = Console.ReadLine().Split();
            var person = new Person(cmdArgs[0], int.Parse(cmdArgs[1]));

            team.AddPlayer(person);
        }

        Console.WriteLine("\n" + team.TeamName + "\n");
        Console.WriteLine($"First team has{team.FirstTeam.Count} players");
        Console.WriteLine($"Reserve team has{team.ReserveTeam.Count} players");

    }
}