# High Quality Software Programming
## Midterm Project

*Duration 3 hours*

The one-dimensional (1D) array TeamName[] contains the names of teams in a sports league.
string[] TeamName = { "Real Madrid", "Barcelona", "Bayern Munich", "Juventus",
"Paris Saint-Germain" };
The two-dimensional (2D) array TeamPoints[] contains the points awarded for each match.
int[,] TeamPoints = new int[,]
{
{ 2, 1, 0, 3, 2 }, // Points for Team A in 5 matches
{ 1, 3, 1, 0, 2 }, // Points for Team B in 5 matches
{ 0, 1, 1, 1, 3 }, // Points for Team C in 5 matches
{ 2, 0, 3, 1, 1 }, // Points for Team D in 5 matches
{ 3, 2, 1, 0, 0 } // Points for Team E in 5 matches
};
The position of each team’s data in the two arrays is the same. For example, the team stored at index 4
in TeamName[] and TeamPoints[] is the same. The variable LeagueSize contains the number of teams in
the league. The variable MatchNo contains the number of matches played. All teams have played the
same number of matches. The arrays and variables have already been set up and the data stored. Each
match can be played at home or away.
Points are recorded for the match results of each team with the following values:
- 3 – away win
- 2 – home win
- 1 – drawn match
- 0 – lost match.
Here are the 5 tasks you should complete based on the above information.
1. Write a method named CalculateTotalPoints that calculates the total points for all matches
played for each team.
2. Write a method named CountMatchResults that counts the total number of away wins, home
wins, drawn matches, and lost matches for each team.
3. Write a method named OutputTeamInfo that outputs the name, total points, and the number of
away wins, home wins, drawn matches, and lost matches for each team.
4. Write a method
a. FindTeamWithHighestPoints that finds and outputs the name of the team with the
highest total points.
b. FindTeamWithLowestPoints that finds and outputs the name of the team with the
lowest total points.
5. Write a method named GetTeamStats that takes the name of a team as a parameter and returns
a string containing the team's total points, number of away wins, home wins, drawn matches,
and lost matches. The string should be formatted in a readable manner. *you do not have to ask
user for input here, I will test it on my end with an appropriate input
