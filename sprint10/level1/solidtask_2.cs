public class Customer 
{
    public static void Register(string email, string password)
    {
        MailService mailService = new MailService();
        SmsService smsService = new SmsService();

        mailService.Email = email;
        mailService.EmailTitle = "User registration";
        mailService.EmailBody = "Body of message...";
        smsService.Number = "111 111 111";
        smsService.SmsText = "User successfully registered...";

        try
        {
            if (mailService.ValidEmail())
            {
                mailService.SendNotification();
                smsService.SendNotification();
            }
        }
        catch 
        {
            throw;
        }
    }
}
public abstract class NotificationService
{
    public abstract void SendNotification();
}

public class MailService : NotificationService
{
    public string Email { get; set; }
    public string EmailTitle { get; set; }
    public string EmailBody { get; set; }

    public bool ValidEmail()
    {
        return Email.Contains("@");
    }

    public void SendEmail(string mail, string emailTitle, string emailBody)
    {
        Console.WriteLine(string.Format("Mail:{0}, Title:{1}, Body:{2}", mail, emailTitle, emailBody));
    }

    public override void SendNotification()
    {
        Console.WriteLine("Mail:{0}, Title:{1}, Body:{2}", Email, EmailTitle, EmailBody);
    }
}

public class SmsService : NotificationService 
{
    public string Number { get; set; }
    public string SmsText { get; set; }

    public override void SendNotification()
    {
        Console.WriteLine("Number:{0}, Message:{1}", Number, SmsText);
    }
}
