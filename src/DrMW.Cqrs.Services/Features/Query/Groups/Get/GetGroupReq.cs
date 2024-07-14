using DrMW.Cqrs.Models.Dtos;
using DrMW.Cqrs.Models.Dtos.Edu;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrMW.Cqrs.Service.Features.Query.Groups.Get
{
    public class GetGroupReq : IRequest<GroupDto>
    {
        public Guid Id { get; set; }
    }
    
    
}
