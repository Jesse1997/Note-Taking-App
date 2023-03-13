namespace NoteApiService.Model
{
    public class Note
    {
        public int Id { get; set; }
        public string Text { get; set; } = "Add text...";
        public int Order { get; set; }
    }
}
