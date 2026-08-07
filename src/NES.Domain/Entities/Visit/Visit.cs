using NES.Domain.Common;

namespace NES.Domain.Entities.Visit;

public class Visit : BaseEntity
{
    public Guid ClientId { get; private set; }

    public DateTime VisitDate { get; private set; }

    public string? Notes { get; private set; }


    private Visit()
    {
    }


    public Visit(
        Guid clientId,
        DateTime visitDate,
        string? notes = null)
    {
        ClientId = clientId;
        VisitDate = visitDate;
        Notes = notes;
    }


    public void UpdateNotes(string? notes)
    {
        Notes = notes;
        MarkAsUpdated();
    }
}