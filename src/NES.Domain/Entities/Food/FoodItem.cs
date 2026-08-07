using NES.Domain.Common;

namespace NES.Domain.Entities.Food;

public class FoodItem : BaseEntity
{
    public string Name { get; private set; }

    public string? Description { get; private set; }

  public FoodCategory Category { get; private set; } = default!;

    public decimal Calories { get; private set; }

    public decimal Protein { get; private set; }

    public decimal Carbohydrates { get; private set; }

    public decimal Fat { get; private set; }


    private FoodItem()
    {
        Name = string.Empty;
    }


    public FoodItem(
        string name,
        FoodCategory category,
        decimal calories,
        decimal protein,
        decimal carbohydrates,
        decimal fat,
        string? description = null)
    {
        Name = name;
        Category = category;
        Calories = calories;
        Protein = protein;
        Carbohydrates = carbohydrates;
        Fat = fat;
        Description = description;
    }


    public void UpdateNutrition(
        decimal calories,
        decimal protein,
        decimal carbohydrates,
        decimal fat)
    {
        Calories = calories;
        Protein = protein;
        Carbohydrates = carbohydrates;
        Fat = fat;

        MarkAsUpdated();
    }


    public void UpdateDescription(string? description)
    {
        Description = description;

        MarkAsUpdated();
    }
}