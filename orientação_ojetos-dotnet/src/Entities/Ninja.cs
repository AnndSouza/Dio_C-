namespace orientação_ojetos_dotnet.src.Entities
{
    public class Ninja : Hero
    {
         public Ninja(string Name,int Level,string HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }
         public override string Attack(){
            return this.Name + "" + " Launched knife";

        }

        public string Attack(int Bonus){
            return this.Name + " "+ "Launched a Attack stealth" + Bonus;
        }
    }
}