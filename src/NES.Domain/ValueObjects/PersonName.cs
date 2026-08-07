namespace NES.Domain.ValueObjects;

public sealed class PersonName
{
    public string Value { get; private set; }

    private PersonName()
    {
        Value = string.Empty;
    }

    public PersonName(string value)
    {
        if (string.IsNullOrWhiteSpace(value))
            throw new ArgumentException("Person name is required");

        Value = value.Trim();
    }

    public override string ToString()
    {
        return Value;
    }
}