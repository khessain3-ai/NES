using NES.Domain.Common;

namespace NES.Domain.Patients;

public class Patient : BaseEntity
{
    public string FirstName { get; private set; } = string.Empty;

    public string LastName { get; private set; } = string.Empty;

    public string NationalId { get; private set; } = string.Empty;

    public DateOnly DateOfBirth { get; private set; }

    public Gender Gender { get; private set; }

    public string PhoneNumber { get; private set; } = string.Empty;

    public string Email { get; private set; } = string.Empty;

    public string Address { get; private set; } = string.Empty;

    public BloodGroup BloodGroup { get; private set; }

    public PatientStatus Status { get; private set; }

    private Patient()
    {
    }

    public Patient(
        string firstName,
        string lastName,
        string nationalId,
        DateOnly dateOfBirth,
        Gender gender)
    {
        FirstName = firstName;
        LastName = lastName;
        NationalId = nationalId;
        DateOfBirth = dateOfBirth;
        Gender = gender;
        Status = PatientStatus.Active;
    }

    public string FullName => $"{FirstName} {LastName}";
}
