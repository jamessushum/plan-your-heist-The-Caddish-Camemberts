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
            int difficultyLevel = getDifficultyLevel();

            Team team = start();
            int TeamSkills = team.AddTeamSkills();
            // team.DisplayTeamMembers();
            int trials = getTrials();
            Bank aBank = new Bank(difficultyLevel);
            int Difficulty = aBank.difficulty;
            int count = 0;
            int success = 0;
            int failed = 0;
            do
            {
                string attempt = BankHeist(TeamSkills, Difficulty);
                if (attempt == "success")
                {
                    success++;
                }
                else
                {
                    failed++;
                }
                count++;
            } while (count < trials);
            Console.WriteLine($"Number of successful runs: {success}");
            Console.WriteLine($"Number of failed runs: {failed}");
            Console.WriteLine("COMPLETE!");

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
                Console.WriteLine($"Enter {memberName}'s skill level (between 1 and 10): ");
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
                Console.WriteLine($"Enter {memberName}'s courage factor (between 0.0 and 2.0): ");
                memberCourageFactor = Console.ReadLine();
            }
            while ((double.TryParse(memberCourageFactor, out courageFactor) == false));

            return courageFactor;
        }

        public static string BankHeist(int TeamSkills, int Difficulty)
        {
            int luckvalue = new Random().Next(-10, 10);
            int BankLikelyhood = luckvalue + Difficulty;
            Console.WriteLine($"Bank value {BankLikelyhood}");
            Console.WriteLine($"Team combined skill = {TeamSkills}");

            if (TeamSkills >= BankLikelyhood)
            {
                Console.WriteLine("Congratulations!! You've robbed aBank");
                return "success";
            }
            else
            {
                Console.WriteLine("Welcome to Jail!");
                return "failed";
            }
        }
        public static int getTrials()
        {
            int result = 0;
            string response;
            do
            {
                Console.WriteLine("How many attemps will you make?");
                response = Console.ReadLine();

            } while (Int32.TryParse(response, out result) == false);
            return result;
        }

        public static int getDifficultyLevel()
        {
            string response;
            int result = 0;
            do
            {
                Console.WriteLine("Choose a level of difficulty (E) (M) (H): ");
                response = Console.ReadLine().ToLower();

            }
            while (response != "e" && response != "m" && response != "h");
            if (response == "e")
            {
                result = new Random().Next(0, 30);

            }
            else if (response == "m")
            {
                result = new Random().Next(10, 60);
            }
            else if (response == "h")
            {
                result = new Random().Next(20, 100);
            }
            return result;
        }
    }

}