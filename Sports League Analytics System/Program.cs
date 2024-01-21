using System;
using System.Text;

class Program
{
    static string[] TeamName = { "Real Madrid", "Barcelona", "Bayern Munich", "Juventus", "Paris Saint-Germain" };
    static int[,] TeamPoints = new int[,]
    {
        { 2, 1, 0, 3, 2 },   // Points for Real Madrid in 5 matches
        { 1, 3, 1, 0, 2 },   // Points for Barcelona in 5 matches
        { 0, 1, 1, 1, 3 },   // Points for Bayern Munich in 5 matches
        { 2, 0, 3, 1, 1 },   // Points for Juventus in 5 matches
        { 3, 2, 1, 0, 0 }    // Points for Paris Saint-Germain in 5 matches
    };

    static int LeagueSize = TeamName.Length;
    static int MatchNo = TeamPoints.GetLength(1);

    static int[] totalPoints;
    static int[,] matchResults;

    static void Main()
    {
        totalPoints = new int[LeagueSize];
        matchResults = new int[LeagueSize, 4];

        CalculateTotalPoints();
        CountMatchResults();

        Console.WriteLine("-------------------------------------------------------------");
        Console.WriteLine("| Subject    : PROG8050 High Quality Software Programming   |");
        Console.WriteLine("| Name       : Meet Sheth                                   |");
        Console.WriteLine("| Student ID : 8881984                                      |");
        Console.WriteLine("| Date       : 5th July 2023                                |");
        Console.WriteLine("-------------------------------------------------------------\n \n");

        Console.WriteLine("Welcome to the Football league.\n ");
        Console.WriteLine("Here you'll be able to check the All Team's score, the table toppers and the table bottomers.\n \n ");


        while (true)
        {
            Console.WriteLine("Please select the option from below menu.");
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("1. See the score card");
            Console.WriteLine("2. Team at the Top of the table");
            Console.WriteLine("3. Team at the Bottom of the table");
            Console.WriteLine("4. Exit");

            Console.Write("\nEnter your choice: ");
            string choice = Console.ReadLine();

            Console.WriteLine();

            switch (choice)
            {
                case "1":
                    Console.WriteLine("Here is the list of all teams with their respective scores");
                    OutputTeamInfo();
                    break;
                case "2":
                    FindTeamWithHighestPoints();
                    break;
                case "3":
                    FindTeamWithLowestPoints();
                    break;
                case "4":
                    Console.WriteLine("Exiting...");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }


            Console.WriteLine("\n------------------------\n");
            Console.WriteLine("Individual Team score of your choice\n");
            string teamName = "Real Madrid";
            string teamStats = GetTeamStats(teamName);
            Console.WriteLine(teamStats);
            Console.WriteLine("\n================== \n");
        }
    }

    static void CalculateTotalPoints()
    {
        totalPoints = new int[LeagueSize];
        for (int i = 0; i < LeagueSize; i++)
        {
            int teamTotalPoints = 0;
            for (int j = 0; j < MatchNo; j++)
            {
                teamTotalPoints += TeamPoints[i, j];
            }
            totalPoints[i] = teamTotalPoints;
        }
    }

    static void CountMatchResults()
    {
        matchResults = new int[LeagueSize, 4];
        for (int i = 0; i < LeagueSize; i++)
        {
            int awayWins = 0, homeWins = 0, drawnMatches = 0, lostMatches = 0;
            for (int j = 0; j < MatchNo; j++)
            {
                int points = TeamPoints[i, j];
                switch (points)
                {
                    case 3:
                        awayWins++;
                        break;
                    case 2:
                        homeWins++;
                        break;
                    case 1:
                        drawnMatches++;
                        break;
                    case 0:
                        lostMatches++;
                        break;
                }
            }
            matchResults[i, 0] = awayWins;
            matchResults[i, 1] = homeWins;
            matchResults[i, 2] = drawnMatches;
            matchResults[i, 3] = lostMatches;
        }
    }

    static void OutputTeamInfo()
    {
        for (int i = 0; i < LeagueSize; i++)
        {
            Console.WriteLine("------------------------");
            Console.WriteLine("Team Name: " + TeamName[i]);
            Console.WriteLine("    Total Points: " + totalPoints[i]);
            Console.WriteLine("    Away Wins: " + matchResults[i, 0]);
            Console.WriteLine("    Home Wins: " + matchResults[i, 1]);
            Console.WriteLine("    Drawn Matches: " + matchResults[i, 2]);
            Console.WriteLine("    Lost Matches: " + matchResults[i, 3]);
        }
    }

    static void FindTeamWithHighestPoints()
    {
        int highestPoints = int.MinValue;
        string teamWithHighestPoints = "";
        for (int i = 0; i < LeagueSize; i++)
        {
            if (totalPoints[i] > highestPoints)
            {
                highestPoints = totalPoints[i];
                teamWithHighestPoints = TeamName[i];
            }
        }
        Console.WriteLine("Team with the highest total points is " + teamWithHighestPoints + " with " + highestPoints + " points and Tops the table.");
    }

    static void FindTeamWithLowestPoints()
    {
        int lowestPoints = int.MaxValue;
        string teamWithLowestPoints = "";
        for (int i = 0; i < LeagueSize; i++)
        {
            if (totalPoints[i] < lowestPoints)
            {
                lowestPoints = totalPoints[i];
                teamWithLowestPoints = TeamName[i];
            }
        }
        Console.WriteLine("Team with the lowest total points is " + teamWithLowestPoints + " with " + lowestPoints + " points and stays at the bottom of the table.");
    }

    static string GetTeamStats(string teamName)
    {
        for (int i = 0; i < TeamName.Length; i++)
        {
            if (TeamName[i] == teamName)
            {
                int teamTotalPoints = totalPoints[i];
                int awayWins = matchResults[i, 0];
                int homeWins = matchResults[i, 1];
                int drawnMatches = matchResults[i, 2];
                int lostMatches = matchResults[i, 3];

                string teamStats = $"Team Name: {teamName}\n" +
                               $"Total Points: {teamTotalPoints}\n" +
                               $"Away Wins: {awayWins}\n" +
                               $"Home Wins: {homeWins}\n" +
                               $"Drawn Matches: {drawnMatches}\n" +
                               $"Lost Matches: {lostMatches}\n";

                return teamStats;
            }
        }

        return "Team not found.";
    }
}
