using Maze_Manual_NS.models;

namespace Maze_Manual_NS.Services;

/// <summary>
///     The service that handles all logic behind creating, editing, and deleting comments. Implements
///     <see cref="INoteService" />
/// </summary>
public class NoteService : INoteService
{
    /// <inheritdoc />
    public List<Note> Notes { get; set; } = new();

    /// <summary>
    ///     Integer that represents the next sequential ID a note can have.
    /// </summary>
    private int NextId { get; set; }

    /// <inheritdoc />
    public Task AddNote(Note note)
    {
        note.NoteId = NextId++;
        Notes.Add(note);
        return Task.CompletedTask;
    }

    /// <inheritdoc />
    public Task EditNote(Note note)
    {
        Note? noteToEdit = Notes.FirstOrDefault(tempNote => tempNote.NoteId == note.NoteId);

        noteToEdit.Content = note.Content;

        return Task.CompletedTask;
    }

    /// <inheritdoc />
    public Task DeleteNote(Note note)
    {
        Note? noteToDelete = Notes.FirstOrDefault(tempNote => tempNote.NoteId == note.NoteId);
        Notes.Remove(noteToDelete);
        return Task.CompletedTask;
    }
}