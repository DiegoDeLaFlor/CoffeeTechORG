using CoffeeTechORG.IdentityandAccessManagementContext.Domain.Model.Aggregates;
using CoffeeTechORG.IdentityandAccessManagementContext.Domain.Model.ValueObjets;
using CoffeeTechORG.IdentityandAccessManagementContext.Domain.Repositories;
using CoffeeTechORG.Shared.Infrastructure.Persistence.EFC.Configuration;
using CoffeeTechORG.Shared.Infrastructure.Persistence.EFC.Repositories;
using Microsoft.EntityFrameworkCore;

namespace CoffeeTechORG.IdentityandAccessManagementContext.Infrastructure.Persistence.EFC.Repositories;

public class UserRepository(AppDbContext context) : BaseRepository<User>(context), IUserRepository
{
    public Task<User?> FindUserByEmailAsync(EmailAddress email)
    {
        return Context.Set<User>().Where(p => p.Email == email).FirstOrDefaultAsync();
    }
}