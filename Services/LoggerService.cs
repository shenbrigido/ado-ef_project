using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class LoggerService : ILoggerService
    {
        INotepadService notepadService = new NotepadService();

        /// <summary>
        /// Creates logs into a notepad
        /// </summary>
        /// <param name="errorLogEntity">ErrorLogEntity</param>
        /// <returns>ErrorLogEntity</returns>
        //public NotepadService CreateNotepadLogFolder ()
        //{
        //     notepadService.CreateNotePadLogFolder();
        //     ;
        //}
        public ErrorLogEntity CreateNotePadLog(ErrorLogEntity errorLogEntity)
        {
            notepadService.AppendInNotePad(GetNotePadEntity(errorLogEntity));
            return errorLogEntity;
        }
        private FolderEntity GetFolderEntity()
        {
            var folderEntity = new FolderEntity();
            folderEntity.FolderPath = @"c:\Temp\Log";
            return folderEntity;
        }
        private NotepadEntity GetNotePadEntity(ErrorLogEntity errorLogEntity)
        {
            var notePadEntity = new NotepadEntity();
            notePadEntity.Name = "ErrorLogs";
            notePadEntity.FilePath = @"c:\Temp\Log\ErrorLogs.txt";
            notePadEntity.Description = "desc";
            notePadEntity.Contents = $"ControllerName {errorLogEntity.ControllerName} StackTrace {errorLogEntity.StackTrace} TimeStamp {errorLogEntity.TimeStamp}";
            return notePadEntity;
        }
    }
}

