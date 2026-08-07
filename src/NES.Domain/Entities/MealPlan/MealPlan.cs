using NES.Domain.Common;
using NES.Domain.Entities.MealEntry;

namespace NES.Domain.Entities.MealEntry;

public class MealPlan : BaseEntity
{
    private readonly List<MealEntry> _meals = new();

    public string Name { get; private set; } = string.Empty;

    public IReadOnlyCollection<MealEntry> Meals => _meals.AsReadOnly();

    private MealPlan()
    {
    }


    public MealPlan(string name)
    {
        Name = name;
    }


    public void AddMeal(MealEntry meal)
    {
        _meals.Add(meal);
    }
}