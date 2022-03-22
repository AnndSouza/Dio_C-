namespace orientação_ojetos_dotnet.src.Entities
{
    public class Knight : Hero
    {
         public Knight(string Name,int Level,string HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }
         public override string Attack(){
            return this.Name + "" + " Attack at sword";

        }

        public string Attack(int Bonus){
            return this.Name + " "+ "Launched a critical Attack at sword slash";
        }
    }
}