using System.Linq;

namespace _2_builder.Product;
public class Pizza
{
    public TipoMassa TipoMassa { get; set; }
    public TipoBorda TipoBorda { get; set; }
    public Tamanho Tamanho { get; set; }
    public List<string> Ingredientes { get; set; }

    public void PizzaConteudo()
    {
        Console.WriteLine($"Pizza com massa: {TipoMassa}");
        Console.WriteLine($"Tipo de borda: {TipoBorda}");
        Console.WriteLine($"Tamanho: {Tamanho}");
        Console.WriteLine("ingredientes: " + String.Join(",", Ingredientes));
        Console.WriteLine("\n\n");
    }
}
