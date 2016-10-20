namespace SuperHeroseApi.Models
{
    using System.Collections.Generic;

    public class SuperHero : DataModel
    {
        private ICollection<Perk> perks;

        public SuperHero()
        {
            this.perks = new HashSet<Perk>();
        }

        public string Name { get; set; }

        public int Strength { get; set; }

        public int Preception { get; set; }

        public int Endurance { get; set; }

        public int Charisma { get; set; }

        public int Intelligence { get; set; }

        public int Agility { get; set; }

        public int Luck { get; set; }

        public virtual ICollection<Perk> Perks
        {
            get { return this.perks; }

            set { this.perks = value; }
        }
    }
}
