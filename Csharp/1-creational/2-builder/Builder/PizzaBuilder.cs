using _2_builder.Product;

namespace _2_builder.Builder;
public abstract class PizzaBuilder
{
    protected Pizza pizza;
    public void CriaPizza() { 
        pizza = new Pizza();
    }

    public Pizza GetPizza() { 
        return pizza;
    }

    public abstract void PreparaMassa();
    public abstract void IncluiIngredientes();

}
