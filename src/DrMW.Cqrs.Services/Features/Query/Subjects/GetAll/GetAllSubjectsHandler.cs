using DrMW.Cqrs.Models.Dtos.Edu;
using DrMW.Cqrs.Service.Abstractions.Edu;
using DrMW.Cqrs.Service.Concretes.Edu;
using DrMW.Cqrs.Service.Features.Query.Groups.GetAll;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrMW.Cqrs.Service.Features.Query.Subjects.GetAll
{
    public class GetAllSubjectsHandler : IRequestHandler<GetAllSubjectsReq, List<SubjectDto>>
    {
        private readonly ISubjectService _subjectservice;
        public GetAllSubjectsHandler(ISubjectService subjectService)
        {
            _subjectservice = subjectService;
            
        }
        public async Task<List<SubjectDto>> Handle(GetAllSubjectsReq request, CancellationToken cancellationToken)
        {
            return await _subjectservice.GetAll();
        }
    }
}
