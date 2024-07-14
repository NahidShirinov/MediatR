using DrMW.Cqrs.Core.Edu.Questionnaires;
using DrMW.Cqrs.Core.Edu;
using DrMW.Cqrs.Core.Students;
using DrMW.Cqrs.Models.Dtos.Edu;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrMW.Cqrs.Service.Features.Query.Groups.GetAll
{
    public class GetAllGroupReq:IRequest<List<GroupDto>>
    {
       
    }
}

