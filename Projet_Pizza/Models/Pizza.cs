using System.Linq;

namespace Projet_Pizza.Models
{
    public class Pizza
    {
        #region  Constructors
        public Pizza(string name, float price, bool vegetarian, List<string> ingredients)
        {
            Name = name;
            Price = price;
            Vegetarian = vegetarian;
            Ingredients = ingredients;
        }
        public Pizza()
        {
        }
        #endregion
        #region Property
        public string Name { get; private set; }
        public float Price { get; protected set; }
        public bool Vegetarian { get; private set; }
        public List<string> Ingredients { get; protected set; }
        #endregion
        #region Method
        public void Afficher()
        {
            string layoutVege = Vegetarian ? "(V)" : "";
            string nameMajMin = NomMajpuisMin(Name);
            List<string> ingredientMajmin = Ingredients.Select(i => NomMajpuisMin(i)).ToList();

            Console.WriteLine($"{nameMajMin} {layoutVege} - {Price} euros");
            Console.WriteLine(string.Join(", ", ingredientMajmin));
            Console.WriteLine();
        }
        public static string NomMajpuisMin(string s)
        {
            string nameLower = s.ToLower();
            string nameUpper = s.ToUpper();
            if (string.IsNullOrEmpty(s))
            {
                return s;
            }
            string nameAfficher = nameUpper[0] + nameLower[1..];
            return nameAfficher;
        }
        public static List<Pizza> TrierPrixAsc(List<Pizza> listePizza) 
        {
            return listePizza.OrderBy(p => p.Price).ToList();
        }
        public static List<Pizza> TrierPrixDesc(List<Pizza> listePizza)
        {
            return listePizza.OrderByDescending(p => p.Price).ToList();
        }
        public static Pizza PizzaLaMoinsChere (List<Pizza> pizzaList)
        {
            Pizza pizzaLowCost = pizzaList[0];
            foreach (Pizza pizza in pizzaList)
            {
                if (pizzaLowCost.Price > pizza.Price)
                {
                    pizzaLowCost = pizza;
                }
            }
            return pizzaLowCost;
        }
        public static Pizza PizzaLaPlusCher(List<Pizza> pizzaList)
        {
            Pizza pizzaGold = pizzaList[0];
            foreach (Pizza pizza in pizzaList)
            {
                if (pizzaGold.Price < pizza.Price)
                {
                    pizzaGold = pizza;
                }
            }
            return pizzaGold;
        }
        public static List<Pizza> PizzaVege (List<Pizza> pizzaList)
        {
            return pizzaList.Where(p => p.Vegetarian == true).ToList();
        }
        public static List<Pizza> ContientIngredient (List<Pizza> pizzaList, string ingredient)
        {
            return pizzaList.Where(p => p.Ingredients.Where(i => i.ToLower().Contains(ingredient)).ToList().Count > 0).ToList();
        }
        #endregion
    }
}
