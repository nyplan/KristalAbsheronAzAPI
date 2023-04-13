using KristalAbsheronAzAPI.DAL.Abstract;
using KristalAbsheronAzAPI.Entities;
using Microsoft.EntityFrameworkCore;

namespace KristalAbsheronAzAPI.DAL.Concrete
{
    public class ProjectRepository : IProjectRepository
    {
        private readonly KAContext _context;
        public ProjectRepository(KAContext context)
        {
            _context = context;
        }
        public void Add(CompletedProject entity)
        {
            _context.CompletedProjects.Add(entity);
            _context.SaveChanges();
        }

        public void Delete(CompletedProject entity)
        {
            _context.CompletedProjects.Remove(entity);
            _context.SaveChanges();
        }

        public IQueryable<CompletedProject> GetAll()
        {
            return _context.CompletedProjects;
        }

        public CompletedProject GetById(int id)
        {
            return _context.CompletedProjects.Find(id);
        }

        public void Update(CompletedProject entity)
        {
            _context.CompletedProjects.Update(entity);
            _context.SaveChanges();
        }
    }
}
