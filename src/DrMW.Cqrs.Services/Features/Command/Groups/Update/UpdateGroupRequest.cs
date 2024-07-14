using DrMW.Cqrs.Models.Dtos.Edu;
using DrMW.Cqrs.Models.Requests.Groups;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrMW.Cqrs.Service.Features.Command.Groups.Update
{
    public class UpdateGroupRequest : IRequest<bool>
    {
        public UpdateGroupReq Request { get; set; } = null!;
    }
}
