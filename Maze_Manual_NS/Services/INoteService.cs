using Maze_Manual_NS.models;

namespace Maze_Manual_NS.Services;

public interface INoteService
{
    /// <summary>
    ///     A list containing any note made by the user of the web manual.
    /// </summary>
    List<Note> Notes { get; set; }

    /// <summary>
    ///     Adds a new note to the list of Notes
    /// </summary>
    /// <param name="note">The note object that contains the content and note ID to be added.</param>
    /// <returns>A task representing an asynchronous operation</returns>
    Task AddNote(Note note);

    /// <summary>
    ///     Edits a currently existing note in the list of Notes
    /// </summary>
    /// <param name="note">The note object containing the edited content to be updated.</param>
    /// <returns>A task representing an asynchronous operation</returns>
    Task EditNote(Note note);

    /// <summary>
    ///     Removes a currently existing note in the list of Notes
    /// </summary>
    /// <param name="note">The note object that is being removed</param>
    /// <returns>A task representing an ansynchronous operation</returns>
    Task DeleteNote(Note note);
}