using Flunt.Notifications;
using Flunt.Validations;
using Signup.Domain.Commands.Contracts;

namespace Signup.Domain.Commands;

public class CreateUserCommand : Notifiable, ICommand
{
    public CreateUserCommand(){}

    public CreateUserCommand(string name, string email, DateTime birthDate, DateTime signupDate )
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


    public void Validate()
    {
        AddNotifications(
            new Contract()
            .Requires()
            .HasMinLen(Name, 3, "Name", "Name must to be greater than 3 character !")
            .HasMinLen(Email, 15, "Email", "Name must to be greater than 15 character !")
        );
    }
}