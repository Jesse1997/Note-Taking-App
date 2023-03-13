using NoteApiService.Model;
using NoteApiService.Repositories.Interfaces;
using NoteApiService.Services.Interfaces;

namespace NoteApiService.Services
{
    public class NoteService : INoteService
    {
        private readonly INoteRepository _noteRepository;

        public NoteService(INoteRepository noteRepository)
        {
            _noteRepository = noteRepository;
        }
        public IEnumerable<Note> GetNotes()
        {
            return _noteRepository.GetAll();
        }
    }
}
