using CoffeeTechORG.IdentityandAccessManagementContext.Domain.Model.Aggregates;
using CoffeeTechORG.IdentityandAccessManagementContext.Domain.Model.ValueObjets;
using CoffeeTechORG.Shared.Domain.Repositories;

namespace CoffeeTechORG.IdentityandAccessManagementContext.Domain.Repositories;

public interface IUserRepository : IBaseRepository<User>
{
    Task<User?> FindUserByEmailAsync(EmailAddress email);
}