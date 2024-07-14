using DrMW.Cqrs.Models.Dtos.Edu;
using DrMW.Cqrs.Models.Requests.Subjects;
using DrMW.Cqrs.Service.Abstractions.Edu;
using DrMW.Cqrs.Service.Features.Command.Subjects.Add;
using DrMW.Cqrs.Service.Features.Command.Subjects.Delete;
using DrMW.Cqrs.Service.Features.Command.Subjects.Update;
using DrMW.Cqrs.Service.Features.Query.Groups.GetAll;
using DrMW.Cqrs.Service.Features.Query.Students.GetAll;
using DrMW.Cqrs.Service.Features.Query.Subjects.Get;
using DrMW.Cqrs.Service.Features.Query.Subjects.GetAll;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace DrMW.Cqrs.Api.Controllers;

public class SubjectsController : BaseController
{
    private readonly ISubjectService _subjectService;
    private readonly IMediator _mediator;
    public SubjectsController(ISubjectService subjectService,IMediator mediator)
    {
        _mediator = mediator;
        _subjectService = subjectService;
    }
    
    
    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        List<SubjectDto> result = await _mediator.Send(new GetAllSubjectsReq());
        return Ok(result);
    }
    
    [HttpGet("{id:guid}")]
    public async Task<IActionResult> Get(Guid id)
    {
        var result = await _mediator.Send(new GetSubjectsReq { Id = id });
        return Ok(result);
    }

    [HttpPost]
    public async Task<IActionResult> Add(AddSubjectReq request)
    {
        var result = await _mediator.Send(new AddSubjectsRequest {Request = request});
        return Ok(result);
    } 
    
    [HttpPut]
    public async Task<IActionResult> Put([FromBody]UpdateSubjectReq request)
    {
        var result = await _mediator.Send(new UpdateSubjectsRequest { Request = request });
        return Ok(result);
    } 
    
    
    [HttpDelete]
    public async Task<IActionResult> Delete(Guid id)
    {
        var result=await _mediator.Send(new DeleteSubjectsRequest { Id = id});
        return Ok(result);
    }
    
}