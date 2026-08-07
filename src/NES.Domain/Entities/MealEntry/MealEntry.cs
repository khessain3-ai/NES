using NES.Domain.Common;
using System;

namespace NES.Domain.Entities.MealEntry;

public class MealEntry : BaseEntity
{
    public string Name { get; private set; } = string.Empty;

    public int Calories { get; private set; }

    public DateTime MealTime { get; private set; }


    private MealEntry()
    {
    }


    public MealEntry(
        string name,
        int calories,
        DateTime mealTime)
    {
        Name = name;
        Calories = calories;
        MealTime = mealTime;
    }
}