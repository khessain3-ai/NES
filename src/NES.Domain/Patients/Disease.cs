using NES.Domain.Common;

namespace NES.Domain.Patients;

public class Disease : BaseEntity
{
    public Guid PatientId { get; private set; }

    public string Name { get; private set; } = string.Empty;

    public DateOnly? DiagnosedOn { get; private set; }

    public bool IsChronic { get; private set; }

    public string? Notes { get; private set; }

    private Disease()
    {
    }

    public Disease(
        Guid patientId,
        string name,
        bool isChronic,
        DateOnly? diagnosedOn = null,
        string? notes = null)
    {
        PatientId = patientId;
        Name = name;
        IsChronic = isChronic;
        DiagnosedOn = diagnosedOn;
        Notes = notes;
    }

    public void Update(
        string name,
        bool isChronic,
        DateOnly? diagnosedOn,
        string? notes)
    {
        Name = name;
        IsChronic = isChronic;
        DiagnosedOn = diagnosedOn;
        Notes = notes;

        MarkAsUpdated();
    }
}
