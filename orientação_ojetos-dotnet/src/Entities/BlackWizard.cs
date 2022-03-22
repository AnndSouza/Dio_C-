namespace orientação_ojetos_dotnet.src.Entities
{
    public class BlackWizard : Hero
    {
        public BlackWizard(string Name,int Level,string HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }
         public override string Attack(){
            return this.Name + "" + " Dark Magic was launched";

        }

        public string Attack(int Bonus){
            return this.Name + " "+ "Launched a Critical Dark Magic" + Bonus;
        }
    }
}