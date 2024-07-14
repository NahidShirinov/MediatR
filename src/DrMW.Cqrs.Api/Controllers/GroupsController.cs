using DrMW.Cqrs.Models.Dtos.Edu;
using DrMW.Cqrs.Models.Requests.Groups;
using DrMW.Cqrs.Service.Abstractions.Edu;
using DrMW.Cqrs.Service.Features.Command.Groups.Add;
using DrMW.Cqrs.Service.Features.Command.Groups.Delete;
using DrMW.Cqrs.Service.Features.Command.Groups.Update;
using DrMW.Cqrs.Service.Features.Query.Groups.Get;
using DrMW.Cqrs.Service.Features.Query.Groups.GetAll;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace DrMW.Cqrs.Api.Controllers;

public class GroupsController : BaseController
{
    private readonly IGroupService _groupService;
    private readonly IMediator _mediator;
    public GroupsController(IGroupService groupService, IMediator mediator)
    {
        _groupService = groupService;
        _mediator = mediator;
    }
    
    
    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        List<GroupDto> result = await _mediator.Send(new GetAllGroupReq());
        return Ok(result);
    }
    
    [HttpGet("{id:guid}")]
    public async Task<IActionResult> Get(Guid id)
    {
        var result = await _mediator.Send(new GetGroupReq { Id = id });
        return Ok(result);
    }
    
    [HttpPost]
    public async Task<IActionResult> Add(AddGroupReq request)
    {
        var result = await _mediator.Send(new AddGroupRequest { Request = request });
        return Ok(result);
    } 
    
    [HttpPut]
    public async Task<IActionResult> Put([FromBody]UpdateGroupReq request)
    {
        var result = await _mediator.Send(new UpdateGroupRequest { Request = request });
        return Ok(result);
    } 
    
    
    [HttpDelete]
    public async Task<IActionResult> Delete(Guid id)
    {
        var result = await _mediator.Send(new DeleteGroupRequest { Id = id });
        return Ok(result);
    }
    
}