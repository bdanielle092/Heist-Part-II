using System;

namespace HeistPart2
{
    public class LockPickSpecialist : IRobber
    {
        public string Name { get; set; }
        public int SkillLevel { get; set; }
        public int PercentageCut { get; set; }

        public void PerformSkill(Bank bank)
        // VaultScore - SkillLevel
        {
            bank.VaultScore -= SkillLevel;
            if (bank.VaultScore <= 0)
            {
                Console.WriteLine($"{Name} has picked the lock");
            }
            else
            {
                Console.WriteLine($"{Name} is picking the lock on the vault. Decreased {SkillLevel} by 50 points");
            }

        }
    }
}