using Entities;

namespace Services
{
    public interface INotepadService
    {
        int CreateNotePadLogFolder(string folderPath);
        int CreateNotePad(string filePath);
        int EditNotePad(NotepadEntity notePadEntity);
        int AppendInNotePad(NotepadEntity notePadEntity);
        string GetAllNotepad(NotepadEntity notePadEntity);
        int DeleteNotepad(string filePath);
    }
}