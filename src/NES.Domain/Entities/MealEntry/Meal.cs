namespace NES.Domain.Entities.MealEntry;

public class Meal
{
    public Guid Id { get; private set; }

   public string Name { get; private set; } = string.Empty;
    private Meal()
    {
    }

    public Meal(string name)
    {
        Id = Guid.NewGuid();
        Name = name;
    }
}