namespace AvesdoWebApi;

public class Pizza
{
    public static readonly HashSet<string> PizzaTypes = new()
    {
        "Neapolitan", "Sicilian", "Pepperoni", "Hawaiian"
    };

    public string PizzaType { get; }

    public Pizza(string PizzaType)
    {
        if (!PizzaTypes.Contains(PizzaType))
        {
            throw new InvalidDataException($"Invalid pizza type, try using an option from {nameof(PizzaTypes)}");
        }

        this.PizzaType = PizzaType;

    }
}
