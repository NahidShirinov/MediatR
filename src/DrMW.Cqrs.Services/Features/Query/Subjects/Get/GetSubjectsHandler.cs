using DrMW.Cqrs.Models.Dtos.Edu;
using DrMW.Cqrs.Service.Abstractions.Edu;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrMW.Cqrs.Service.Features.Query.Subjects.Get
{
    public class GetSubjectsHandler : IRequestHandler<GetSubjectsReq, SubjectDto>
    {
        private readonly ISubjectService _subjectservice;
        public GetSubjectsHandler(ISubjectService subjectservice)
        {
            _subjectservice=subjectservice;
            
        }
        public async Task<SubjectDto> Handle(GetSubjectsReq request, CancellationToken cancellationToken)
        {
            return await _subjectservice.Get(request.Id);
        }
    }
}
