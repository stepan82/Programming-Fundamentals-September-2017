using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teamwork_projects
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfTeams = int.Parse(Console.ReadLine());

            SortedDictionary<string, string> creatorsAndTeams = new SortedDictionary<string, string>();

            SortedDictionary<string, List<string>> teamsAndMembers = new SortedDictionary<string, List<string>>();
           
            //start creating teams
            for (int i = 0; i < numberOfTeams; i++)
            {
                var tokens = Console.ReadLine().Split('-').ToArray();
                string creatorName = tokens[0];
                string teamName = tokens[1];

                if (!creatorsAndTeams.ContainsKey(creatorName) && !creatorsAndTeams.ContainsValue(teamName))
                {
                    creatorsAndTeams.Add(creatorName, teamName);
                    teamsAndMembers.Add(teamName, new List<string>());
                    teamsAndMembers[teamName].Add(creatorName);
                    Console.WriteLine($"Team {teamName} has been created by {creatorName}!");
                }
                else if (creatorsAndTeams.ContainsKey(creatorName))
                {
                    Console.WriteLine($"{creatorName} cannot create another team!");
                }

                else if (creatorsAndTeams.ContainsValue(teamName))
                {
                    Console.WriteLine($"Team {teamName} was already created!");
                }
            }
            //teams have been created!!!

            //start assigning 
            while (true)
            {
                var tokens_2 = Console.ReadLine().Split(new string[] { "->" }, StringSplitOptions.None).ToArray();
                if (tokens_2[0] == "end of assignment")
                {
                    break;
                }
                string memberName = tokens_2[0];
                string teamName = tokens_2[1];

                if (!teamsAndMembers.ContainsKey(teamName))
                {
                    Console.WriteLine($"Team {teamName} does not exist!");
                }

                else if (creatorsAndTeams.ContainsKey(memberName) || teamsAndMembers.Where(c => c.Value.Contains(memberName)).Any())
                {
                    Console.WriteLine($"Member {memberName} cannot join team {teamName}!");
                }

                else if (!teamsAndMembers[teamName].Contains(memberName))
                {
                    teamsAndMembers[teamName].Add(memberName);
                }
            }
            //end of assignments loop


            // start printing output
            foreach (var team in teamsAndMembers.OrderByDescending(o => o.Value.Count))
            {
                if (team.Value.Count > 1)
                {
                    Console.WriteLine(team.Key);
                }

                if (team.Value.Count > 1)
                {

                    for (int i = 0; i < team.Value.Count; i++)
                    {
                        if (i == 0)
                        {
                            Console.WriteLine($"- {team.Value[0]}");
                        }
                        else
                        {
                            Console.WriteLine($"-- {team.Value[i]}");
                        }
                        
                    }
                }
            }

            Console.WriteLine("Teams to disband:");
            foreach (var team in teamsAndMembers)
            {
                if (team.Value.Count < 2)
                {
                    Console.WriteLine(team.Key);
                }
            }

            //end of printing output

        }
    }
}
