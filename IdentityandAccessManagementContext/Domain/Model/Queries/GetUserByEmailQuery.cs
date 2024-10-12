using CoffeeTechORG.IdentityandAccessManagementContext.Domain.Model.ValueObjets;

namespace CoffeeTechORG.IdentityandAccessManagementContext.Domain.Model.Queries;

public record GetUserByEmailQuery(EmailAddress Email);