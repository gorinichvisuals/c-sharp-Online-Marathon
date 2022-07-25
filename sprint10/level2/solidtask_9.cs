public interface IProgrammer
{
    void WorkOnTask();
}

public interface ILead
{
    void CreateSubTask();
    void AssignTask();
}

public class TeamLead : ILead, IProgrammer
{
    public void AssignTask()
    {

    }

    public void CreateSubTask()
    {

    }

    public void WorkOnTask()
    {

    }
}

public class Manager : ILead
{
    public void AssignTask()
    {

    }

    public void CreateSubTask()
    {

    }
}

public class Programmer : IProgrammer
{
    public void WorkOnTask()
    {

    }
}
