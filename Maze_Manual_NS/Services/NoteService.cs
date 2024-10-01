using Maze_Manual_NS.models;

namespace Maze_Manual_NS.Services;

public class NoteService : INoteService
{
    public List<Note> Notes { get; set; } = new List<Note>();
    private int NextId { get; set; }

    public Task AddNote(Note note)
    {
        note.NoteId = NextId++;
        Notes.Add(note);
        return Task.CompletedTask;
    }

    public Task EditNote(Note note)
    {
        var noteToEdit = Notes.FirstOrDefault(n => n.NoteId == note.NoteId);
        
        noteToEdit.Content = note.Content;
        
        return Task.CompletedTask; 
    }

    public Task DeleteNote(Note note)
    {
        var noteToDelete = Notes.FirstOrDefault(n => n.NoteId == note.NoteId);
        Notes.Remove(noteToDelete);
        return Task.CompletedTask;
    }
}