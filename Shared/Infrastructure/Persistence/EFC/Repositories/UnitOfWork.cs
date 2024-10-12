using CoffeeTechORG.Shared.Domain.Repositories;
using CoffeeTechORG.Shared.Infrastructure.Persistence.EFC.Configuration;

namespace CoffeeTechORG.Shared.Infrastructure.Persistence.EFC.Repositories;

public class UnitOfWork(AppDbContext context) : IUnitOfWork
{
    public async Task CompleteAsync() => await context.SaveChangesAsync();
}
