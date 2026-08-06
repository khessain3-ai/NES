using NES.Domain.Common;

namespace NES.Domain.Patients;

public class EmergencyContact : BaseEntity
{
    public Guid PatientId { get; private set; }

    public string Name { get; private set; } = string.Empty;

    public string Relationship { get; private set; } = string.Empty;

    public string PhoneNumber { get; private set; } = string.Empty;

    public string? Notes { get; private set; }

    private EmergencyContact()
    {
    }

    public EmergencyContact(
        Guid patientId,
        string name,
        string relationship,
        string phoneNumber,
        string? notes = null)
    {
        PatientId = patientId;
        Name = name;
        Relationship = relationship;
        PhoneNumber = phoneNumber;
        Notes = notes;
    }

    public void Update(
        string name,
        string relationship,
        string phoneNumber,
        string? notes)
    {
        Name = name;
        Relationship = relationship;
        PhoneNumber = phoneNumber;
        Notes = notes;

        MarkAsUpdated();
    }
}
