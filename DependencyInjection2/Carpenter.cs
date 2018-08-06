using System;

namespace DependencyInjection2
{
    public class Carpenter : IWorker
    {

        private readonly ICleaner _clean;

        public Carpenter(ICleaner cleaner)
        {
            _clean = cleaner;
        }   
        public void DoWork()
        {
            Console.WriteLine("Doing Carpentry");
            _clean.Clean();

        }
         public void LeaveInvoice()
         {
             Console.WriteLine("$100 for Carpentry Work and $50 for Cleaners");
         }
    }
}