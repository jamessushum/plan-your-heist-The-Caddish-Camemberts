using System;
using System.Collections.Generic;

namespace plan_your_heist_THE_CADDISH_CAMEMBERTS {
    public class Team {
        public Dictionary<string, TeamMember> TeamList = new Dictionary<string, TeamMember> ();

        public void AddMember (TeamMember member) {
            TeamList.Add (member.memberName, member);
        }
        public void DisplayTeamMembers () {
            DisplayCount ();
            foreach (KeyValuePair<string, TeamMember> teamMember in TeamList) {
                Console.WriteLine ($"Name: {teamMember.Key}");
                Console.WriteLine ($"Skill: {teamMember.Value.skillLevel}");
                Console.WriteLine ($"Courage: {teamMember.Value.courageFactor}");
                Console.WriteLine ("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            }

        }
        public void DisplayCount () {
            Console.WriteLine ($"Team Count: {TeamList.Count}");
        }

        public int AddTeamSkills ()

        {
            int TotalSkills = 0;

            foreach (KeyValuePair<string, TeamMember> member in TeamList) {
                TotalSkills += member.Value.skillLevel;
            }

            return TotalSkills;
        }
    }
}