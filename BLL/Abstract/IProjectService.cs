using KristalAbsheronAzAPI.DTOs.ProjectDTOs;

namespace KristalAbsheronAzAPI.BLL.Abstract
{
    public interface IProjectService
    {
        IEnumerable<ProjectToListDto> GetAll();
        ProjectByIdDto GetById(int id);
        void Add(ProjectToAddDto dto);
        void Update(ProjectToUpdateDto dto);
        void Delete(int id);
    }
}
