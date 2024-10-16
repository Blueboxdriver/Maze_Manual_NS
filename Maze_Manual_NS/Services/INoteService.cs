using Maze_Manual_NS.models;

namespace Maze_Manual_NS.Services;

public interface INoteService
{
    /// <summary>
    ///     A list containing any note made by the user of the web manual.
    /// </summary>
    List<Note> Notes { get; set; }

    /// <summary>
    /// Adds a new note to the list of notes and assigns it a unique identifier.
    /// </summary>
    /// <param name="note">The note to be added.</param>
    /// <returns>A completed task once the note has been added.</returns>
    Task AddNote(Note note);

    /// <summary>
    /// Edits an existing note by updating its content based on the provided note's identifier.
    /// </summary>
    /// <param name="note">The note being edited.</param>
    /// <returns>A completed task once the note has been edited.</returns>
    Task EditNote(Note note);

    /// <summary>
    /// Deletes a note from the list based on the provided note's identifier.
    /// </summary>
    /// <param name="note">The note object that is being removed.</param>
    /// <returns>A completed task once the note has been removed.</returns>
    Task DeleteNote(Note note);
}