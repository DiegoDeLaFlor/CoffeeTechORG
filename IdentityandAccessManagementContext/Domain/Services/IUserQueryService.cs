using CoffeeTechORG.IdentityandAccessManagementContext.Domain.Model.Aggregates;
using CoffeeTechORG.IdentityandAccessManagementContext.Domain.Model.Queries;

namespace CoffeeTechORG.IdentityandAccessManagementContext.Domain.Services;

public interface IUserQueryService
{
    Task<IEnumerable<User>> Handle(GetAllUsersQuery query);
    Task<User?> Handle(GetUserByEmailQuery query);
    Task<User?> Handle(GetUserByIdQuery query);
}
