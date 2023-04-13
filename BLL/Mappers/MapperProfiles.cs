using AutoMapper;
using KristalAbsheronAzAPI.DTOs.ProjectDTOs;
using KristalAbsheronAzAPI.Entities;

namespace KristalAbsheronAzAPI.BLL.Mappers
{
    public class MapperProfiles : Profile
    {
        public MapperProfiles()
        {
            CreateMap<CompletedProject, ProjectToListDto>();
            CreateMap<CompletedProject, ProjectByIdDto>();
            CreateMap<ProjectToAddDto, CompletedProject>();
            CreateMap<ProjectToUpdateDto, CompletedProject>();
        }
    }
}
