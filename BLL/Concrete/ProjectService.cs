using AutoMapper;
using KristalAbsheronAzAPI.BLL.Abstract;
using KristalAbsheronAzAPI.DAL.Abstract;
using KristalAbsheronAzAPI.DTOs.ProjectDTOs;
using KristalAbsheronAzAPI.Entities;

namespace KristalAbsheronAzAPI.BLL.Concrete
{
    public class ProjectService : IProjectService
    {
        private readonly IMapper _mapper;
        private readonly IProjectRepository _repository;
        public ProjectService(IMapper mapper, IProjectRepository repository)
        {
            _mapper = mapper;
            _repository = repository;
        }


        public void Add(ProjectToAddDto dto)
        {
            CompletedProject entity = _mapper.Map<CompletedProject>(dto);
            _repository.Add(entity);
        }

        public void Delete(int id)
        {
            CompletedProject entity = _repository.GetById(id);
            _repository.Delete(entity);
        }

        public IEnumerable<ProjectToListDto> GetAll()
        {
            return _mapper.Map<IEnumerable<ProjectToListDto>>(_repository.GetAll());
        }

        public ProjectByIdDto GetById(int id)
        {
            return _mapper.Map<ProjectByIdDto>(_repository.GetById(id));
        }

        public void Update(ProjectToUpdateDto dto)
        {
            CompletedProject entity = _mapper.Map<CompletedProject>(dto);
            _repository.Update(entity);
        }
    }
}
