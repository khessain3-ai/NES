using NES.Domain.Common;

namespace NES.Domain.Patients;

public class LabResult : BaseEntity
{
    public Guid PatientId { get; private set; }

    public string TestName { get; private set; } = string.Empty;

    public string LaboratoryName { get; private set; } = string.Empty;

    public DateOnly TestDate { get; private set; }

    public string Result { get; private set; } = string.Empty;

    public string? Notes { get; private set; }

    private LabResult()
    {
    }

    public LabResult(
        Guid patientId,
        string testName,
        string laboratoryName,
        DateOnly testDate,
        string result,
        string? notes = null)
    {
        PatientId = patientId;
        TestName = testName;
        LaboratoryName = laboratoryName;
        TestDate = testDate;
        Result = result;
        Notes = notes;
    }

    public void Update(
        string testName,
        string laboratoryName,
        DateOnly testDate,
        string result,
        string? notes)
    {
        TestName = testName;
        LaboratoryName = laboratoryName;
        TestDate = testDate;
        Result = result;
        Notes = notes;

        MarkAsUpdated();
    }
}
