using System.Linq;
using Xunit;

namespace AvesdoWebApi.Tests;

public class PizzaTests
{
    [Fact]
    public void PizzaTypesValid()
    {
        Pizza pizza = new(Pizza.PizzaTypes.First());

        Assert.True(pizza.PizzaType == Pizza.PizzaTypes.First(), $"PizzaType should be {Pizza.PizzaTypes.First()}");
    }
}