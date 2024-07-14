using DrMW.Cqrs.Service.Abstractions.Edu;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrMW.Cqrs.Service.Features.Command.Subjects.Delete
{
    public class DeleteSubjectsHandler : IRequestHandler<DeleteSubjectsRequest, bool>
    {
        private readonly ISubjectService _subjectService;
        public DeleteSubjectsHandler(ISubjectService subjectService)
        {
            _subjectService = subjectService;
        }
        public async Task<bool> Handle(DeleteSubjectsRequest request, CancellationToken cancellationToken)
        {
            return await _subjectService.DeleteAsync(request.Id);
        }
    }
}
