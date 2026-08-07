namespace NES.Domain.Entities.MealPlan;

public class MealPlanItem
{
    public Guid FoodItemId { get; private set; }

    public decimal Quantity { get; private set; }

    public string? MealTime { get; private set; }

    private MealPlanItem()
    {
    }

    public MealPlanItem(
        Guid foodItemId,
        decimal quantity,
        string? mealTime)
    {
        FoodItemId = foodItemId;
        Quantity = quantity;
        MealTime = mealTime;
    }

    public void UpdateQuantity(decimal quantity)
    {
        Quantity = quantity;
    }

    public void ChangeMealTime(string? mealTime)
    {
        MealTime = mealTime;
    }
}