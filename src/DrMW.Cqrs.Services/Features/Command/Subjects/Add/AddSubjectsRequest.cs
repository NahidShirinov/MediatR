using DrMW.Cqrs.Models.Requests.Groups;
using DrMW.Cqrs.Models.Requests.Subjects;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrMW.Cqrs.Service.Features.Command.Subjects.Add
{
    public class AddSubjectsRequest : IRequest<bool>
    {
        public AddSubjectReq Request { get; set; } = null!;
    }
}
