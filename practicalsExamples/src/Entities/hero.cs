namespace src.Entities
{
    public class Hero
    {
        public Hero(string Name, string Class)
    {
        this.Name = Name;
        this.Class = Class;
        this.Level = 1;
        this.Health = 30;
        this.Mana = 25;
    }
        public string Name { get; set; }
        public int Level { get; set; }
        public int Health { get; set; }
        public int Mana { get; set; }
        public string Class { get; set; }

        public override string ToString (){
            return $" Name: {this.Name} \nLevel: {this.Level} \nHealth: {this.Health} \nMana: {this.Mana} \nClass: {this.Class}";
        }
        public virtual string Atack(){
            Random dice = new Random();
            int power = this.Level + dice.Next(1, 20);
            
            return this.Name + " Atack with your sword and give " + power + " damage";
        }
    }
    
    
}