using _2_builder.Builder;
using _2_builder.Product;

namespace _2_builder.ConcreteBuilder;
public class PizzaCalabresa : PizzaBuilder
{
    public override void IncluiIngredientes()
    {
        pizza.TipoMassa = TipoMassa.Grossa;
        pizza.TipoBorda = TipoBorda.Normal;
        pizza.Tamanho = Tamanho.Grande;
    }

    public override void PreparaMassa()
    {
        pizza.Ingredientes = new List<string> { 
            "Calabresa em fatias", "Molho de tomate"
        };
    }
}
