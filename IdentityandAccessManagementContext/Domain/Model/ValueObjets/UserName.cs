namespace CoffeeTechORG.IdentityandAccessManagementContext.Domain.Model.ValueObjets;

public record UserName(string FirstName, string LastName)
{
    public UserName() : this(string.Empty, string.Empty)
    {
    }

    public UserName(string firstName) : this(firstName, string.Empty)
    {
    }

    public string FullName => $"{FirstName} {LastName}";
}
