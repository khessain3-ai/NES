namespace NES.Domain.Entities.Food;

public class FoodNutrient
{
    public string Name { get; private set; }

    public decimal Amount { get; private set; }

    public string Unit { get; private set; }


    private FoodNutrient()
    {
        Name = string.Empty;
        Unit = string.Empty;
    }


    public FoodNutrient(
        string name,
        decimal amount,
        string unit)
    {
        Name = name;
        Amount = amount;
        Unit = unit;
    }


    public void Update(
        decimal amount,
        string unit)
    {
        Amount = amount;
        Unit = unit;
    }
}