using CoffeeTechORG.IdentityandAccessManagementContext.Domain.Model.Commands;
using CoffeeTechORG.IdentityandAccessManagementContext.Domain.Model.Queries;
using CoffeeTechORG.IdentityandAccessManagementContext.Domain.Model.ValueObjets;
using CoffeeTechORG.IdentityandAccessManagementContext.Domain.Services;

namespace CoffeeTechORG.IdentityandAccessManagementContext.Interfaces.ACL.Services;

public class UsersContextFacade(IUserCommandService userCommandService, IUserQueryService userQueryService) : IUsersContextFacade
{
     /**
     * Create a user.
     *
     * <param name="firstName">The first name of the user</param>
     * <param name="lastName">The last name of the user</param>
     * <param name="email">The email of the user</param>
     * * <returns>The user id</returns>
     * 
     */

    public async Task<int> CreateUser(string firstName, string lastName, string email)
    {
        var createUserCommand = new CreateUserCommand(firstName, lastName, email);
        var user = await userCommandService.Handle(createUserCommand);
        return user?.Id ?? 0;
    }

     /**
     * Fetch a user id by email.
     *
     * <param name="email">The email of the user</param>
     * <returns>The user id</returns>
     * 
     */
     public async Task<int> FetchUserIdByEmail(string email)
    {
        var getUserByEmailQuery = new GetUserByEmailQuery(new EmailAddress(email));
        var user = await userQueryService.Handle(getUserByEmailQuery);
        return user?.Id ?? 0;
    }
}
