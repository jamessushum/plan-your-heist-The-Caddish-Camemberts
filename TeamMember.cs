namespace plan_your_heist_THE_CADDISH_CAMEMBERTS
{
    public class TeamMember
    {
        public string memberName { get; set; }
        public int skillLevel { get; set; }
        public double courageFactor { get; set; }
        public TeamMember(string memberName, int skillLevel, double courageFactor)
        {
            this.memberName = memberName;
            this.skillLevel = skillLevel;
            this.courageFactor = courageFactor;
        }


    }

}