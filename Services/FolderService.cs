using System;
using System.IO;

namespace Services
{
    public class FolderService : IFolderService
    {
        public int CreateFolder(string folderPath)
        {
            try
            {
                if (!Directory.Exists(folderPath))
                {
                    Directory.CreateDirectory(folderPath);


                    return 0;
                }
                else
                {
                    return 1;
                }
            }
            catch (Exception ex)
            {

                return 1;
            }
        }
        public int DeleteFolder(string folderPath)
        {
            try
            {
                if (Directory.Exists(folderPath))
                {
                    Directory.Delete(folderPath);
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
            catch (Exception ex)
            {
                return 1;
            }

        }
    }
}