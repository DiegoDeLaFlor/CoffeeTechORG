using CoffeeTechORG.IdentityandAccessManagementContext.Domain.Model.Aggregates;
using CoffeeTechORG.IdentityandAccessManagementContext.Domain.Model.Commands;

namespace CoffeeTechORG.IdentityandAccessManagementContext.Domain.Services;

public interface IUserCommandService
{
    Task<User?> Handle(CreateUserCommand commad);
}
