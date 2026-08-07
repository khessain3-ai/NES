namespace NES.Domain.Entities.ClientFood;

public class ClientFoodPreference
{
    public Guid ClientId { get; private set; }

    public Guid FoodItemId { get; private set; }

    public FoodPreferenceType Type { get; private set; }

    public string? Notes { get; private set; }


    private ClientFoodPreference()
    {
    }


    public ClientFoodPreference(
        Guid clientId,
        Guid foodItemId,
        FoodPreferenceType type,
        string? notes = null)
    {
        ClientId = clientId;
        FoodItemId = foodItemId;
        Type = type;
        Notes = notes;
    }


    public void Update(
        FoodPreferenceType type,
        string? notes)
    {
        Type = type;
        Notes = notes;
    }
}