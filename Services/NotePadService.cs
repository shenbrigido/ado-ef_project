using Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class NotepadService : INotepadService
    {
        IFolderService folderService = new FolderService();
        /// <summary>
        /// Method creates notepad
        /// </summary>
        /// <param name="filePath">enter filepath of notepad</param>
        /// <returns>true if file created, false if file is not created</returns>
        public int CreateNotePadLogFolder(string folderpath)
        {
            var createFolder = folderService.CreateFolder(folderpath);
            return createFolder;
        }
        public int CreateNotePad(string filePath)
        {
            try
            {
                if (!File.Exists(filePath))
                {
                    var fileStream = File.Create(filePath);
                    fileStream.Close();
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

        public int EditNotePad(NotepadEntity notePadEntity)
        {
            try
            {
                if (File.Exists(notePadEntity.FilePath))
                {
                    File.WriteAllText(notePadEntity.FilePath, notePadEntity.Contents);
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

        public int AppendInNotePad(NotepadEntity notePadEntity)
        {
            try
            {
                File.AppendAllLines(notePadEntity.FilePath, ConvertToIEnumerableString(notePadEntity.Contents));
                return 0;
            }
            catch (Exception ex)
            {
                return 1;
            }
        }

        private IEnumerable<string> ConvertToIEnumerableString(string contents)
        {
            var convertedString = new List<string>();
            convertedString.Add(contents);
            return convertedString;
        }

        public string GetAllNotepad(NotepadEntity notePadEntity)
        {
            try
            {
                if (File.Exists(notePadEntity.FilePath))
                {
                    var text = File.ReadAllText(notePadEntity.FilePath);
                    return text;
                }
                else
                {
                    return "File does not exist";
                }
            }
            catch (Exception ex)
            {
                return "File does not exist";
            }
        }

        public int DeleteNotepad(string filePath)
        {
            try
            {
                if (File.Exists(filePath))
                {
                    File.Delete(filePath);
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
