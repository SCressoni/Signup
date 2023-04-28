namespace Signup.Domain.Entities;

public class User : Entity
{
    public User(string firstName, string surname, string email)
    {
        Id = Guid.NewGuid();
        FirstName = firstName;
        Surname = surname;
        Email = email;
    }
    
    public Guid Id { get; set; }
    public string FirstName { get; private set; }
    public string Surname { get; private set; }
    public string Email { get; private set; }

    public override string ToString()
    {
        return "First Name : " + FirstName
                               + "Surname : " + Surname
                               + "Email : " + Email;
    }
}