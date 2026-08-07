namespace NES.Domain.Entities.Food;

public class FoodCategory
{
    public string Name { get; private set; }

    public string? Description { get; private set; }


    private FoodCategory()
    {
        Name = string.Empty;
    }


    public FoodCategory(
        string name,
        string? description = null)
    {
        Name = name;
        Description = description;
    }


    public void Update(
        string name,
        string? description = null)
    {
        Name = name;
        Description = description;
    }
}