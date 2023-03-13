using NoteApiService.Model;
using NoteApiService.Repositories.Interfaces;

namespace NoteApiService.Repositories
{
    public class NoteRepository : GenericRepository<Note>, INoteRepository
    {
        public NoteRepository(NoteContext _context) : base(_context)
        {
        }
    }
}
