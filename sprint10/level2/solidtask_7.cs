public interface IMailSender
{
    void SendEmail();
}

public interface IFileLogger
{
    public void Check();

    public void Debug();

    public void Info();
}

public class Invoice
{
    public string From { get; set; }
    public string To { get; set; }
    public string Subject { get; set; }
    public long Amount { get; set; }
    public DateTime InvoiceDate { get; set; }

    MailSender MailSender = new MailSender();

    public void Add()
    {
        Console.WriteLine("Adding amount...");
        string mailMessage = "Your invoice is ready.";
        MailSender.SendEmail(mailMessage);
    }

    public void Delete()
    {
        Console.WriteLine("Deleting amount...");
    }
}

public class MailSender
{
    public string From { get; set; }
    public string To { get; set; }
    public string Subject { get; set; }

    public void SendEmail(string mailMessage)
    {
        Console.WriteLine("Sending Email: {0}", mailMessage);
    }
}

public class FileLogger : IFileLogger
{
    public void Check()
    {
        /// log check result to file
    }
    public void Debug()
    {
        /// log debug result to file
    }
    public void Info()
    {
        /// log info result to file
    }
}
