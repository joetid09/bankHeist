using System;
using System.Collections.Generic;
using System.Linq;

namespace Heist
{
    class Program
    {
        static void Main(string[] args)
        {
            int teamMateToken = 0;
            List<TeamMate> team = new List<TeamMate>();
            while (teamMateToken == 0)
            {


                TeamMate Ted = new TeamMate();
                Console.WriteLine("Plan Your Heist!");
                Console.WriteLine("Enter a name for a new teammate:");
                string proposedName = Console.ReadLine();
                if (proposedName != "")
                {
                    Ted.AddName(proposedName);
                }
                else
                {
                    break;
                }


                Console.WriteLine("Enter teammate Skill Level: ");
                string proposedSkillInput = Console.ReadLine();
                int proposedSkill = int.Parse(proposedSkillInput);
                Ted.AddSkillLevel(proposedSkill);

                Console.WriteLine("Enter teammate courage: ");
                string proposedCourageInput = Console.ReadLine();
                double proposedCourage = Convert.ToDouble(proposedCourageInput);
                Ted.AddCourage(proposedCourage);

                Console.WriteLine($"Teammate: {Ted.Name} - Skill {Ted.SkillLevel} - Courage: {Ted.Courage}");

                team.Add(Ted);
            }

            // Console.WriteLine(team.Count);
            // foreach (TeamMate member in team)
            // {
            //     Console.WriteLine($"TeamMate: {member.Name} Skill: {member.SkillLevel} Courage: {member.Courage}");
            // }

            Random rnd = new Random();
            int luckyNumber = rnd.Next(-10, 10);
            int bankDifficulty = 100 + luckyNumber;

            List<int> SkillCatcher = new List<int>();
            foreach (TeamMate member in team)
            {
                SkillCatcher.Add(member.SkillLevel);
            }

            int teamSkill = SkillCatcher.Sum();

            if (teamSkill > bankDifficulty)
            {
                Console.WriteLine($"With your powers combined, you have {teamSkill} total points!");
                Console.WriteLine($"The banks difficulty is: {bankDifficulty}!");
                Console.WriteLine("You've robbed a bank!");
            }
            else
            {
                Console.WriteLine($"With your powers combined, you have {teamSkill} total points!");
                Console.WriteLine($"The banks difficulty is: {bankDifficulty}");
                Console.WriteLine("You have failed!");
            }


        }



    }


}
