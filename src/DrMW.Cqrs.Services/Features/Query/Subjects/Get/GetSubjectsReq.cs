using DrMW.Cqrs.Models.Dtos.Edu;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrMW.Cqrs.Service.Features.Query.Subjects.Get
{
    public class GetSubjectsReq:IRequest<SubjectDto>
    {
        public Guid Id { get; set; }
    }
}
