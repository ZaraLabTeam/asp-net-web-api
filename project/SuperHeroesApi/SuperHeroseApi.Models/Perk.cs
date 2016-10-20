namespace SuperHeroseApi.Models
{
    public class Perk : DataModel
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public int StrengthBonus { get; set; }

        public int PreceptionBonus { get; set; }

        public int EnduranceBonus { get; set; }

        public int CharismaBonus { get; set; }

        public int IntelligenceBonus { get; set; }

        public int AgilityBonus { get; set; }

        public int LuckBonus { get; set; }
    }
}
