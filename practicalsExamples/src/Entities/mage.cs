namespace src.Entities
{
    public class Mage : Hero
    {
        public Mage(string Name, string Class): base(Name, Class)
        {
            this.Name = Name;
            this.Class = Class;
            this.Level = 1;
            this.Health = 15;
            this.Mana = 50;
            
        }
        public override string Atack(){
            Random dice = new Random();
            int power = this.Level + dice.Next(1, 4);
            
            return this.Name + " Atack with your staff and give " + power + " damage";
        }
        public string Atack(int bonus) {
            Random dice = new Random();
            int power = this.Level + dice.Next(1,4) + bonus;
            return this.Name + " Atack with your staff and give " + power + " damage with the bonus";
        }
    }
}