using Maze_Manual_NS.models;

namespace Maze_Manual_NS.Services;

public interface INoteService
{
    List<Note> Notes {get; set;}

    Task AddNote(Note note);
    Task EditNote(Note note);
    Task DeleteNote(Note note);  
}