using DrMW.Cqrs.Models.Dtos.Edu;
using DrMW.Cqrs.Repository.Abstractions.Cqrs;
using DrMW.Cqrs.Service.Abstractions.Edu;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrMW.Cqrs.Service.Features.Query.Groups.GetAll
{
    internal class GetAllGroupHandler : IRequestHandler<GetAllGroupReq, List<GroupDto>>
    {
        private readonly IGroupService _groupservice;
        public GetAllGroupHandler(IGroupService groupService)
        {
            _groupservice = groupService; 
        }

        public async Task<List<GroupDto>> Handle(GetAllGroupReq request, CancellationToken cancellationToken)
        {
            return await _groupservice.GetAll();
        }
    }
}
