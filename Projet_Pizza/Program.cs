using Projet_Pizza.Models;

List<Pizza> ListPizza = new List<Pizza>()
{
    new Pizza("4 fromages", 11.5f , true, new List<string> {"gorgozola","emmental", "tomate","talegio", "mozzarela"}),
    new Pizza("Forestia", 9.5f , false, new List < string > { "tomate", "mozzarela", "jambon","champignon" }),
    new Pizza("Marguerita", 8f , true, new List < string > { "tomate", "mozarela" }),
    new Pizza("DuChef", 14f , false , new List < string > { "mozzarela", "gorgonzola", "samali piquant" }),
    new PizzaPersonnalisee(),
    new PizzaPersonnalisee()
};
    foreach (Pizza p in ListPizza)
{
    p.Afficher();
}
var prixAsc = Pizza.TrierPrixAsc(ListPizza);

foreach (Pizza p in prixAsc)
{
    p.Afficher();
}

var prixDesc = Pizza.TrierPrixDesc(ListPizza);

foreach (Pizza p in prixDesc)
{
    p.Afficher();
}

Pizza lamoinschere = Pizza.PizzaLaMoinsChere(ListPizza);
Console.WriteLine("La pizza la moins chere : "); 
lamoinschere.Afficher();

Pizza lapluschere = Pizza.PizzaLaPlusCher(ListPizza);
Console.WriteLine("La pizza la plus chere : ");
lapluschere.Afficher();

Console.WriteLine("Voici la liste des pizza végé : ");
foreach (Pizza p in Pizza.PizzaVege(ListPizza))
{
    p.Afficher();
}

Console.WriteLine("Voici la liste des pizza avec de la tomate : ");
foreach (Pizza p in Pizza.ContientIngredient(ListPizza, "tomate"))
{
    p.Afficher();
}