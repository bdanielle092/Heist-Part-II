using System;

namespace HeistPart2
{
    public class Hacker : IRobber
    {
        public string Name { get; set; }
        public int SkillLevel { get; set; }
        public int PercentageCut { get; set; }

        // Bank is the class and bank is the parameter
        public void PerformSkill(Bank bank)
        // AlarmScore - SkillLevel 
        {
            bank.AlarmScore -= SkillLevel;
            if (bank.AlarmScore <= 0)
            {
                Console.WriteLine($"{Name} has disabled the alarm system");
            }
            else
            {
                Console.WriteLine($"{Name} is hacking the alarm. Decreased {SkillLevel} by 50 points");
            }

        }
    }

}