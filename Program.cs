using System;

namespace plan_your_heist_THE_CADDISH_CAMEMBERTS
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Plan Your Heist!");
            Console.WriteLine("----------------");

            Team team = start();
            team.DisplayTeamMembers();

        }
        public static Team start()
        {
            Team Ateam = new Team();
            bool exit = true;
            while (exit)
            {


                // Get member name
                Console.WriteLine("Enter a team member's name: ");
                string memberName = Console.ReadLine();
                Console.WriteLine(memberName);
                if (memberName.Length == 0)
                {
                    return Ateam;
                }
                // Get member skill level
                int skillLevel;
                do
                {
                    skillLevel = enterSkillLevel(memberName);
                }
                while (skillLevel < 1 || skillLevel > 10);

                // Get member courage factor
                double courageFactor;
                do
                {
                    courageFactor = enterCourageFactor(memberName);
                }
                while (courageFactor < 0.0 || courageFactor > 2.0);

                Console.WriteLine(memberName);
                Console.WriteLine(skillLevel);
                Console.WriteLine(courageFactor);

                Ateam.AddMember(new TeamMember(memberName, skillLevel, courageFactor));
            }
            return Ateam;
        }

        // Method gets user skill level string and returns integer
        public static int enterSkillLevel(string memberName)
        {
            string memberSkillLevel;
            int skillLevel;
            do
            {
                Console.WriteLine($"Enter {memberName}'s skill level (between 1 to 10): ");
                memberSkillLevel = Console.ReadLine();
            }
            while ((int.TryParse(memberSkillLevel, out skillLevel) == false));

            return skillLevel;
        }

        // Method gets user courage factor string and return integer
        public static double enterCourageFactor(string memberName)
        {
            string memberCourageFactor;
            double courageFactor;
            do
            {
                Console.WriteLine($"Enter {memberName}'s courage factor (between 0.0 to 2.0): ");
                memberCourageFactor = Console.ReadLine();
            }
            while ((double.TryParse(memberCourageFactor, out courageFactor) == false));

            return courageFactor;
        }
    }
}