namespace CoffeeTechORG.IdentityandAccessManagementContext.Interfaces.ACL;

public interface IUsersContextFacade
{
    Task<int> CreateUser(string firstName, string lastName, string email);
    Task<int> FetchUserIdByEmail(string email);
}
