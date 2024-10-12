namespace CoffeeTechORG.IdentityandAccessManagementContext.Domain.Model.ValueObjets;

public record EmailAddress(string Address)
{
    public EmailAddress() : this(string.Empty) 
    { 
    }
}
