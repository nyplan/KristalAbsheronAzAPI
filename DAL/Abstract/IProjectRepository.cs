using KristalAbsheronAzAPI.Entities;

namespace KristalAbsheronAzAPI.DAL.Abstract
{
    public interface IProjectRepository
    {
        IQueryable<CompletedProject> GetAll();
        CompletedProject GetById(int id);
        void Add(CompletedProject project);
        void Update(CompletedProject project);
        void Delete(CompletedProject project);
    }
}
