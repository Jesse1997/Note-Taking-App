using Microsoft.EntityFrameworkCore;
using NoteApiService.Model;
using NoteApiService.Repositories.Interfaces;

namespace NoteApiService.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly NoteContext _context;
        private readonly DbSet<T> table;

        public GenericRepository(NoteContext _context)
        {
            this._context = _context;
            table = _context.Set<T>();
        }
        public IEnumerable<T> GetAll()
        {
            return table.ToList();
        }
        public T? GetById(object id)
        {
            return table.Find(id);
        }
        public void Insert(T obj)
        {
            table.Add(obj);
        }
        public void Update(T obj)
        {
            table.Attach(obj);
            _context.Entry(obj).State = EntityState.Modified;
        }
        public void Delete(object id)
        {
            var existing = table.Find(id);
            if (existing != null)
            {
                table.Remove(existing);
            }
        }
        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
