namespace NES.Domain.Entities.Client;

public class ClientContact
{
    public string? Mobile { get; private set; }

    public string? Email { get; private set; }

    private ClientContact()
    {
    }

    public ClientContact(
        string? mobile,
        string? email)
    {
        Mobile = mobile;
        Email = email;
    }

    public void Update(
        string? mobile,
        string? email)
    {
        Mobile = mobile;
        Email = email;
    }
}