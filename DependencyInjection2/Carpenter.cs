using System;

namespace DependencyInjection2
{
    public class Carpenter : IWorker
    {
        public void DoWork()
        {
            Console.WriteLine("Doing Carpentry");
        }
         public void LeaveInvoice()
         {
             Console.WriteLine("$100 for Carpentry Work");
         }
    }
}