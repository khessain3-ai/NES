namespace NES.Domain.Entities.Visit;

public class LaboratoryResult
{
    public string LabName { get; private set; }

    public DateTime TestDate { get; private set; }

    public string? Result { get; private set; }

    public string? Notes { get; private set; }


    private LaboratoryResult()
    {
        LabName = string.Empty;
    }


    public LaboratoryResult(
        string labName,
        DateTime testDate,
        string? result = null,
        string? notes = null)
    {
        LabName = labName;
        TestDate = testDate;
        Result = result;
        Notes = notes;
    }


    public void Update(
        string labName,
        DateTime testDate,
        string? result = null,
        string? notes = null)
    {
        LabName = labName;
        TestDate = testDate;
        Result = result;
        Notes = notes;
    }
}