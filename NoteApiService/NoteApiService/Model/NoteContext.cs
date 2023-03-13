using Microsoft.EntityFrameworkCore;

namespace NoteApiService.Model
{
    public class NoteContext : DbContext
    {
        public DbSet<Note> Notes { get; set; } = default!;

        public string DbPath { get; }

        public NoteContext()
        {
            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);
            DbPath = Path.Join(path, "note.db");
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite($"Data Source={DbPath}");
    }
}
