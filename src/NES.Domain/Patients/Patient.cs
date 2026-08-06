using NES.Domain.Common;

namespace NES.Domain.Patients;

public class Patient : BaseEntity
{
    public string FirstName { get; private set; } = string.Empty;

    public string LastName { get; private set; } = string.Empty;

    public string NationalId { get; private set; } = string.Empty;

    public DateOnly DateOfBirth { get; private set; }

    public Gender Gender { get; private set; }

    public BloodGroup BloodGroup { get; private set; }

    public PatientStatus Status { get; private set; }

    public string Address { get; private set; } = string.Empty;

    private readonly List<PatientPhone> _phones = new();
    public IReadOnlyCollection<PatientPhone> Phones => _phones.AsReadOnly();

    private readonly List<Allergy> _allergies = new();
    public IReadOnlyCollection<Allergy> Allergies => _allergies.AsReadOnly();

    private readonly List<Disease> _diseases = new();
    public IReadOnlyCollection<Disease> Diseases => _diseases.AsReadOnly();

    private readonly List<LabResult> _labResults = new();
    public IReadOnlyCollection<LabResult> LabResults => _labResults.AsReadOnly();

    private readonly List<PatientAttachment> _attachments = new();
    public IReadOnlyCollection<PatientAttachment> Attachments => _attachments.AsReadOnly();

    private readonly List<EmergencyContact> _emergencyContacts = new();
    public IReadOnlyCollection<EmergencyContact> EmergencyContacts => _emergencyContacts.AsReadOnly();

    private Patient()
    {
    }

    public Patient(
        string firstName,
        string lastName,
        string nationalId,
        DateOnly dateOfBirth,
        Gender gender,
        BloodGroup bloodGroup,
        string address)
    {
        FirstName = firstName;
        LastName = lastName;
        NationalId = nationalId;
        DateOfBirth = dateOfBirth;
        Gender = gender;
        BloodGroup = bloodGroup;
        Address = address;

        Status = PatientStatus.Active;
    }

    public string FullName => $"{FirstName} {LastName}";

    public void AddPhone(PatientPhone phone)
        => _phones.Add(phone);

    public void AddAllergy(Allergy allergy)
        => _allergies.Add(allergy);

    public void AddDisease(Disease disease)
        => _diseases.Add(disease);

    public void AddLabResult(LabResult result)
        => _labResults.Add(result);

    public void AddAttachment(PatientAttachment attachment)
        => _attachments.Add(attachment);

    public void AddEmergencyContact(EmergencyContact contact)
        => _emergencyContacts.Add(contact);

    public void Archive()
    {
        Status = PatientStatus.Archived;
        MarkAsUpdated();
    }
}
