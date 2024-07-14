using DrMW.Cqrs.Models.Dtos.Edu;
using DrMW.Cqrs.Service.Abstractions.Edu;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrMW.Cqrs.Service.Features.Command.Groups.Update
{
    public class UpdateGroupHandler : IRequestHandler<UpdateGroupRequest, bool>
    {
        private readonly IGroupService _groupService;

        public UpdateGroupHandler(IGroupService groupService)
        {
            _groupService = groupService;
        }

        public async Task<bool> Handle(UpdateGroupRequest request, CancellationToken cancellationToken)
        {
            return await _groupService.UpdateAsync(request.Request);
        }
    }
}
