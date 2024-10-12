using CoffeeTechORG.IdentityandAccessManagementContext.Domain.Model.Aggregates;
using CoffeeTechORG.IdentityandAccessManagementContext.Domain.Model.ValueObjets;
using CoffeeTechORG.IdentityandAccessManagementContext.Interfaces.REST.Resources;

namespace CoffeeTechORG.IdentityandAccessManagementContext.Interfaces.REST.Transform;

public static class UserResourceFromEntityAssembler
{
    public static UserResource ToResourceFromEntity(User entity)
    {
        return new UserResource(entity.Id, entity.FullName, entity.EmailAddress);
    }
}
