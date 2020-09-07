using System;

namespace HeistPart2
{
    public class Muscle : IRobber
    {
        public string Name { get; set; }
        public int SkillLevel { get; set; }
        public int PercentageCut { get; set; }

        public void PerformSkill(Bank bank)
        // SecurityGuard - SkillLevel
        {
            bank.SecurityGuardScore -= SkillLevel;
            if (bank.SecurityGuardScore <= 0)
            {
                Console.WriteLine($"{Name} has taken care of the guards");
            }
            else
            {
                Console.WriteLine($"{Name} is taking care of the security guard. Decreased {SkillLevel} by 50 points");
            }

        }
    }
}