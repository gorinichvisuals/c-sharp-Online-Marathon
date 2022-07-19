using System;
using System.Threading;
using System.Threading.Tasks;
class PersonInTheShop
{ 
    public void Enter(){ }
    public void SelectGroceries(){ }
    public void Pay(){ }
    public void Leave(){ }
}

class Buyer : PersonInTheShop
{
    private const int maxUsers = 10;
    static Semaphore sem = new Semaphore(maxUsers, maxUsers);

    Thread thread;
    public Buyer(string x)
    {
        thread = new Thread(User){ Name = x };  
        thread.Start();
    }
    
    public void User()
    {
        sem.WaitOne();

        Enter();
        SelectGroceries();
        Pay();
        Leave();

        sem.Release();
    }    
}
