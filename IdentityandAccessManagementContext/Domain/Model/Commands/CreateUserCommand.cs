namespace CoffeeTechORG.IdentityandAccessManagementContext.Domain.Model.Commands;

public record CreateUserCommand(string FirstName, string LastName, string Email);