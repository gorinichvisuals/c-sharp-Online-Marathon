using System;

public class DisposePatternImplementer : CloseableResource, IDisposable
{
    private bool disposed = false;
    
    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }
    
    protected virtual void Dispose(bool disposing)
    {
        if (!disposed) 
        {
            if (disposing)
            {
                
                Console.WriteLine("Disposing by developer");
            }
            else    
            {            
                Console.WriteLine("Disposing by GC");
            }
            disposed = true;
        
            base.Close();
        }
    }
    
    ~DisposePatternImplementer()
    {
        Dispose(false);
    }
}
