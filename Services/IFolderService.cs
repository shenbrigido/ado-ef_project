namespace Services
{
    public interface IFolderService
    {
        int CreateFolder(string folderPath);
        int DeleteFolder(string folderPath);
    }
}