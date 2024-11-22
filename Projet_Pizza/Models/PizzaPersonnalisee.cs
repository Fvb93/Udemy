using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_Pizza.Models
{
    public class PizzaPersonnalisee : Pizza
    {
        #region  Constructors
        public PizzaPersonnalisee() : base($"personalisee {NbPerso}", 5f, false ,null)
        {
            Console.WriteLine($"Pizza personalisee {NbPerso} : ");
            NbPerso++;
            Ingredients = new List<string> { };
            while (true)
            {
                Console.WriteLine("Ajouter un ingrédient (ENTER pour terminer) : ");
                var ingredient = Console.ReadLine();
                if(string.IsNullOrWhiteSpace(ingredient))
                {
                    break;
                }
                if (Ingredients.Contains(ingredient)) 
                {
                    Console.WriteLine("L'ingrédient a déjà été choisi !");
                }
                else
                {
                    Ingredients.Add(ingredient);
                    Console.WriteLine("Liste des ingrédients : " + string.Join(" ,", Ingredients));
                }
                Console.WriteLine();
            }
            Price = 5f + Ingredients.Count() * 1.5f;
        }
        #endregion
        #region Property
        public static int NbPerso = 1;
        #endregion
        #region Method
        #endregion
    }
}
