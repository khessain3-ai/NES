using NES.Domain.Common;

namespace NES.Domain.Patients;

public class PatientPhone : BaseEntity
{
    public Guid PatientId { get; private set; }

    public string PhoneNumber { get; private set; } = string.Empty;

    public bool IsPrimary { get; private set; }

    public string? Notes { get; private set; }

    private PatientPhone()
    {
    }

    public PatientPhone(
        Guid patientId,
        string phoneNumber,
        bool isPrimary = false,
        string? notes = null)
    {
        PatientId = patientId;
        PhoneNumber = phoneNumber;
        IsPrimary = isPrimary;
        Notes = notes;
    }

    public void Update(
        string phoneNumber,
        bool isPrimary,
        string? notes)
    {
        PhoneNumber = phoneNumber;
        IsPrimary = isPrimary;
        Notes = notes;

        MarkAsUpdated();
    }
}
