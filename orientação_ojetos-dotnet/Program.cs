using System;
using orientação_ojetos_dotnet.src.Entities;

namespace orientação_ojetos_dotnet
{
    class Program
    {        
        public static void Main(string[] args) 
        {
            Hero knight = new Knight("Arus", 42, "Knight");
            Wizard wizard = new Wizard("Jennica", 42, "White Wizard");
            Ninja ninja = new Ninja("Wedge", 42, "Ninja");
            BlackWizard blackWizard = new BlackWizard("Topapa", 42, "Black Wizard");
          
            
            Console.WriteLine(knight.Attack());
            Console.WriteLine(wizard.Attack());
            Console.WriteLine(ninja.Attack());
            Console.WriteLine(blackWizard.Attack());
        }
 

    }
  
}