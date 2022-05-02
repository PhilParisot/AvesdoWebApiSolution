
using AvesdoWebApi;

public class Order
{
    public int Id { get; }
    private List<Pizza> Pizzas { get; set; }
    public bool Completed { get; }
    // public ShopAddress shopAddress...
    // public DestinationAddress destinationAddress...
    // public Distance distance...

    public Order(List<Pizza> pizzas)
    {
        if (pizzas is null)
            throw new ArgumentNullException(nameof(pizzas), $"{nameof(pizzas)} cannot be null");

        // Using Guid to genereate unique IDs and to avoid any potential enumeration vulnerabilities
        this.Id = int.Parse(Guid.NewGuid().ToString("N"));
        this.Pizzas = pizzas;
        this.Completed = false;
    }

    public void ChangeOrder(List<Pizza> pizzas)
    {
        Pizzas = pizzas;
    }

    public void PrintOrder()
    {
        foreach (var pizza in Pizzas)
        {
            System.Console.WriteLine(pizza.PizzaType);
        }
    }
}