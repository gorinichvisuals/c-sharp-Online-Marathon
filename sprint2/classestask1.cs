class Employee
{
    internal string name;
    private DateTime hiringDate;
    DateTime nowDate = DateTime.Now;

    public Employee(string name, DateTime hiringDate)
    {
        this.name = name;
        this.hiringDate = hiringDate;
    }

    public int Experience()
    {
        System.TimeSpan interval = nowDate - hiringDate;
        //int convertExpInDays = int.Parse(interval.Days.ToString());
        int yearsOfExp = interval.Days / 365;

        return yearsOfExp;
    }

    public void ShowInfo()
    {
        Console.WriteLine($"{this.name} has {this.Experience()} years of experience");
    }
}

class Developer : Employee
{
    private string programmingLanguage;

    public Developer(string name, DateTime hiringDate, string programmingLanguage) : base(name, hiringDate)
    {
        this.programmingLanguage = programmingLanguage;
    }

    public new void ShowInfo()
    {
        Console.WriteLine($"{this.name} has {this.Experience()} years of experience. {this.name} is {this.programmingLanguage} programmer");
    }
}

class Tester : Employee 
{
    private bool isAuthomation;

    public Tester(string name, DateTime hiringDate, bool isAutomation) : base(name, hiringDate)
    {
        this.isAuthomation = isAutomation;
    }

    public new void ShowInfo()
    {
        if (isAuthomation == true)
        {
            Console.WriteLine($"{this.name} is authomated tester and has {this.Experience()} year(s) of experience");
        }
        else 
        {
            Console.WriteLine($"{this.name} is manual tester and has {this.Experience()} year(s) of experience");
        }
    }
} 
