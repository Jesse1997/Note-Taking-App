using NoteApiService.Model;

namespace NoteApiService.Services.Interfaces
{
    public interface INoteService
    {
        IEnumerable<Note> GetNotes();
    }
}
