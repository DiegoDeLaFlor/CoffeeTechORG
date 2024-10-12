using CoffeeTechORG.IdentityandAccessManagementContext.Domain.Model.Aggregates;
using CoffeeTechORG.IdentityandAccessManagementContext.Domain.Model.Queries;
using CoffeeTechORG.IdentityandAccessManagementContext.Domain.Repositories;
using CoffeeTechORG.IdentityandAccessManagementContext.Domain.Services;

namespace CoffeeTechORG.IdentityandAccessManagementContext.Application.Internal.QueryServices;

public class UserQueryService(IUserRepository userRepository) : IUserQueryService
{
    public async Task<IEnumerable<User>> Handle(GetAllUsersQuery query)
    {
        return await userRepository.ListAsync();
    }
    public async Task<User?> Handle(GetUserByEmailQuery query)
    {
        return await userRepository.FindUserByEmailAsync(query.Email);
    }

    public async Task<User?> Handle(GetUserByIdQuery query)
    {
        return await userRepository.FindByIdAsync(query.UserId);
    }
}
