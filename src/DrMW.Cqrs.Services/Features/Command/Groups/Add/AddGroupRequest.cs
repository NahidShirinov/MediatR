using DrMW.Cqrs.Models.Requests.Groups;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrMW.Cqrs.Service.Features.Command.Groups.Add
{
    public class AddGroupRequest:IRequest<bool>
    {
        public AddGroupReq Request { get; set; } = null!;
    }
}
