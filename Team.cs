using System;
using System.Collections.Generic;

namespace plan_your_heist_THE_CADDISH_CAMEMBERTS
{
    public class Team
    {
        public Dictionary<string, TeamMember> TeamList = new Dictionary<string, TeamMember>();

        public void AddMember(TeamMember member)
        {
            TeamList.Add(member.memberName, member);
        }
    }
}