using Microsoft.AspNetCore.Mvc;
using NoteApiService.Model;
using NoteApiService.Services.Interfaces;

namespace NoteApiService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class NoteController : ControllerBase
    {
        private readonly ILogger<NoteController> _logger;
        private readonly INoteService _noteService;

        public NoteController(ILogger<NoteController> logger, INoteService noteService)
        {
            _logger = logger;
            _noteService = noteService;
        }

        [HttpGet(Name = "GetNotes")]
        public IEnumerable<Note> GetNotes()
        {
            return _noteService.GetNotes();
        }
    }
}