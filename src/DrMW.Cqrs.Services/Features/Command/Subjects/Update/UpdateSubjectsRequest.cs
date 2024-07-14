using DrMW.Cqrs.Models.Requests.Subjects;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrMW.Cqrs.Service.Features.Command.Subjects.Update
{
    public class UpdateSubjectsRequest : IRequest<bool>
    {
        public UpdateSubjectsRequest Request { get; set; } = null!;

        public static implicit operator UpdateSubjectsRequest(UpdateSubjectReq v)
        {
            throw new NotImplementedException();
        }
    }
}
