namespace RPG.src.Entities
{
    public class Wizard : Hero
    {
        public Wizard(string Name, int Level, string HeroType) : base(Name, Level, HeroType)
        {
        }

        public override string Attack()
        {
            return this.Name + " Lançou Magia!";
        }

        public string Attack(int Bonus)
        {
            if (Bonus > 6)
            {
                return this.Name + " Lançou Magia super efetiva com bonus de " + Bonus;
            }
            else
            {
                return this.Name + " Lançou Magia fraca com bonus de " + Bonus;
            }
        }
    }
}