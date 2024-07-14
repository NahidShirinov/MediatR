using DrMW.Cqrs.Service.Abstractions.Edu;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrMW.Cqrs.Service.Features.Command.Groups.Delete
{
    public class DeleteGroupHandler : IRequestHandler<DeleteGroupRequest, bool>
    {
        private readonly IGroupService _groupService;

        public DeleteGroupHandler(IGroupService groupService)
        {
            _groupService = groupService;
        }
        public async Task<bool> Handle(DeleteGroupRequest request, CancellationToken cancellationToken)
        {
            return await _groupService.DeleteAsync(request.Id);
        }
    }
}
