using DrMW.Cqrs.Models.Dtos.Edu;
using DrMW.Cqrs.Models.Requests.Subjects;
using DrMW.Cqrs.Service.Features.Command.Subjects.Update;

namespace DrMW.Cqrs.Service.Abstractions.Edu;

public interface ISubjectService
{
    Task<List<SubjectDto>> GetAll();
    Task<SubjectDto> Get(Guid id);
    Task<bool> AddAsync(AddSubjectReq req);
    Task<bool> UpdateAsync(UpdateSubjectReq req);
    Task<bool> DeleteAsync(Guid id);
    Task<bool> UpdateAsync(UpdateSubjectsRequest request);
}