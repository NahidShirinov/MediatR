using DrMW.Cqrs.Service.Abstractions.Edu;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrMW.Cqrs.Service.Features.Command.Groups.Add
{
    public class AddGroupHandler : IRequestHandler<AddGroupRequest, bool>
    {
        private readonly IGroupService _groupService;

        public AddGroupHandler(IGroupService groupService)
        {
            _groupService = groupService;
        }
        public async Task<bool> Handle(AddGroupRequest request, CancellationToken cancellationToken)
        {
            return await _groupService.AddAsync(request.Request);
        }
    }
}
