using Entities;

namespace Services
{
    public interface ILoggerService
    {
        ErrorLogEntity CreateNotePadLog(ErrorLogEntity errorLogEntity);
    }
}