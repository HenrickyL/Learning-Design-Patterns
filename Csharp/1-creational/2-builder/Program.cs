using _2_builder.ConcreteBuilder;
using _2_builder.Director;
using _2_builder.Product;

public class Program {
    public static void Main(string[] args) {

        Pizzaria pizzaria1 = new Pizzaria(new PizzaMussarela());
        Pizzaria pizzaria2 = new Pizzaria(new PizzaCalabresa());

        pizzaria1.MontaPizza();
        Pizza pizza1 = pizzaria1.GetPizza();
        pizza1.PizzaConteudo();
        pizzaria2.MontaPizza();
        Pizza pizza2 = pizzaria2.GetPizza();
        pizza2.PizzaConteudo();
    }
}