using CoffeeTechORG.IdentityandAccessManagementContext.Domain.Model.Commands;
using CoffeeTechORG.IdentityandAccessManagementContext.Domain.Model.ValueObjets;

namespace CoffeeTechORG.IdentityandAccessManagementContext.Domain.Model.Aggregates;

public partial class User
{
    public User() 
    {
        Name = new UserName();
        Email = new EmailAddress();
    }

    public User(string firstName, string lastName, string email)
    {
        Name = new UserName(firstName, lastName);
        Email = new EmailAddress(email);
    }

    public User(CreateUserCommand command)
    {
        Name = new UserName(command.FirstName, command.LastName);
        Email = new EmailAddress(command.Email);
    }

    public int Id { get; }
    public UserName Name { get; private set; }
    public EmailAddress Email { get; private set; }

    public string FullName => Name.FullName;

    public string EmailAddress => Email.Address;

}
