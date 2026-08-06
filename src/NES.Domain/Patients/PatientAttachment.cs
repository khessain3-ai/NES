using NES.Domain.Common;

namespace NES.Domain.Patients;

public class PatientAttachment : BaseEntity
{
    public Guid PatientId { get; private set; }

    public string FileName { get; private set; } = string.Empty;

    public string FileType { get; private set; } = string.Empty;

    public string FilePath { get; private set; } = string.Empty;

    public long FileSize { get; private set; }

    public string? Description { get; private set; }

    private PatientAttachment()
    {
    }

    public PatientAttachment(
        Guid patientId,
        string fileName,
        string fileType,
        string filePath,
        long fileSize,
        string? description = null)
    {
        PatientId = patientId;
        FileName = fileName;
        FileType = fileType;
        FilePath = filePath;
        FileSize = fileSize;
        Description = description;
    }

    public void Update(
        string fileName,
        string fileType,
        string filePath,
        long fileSize,
        string? description)
    {
        FileName = fileName;
        FileType = fileType;
        FilePath = filePath;
        FileSize = fileSize;
        Description = description;

        MarkAsUpdated();
    }
}
