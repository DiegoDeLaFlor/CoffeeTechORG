using CoffeeTechORG.IdentityandAccessManagementContext.Domain.Model.Queries;
using CoffeeTechORG.IdentityandAccessManagementContext.Domain.Services;
using CoffeeTechORG.IdentityandAccessManagementContext.Interfaces.REST.Resources;
using CoffeeTechORG.IdentityandAccessManagementContext.Interfaces.REST.Transform;
using Microsoft.AspNetCore.Mvc;
using System.Net.Mime;

namespace CoffeeTechORG.IdentityandAccessManagementContext.Interfaces.REST;

[ApiController]
[Route("api/v1/[controller]")]
[Produces(MediaTypeNames.Application.Json)]
public class UsersController(IUserCommandService userCommandService, IUserQueryService userQueryService)
    : ControllerBase
{
    [HttpPost]
    public async Task<IActionResult> CreatedUser(CreateUserResource resource)
    {
        var createUserCommand = CreateUserCommandFromResourceAssembler.ToCommandFromResource(resource);
        var user = await userCommandService.Handle(createUserCommand);
        if (user is null) return BadRequest();
        var userResource = UserResourceFromEntityAssembler.ToResourceFromEntity(user);
        return CreatedAtAction(nameof(GetUserById), new {userId = userResource.Id},userResource);
    }

    [HttpGet]
    public async Task<IActionResult> GetAllUsers()
    {
        var getAllUsersQuery = new GetAllUsersQuery();
        var users = await userQueryService.Handle(getAllUsersQuery);
        var userResource = users.Select(UserResourceFromEntityAssembler.ToResourceFromEntity);
        return Ok(userResource);
    }

    [HttpGet("{userId:int}")]
    public async Task<IActionResult> GetUserById(int userId)
    {
        var getUserByIdQuery = new GetUserByIdQuery(userId);
        var user = await userQueryService.Handle(getUserByIdQuery);
        if (user == null) return NotFound();
        var userResource = UserResourceFromEntityAssembler.ToResourceFromEntity(user);
        return Ok(userResource);
    }
}
