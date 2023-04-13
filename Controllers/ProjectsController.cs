using KristalAbsheronAzAPI.BLL.Abstract;
using KristalAbsheronAzAPI.DTOs.ProjectDTOs;
using KristalAbsheronAzAPI.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace KristalAbsheronAzAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectsController : ControllerBase
    {
        private readonly IProjectService _service;
        public ProjectsController(IProjectService service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_service.GetAll());
        }
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(_service.GetById(id));
        }
        [HttpPost]
        public IActionResult Post([FromBody] ProjectToAddDto dto)
        {
            _service.Add(dto);
            return Ok(dto);
        }
        [HttpPut]
        public IActionResult Put(ProjectToUpdateDto dto)
        {
            _service.Update(dto);
            return Ok(dto);
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _service.Delete(id);
            return Ok();
        }
    }
}
