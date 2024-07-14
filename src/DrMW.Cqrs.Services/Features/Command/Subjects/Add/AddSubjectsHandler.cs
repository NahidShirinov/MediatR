using DrMW.Cqrs.Service.Abstractions.Edu;
using DrMW.Cqrs.Service.Features.Command.Groups.Add;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrMW.Cqrs.Service.Features.Command.Subjects.Add
{
    public class AddSubjectsHandler : IRequestHandler<AddSubjectsRequest, bool>
    {
        private readonly ISubjectService _subjectService;

        public AddSubjectsHandler(ISubjectService subjectService)
        {
            _subjectService = subjectService;
        }
        public async Task<bool> Handle(AddSubjectsRequest request, CancellationToken cancellationToken)
        {
            return await _subjectService.AddAsync(request.Request);
        }
    }
}
