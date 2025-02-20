using _2_builder.Builder;
using _2_builder.Product;

namespace _2_builder.ConcreteBuilder;
public sealed class PizzaMussarela : PizzaBuilder
{
    public override void IncluiIngredientes()
    {
        pizza.TipoMassa = TipoMassa.Normal;
        pizza.TipoBorda = TipoBorda.Recheada;
        pizza.Tamanho = Tamanho.Grande;
    }

    public override void PreparaMassa()
    {
        pizza.Ingredientes = new List<string> {
            "Mussarela","Oregano", "Molho de tomate"
        };
    }
}
