using NES.Domain.Common;

namespace NES.Domain.Patients;

public class Allergy : BaseEntity
{
    public Guid PatientId { get; private set; }

    public string Name { get; private set; } = string.Empty;

    public string? Notes { get; private set; }

    private Allergy()
    {
    }

    public Allergy(Guid patientId, string name, string? notes = null)
    {
        PatientId = patientId;
        Name = name;
        Notes = notes;
    }

    public void Update(string name, string? notes)
    {
        Name = name;
        Notes = notes;

        MarkAsUpdated();
    }
}
