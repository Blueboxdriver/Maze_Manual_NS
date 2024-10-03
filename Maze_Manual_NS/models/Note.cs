namespace Maze_Manual_NS.models;

/// <summary>
///     Represents a Note in the game manual.
/// </summary>
public class Note
{
    /// <summary>
    ///     A string representing the text content in a note.
    /// </summary>
    public string Content { get; set; }

    /// <summary>
    ///     A unique Id assigned to every comment.
    /// </summary>
    public int NoteId { get; set; }
}