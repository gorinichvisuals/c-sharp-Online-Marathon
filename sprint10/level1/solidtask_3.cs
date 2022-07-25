interface INotification
{
    public void SendNotification();
}
interface INotificationToDB
{
    public void AddNotificationToDB();
}

public class Customer 
{
    public static void Register(string email, string password)
    {
        try
        {
            MailService mailService = new MailService();
            SmsService smsService = new SmsService();
            mailService.Email = email;
            mailService.EmailTitle = "User registration";
            mailService.EmailBody = "Body of message...";
            smsService.Number = "111 111 111";
            smsService.SmsText = "User successfully registered...";

            if (mailService.ValidEmail())
            {
                mailService.SendNotification();
                smsService.SendNotification();
            }
        }
        catch (Exception)
        {
            throw;
        }
    }
}

public class MailService : INotification, INotificationToDB
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
        Console.WriteLine("Mail:{0}, Title:{1}, Body:{2}", Email, EmailTitle, EmailBody);
    }

    public void AddNotificationToDB()
    {

    }
}

public class SmsService : INotification
{
    public string Number { get; set; }
    public string SmsText { get; set; }

    public void SendNotification()
    {
        Console.WriteLine("Number:{0}, Message:{1}", Number, SmsText);
    }
}
