using CoffeeTechORG.IdentityandAccessManagementContext.Domain.Model.Aggregates;
using CoffeeTechORG.IdentityandAccessManagementContext.Domain.Model.Commands;
using CoffeeTechORG.IdentityandAccessManagementContext.Domain.Repositories;
using CoffeeTechORG.IdentityandAccessManagementContext.Domain.Services;
using CoffeeTechORG.Shared.Domain.Repositories;

namespace CoffeeTechORG.IdentityandAccessManagementContext.Application.Internal.CommandServices;

public class UserCommandService(IUserRepository userRepository, IUnitOfWork unitOfWork) : IUserCommandService
{
    public async Task<User?> Handle(CreateUserCommand command)
    {
        var user = new User(command);
        try
        {
            await userRepository.AddAsync(user);
            await unitOfWork.CompleteAsync();
            return user;
        } catch (Exception e) 
        { 
            Console.WriteLine($"An error ocurred while creating the user: {e.Message}");
            return null;
        }
    }
}
