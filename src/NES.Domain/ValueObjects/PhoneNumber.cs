namespace NES.Domain.ValueObjects;

public sealed class PhoneNumber
{
    public string Value { get; private set; }

    private PhoneNumber()
    {
        Value = string.Empty;
    }

    public PhoneNumber(string value)
    {
        if (string.IsNullOrWhiteSpace(value))
            throw new ArgumentException("Phone number is required");

        Value = value;
    }

    public override string ToString()
    {
        return Value;
    }
}