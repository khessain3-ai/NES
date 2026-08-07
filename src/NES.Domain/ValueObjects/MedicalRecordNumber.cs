namespace NES.Domain.ValueObjects;

public sealed class MedicalRecordNumber
{
    public string Value { get; private set; }

    private MedicalRecordNumber()
    {
        Value = string.Empty;
    }

    public MedicalRecordNumber(string value)
    {
        if (string.IsNullOrWhiteSpace(value))
            throw new ArgumentException("Medical record number is required");

        Value = value.Trim();
    }

    public override string ToString()
    {
        return Value;
    }
}