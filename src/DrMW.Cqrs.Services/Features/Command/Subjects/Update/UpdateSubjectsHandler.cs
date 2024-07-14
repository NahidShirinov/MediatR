using DrMW.Cqrs.Service.Abstractions.Edu;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrMW.Cqrs.Service.Features.Command.Subjects.Update
{
    public class UpdateSubjectsHandler : IRequestHandler<UpdateSubjectsRequest, bool>
    {
        private readonly ISubjectService _subjectService;
        public UpdateSubjectsHandler(ISubjectService subjectService)
        {
            _subjectService = subjectService;
        }
        public async Task<bool> Handle(UpdateSubjectsRequest request, CancellationToken cancellationToken)
        {
            return await _subjectService.UpdateAsync(request.Request);
        }
    }
}

