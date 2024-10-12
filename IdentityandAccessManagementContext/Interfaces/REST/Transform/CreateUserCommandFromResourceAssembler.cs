using CoffeeTechORG.IdentityandAccessManagementContext.Domain.Model.Commands;
using CoffeeTechORG.IdentityandAccessManagementContext.Interfaces.REST.Resources;

namespace CoffeeTechORG.IdentityandAccessManagementContext.Interfaces.REST.Transform;

public static class CreateUserCommandFromResourceAssembler
{
    public static CreateUserCommand ToCommandFromResource(CreateUserResource resource)
    {
        return new CreateUserCommand(resource.FirstName, resource.LastName, resource.Email);
    }
}
