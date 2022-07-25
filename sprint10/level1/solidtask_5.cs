public interface INotification
{
    public void SendNotification();
}

public interface INotificationToDB
{
    public void AddNotificationToDB();
}

public interface INotificationToDBRead
{
    public void ReadNotification();
}

public class Customer
{
    private INotification _notification;
    public Customer(INotification notification)
    {
        _notification = notification;
    }

    public void SendNotification(INotification notification)
    {
        notification.SendNotification();
    }

    public void Register(string email, string password)
    {
        try
        { 
        
        }
        catch (Exception)
        { 
            throw; 
        }
    }
}

public class MailService : INotification, INotificationToDB, INotificationToDBRead
{
    public string Email { get; set; }
    public string EmailTitle { get; set; }
    public string EmailBody { get; set; }

    public bool ValidEmail()
    {
        return Email.Contains("@");
    }

    public void SendNotification()
    {
        Console.WriteLine(string.Format("Mail:{0}, Title:{1}, Body:{2}", Email, EmailTitle, EmailBody));
    }

    public void AddNotificationToDB()
    {

    }

    public void ReadNotification()
    {

    }
}

public class SmsService : INotification
{
    public string Number { get; set; }
    public string SmsText { get; set; }

    public void SendNotification()
    {
        Console.WriteLine(string.Format("Number:{0}, Message:{1}", Number, SmsText));
    }
}
