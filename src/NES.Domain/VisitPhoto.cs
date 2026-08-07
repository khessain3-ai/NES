namespace NES.Domain.Entities.Visit;

public class VisitPhoto
{
    public string FilePath { get; private set; }

    public DateTime TakenDate { get; private set; }

    public string? Description { get; private set; }


    private VisitPhoto()
    {
        FilePath = string.Empty;
    }


    public VisitPhoto(
        string filePath,
        DateTime takenDate,
        string? description = null)
    {
        FilePath = filePath;
        TakenDate = takenDate;
        Description = description;
    }


    public void UpdateDescription(string? description)
    {
        Description = description;
    }
}