namespace NES.Domain.Entities.Visit;

public class ClinicalNote
{
    public string Content { get; private set; }


    private ClinicalNote()
    {
        Content = string.Empty;
    }


    public ClinicalNote(string content)
    {
        Content = content;
    }


    public void Update(string content)
    {
        Content = content;
    }
}