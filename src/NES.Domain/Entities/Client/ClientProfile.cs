namespace NES.Domain.Entities.Client;

public class ClientProfile
{
    public DateTime? BirthDate { get; private set; }

    public int? GenderId { get; private set; }

    public decimal? Height { get; private set; }

    public decimal? Weight { get; private set; }

    public string? Address { get; private set; }

    public string? Occupation { get; private set; }


    private ClientProfile()
    {
    }


    public ClientProfile(
        DateTime? birthDate,
        int? genderId,
        decimal? height,
        decimal? weight,
        string? address,
        string? occupation)
    {
        BirthDate = birthDate;
        GenderId = genderId;
        Height = height;
        Weight = weight;
        Address = address;
        Occupation = occupation;
    }


    public void Update(
        DateTime? birthDate,
        int? genderId,
        decimal? height,
        decimal? weight,
        string? address,
        string? occupation)
    {
        BirthDate = birthDate;
        GenderId = genderId;
        Height = height;
        Weight = weight;
        Address = address;
        Occupation = occupation;
    }
}