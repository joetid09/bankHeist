using System;
using System.Collections.Generic;

namespace Heist
{
    class Program
    {
        static void Main(string[] args)
        {
            int teamMateToken = 0;
            List<TeamMate> team = new List<TeamMate>();
            while (teamMateToken < 5)
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
                teamMateToken++;

            }

            Console.WriteLine(team.Count);
            foreach (TeamMate member in team)
            {
                Console.WriteLine($"TeamMate: {member.Name} Skill: {member.SkillLevel} Courage: {member.Courage}");
            }
        }



    }


}
