namespace Signup.Domain.Entities;

public class User : Entity
{
    public User(string name, string email, DateTime birthDate, DateTime signupDate)
    {
        Name = name;
        Email = email;
        BirthDate = birthDate;
        SignupDate = signupDate;
    }
    public string Name { get; private set; }
    public string Email { get; private set; }
    public DateTime BirthDate { get; private set; }
    public DateTime SignupDate { get; private set; }

    public override string ToString()
    {
        return "First Name : " + Name
                               + "Email : " + Email
                               + "Birth Date : " + BirthDate
                               + "Signup Date : " + SignupDate;
    }
}