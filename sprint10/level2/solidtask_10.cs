using System.IO;

public interface ILogger
{
    void LogMessage(string message);
}

public class DbLogger : ILogger
{
    public void LogMessage(string mMessage)
    {

    }
}

public class FileLogger : ILogger
{
    public void LogMessage(string mStackTrace)
    {

    }
}

public class ExceptionLogger
{
    ILogger _logger;

    public ExceptionLogger(ILogger logger)
    {
        _logger = logger;
    }

    public void LogException(Exception mException)
    {
        _logger.LogMessage(GetUserReadableMessage(mException));
    }

    private string GetUserReadableMessage(Exception ex)
    {
        return string.Empty;
    }
}

public class DataExporter
{
    public void ExportDataFromFile()
    {
        try
        {
        }
        catch (IOException ex)
        {
            new ExceptionLogger(new DbLogger()).LogException(ex);
        }
        catch (Exception ex)
        {
            new ExceptionLogger(new FileLogger()).LogException(ex);
        }
    }
}
