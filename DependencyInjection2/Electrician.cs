using System;

namespace DependencyInjection2
{
    public class Electrician : IWorker
    {
        public void DoWork()
        {
            Console.WriteLine("Doing Electric");
        }
         public void LeaveInvoice()
         {
             Console.WriteLine("$250 for Electric Work");
         }
    }
}