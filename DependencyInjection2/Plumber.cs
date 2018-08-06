using System;

namespace DependencyInjection2
{
    public class Plumber : IWorker
    {
    
        public void DoWork()
        {
            Console.WriteLine("Doing Plumbing");
        }
         public void LeaveInvoice()
         {
             Console.WriteLine("$150 for Plumbing Work");
         }
    
    }
}