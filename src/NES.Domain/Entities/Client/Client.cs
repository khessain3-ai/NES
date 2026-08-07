using NES.Domain.Common;
using NES.Domain.ValueObjects;
using NES.Domain.Enums;

namespace NES.Domain.Entities.Client;

public class Client : BaseEntity
{
    public string ClientCode { get; private set; }

    public ClientStatus Status { get; private set; } = ClientStatus.Active;

    public PersonName Name { get; private set; }

    public MedicalRecordNumber MedicalRecordNumber { get; private set; }

    public ClientContact? Contact { get; private set; }

    public ClientProfile? Profile { get; private set; }


    private Client()
    {
        ClientCode = string.Empty;
        Name = null!;
        MedicalRecordNumber = null!;
        Status = ClientStatus.Active;
    }


    public Client(
        string clientCode,
        PersonName name,
        MedicalRecordNumber medicalRecordNumber,
        ClientContact? contact = null,
        ClientProfile? profile = null)
    {
        ClientCode = clientCode;
        Name = name;
        MedicalRecordNumber = medicalRecordNumber;
        Contact = contact;
        Profile = profile;
        Status = ClientStatus.Active;
    }


    public void UpdateContact(ClientContact contact)
    {
        Contact = contact;
        MarkAsUpdated();
    }


    public void UpdateProfile(ClientProfile profile)
    {
        Profile = profile;
        MarkAsUpdated();
    }


    public void ChangeStatus(ClientStatus status)
    {
        Status = status;
        MarkAsUpdated();
    }
}