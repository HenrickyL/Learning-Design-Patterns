using _2_builder.Builder;
using _2_builder.Product;

namespace _2_builder.Director;
public class Pizzaria
{
    private readonly PizzaBuilder _builder;
    public Pizzaria(PizzaBuilder builder) { 
        this._builder = builder;
    }

    //construct method
    public void MontaPizza() {
        _builder.CriaPizza();
        _builder.PreparaMassa();
        _builder.IncluiIngredientes();
    }

    public Pizza GetPizza() { 
        return _builder.GetPizza();
    }
}
