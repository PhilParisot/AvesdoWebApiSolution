
using AvesdoWebApi;

public class Order
{
    private List<Pizza> Pizzas { get; set; }
    public bool Completed { get; }
    // public Address address...
    // public Distance distance...

    public Order(List<Pizza> pizzas)
    {
        if (pizzas is null)
            throw new ArgumentNullException(nameof(pizzas), $"{nameof(pizzas)} cannot be null");

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