namespace NES.Domain.Entities.Visit;

public class VisitDiagnosis
{
    public string DiagnosisName { get; private set; }

    public string? Notes { get; private set; }


    private VisitDiagnosis()
    {
        DiagnosisName = string.Empty;
    }


    public VisitDiagnosis(
        string diagnosisName,
        string? notes = null)
    {
        DiagnosisName = diagnosisName;
        Notes = notes;
    }


    public void Update(
        string diagnosisName,
        string? notes = null)
    {
        DiagnosisName = diagnosisName;
        Notes = notes;
    }
}