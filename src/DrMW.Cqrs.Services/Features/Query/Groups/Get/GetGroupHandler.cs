using AutoMapper;
using DrMW.Cqrs.Core.Students;
using DrMW.Cqrs.Models.Dtos;
using DrMW.Cqrs.Models.Dtos.Edu;
using DrMW.Cqrs.Service.Abstractions.Edu;
using DrMW.Cqrs.Service.Concretes.Edu;
using DrMW.Cqrs.Service.Features.Students.Get;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrMW.Cqrs.Service.Features.Query.Groups.Get
{
    public class GetGroupHandler : IRequestHandler<GetGroupReq, GroupDto>
    {
        private readonly IGroupService _groupservice;
       
        public GetGroupHandler(IGroupService groupService, IMapper mapper)
        {
           
            _groupservice = groupService;
        }

        public async Task<GroupDto> Handle(GetGroupReq request, CancellationToken cancellationToken)
        {
            return await _groupservice.Get(request.Id);
        }
    }
}
