using Maze_Manual_NS.models;

namespace Maze_Manual_NS.Services;

/// <summary>
///     The service that handles all logic behind creating, editing, and deleting comments. Implements <see cref="INoteService"/>
/// </summary>
public class NoteService : INoteService
{
    /// <summary>
    ///     <inheritdoc />
    /// </summary>
    public List<Note> Notes { get; set; } = new();

    /// <summary>
    ///     <inheritdoc />
    /// </summary>
    private int NextId { get; set; }

    /// <summary>
    ///     <inheritdoc />
    /// </summary>
    public Task AddNote(Note note)
    {
        note.NoteId = NextId++;
        Notes.Add(note);
        return Task.CompletedTask;
    }

    /// <summary>
    ///     <inheritdoc />
    /// </summary>
    public Task EditNote(Note note)
    {
        Note? noteToEdit = Notes.FirstOrDefault(n => n.NoteId == note.NoteId);

        noteToEdit.Content = note.Content;

        return Task.CompletedTask;
    }

    /// <summary>
    ///     <inheritdoc />
    /// </summary>
    public Task DeleteNote(Note note)
    {
        Note? noteToDelete = Notes.FirstOrDefault(n => n.NoteId == note.NoteId);
        Notes.Remove(noteToDelete);
        return Task.CompletedTask;
    }
}