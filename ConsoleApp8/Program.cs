using System;
using System.Linq;
using Data;
using Model;

using (var context = new FootballTeamDBContext())
{
    var teams = new[]
 {
 new FootballTeam { Name = "Barcelona", City = "Barcelona", WinCount = 20, LoseCount = 2, DrawCount = 6 },
 new FootballTeam { Name = "Real Madrid", City = "Madrid", WinCount = 18, LoseCount = 4, DrawCount = 6 },
 new FootballTeam { Name = "Atletico Madrid", City = "Madrid", WinCount = 16, LoseCount = 4, DrawCount = 8 }
};
    //context.Teams.AddRange(teams);
    //context.SaveChanges();
    var teams1 = context.Teams.ToList();
    Console.WriteLine("Game List");

    foreach (var team in teams1)
    {
        Console.WriteLine(team.ToString());
    }

}
