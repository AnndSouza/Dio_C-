namespace orientação_ojetos_dotnet.src.Entities
{
    public class Wizard : Hero
    {
        public Wizard(string Name,int Level,string HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }
         public override string Attack(){
            return this.Name + " Lançou Magia";

        }

        public string Attack(int Bonus){
            
            if (Bonus > 6){
                return this.Name + " "+ "Launched Magic of critical Attack: "+ Bonus;
            
        } else{
            return this.Name + " "+ "Launched a Magic Attack: "+ Bonus;
        }

    }
}
}