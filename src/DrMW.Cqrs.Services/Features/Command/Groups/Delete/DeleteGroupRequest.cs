using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrMW.Cqrs.Service.Features.Command.Groups.Delete
{
    public class DeleteGroupRequest : IRequest<bool>
    {
        public Guid Id { get; set; }
    }
}
