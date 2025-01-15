using CleanArch.Application.UserCases.CreateUser;
using CleanArch.Application.UserCases.DeleteUser;
using CleanArch.Application.UserCases.GetAllUsers;
using CleanArch.Application.UserCases.UpdateUser;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CleanArchitecture.WebAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class UsersController : ControllerBase
{
    private readonly IMediator _mediator;

    public UsersController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet]
    public async Task<ActionResult<List<GetAllUsersResponse>>> 
        GetAll(CancellationToken cancellationToken)
    {
        var response = await _mediator.Send(new GetAllUsersRequest(), cancellationToken);
        return Ok(response);
    }

    [HttpPost]
    public async Task<ActionResult<CreateUserResponse>> Create(CreateUserRequest request,
                                                         CancellationToken cancellationToken)
    {
        var validator = new CreateUserValidator();
        var validationResult = await validator.ValidateAsync(request);

        if (!validationResult.IsValid)
        {
            return BadRequest(validationResult.Errors);
        }

        var response = await _mediator.Send(request, cancellationToken);

        return Ok(response);
    }

    [HttpPut("{id}")]
    public async Task<ActionResult<UpdateUserResponse>>
        Update(Guid id, UpdateUserRequest request, CancellationToken cancellationToken)
    {
        if (id != request.Id) return BadRequest();

        var response = await _mediator.Send(request, cancellationToken);
        return Ok(response);
    }    

    [HttpDelete("{id}")]
    public async Task<ActionResult> Delete(Guid? id, CancellationToken cancellationToken)
    {
        if(id == null) return BadRequest();

        var deleteUserRequest = new DeleteUserRequest(id.Value);

        var response = await _mediator.Send(deleteUserRequest, cancellationToken);
        return Ok(response);
    }

}